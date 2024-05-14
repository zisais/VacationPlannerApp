namespace Project1
{
    partial class pnlTravel
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
            label1 = new Label();
            label2 = new Label();
            rbCar = new RadioButton();
            rbPlane = new RadioButton();
            rbTrain = new RadioButton();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtCost = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 45);
            label1.TabIndex = 0;
            label1.Text = "Travel Expense";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(233, 38);
            label2.TabIndex = 1;
            label2.Text = "Method of Travel:";
            // 
            // rbCar
            // 
            rbCar.AutoSize = true;
            rbCar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbCar.Location = new Point(29, 108);
            rbCar.Name = "rbCar";
            rbCar.Size = new Size(74, 36);
            rbCar.TabIndex = 2;
            rbCar.TabStop = true;
            rbCar.Text = "Car";
            rbCar.UseVisualStyleBackColor = true;
            // 
            // rbPlane
            // 
            rbPlane.AutoSize = true;
            rbPlane.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbPlane.Location = new Point(116, 108);
            rbPlane.Name = "rbPlane";
            rbPlane.Size = new Size(97, 36);
            rbPlane.TabIndex = 2;
            rbPlane.TabStop = true;
            rbPlane.Text = "Plane";
            rbPlane.UseVisualStyleBackColor = true;
            // 
            // rbTrain
            // 
            rbTrain.AutoSize = true;
            rbTrain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbTrain.Location = new Point(226, 108);
            rbTrain.Name = "rbTrain";
            rbTrain.Size = new Size(90, 36);
            rbTrain.TabIndex = 2;
            rbTrain.TabStop = true;
            rbTrain.Text = "Train";
            rbTrain.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 166);
            label3.Name = "label3";
            label3.Size = new Size(97, 38);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(106, 168);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 39);
            txtName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 211);
            label4.Name = "label4";
            label4.Size = new Size(77, 38);
            label4.TabIndex = 1;
            label4.Text = "Cost:";
            // 
            // txtCost
            // 
            txtCost.BackColor = SystemColors.Info;
            txtCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCost.Location = new Point(106, 213);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(210, 39);
            txtCost.TabIndex = 3;
            // 
            // pnlTravel
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.PapayaWhip;
            Controls.Add(txtCost);
            Controls.Add(txtName);
            Controls.Add(rbTrain);
            Controls.Add(rbPlane);
            Controls.Add(label4);
            Controls.Add(rbCar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DeepSkyBlue;
            Name = "pnlTravel";
            Size = new Size(358, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public RadioButton rbCar;
        public RadioButton rbPlane;
        public RadioButton rbTrain;
        public TextBox txtName;
        public TextBox txtCost;
    }
}
