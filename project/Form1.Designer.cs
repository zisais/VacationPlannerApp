namespace Project1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            listVacays = new ListBox();
            btnAdd = new Button();
            label2 = new Label();
            lblTotal = new Label();
            btnDetails = new Button();
            btnLoadVacay = new Button();
            btnRmvVaca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(420, 19);
            label1.Name = "label1";
            label1.Size = new Size(391, 53);
            label1.TabIndex = 0;
            label1.Text = "Vacation Planner";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listVacays
            // 
            listVacays.BackColor = Color.Moccasin;
            listVacays.BorderStyle = BorderStyle.FixedSingle;
            listVacays.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listVacays.ForeColor = Color.DeepSkyBlue;
            listVacays.FormattingEnabled = true;
            listVacays.ItemHeight = 38;
            listVacays.Location = new Point(146, 322);
            listVacays.Name = "listVacays";
            listVacays.Size = new Size(960, 420);
            listVacays.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LemonChiffon;
            btnAdd.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DeepSkyBlue;
            btnAdd.Location = new Point(872, 151);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(234, 103);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Vacation";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(699, 837);
            label2.Name = "label2";
            label2.Size = new Size(260, 53);
            label2.TabIndex = 3;
            label2.Text = "Total Cost:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Location = new Point(952, 837);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 53);
            lblTotal.TabIndex = 4;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.LemonChiffon;
            btnDetails.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnDetails.FlatAppearance.BorderSize = 2;
            btnDetails.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.ForeColor = Color.DeepSkyBlue;
            btnDetails.Location = new Point(146, 748);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(158, 43);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Details...";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnLoadVacay
            // 
            btnLoadVacay.BackColor = Color.LemonChiffon;
            btnLoadVacay.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnLoadVacay.FlatAppearance.BorderSize = 2;
            btnLoadVacay.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            btnLoadVacay.FlatStyle = FlatStyle.Flat;
            btnLoadVacay.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadVacay.ForeColor = Color.DeepSkyBlue;
            btnLoadVacay.Location = new Point(872, 257);
            btnLoadVacay.Name = "btnLoadVacay";
            btnLoadVacay.Size = new Size(234, 62);
            btnLoadVacay.TabIndex = 3;
            btnLoadVacay.Text = "Load Vacation";
            btnLoadVacay.UseVisualStyleBackColor = false;
            btnLoadVacay.Click += btnLoadVacay_Click;
            // 
            // btnRmvVaca
            // 
            btnRmvVaca.BackColor = Color.LemonChiffon;
            btnRmvVaca.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnRmvVaca.FlatAppearance.BorderSize = 2;
            btnRmvVaca.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            btnRmvVaca.FlatStyle = FlatStyle.Flat;
            btnRmvVaca.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRmvVaca.ForeColor = Color.DeepSkyBlue;
            btnRmvVaca.Location = new Point(146, 257);
            btnRmvVaca.Name = "btnRmvVaca";
            btnRmvVaca.Size = new Size(234, 62);
            btnRmvVaca.TabIndex = 3;
            btnRmvVaca.Text = "Remove Vacation";
            btnRmvVaca.UseVisualStyleBackColor = false;
            btnRmvVaca.Click += btnRmvVaca_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Moccasin;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1258, 968);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(btnRmvVaca);
            Controls.Add(btnLoadVacay);
            Controls.Add(btnDetails);
            Controls.Add(btnAdd);
            Controls.Add(listVacays);
            Controls.Add(label1);
            Font = new Font("Verdana", 22F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DeepSkyBlue;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(8, 6, 8, 6);
            MaximumSize = new Size(1280, 1024);
            MinimumSize = new Size(1280, 1024);
            Name = "Form1";
            Text = "Vacation Planner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Label label2;
        private Label lblTotal;
        private Button btnDetails;
        public ListBox listVacays;
        private Button btnLoadVacay;
        private Button btnRmvVaca;
    }
}