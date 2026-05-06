using CryptoTool.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoTool
{
    public partial class BenchmarkForm : Form
    {
        public BenchmarkForm()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvResults.Columns.Clear();
            dgvResults.Columns.Add("Algorithm", "Алгоритм");
            dgvResults.Columns.Add("Type", "Тип");
            dgvResults.Columns.Add("EncryptTime", "Шифрування (мс)");
            dgvResults.Columns.Add("DecryptTime", "Розшифрування (мс)");
            dgvResults.Columns.Add("OutputSize", "Розмір результату (байт)");

            foreach (DataGridViewColumn col in dgvResults.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";

            var sb = new StringBuilder(1000);
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            txtTestData.Text = sb.ToString();
        }

        private const int SymmetricIterations = 5000;
        private const int AsymmetricIterations = 50;

        private void btnRunBenchmark_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestData.Text))
            {
                MessageBox.Show("Введіть або згенеруйте тестовий текст.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvResults.Rows.Clear();
            string testData = txtTestData.Text;

            // Симетричні — багато ітерацій, повний текст.
            BenchmarkCipher(CryptoState.Aes, "Симетричний", testData, SymmetricIterations);
            BenchmarkCipher(CryptoState.Des, "Симетричний", testData, SymmetricIterations);

            // RSA — мало ітерацій (повільний), короткий текст (обмеження ~190 байт).
            string rsaTestData = testData.Length > 100 ? testData.Substring(0, 100) : testData;
            BenchmarkCipher(CryptoState.Rsa, "Асиметричний", rsaTestData, AsymmetricIterations);

            ShowConclusion();
        }

        // Універсальний метод бенчмарка для будь-якого CipherBase.
        // Тут і працює поліморфізм: метод не знає чи це AES, DES чи RSA —
        // звертається до абстрактного інтерфейсу.
        private void BenchmarkCipher(CipherBase cipher, string type, string data, int iterations)
        {
            try
            {
                // Прогрів — перший виклик завжди повільніший через JIT-компіляцію
                // та ініціалізацію криптографічного провайдера. Не міряємо.
                string warmupResult = cipher.Encrypt(data);
                cipher.Decrypt(warmupResult);

                // Заміряємо ШИФРУВАННЯ багато разів.
                var sw = Stopwatch.StartNew();
                string encrypted = "";
                for (int i = 0; i < iterations; i++)
                {
                    encrypted = cipher.Encrypt(data);
                }
                sw.Stop();
                double encryptMs = sw.Elapsed.TotalMilliseconds;
                // Середній час однієї операції з точністю до мікросекунд.
                double avgEncryptMs = encryptMs / iterations;

                int outputSize = encrypted.Length;

                // Заміряємо РОЗШИФРУВАННЯ.
                sw.Restart();
                string decrypted = "";
                for (int i = 0; i < iterations; i++)
                {
                    decrypted = cipher.Decrypt(encrypted);
                }
                sw.Stop();
                double decryptMs = sw.Elapsed.TotalMilliseconds;
                double avgDecryptMs = decryptMs / iterations;

                bool ok = decrypted == data;
                string algoName = cipher.Name + (ok ? " ✅" : " ❌");

                // F4 = форматування з 4 знаками після коми (точність до 0.0001 мс = 100 нс).
                dgvResults.Rows.Add(
                    algoName,
                    type,
                avgEncryptMs.ToString("F4", System.Globalization.CultureInfo.InvariantCulture) + $" (×{iterations})",
avgDecryptMs.ToString("F4", System.Globalization.CultureInfo.InvariantCulture) + $" (×{iterations})",
                    outputSize
                );
            }
            catch (Exception ex)
            {
                dgvResults.Rows.Add(cipher.Name + " ❌", type, "помилка", "помилка", ex.Message);
            }
        }

        private void ShowConclusion()
        {
            if (dgvResults.Rows.Count == 0) return;

            string? fastest = null;
            string? slowest = null;
            double minTotalTime = double.MaxValue;
            double maxTotalTime = double.MinValue;

            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                // Парсимо обидві колонки часу і складаємо.
                if (TryParseTime(row.Cells["EncryptTime"].Value?.ToString(), out double encTime) &&
                    TryParseTime(row.Cells["DecryptTime"].Value?.ToString(), out double decTime))
                {
                    double total = encTime + decTime;
                    string name = row.Cells["Algorithm"].Value?.ToString() ?? "";

                    if (total < minTotalTime)
                    {
                        minTotalTime = total;
                        fastest = name;
                    }
                    if (total > maxTotalTime)
                    {
                        maxTotalTime = total;
                        slowest = name;
                    }
                }
            }

            if (fastest != null && slowest != null && fastest != slowest)
            {
                var inv = System.Globalization.CultureInfo.InvariantCulture;
                lblConclusion.Text =
                    $"Найшвидший: {fastest} (загалом {minTotalTime.ToString("F4", inv)} мс)   |   " +
                    $"Найповільніший: {slowest} (загалом {maxTotalTime.ToString("F4", inv)} мс)\n" +
                    $"Симетричні шифри (AES/DES) значно швидші за асиметричний RSA — " +
                    $"саме тому в реальних системах RSA шифрує лише AES-ключ.";
            }
        }

        // Допоміжний метод — витягує число з рядка типу "0.0018 (×5000)".
        private bool TryParseTime(string? cellText, out double result)
        {
            result = 0;
            if (string.IsNullOrEmpty(cellText)) return false;

            string numberPart = cellText.Split(' ')[0];
            return double.TryParse(numberPart,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out result);
        }
    }
}
