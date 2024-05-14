using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class ViewVacay : Form
    {
        pnlAddExpense? pnlOne;
        pnlTravel? pnlTrvl;
        pnlAccomodation? pnlAccom;
        pnlActivity? pnlAct;
        VacaData dataVaca;
        public ViewVacay(VacaData data)
        {
            InitializeComponent();
            dataVaca = data;

            lblHeader.Text = data.ToString();
            lblNumExp.Text = data.numExpenses.ToString();
            lblCost.Text = String.Format("{0:C}", data.cost);

            pnlOne = new pnlAddExpense();

            pnl.Controls.Add(pnlOne); pnlOne.Show();


            foreach (Expense exp in data.expenses)
            {
                listExpenses.Items.Add(exp.name);
            }
        }

        private bool btnIsNext = true; // button is a next button or submit button
        private int n = 0;
        private void btnNextSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnIsNext)
                {
                    RadioButton rb1 = pnlOne.radioButton1;
                    RadioButton rb2 = pnlOne.radioButton2;
                    RadioButton rb3 = pnlOne.radioButton3;

                    btnNextSubmit.Text = "Submit";
                    btnIsNext = false;
                    pnl.Controls.Remove(pnlOne);
                    pnlOne = null;
                    if (rb1.Checked) // TRAVEL
                    {
                        pnlTrvl = new pnlTravel();
                        pnl.Controls.Add(pnlTrvl); pnlTrvl.Show();
                        n = 1;
                    }
                    else if (rb2.Checked) // ACCOMODATION
                    {
                        pnlAccom = new pnlAccomodation();
                        pnl.Controls.Add(pnlAccom); pnlAccom.Show();
                        n = 2;
                    }
                    else if (rb3.Checked) // ACTIVITY
                    {
                        pnlAct = new pnlActivity();
                        pnl.Controls.Add(pnlAct); pnlAct.Show();
                        n = 3;
                    }
                }
                else
                {
                    btnIsNext = true;
                    btnNextSubmit.Text = "Next";
                    switch (n)
                    {
                        case 1:
                            {
                                RadioButton rbC = pnlTrvl.rbCar;
                                RadioButton rbP = pnlTrvl.rbPlane;
                                RadioButton rbT = pnlTrvl.rbTrain;
                                string name = pnlTrvl.txtName.Text;
                                if (!Decimal.TryParse(pnlTrvl.txtCost.Text, out decimal cost))
                                {
                                    MessageBox.Show("Cost must be decimal number", "Error", MessageBoxButtons.OK);
                                    pnlTrvl.txtCost.Text = string.Empty;
                                    pnlTrvl.txtCost.Focus();
                                    btnIsNext = false;
                                    btnNextSubmit.Text = "Submit";
                                }
                                else
                                {
                                    btnIsNext = true;
                                    btnNextSubmit.Text = "Next";
                                    Expense.ExpenseType eType = Expense.ExpenseType.Travel;
                                    Travel.TravelType tType = new Travel.TravelType();

                                    Travel trvl = new Travel();

                                    if (rbC.Checked)
                                    {
                                        tType = Travel.TravelType.Car;
                                    }
                                    else if (rbP.Checked)
                                    {
                                        tType = Travel.TravelType.Plane;
                                    }
                                    else if (rbT.Checked)
                                    {
                                        tType = Travel.TravelType.Train;
                                    }

                                    trvl.setAll(name, cost, eType, tType);

                                    dataVaca.cost += cost;
                                    listExpenses.Items.Add(trvl.name);
                                    dataVaca.newExpense(trvl);
                                    pnl.Controls.Remove(pnlTrvl);
                                    pnlTrvl = null;
                                }
                                break;
                            }
                        case 2:
                            {
                                RadioButton rbH = pnlAccom.rbHotel;
                                RadioButton rbB = pnlAccom.rbBnb;
                                RadioButton rbF = pnlAccom.rbFriend;
                                string name = pnlAccom.txtName.Text;
                                if (!Int32.TryParse(pnlAccom.txtNights.Text, out int nights))
                                {
                                    MessageBox.Show("Nights must be numeric value", "Error", MessageBoxButtons.OK);
                                    pnlAccom.txtNights.Text = string.Empty;
                                    pnlAccom.txtNights.Focus();
                                    btnIsNext = false;
                                    btnNextSubmit.Text = "Submit";
                                }
                                else
                                {
                                    if (!Decimal.TryParse(pnlAccom.txtCost.Text, out decimal cost))
                                    {
                                        MessageBox.Show("Cost must be decimal number", "Error", MessageBoxButtons.OK);
                                        pnlAccom.txtCost.Text = string.Empty;
                                        pnlAccom.txtCost.Focus();
                                        btnIsNext = false;
                                        btnNextSubmit.Text = "Submit";
                                    }
                                    else
                                    {
                                        btnIsNext = true;
                                        btnNextSubmit.Text = "Next";
                                        Expense.ExpenseType eType = Expense.ExpenseType.Accomodation;
                                        Accomodation.AccomType aType = new Accomodation.AccomType();

                                        Accomodation accom = new Accomodation();

                                        if (rbH.Checked)
                                        {
                                            aType = Accomodation.AccomType.Hotel;
                                        }
                                        else if (rbB.Checked)
                                        {
                                            aType = Accomodation.AccomType.BNB;
                                        }
                                        else if (rbF.Checked)
                                        {
                                            aType = Accomodation.AccomType.Friend;
                                        }

                                        accom.setAll(name, cost, nights, eType, aType);

                                        dataVaca.cost += accom.cost;
                                        listExpenses.Items.Add(accom.name);
                                        dataVaca.newExpense(accom);
                                        pnl.Controls.Remove(pnlAccom);
                                        pnlAccom = null;
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                RadioButton rbW = pnlAct.rbWinter;
                                RadioButton rbS = pnlAct.rbSummer;
                                RadioButton rbE = pnlAct.rbEnt;
                                string name = pnlAct.txtName.Text;
                                if (!Decimal.TryParse(pnlAct.txtCost.Text, out decimal cost))
                                {
                                    MessageBox.Show("Cost must be decimal number", "Error", MessageBoxButtons.OK);
                                    pnlAct.txtCost.Text = string.Empty;
                                    pnlAct.txtCost.Focus();
                                    btnIsNext = false;
                                    btnNextSubmit.Text = "Submit";
                                }
                                else
                                {
                                    btnIsNext = true;
                                    btnNextSubmit.Text = "Next";
                                    Expense.ExpenseType eType = Expense.ExpenseType.Activity;
                                    Activity.ActivityType aType = new Activity.ActivityType();

                                    Activity act = new Activity();

                                    if (rbW.Checked)
                                    {
                                        aType = Activity.ActivityType.Winter;
                                    }
                                    else if (rbS.Checked)
                                    {
                                        aType = Activity.ActivityType.Summer;
                                    }
                                    else if (rbE.Checked)
                                    {
                                        aType = Activity.ActivityType.Entertainment;
                                    }

                                    act.setAll(name, cost, eType, aType);

                                    dataVaca.cost += cost;
                                    listExpenses.Items.Add(act.name);
                                    dataVaca.newExpense(act);
                                    pnl.Controls.Remove(pnlAct);
                                    pnlAct = null;
                                }
                                break;
                            }
                    }
                
                    lblCost.Text = string.Format("{0:C}", dataVaca.cost);
                    lblNumExp.Text = dataVaca.numExpenses.ToString();
                    pnlOne = new pnlAddExpense();
                    pnl.Controls.Add(pnlOne); pnlOne.Show();
                }
            }
            catch (Exception ex)
            {
                string str = "For the life of me I can not figure out why after catching " +
                    "an input validation(i.e. user inputs alphabetical characters in the 'cost' input), the next time you click 'next' on the New Expense UserControl, " +
                    "the button changes to 'Submit', but it stays on the New Expense screen. " +
                    "Clicking that 'Submit' then throws an error which I am catching now. " +
                    "Click 'Done' and then load the vacation data form again, and it will be fine.";
                MessageBox.Show(str, "a dumb error", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnRmvExp_Click(object sender, EventArgs e)
        {
            int i = listExpenses.SelectedIndex;
            listExpenses.Items.RemoveAt(i);
            dataVaca.rmvExpense(i);
            lblCost.Text = string.Format("{0:C}", dataVaca.cost);
            lblNumExp.Text = dataVaca.numExpenses.ToString();
        }
    }
}


