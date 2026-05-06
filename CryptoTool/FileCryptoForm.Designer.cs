namespace CryptoTool
{
    partial class FileCryptoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFile = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            label1 = new Label();
            cmbAlgorithm = new ComboBox();
            btnEncryptFile = new Button();
            btnDecryptFile = new Button();
            lblStatus = new Label();
            lblInfo = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(12, 10);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(44, 19);
            lblFile.TabIndex = 0;
            lblFile.Text = "Файл:";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(57, 7);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(450, 25);
            txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(224, 224, 224);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(513, 7);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 28);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Вибрати...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 3;
            label1.Text = "Алгоритм:";
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Location = new Point(238, 47);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(200, 25);
            cmbAlgorithm.TabIndex = 4;
            // 
            // btnEncryptFile
            // 
            btnEncryptFile.BackColor = Color.FromArgb(0, 120, 212);
            btnEncryptFile.FlatAppearance.BorderSize = 0;
            btnEncryptFile.FlatStyle = FlatStyle.Flat;
            btnEncryptFile.ForeColor = Color.FloralWhite;
            btnEncryptFile.Location = new Point(57, 103);
            btnEncryptFile.Name = "btnEncryptFile";
            btnEncryptFile.Size = new Size(200, 45);
            btnEncryptFile.TabIndex = 5;
            btnEncryptFile.Text = "🔒Зашифрувати файл";
            btnEncryptFile.UseVisualStyleBackColor = false;
            btnEncryptFile.Click += btnEncryptFile_Click;
            // 
            // btnDecryptFile
            // 
            btnDecryptFile.BackColor = Color.FromArgb(0, 120, 212);
            btnDecryptFile.FlatAppearance.BorderSize = 0;
            btnDecryptFile.FlatStyle = FlatStyle.Flat;
            btnDecryptFile.ForeColor = Color.FloralWhite;
            btnDecryptFile.Location = new Point(346, 103);
            btnDecryptFile.Name = "btnDecryptFile";
            btnDecryptFile.Size = new Size(200, 45);
            btnDecryptFile.TabIndex = 6;
            btnDecryptFile.Text = "🔓Розшифрувати файл";
            btnDecryptFile.UseVisualStyleBackColor = false;
            btnDecryptFile.Click += btnDecryptFile_Click;
            // 
            // lblStatus
            // 
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Location = new Point(12, 181);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(580, 34);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Готово до роботи";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(12, 236);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(564, 57);
            lblInfo.TabIndex = 8;
            lblInfo.Text = "ℹ Зашифрований файл збережеться поряд з оригіналом з розширенням .encrypted.\r\n   Для розшифрування — оберіть .encrypted файл, результат збережеться як .decrypted";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(224, 224, 224);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Location = new Point(215, 344);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(223, 53);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Повернутись на головну форму";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // FileCryptoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 409);
            Controls.Add(btnReturn);
            Controls.Add(lblInfo);
            Controls.Add(lblStatus);
            Controls.Add(btnDecryptFile);
            Controls.Add(btnEncryptFile);
            Controls.Add(cmbAlgorithm);
            Controls.Add(label1);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(lblFile);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FileCryptoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Шифрування файлів";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFile;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private Label label1;
        private ComboBox cmbAlgorithm;
        private Button btnEncryptFile;
        private Button btnDecryptFile;
        private Label lblStatus;
        private Label lblInfo;
        private Button btnReturn;
    }
}