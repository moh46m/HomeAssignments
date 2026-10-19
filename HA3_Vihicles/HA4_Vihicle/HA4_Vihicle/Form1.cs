using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HA4_Vihicle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowTemplate();
        }

        private void ShowTemplate()
        {
            lstresults.Items.Clear();
            lstresults.Items.Add("Rental Details");
            lstresults.Items.Add("-------------------------------------------");
            lstresults.Items.Add("Customer Name        :");
            lstresults.Items.Add("Customer Age         :");
            lstresults.Items.Add("Driving Experience   :");
            lstresults.Items.Add("Vehicle Type         :");
            lstresults.Items.Add("Daily Rate           :");
            lstresults.Items.Add("Rental Days          :");
            lstresults.Items.Add("Basic Rental Cost    :");
            lstresults.Items.Add("Discount             :");
            lstresults.Items.Add("Insurance Cost       :");
            lstresults.Items.Add("Young Driver Surcharge :");
            lstresults.Items.Add("Final Rental Cost    :");
            lstresults.Items.Add("");
            lstresults.Items.Add("-------------------------------------------");
            lstresults.Items.Add("Rental Status        :");
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // 1. Hubinta xogta macmiilka iyo in tirooyinka si sax ah loo geliyey
            string customerName = txtname.Text.Trim();

            int age, days, exp;

            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
                return;
            }

            // TryParse wuxuu hubinayaa in xogtu tahay tiro sax ah
            if (!int.TryParse(txtage.Text, out age) ||
                !int.TryParse(txtdays.Text, out days) ||
                !int.TryParse(txtexperience.Text, out exp))
            {
                MessageBox.Show("Please enter valid numbers for age, rental days and driving experience.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hubinta da'da: waa inay u dhexaysaa 18 ilaa 80
            if (age < 18 || age > 80)
            {
                MessageBox.Show("Customer age must be between 18 and 80.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hubinta maalmaha kirada: waa inay u dhexaysaa 1 ilaa 30
            if (days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Waayo-aragnimada wadistu ma noqon karto tiro taban
            if (exp < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Go'aaminta nooca gaariga iyo qiimaha maalinlaha ah
            decimal rate;
            string type;

            if (rdoeconomy.Checked)
            {
                rate = 35m;
                type = "Economy";
            }
            else if (rdosuv.Checked)
            {
                rate = 60m;
                type = "SUV";
            }
            else if (rdoluxury.Checked)
            {
                rate = 100m;
                type = "Luxury";
            }
            else
            {
                MessageBox.Show("Please select a vehicle type.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Xisaabinta qiimaha aasaasiga ah ee kirada
            decimal basic = rate * days;

            // 4. Xisaabinta discount-ka iyadoo lagu salaynayo maalmaha
            decimal discountRate = 0m;

            if (days >= 14)
            {
                discountRate = 0.10m; // 10% discount
            }
            else if (days >= 7)
            {
                discountRate = 0.05m; // 5% discount
            }

            decimal discount = basic * discountRate;

            // 5. Insurance-ku waa $15 maalintii haddii la doorto
            decimal insurance = 0m;

            if (chkinsurance.Checked)
            {
                insurance = 15m * days;
            }

            // 6. Surcharge-ka darawalka da'diisu tahay 21 ilaa 24
            decimal surcharge = 0m;

            if (age >= 21 && age <= 24)
            {
                surcharge = basic * 0.10m; // 10% young-driver surcharge
            }

            // 7. Hubinta in macmiilku xaq u leeyahay kirada
            // Bool wuxuu kaydinayaa in booking-ku la oggolaaday iyo in kale
            bool bookingApproved = true;
            string status = "Approved";

            if (age < 21)
            {
                bookingApproved = false;
                status = "Rejected (Customer must be at least 21)";
            }
            else if (exp < 1)
            {
                bookingApproved = false;
                status = "Rejected (At least 1 year of experience required)";
            }
            else if (type == "Luxury" && age < 25)
            {
                bookingApproved = false;
                status = "Rejected (Luxury requires age 25 or above)";
            }
            else if (type == "Luxury" && exp < 3)
            {
                bookingApproved = false;
                status = "Rejected (Luxury requires 3 years of experience)";
            }

            // 8. Xisaabinta qiimaha ugu dambeeya
            decimal final = basic - discount + insurance + surcharge;

            // 9. Soo bandhigista natiijada gudaha lstresults
            lstresults.Items.Clear();

            lstresults.Items.Add("Rental Details");
            lstresults.Items.Add("-------------------------------------------");
            lstresults.Items.Add("Customer Name        : " + customerName);
            lstresults.Items.Add("Customer Age         : " + age);
            lstresults.Items.Add("Driving Experience   : " + exp + " years");
            lstresults.Items.Add("Vehicle Type         : " + type);
            lstresults.Items.Add("Daily Rate           : $" + rate.ToString("0.00"));
            lstresults.Items.Add("Rental Days          : " + days);
            lstresults.Items.Add("Basic Rental Cost    : $" + basic.ToString("0.00"));
            lstresults.Items.Add("Discount             : $" + discount.ToString("0.00"));
            lstresults.Items.Add("Insurance Cost       : $" + insurance.ToString("0.00"));
            lstresults.Items.Add("Young Driver Surcharge : $" + surcharge.ToString("0.00"));
            lstresults.Items.Add("Final Rental Cost    : $" + final.ToString("0.00"));
            lstresults.Items.Add("");
            lstresults.Items.Add("-------------------------------------------");

            // 10. Soo bandhigista xaaladda kirada
            lstresults.Items.Add("Rental Status        : " + status);

            // bookingApproved wuxuu muujinayaa in kirada la oggolaaday
            if (bookingApproved)
            {
                MessageBox.Show("Rental approved successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(status,
                    "Rental Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // 1. Nadiifi magaca macmiilka
            txtname.Clear();

            // 2. Nadiifi da'da macmiilka
            txtage.Clear();

            // 3. Nadiifi tirada maalmaha kirada
            txtdays.Clear();

            // 4. Nadiifi waayo-aragnimada wadista
            txtexperience.Clear();

            // 5. Ka saar doorashada nooca gaariga
            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;

            // 6. Ka saar doorashada insurance-ka
            chkinsurance.Checked = false;

            // 7. Soo celi template-kii natiijada
            ShowTemplate();

            // 8. Cursor-ka ku celi meesha magaca lagu qorayo
            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Xir barnaamijka Vehicle Rental
            Application.Exit();
        }
    }
}
