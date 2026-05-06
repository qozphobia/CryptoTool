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
            lblText.Location = new Point(12, 19);
            lblText.Name = "lblText";
            lblText.Size = new Size(96, 15);
            lblText.TabIndex = 0;
            lblText.Text = "Тестовий рядок:";
            // 
            // txtTestData
            // 
            txtTestData.Location = new Point(12, 37);
            txtTestData.Multiline = true;
            txtTestData.Name = "txtTestData";
            txtTestData.ScrollBars = ScrollBars.Vertical;
            txtTestData.Size = new Size(700, 80);
            txtTestData.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 123);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(248, 23);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Згенерувати випадковий (1000 символів)";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRunBenchmark
            // 
            btnRunBenchmark.Location = new Point(266, 123);
            btnRunBenchmark.Name = "btnRunBenchmark";
            btnRunBenchmark.Size = new Size(208, 23);
            btnRunBenchmark.TabIndex = 3;
            btnRunBenchmark.Text = "▶  Запустити тест";
            btnRunBenchmark.UseVisualStyleBackColor = true;
            btnRunBenchmark.Click += btnRunBenchmark_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(12, 185);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(68, 21);
            lblResults.TabIndex = 4;
            lblResults.Text = "Результати:";
            lblResults.UseCompatibleTextRendering = true;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 209);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(700, 180);
            dgvResults.TabIndex = 5;
            // 
            // lblConclusion
            // 
            lblConclusion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblConclusion.Location = new Point(12, 392);
            lblConclusion.Name = "lblConclusion";
            lblConclusion.Size = new Size(700, 50);
            lblConclusion.TabIndex = 6;
            lblConclusion.Text = "(висновок з'явиться після тесту)";
            lblConclusion.UseCompatibleTextRendering = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(504, 8);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(208, 23);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Повернутись на головну форму";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // BenchmarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(btnReturn);
            Controls.Add(lblConclusion);
            Controls.Add(dgvResults);
            Controls.Add(lblResults);
            Controls.Add(btnRunBenchmark);
            Controls.Add(btnGenerate);
            Controls.Add(txtTestData);
            Controls.Add(lblText);
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