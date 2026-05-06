namespace CryptoTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInput = new Label();
            txtInput = new TextBox();
            lblAlgorithm = new Label();
            cmbAlgorithm = new ComboBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnHash = new Button();
            btnClear = new Button();
            label1 = new Label();
            txtOutput = new TextBox();
            btnFileCrypto = new Button();
            btnBenchmark = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(12, 27);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(97, 19);
            lblInput.TabIndex = 0;
            lblInput.Text = "Вхідний текст:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 48);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(640, 113);
            txtInput.TabIndex = 1;
            // 
            // lblAlgorithm
            // 
            lblAlgorithm.AutoSize = true;
            lblAlgorithm.Location = new Point(12, 196);
            lblAlgorithm.Name = "lblAlgorithm";
            lblAlgorithm.Size = new Size(73, 19);
            lblAlgorithm.TabIndex = 2;
            lblAlgorithm.Text = "Алгоритм:";
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Location = new Point(83, 193);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(200, 25);
            cmbAlgorithm.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.FromArgb(0, 120, 212);
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.ForeColor = SystemColors.ButtonHighlight;
            btnEncrypt.Location = new Point(12, 228);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(140, 26);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "🔒 Зашифрувати";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.FromArgb(0, 120, 212);
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.ForeColor = SystemColors.ButtonHighlight;
            btnDecrypt.Location = new Point(158, 228);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(140, 26);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "🔓 Розшифрувати";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnHash
            // 
            btnHash.BackColor = Color.FromArgb(0, 120, 212);
            btnHash.FlatAppearance.BorderSize = 0;
            btnHash.FlatStyle = FlatStyle.Flat;
            btnHash.ForeColor = SystemColors.ButtonHighlight;
            btnHash.Location = new Point(304, 228);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(140, 26);
            btnHash.TabIndex = 6;
            btnHash.Text = "#️⃣ Хешувати";
            btnHash.UseVisualStyleBackColor = false;
            btnHash.Click += btnHash_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 90, 158);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.AliceBlue;
            btnClear.Location = new Point(450, 228);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 26);
            btnClear.TabIndex = 7;
            btnClear.Text = "🗑 Очистити";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 272);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 8;
            label1.Text = "Результат:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 292);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(640, 113);
            txtOutput.TabIndex = 9;
            // 
            // btnFileCrypto
            // 
            btnFileCrypto.BackColor = Color.FromArgb(224, 224, 224);
            btnFileCrypto.FlatAppearance.BorderSize = 0;
            btnFileCrypto.FlatStyle = FlatStyle.Flat;
            btnFileCrypto.ForeColor = Color.Black;
            btnFileCrypto.Location = new Point(12, 484);
            btnFileCrypto.Name = "btnFileCrypto";
            btnFileCrypto.Size = new Size(191, 26);
            btnFileCrypto.TabIndex = 10;
            btnFileCrypto.Text = "📁 Робота з файлами";
            btnFileCrypto.UseVisualStyleBackColor = false;
            btnFileCrypto.Click += btnFileCrypto_Click;
            // 
            // btnBenchmark
            // 
            btnBenchmark.BackColor = Color.FromArgb(224, 224, 224);
            btnBenchmark.FlatAppearance.BorderSize = 0;
            btnBenchmark.FlatStyle = FlatStyle.Flat;
            btnBenchmark.ForeColor = Color.Black;
            btnBenchmark.Location = new Point(461, 484);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(191, 26);
            btnBenchmark.TabIndex = 11;
            btnBenchmark.Text = "📊 Порівняння алгоритмів";
            btnBenchmark.UseVisualStyleBackColor = false;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 247);
            ClientSize = new Size(684, 522);
            Controls.Add(btnBenchmark);
            Controls.Add(btnFileCrypto);
            Controls.Add(txtOutput);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnHash);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(cmbAlgorithm);
            Controls.Add(lblAlgorithm);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Шифрування та хешування";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Label lblAlgorithm;
        private ComboBox cmbAlgorithm;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnHash;
        private Button btnClear;
        private Label label1;
        private TextBox txtOutput;
        private Button btnFileCrypto;
        private Button btnBenchmark;
    }
}
