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
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(12, 24);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(83, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Вхідний текст:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 42);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(640, 100);
            txtInput.TabIndex = 1;
            // 
            // lblAlgorithm
            // 
            lblAlgorithm.AutoSize = true;
            lblAlgorithm.Location = new Point(12, 173);
            lblAlgorithm.Name = "lblAlgorithm";
            lblAlgorithm.Size = new Size(65, 15);
            lblAlgorithm.TabIndex = 2;
            lblAlgorithm.Text = "Алгоритм:";
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Location = new Point(83, 170);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(200, 23);
            cmbAlgorithm.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(12, 201);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(140, 23);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Зашифрувати";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += this.btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(158, 201);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(140, 23);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = " Розшифрувати";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += this.btnDecrypt_Click;
            // 
            // btnHash
            // 
            btnHash.Location = new Point(304, 201);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(140, 23);
            btnHash.TabIndex = 6;
            btnHash.Text = "Хешувати";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += this.btnHash_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(450, 201);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += this.btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 240);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "Результат:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 258);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(640, 100);
            txtOutput.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
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
    }
}
