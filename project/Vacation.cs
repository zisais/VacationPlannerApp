using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project1
{
    public partial class Vacation : Form
    {
        public Vacation()
        {
            InitializeComponent();
            dateFrom.Value = DateTime.Today;
            dateTo.Value = DateTime.Today;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDest.Text == "")
            {
                MessageBox.Show("Destination cannot be blank.");
                txtDest.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            //if (txtCost.Text == "")
            //{
            //    MessageBox.Show("Cost cannot be blank.");
            //    txtCost.Text = "0.00";
            //    txtCost.Focus();
            //    this.DialogResult = DialogResult.None;
            //    return;
            //}
            //if (!decimal.TryParse(txtCost.Text, out _))
            //{
            //    MessageBox.Show("Cost must be a decimal number.");
            //    txtCost.Text = "0.00";
            //    txtCost.Focus();
            //    this.DialogResult = DialogResult.None;
            //    return;
            //}
            if (dateFrom.Value < DateTime.Now)
            {
                MessageBox.Show("Starting date cannot be in the past.");
                dateFrom.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            if (dateTo.Value < DateTime.Now)
            {
                MessageBox.Show("End date cannot be in the past.");
                dateTo.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            if (dateTo.Value < dateFrom.Value)
            {
                MessageBox.Show("End date must be after start date.");
                dateTo.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            ;
            DialogResult = DialogResult.OK;
        }
    }
}
