namespace Project1
{
    partial class pnlAddExpense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            SuspendLayout();
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.DeepSkyBlue;
            radioButton3.Location = new Point(55, 171);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 36);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Activity";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.DeepSkyBlue;
            radioButton2.Location = new Point(55, 129);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(193, 36);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Accomodation";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.DeepSkyBlue;
            radioButton1.Location = new Point(55, 87);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 36);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Travel";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(78, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 45);
            label3.TabIndex = 2;
            label3.Text = "Add Expense";
            // 
            // pnlAddExpense
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.PapayaWhip;
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Name = "pnlAddExpense";
            Size = new Size(358, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        public RadioButton radioButton3;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
    }
}
