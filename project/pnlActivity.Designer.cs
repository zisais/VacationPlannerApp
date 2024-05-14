namespace Project1
{
    partial class pnlActivity
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
            txtCost = new TextBox();
            txtName = new TextBox();
            rbEnt = new RadioButton();
            rbSummer = new RadioButton();
            label4 = new Label();
            rbWinter = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCost
            // 
            txtCost.BackColor = SystemColors.Info;
            txtCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCost.Location = new Point(106, 231);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(210, 39);
            txtCost.TabIndex = 25;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(106, 186);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 39);
            txtName.TabIndex = 26;
            // 
            // rbEnt
            // 
            rbEnt.AutoSize = true;
            rbEnt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbEnt.ForeColor = Color.DeepSkyBlue;
            rbEnt.Location = new Point(85, 139);
            rbEnt.Name = "rbEnt";
            rbEnt.Size = new Size(190, 36);
            rbEnt.TabIndex = 22;
            rbEnt.TabStop = true;
            rbEnt.Text = "Entertainment";
            rbEnt.UseVisualStyleBackColor = true;
            // 
            // rbSummer
            // 
            rbSummer.AutoSize = true;
            rbSummer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbSummer.ForeColor = Color.DeepSkyBlue;
            rbSummer.Location = new Point(181, 97);
            rbSummer.Name = "rbSummer";
            rbSummer.Size = new Size(129, 36);
            rbSummer.TabIndex = 23;
            rbSummer.TabStop = true;
            rbSummer.Text = "Summer";
            rbSummer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(3, 229);
            label4.Name = "label4";
            label4.Size = new Size(77, 38);
            label4.TabIndex = 19;
            label4.Text = "Cost:";
            // 
            // rbWinter
            // 
            rbWinter.AutoSize = true;
            rbWinter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbWinter.ForeColor = Color.DeepSkyBlue;
            rbWinter.Location = new Point(41, 97);
            rbWinter.Name = "rbWinter";
            rbWinter.Size = new Size(110, 36);
            rbWinter.TabIndex = 24;
            rbWinter.TabStop = true;
            rbWinter.Text = "Winter";
            rbWinter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(3, 184);
            label3.Name = "label3";
            label3.Size = new Size(97, 38);
            label3.TabIndex = 20;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(179, 38);
            label2.TabIndex = 21;
            label2.Text = "Activity Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(53, 5);
            label1.Name = "label1";
            label1.Size = new Size(249, 45);
            label1.TabIndex = 18;
            label1.Text = "Activity Expense";
            // 
            // pnlActivity
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.PapayaWhip;
            Controls.Add(txtCost);
            Controls.Add(txtName);
            Controls.Add(rbEnt);
            Controls.Add(rbSummer);
            Controls.Add(label4);
            Controls.Add(rbWinter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DeepSkyBlue;
            Name = "pnlActivity";
            Size = new Size(358, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtCost;
        public TextBox txtName;
        public RadioButton rbEnt;
        public RadioButton rbSummer;
        public RadioButton rbWinter;
    }
}
