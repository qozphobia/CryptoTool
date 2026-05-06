namespace CryptoTool
{
    partial class BenchmarkForm
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
            lblText = new Label();
            txtTestData = new TextBox();
            btnGenerate = new Button();
            btnRunBenchmark = new Button();
            lblResults = new Label();
            dgvResults = new DataGridView();
            lblConclusion = new Label();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(12, 22);
            lblText.Name = "lblText";
            lblText.Size = new Size(111, 19);
            lblText.TabIndex = 0;
            lblText.Text = "Тестовий рядок:";
            // 
            // txtTestData
            // 
            txtTestData.Location = new Point(12, 42);
            txtTestData.Multiline = true;
            txtTestData.Name = "txtTestData";
            txtTestData.ScrollBars = ScrollBars.Vertical;
            txtTestData.Size = new Size(700, 90);
            txtTestData.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(0, 120, 212);
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = SystemColors.ButtonHighlight;
            btnGenerate.Location = new Point(12, 139);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(312, 26);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "🎲 Згенерувати випадковий (1000 символів)";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRunBenchmark
            // 
            btnRunBenchmark.BackColor = Color.FromArgb(0, 120, 212);
            btnRunBenchmark.FlatAppearance.BorderSize = 0;
            btnRunBenchmark.FlatStyle = FlatStyle.Flat;
            btnRunBenchmark.ForeColor = SystemColors.ButtonHighlight;
            btnRunBenchmark.Location = new Point(504, 139);
            btnRunBenchmark.Name = "btnRunBenchmark";
            btnRunBenchmark.Size = new Size(208, 26);
            btnRunBenchmark.TabIndex = 3;
            btnRunBenchmark.Text = "▶  Запустити тест";
            btnRunBenchmark.UseVisualStyleBackColor = false;
            btnRunBenchmark.Click += btnRunBenchmark_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(12, 210);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(76, 23);
            lblResults.TabIndex = 4;
            lblResults.Text = "Результати:";
            lblResults.UseCompatibleTextRendering = true;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 237);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(700, 204);
            dgvResults.TabIndex = 5;
            // 
            // lblConclusion
            // 
            lblConclusion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblConclusion.Location = new Point(12, 444);
            lblConclusion.Name = "lblConclusion";
            lblConclusion.Size = new Size(700, 57);
            lblConclusion.TabIndex = 6;
            lblConclusion.Text = "(висновок з'явиться після тесту)";
            lblConclusion.UseCompatibleTextRendering = true;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(224, 224, 224);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ForeColor = SystemColors.ControlText;
            btnReturn.Location = new Point(504, 9);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(208, 26);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Повернутись на головну форму";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // BenchmarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 522);
            Controls.Add(btnReturn);
            Controls.Add(lblConclusion);
            Controls.Add(dgvResults);
            Controls.Add(lblResults);
            Controls.Add(btnRunBenchmark);
            Controls.Add(btnGenerate);
            Controls.Add(txtTestData);
            Controls.Add(lblText);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BenchmarkForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Порівняння алгоритмів";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private TextBox txtTestData;
        private Button btnGenerate;
        private Button btnRunBenchmark;
        private Label lblResults;
        private DataGridView dgvResults;
        private Label lblConclusion;
        private Button btnReturn;
    }
}