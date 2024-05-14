namespace Project1
{
    partial class ViewVacay
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
            lblHeader = new Label();
            label1 = new Label();
            label2 = new Label();
            listExpenses = new ListBox();
            pnl = new Panel();
            btnNextSubmit = new Button();
            lblNumExp = new Label();
            lblCost = new Label();
            btnClose = new Button();
            btnRmvExp = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(18, 22);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(413, 48);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Destination : Start to End";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 106);
            label1.Name = "label1";
            label1.Size = new Size(232, 45);
            label1.TabIndex = 1;
            label1.Text = "# of Expenses: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 151);
            label2.Name = "label2";
            label2.Size = new Size(100, 45);
            label2.TabIndex = 1;
            label2.Text = "Cost: ";
            // 
            // listExpenses
            // 
            listExpenses.BackColor = Color.PapayaWhip;
            listExpenses.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listExpenses.ForeColor = Color.DeepSkyBlue;
            listExpenses.FormattingEnabled = true;
            listExpenses.ItemHeight = 45;
            listExpenses.Location = new Point(18, 254);
            listExpenses.Name = "listExpenses";
            listExpenses.Size = new Size(413, 229);
            listExpenses.TabIndex = 2;
            // 
            // pnl
            // 
            pnl.BackColor = Color.PapayaWhip;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Location = new Point(447, 84);
            pnl.Name = "pnl";
            pnl.Size = new Size(358, 300);
            pnl.TabIndex = 3;
            // 
            // btnNextSubmit
            // 
            btnNextSubmit.BackColor = Color.LemonChiffon;
            btnNextSubmit.FlatStyle = FlatStyle.Flat;
            btnNextSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextSubmit.ForeColor = Color.DeepSkyBlue;
            btnNextSubmit.Location = new Point(570, 390);
            btnNextSubmit.Name = "btnNextSubmit";
            btnNextSubmit.Size = new Size(112, 43);
            btnNextSubmit.TabIndex = 7;
            btnNextSubmit.Text = "Next";
            btnNextSubmit.UseVisualStyleBackColor = false;
            btnNextSubmit.Click += btnNextSubmit_Click;
            // 
            // lblNumExp
            // 
            lblNumExp.AutoSize = true;
            lblNumExp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumExp.Location = new Point(256, 106);
            lblNumExp.Name = "lblNumExp";
            lblNumExp.Size = new Size(0, 45);
            lblNumExp.TabIndex = 8;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCost.Location = new Point(256, 151);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(0, 45);
            lblCost.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LemonChiffon;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.DeepSkyBlue;
            btnClose.Location = new Point(701, 465);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 43);
            btnClose.TabIndex = 7;
            btnClose.Text = "Done";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRmvExp
            // 
            btnRmvExp.BackColor = Color.LemonChiffon;
            btnRmvExp.FlatStyle = FlatStyle.Flat;
            btnRmvExp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRmvExp.ForeColor = Color.DeepSkyBlue;
            btnRmvExp.Location = new Point(264, 440);
            btnRmvExp.Name = "btnRmvExp";
            btnRmvExp.Size = new Size(167, 43);
            btnRmvExp.TabIndex = 7;
            btnRmvExp.Text = "Remove Expense";
            btnRmvExp.UseVisualStyleBackColor = false;
            btnRmvExp.Click += btnRmvExp_Click;
            // 
            // ViewVacay
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(818, 513);
            Controls.Add(lblCost);
            Controls.Add(lblNumExp);
            Controls.Add(btnClose);
            Controls.Add(btnRmvExp);
            Controls.Add(btnNextSubmit);
            Controls.Add(pnl);
            Controls.Add(listExpenses);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DeepSkyBlue;
            Margin = new Padding(6);
            Name = "ViewVacay";
            Text = "ViewVacay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label label1;
        private Label label2;
        private ListBox listExpenses;
        private Panel pnl;
        private Button btnNextSubmit;
        private Label lblNumExp;
        private Label lblCost;
        private Button btnClose;
        private Button btnRmvExp;
    }
}