namespace Project1
{
    partial class Vacation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDest = new TextBox();
            dateFrom = new DateTimePicker();
            dateTo = new DateTimePicker();
            label5 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 28);
            label1.Name = "label1";
            label1.Size = new Size(229, 48);
            label1.TabIndex = 0;
            label1.Text = "Add Vacation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 138);
            label2.Name = "label2";
            label2.Size = new Size(208, 48);
            label2.TabIndex = 1;
            label2.Text = "Destination:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 220);
            label3.Name = "label3";
            label3.Size = new Size(111, 48);
            label3.TabIndex = 2;
            label3.Text = "From:";
            // 
            // txtDest
            // 
            txtDest.BackColor = SystemColors.Info;
            txtDest.BorderStyle = BorderStyle.FixedSingle;
            txtDest.Location = new Point(264, 135);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(241, 55);
            txtDest.TabIndex = 4;
            // 
            // dateFrom
            // 
            dateFrom.CustomFormat = "";
            dateFrom.Format = DateTimePickerFormat.Short;
            dateFrom.Location = new Point(264, 215);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(218, 55);
            dateFrom.TabIndex = 6;
            dateFrom.Value = new DateTime(2024, 5, 14, 0, 0, 0, 0);
            // 
            // dateTo
            // 
            dateTo.Format = DateTimePickerFormat.Short;
            dateTo.Location = new Point(264, 294);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(218, 55);
            dateTo.TabIndex = 6;
            dateTo.Value = new DateTime(2024, 5, 14, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 299);
            label5.Name = "label5";
            label5.Size = new Size(64, 48);
            label5.TabIndex = 2;
            label5.Text = "To:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LemonChiffon;
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(184, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(220, 68);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Vacation
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Moccasin;
            ClientSize = new Size(566, 544);
            Controls.Add(btnSubmit);
            Controls.Add(dateTo);
            Controls.Add(dateFrom);
            Controls.Add(txtDest);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DeepSkyBlue;
            Margin = new Padding(6);
            Name = "Vacation";
            Text = "Vacation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        public TextBox txtDest;
        public DateTimePicker dateFrom;
        public DateTimePicker dateTo;
        private Button btnSubmit;
    }
}