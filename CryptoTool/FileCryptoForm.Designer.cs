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
            lblFile.Location = new Point(12, 9);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(39, 15);
            lblFile.TabIndex = 0;
            lblFile.Text = "Файл:";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(57, 6);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(450, 23);
            txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(513, 6);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 25);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Вибрати...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Алгоритм:";
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Location = new Point(83, 46);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(200, 23);
            cmbAlgorithm.TabIndex = 4;
            // 
            // btnEncryptFile
            // 
            btnEncryptFile.Location = new Point(57, 91);
            btnEncryptFile.Name = "btnEncryptFile";
            btnEncryptFile.Size = new Size(200, 40);
            btnEncryptFile.TabIndex = 5;
            btnEncryptFile.Text = "Зашифрувати файл";
            btnEncryptFile.UseVisualStyleBackColor = true;
            btnEncryptFile.Click += btnEncryptFile_Click;
            // 
            // btnDecryptFile
            // 
            btnDecryptFile.Location = new Point(346, 91);
            btnDecryptFile.Name = "btnDecryptFile";
            btnDecryptFile.Size = new Size(200, 40);
            btnDecryptFile.TabIndex = 6;
            btnDecryptFile.Text = "Розшифрувати файл";
            btnDecryptFile.UseVisualStyleBackColor = true;
            btnDecryptFile.Click += btnDecryptFile_Click;
            // 
            // lblStatus
            // 
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Location = new Point(12, 160);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(580, 30);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Готово до роботи";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(3, 302);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(580, 50);
            lblInfo.TabIndex = 8;
            lblInfo.Text = "ℹ Зашифрований файл збережеться поряд з оригіналом з розширенням .encrypted.\r\n   Для розшифрування — оберіть .encrypted файл, результат збережеться як .decrypted";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(496, 305);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(126, 47);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Повернутись на головну форму";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // FileCryptoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
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