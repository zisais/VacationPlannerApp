namespace Project1
{
    partial class pnlAccomodation
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
            txtNights = new TextBox();
            txtName = new TextBox();
            rbFriend = new RadioButton();
            rbBnb = new RadioButton();
            label4 = new Label();
            rbHotel = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtCost = new TextBox();
            SuspendLayout();
            // 
            // txtNights
            // 
            txtNights.BackColor = SystemColors.Info;
            txtNights.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNights.Location = new Point(107, 207);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(210, 39);
            txtNights.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(107, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 39);
            txtName.TabIndex = 16;
            // 
            // rbFriend
            // 
            rbFriend.AutoSize = true;
            rbFriend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbFriend.ForeColor = Color.DeepSkyBlue;
            rbFriend.Location = new Point(227, 91);
            rbFriend.Name = "rbFriend";
            rbFriend.Size = new Size(106, 36);
            rbFriend.TabIndex = 12;
            rbFriend.TabStop = true;
            rbFriend.Text = "Friend";
            rbFriend.UseVisualStyleBackColor = true;
            // 
            // rbBnb
            // 
            rbBnb.AutoSize = true;
            rbBnb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbBnb.ForeColor = Color.DeepSkyBlue;
            rbBnb.Location = new Point(128, 91);
            rbBnb.Name = "rbBnb";
            rbBnb.Size = new Size(85, 36);
            rbBnb.TabIndex = 13;
            rbBnb.TabStop = true;
            rbBnb.Text = "BNB";
            rbBnb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(4, 205);
            label4.Name = "label4";
            label4.Size = new Size(104, 38);
            label4.TabIndex = 9;
            label4.Text = "Nights:";
            // 
            // rbHotel
            // 
            rbHotel.AutoSize = true;
            rbHotel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbHotel.ForeColor = Color.DeepSkyBlue;
            rbHotel.Location = new Point(27, 91);
            rbHotel.Name = "rbHotel";
            rbHotel.Size = new Size(97, 36);
            rbHotel.TabIndex = 14;
            rbHotel.TabStop = true;
            rbHotel.Text = "Hotel";
            rbHotel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(4, 160);
            label3.Name = "label3";
            label3.Size = new Size(97, 38);
            label3.TabIndex = 10;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(4, 50);
            label2.Name = "label2";
            label2.Size = new Size(214, 38);
            label2.TabIndex = 11;
            label2.Text = "Residence Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(353, 45);
            label1.TabIndex = 8;
            label1.Text = "Accomodation Expense";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(4, 250);
            label5.Name = "label5";
            label5.Size = new Size(175, 38);
            label5.TabIndex = 9;
            label5.Text = "Nightly Cost:";
            // 
            // txtCost
            // 
            txtCost.BackColor = SystemColors.Info;
            txtCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCost.Location = new Point(178, 252);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(139, 39);
            txtCost.TabIndex = 15;
            // 
            // pnlAccomodation
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.PapayaWhip;
            Controls.Add(txtCost);
            Controls.Add(txtNights);
            Controls.Add(txtName);
            Controls.Add(rbFriend);
            Controls.Add(label5);
            Controls.Add(rbBnb);
            Controls.Add(label4);
            Controls.Add(rbHotel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "pnlAccomodation";
            Size = new Size(358, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtNights;
        public TextBox txtName;
        public RadioButton rbFriend;
        public RadioButton rbBnb;
        public RadioButton rbHotel;
        private Label label5;
        public TextBox txtCost;
    }
}
