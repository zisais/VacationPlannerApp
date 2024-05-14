namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<VacaData> vacays = new List<VacaData>();

        private int counter = 0;
        private decimal totalCost = 0.00M;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vacation vacation = new Vacation();
            vacation.StartPosition = FormStartPosition.CenterParent;

            if (vacation.ShowDialog() == DialogResult.OK)
            {
                VacaData data = new VacaData(
                    vacation.txtDest.Text,
                    vacation.dateFrom.Value.Date,
                    vacation.dateTo.Value.Date
                    );

                listVacays.Items.Add(data.dest);
                vacays.Add(data);
                counter++;
            }

            lblTotal.Text = string.Format("{0:C}", totalCost);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (counter != 0)
            {
                string str = string.Empty;
                string strDests = string.Empty;
                List<string> dests = new List<string>();
                decimal avgCost = totalCost / counter;
                string strAvg = string.Format("{0:C}", avgCost);

                foreach (VacaData vaca in vacays)
                {
                    dests.Add(vaca.dest);
                }
                strDests = String.Join(", ", dests);
                str = counter + " vacation(s) are scheduled to " + strDests + ". " +
                    "The total cost of your scheduled vacation(s) is " + lblTotal.Text +
                    " with an average cost per vacation of " + strAvg + ".";
                MessageBox.Show(str, "Vacations", MessageBoxButtons.OK);
            }
        }

        private void btnLoadVacay_Click(object sender, EventArgs e)
        {
            if (listVacays.SelectedIndex != -1)
            {
                ViewVacay viewVacay = new ViewVacay(vacays[listVacays.SelectedIndex]);
                viewVacay.StartPosition = FormStartPosition.CenterScreen;

                if (viewVacay.ShowDialog() == DialogResult.OK)
                {
                    calcCost();
                }
            }
        }

        internal void calcCost()
        {
            totalCost = 0;
            foreach (VacaData vacay in vacays)
            {
                totalCost += vacay.cost;
            }
            lblTotal.Text = string.Format("{0:C}", totalCost);
        }

        private void btnRmvVaca_Click(object sender, EventArgs e)
        {
            listVacays.Items.Remove(listVacays.SelectedItem);
            vacays.Remove((VacaData)listVacays.SelectedItem);
        }
    }
}