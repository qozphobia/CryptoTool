using CryptoTool.Crypto;
using System.Security.Cryptography;

namespace CryptoTool
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            cmbAlgorithm.Items.AddRange(new string[]
            {
                "AES",
                "DES",
                "RSA",
                "SHA-256",
                "MD5"
            });

            cmbAlgorithm.SelectedIndex = 0;
        }
        private CipherBase? GetSelectedCipher()
        {
            return cmbAlgorithm.SelectedItem?.ToString() switch
            {
                "AES" => CryptoState.Aes,
                "DES" => CryptoState.Des,
                "RSA" => CryptoState.Rsa,
                _ => null
            };
        }

        private HasherBase? GetSelectedHasher()
        {
            return cmbAlgorithm.SelectedItem?.ToString() switch
            {
                "SHA-256" => CryptoState.Sha256,
                "MD5" => CryptoState.Md5,
                _ => null
            };
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Введіть текст для обробки.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var cipher = GetSelectedCipher();
            if (cipher == null)
            {
                MessageBox.Show("Оберіть алгоритм шифрування (AES, DES або RSA).",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string result = cipher.Encrypt(txtInput.Text);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка шифрування: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var cipher = GetSelectedCipher();
            if (cipher == null)
            {
                MessageBox.Show("Оберіть алгоритм шифрування (AES, DES або RSA).",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string result = cipher.Decrypt(txtInput.Text);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка розшифрування: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var hasher = GetSelectedHasher();
            if (hasher == null)
            {
                MessageBox.Show("Оберіть хеш-функцію (SHA-256 або MD5).",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = hasher.ComputeHash(txtInput.Text);
            txtOutput.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnFileCrypto_Click(object sender, EventArgs e)
        {
            Form form = new FileCryptoForm();
            form.ShowDialog();
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            Form Form1 = new BenchmarkForm();
            Form1.ShowDialog();

        }
    }
}
