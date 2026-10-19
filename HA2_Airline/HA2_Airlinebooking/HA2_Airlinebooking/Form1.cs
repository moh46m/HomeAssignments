using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HA2_Airlinebooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Hubi magaca rakaabka
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Fadlan geli magaca rakaabka.");
                return;
            }

            // Hubi in da'da, tikidhada iyo boorsadu tiro sax ah yihiin
            if (!int.TryParse(txtAge.Text, out int age) ||
                !int.TryParse(txtTickets.Text, out int tickets) ||
                !decimal.TryParse(txtBaggage.Text, out decimal baggage))
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah.");
                return;
            }

            // Hubi in da'du u dhexayso 1 ilaa 100
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Da'du waa inay u dhexaysaa 1 ilaa 100.");
                return;
            }

            // Hubi in tirada tikidhadu u dhexayso 1 ilaa 5
            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tikidhadu waa inay u dhexeeyaan 1 ilaa 5.");
                return;
            }

            // Hubi in boorsadu aysan negative ahayn ama ka badnayn 50 kg rakaabkiiba
            if (baggage < 0 || baggage > 50m * tickets)
            {
                MessageBox.Show("Boorsadu waa inay ahaataa 0 ilaa 50 kg rakaabkiiba.");
                return;
            }

            // Dooro qiimaha tikidhka iyadoo la eegayo Travel Class
            decimal price;
            string cls;

            if (rdoFirst.Checked)
            {
                price = 300m;
                cls = "First Class";
            }
            else if (rdoNormal.Checked)
            {
                price = 100m;
                cls = "Normal Class";
            }
            else if (rdoBusiness.Checked)
            {
                price = 200m;
                cls = "Business Class";
            }
            else
            {
                MessageBox.Show("Fadlan dooro Travel Class.");
                return;
            }

            // Diid First Class haddii rakaabku ka yar yahay 12 sano
            bool bookingApproved = true;

            if (age < 12 && rdoFirst.Checked)
            {
                bookingApproved = false;

                MessageBox.Show(
                    "Booking waa la diiday: qof ka yar 12 sano ma qaadan karo First Class.");

                return;
            }

            // Xisaabi qiimaha asaasiga ah ee tikidhada
            decimal ticketCost = price * tickets;

            // Xisaabi discount-ka tirada tikidhada
            decimal ticketDiscount = 0m;

            if (tickets == 5)
                ticketDiscount = ticketCost * 0.10m;
            else if (tickets >= 3)
                ticketDiscount = ticketCost * 0.05m;

            // Xisaabi discount-ka da'da
            decimal ageDiscount = 0m;

            if (age < 12)
                ageDiscount = ticketCost * 0.20m;
            else if (age >= 60)
                ageDiscount = ticketCost * 0.10m;

            // Ku dar insurance haddii la doortay
            decimal insurance = chkInsurance.Checked
                ? 25m * tickets : 0m;

            // Xisaabi wadarta lacagta ugu dambaysa
            decimal total = ticketCost - ticketDiscount
                            - ageDiscount + insurance;

            // Ku muuji faahfaahinta booking-ka
            txtDetails.Text =
                "Airline Booking Details" + Environment.NewLine +
                "-----------------------------------" + Environment.NewLine +
                "Passenger Name : " + txtName.Text.Trim() + Environment.NewLine +
                "Passenger Age  : " + age + Environment.NewLine +
                "Travel Class   : " + cls + Environment.NewLine +
                "Number of Tickets: " + tickets + Environment.NewLine +
                "Ticket Price   : $" + price.ToString("0.00") + Environment.NewLine +
                "Tickets Cost   : $" + ticketCost.ToString("0.00") + Environment.NewLine +
                "Baggage Weight : " + baggage + " kg" + Environment.NewLine +
                "Ticket Discount: $" + ticketDiscount.ToString("0.00") + Environment.NewLine +
                "Age Discount   : $" + ageDiscount.ToString("0.00") + Environment.NewLine +
                "Insurance      : $" + insurance.ToString("0.00") + Environment.NewLine +
                "-----------------------------------" + Environment.NewLine +
                "Total Amount   : $" + total.ToString("0.00") + Environment.NewLine +
                "Booking Approved: " + bookingApproved;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Nadiifi xogta rakaabka
            txtName.Clear();
            txtAge.Clear();
            txtTickets.Clear();
            txtBaggage.Clear();

            // Ka saar doorashada Travel Class
            rdoFirst.Checked = false;
            rdoNormal.Checked = false;
            rdoBusiness.Checked = false;

            // Ka saar Insurance
            chkInsurance.Checked = false;

            // Nadiifi natiijada booking-ka
            txtDetails.Clear();

            // Cursor-ka ku celi magaca rakaabka
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Xir application-ka
            this.Close();
        }
    }
}
