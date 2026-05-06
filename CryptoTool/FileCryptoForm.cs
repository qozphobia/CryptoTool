using CryptoTool.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoTool
{
    public partial class FileCryptoForm : Form
    {
        public FileCryptoForm()
        {
            InitializeComponent();
            cmbAlgorithm.Items.AddRange(new string[] { "AES", "DES" });
            cmbAlgorithm.SelectedIndex = 0;
        }

        private CipherBase? GetSelectedCipher()
        {
            return cmbAlgorithm.SelectedItem?.ToString() switch
            {
                "AES" => CryptoState.Aes,
                "DES" => CryptoState.Des,
                _ => null
            };
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Оберіть файл",
                Filter = "Усі файли (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dialog.FileName;
                lblStatus.Text = $"Обрано файл: {Path.GetFileName(dialog.FileName)}";
            }
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            if (!ValidateFileSelected()) return;

            var cipher = GetSelectedCipher();
            if (cipher == null) return;

            string inputPath = txtFilePath.Text;
            string outputPath = inputPath + ".encrypted";

            try
            {
                lblStatus.Text = "Шифрування...";
                Application.DoEvents();

                byte[] fileBytes = File.ReadAllBytes(inputPath);
                byte[] encrypted = cipher.EncryptBytes(fileBytes);

                File.WriteAllBytes(outputPath, encrypted);

                lblStatus.Text = $"✅ Зашифровано: {Path.GetFileName(outputPath)} " +
                                 $"({FormatSize(encrypted.Length)})";

                MessageBox.Show($"Файл успішно зашифровано!\n\nШлях: {outputPath}",
                    "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Помилка";
                MessageBox.Show($"Не вдалося зашифрувати файл:\n{ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            if (!ValidateFileSelected()) return;

            var cipher = GetSelectedCipher();
            if (cipher == null) return;

            string inputPath = txtFilePath.Text;

            string outputPath = inputPath.EndsWith(".encrypted")
                ? inputPath.Substring(0, inputPath.Length - ".encrypted".Length) + ".decrypted"
                : inputPath + ".decrypted";

            try
            {
                lblStatus.Text = "Розшифрування...";
                Application.DoEvents();

                byte[] fileBytes = File.ReadAllBytes(inputPath);
                byte[] decrypted = cipher.DecryptBytes(fileBytes);
                File.WriteAllBytes(outputPath, decrypted);

                lblStatus.Text = $"✅ Розшифровано: {Path.GetFileName(outputPath)} " +
                                 $"({FormatSize(decrypted.Length)})";

                MessageBox.Show($"Файл успішно розшифровано!\n\nШлях: {outputPath}",
                    "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Помилка";
                MessageBox.Show($"Не вдалося розшифрувати файл:\n{ex.Message}\n\n" +
                    $"Можливі причини:\n" +
                    $"• Файл був зашифрований іншим алгоритмом\n" +
                    $"• Файл не є зашифрованим\n" +
                    $"• Програма була перезапущена (ключі генеруються при кожному запуску)",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFileSelected()
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("Спочатку оберіть файл.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Обраний файл не існує.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string FormatSize(long bytes)
        {
            if (bytes < 1024) return $"{bytes} B";
            if (bytes < 1024 * 1024) return $"{bytes / 1024.0:F1} KB";
            return $"{bytes / (1024.0 * 1024.0):F1} MB";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
