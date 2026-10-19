using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HA1_Roombookin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tus cinwaanka marka barnaamijku furmo
            txtDetails.Text = "Booking Details";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Hubinta magaca martida iyo xogta tirooyinka
            string guestName = txtName.Text.Trim();

            int age, nights, guests;

            // Hubi in magaca martidu aanu madhnayn
            if (guestName == "")
            {
                MessageBox.Show("Please enter guest name.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // TryParse wuxuu hubinayaa in xogtu tahay tiro sax ah
            if (!int.TryParse(txtAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers for age, nights and guests.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hubinta da'da martida: 18 ilaa 90 sano
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Hubinta tirada habeenada: 1 ilaa 30
            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Hubinta tirada martida: 1 ilaa 6 qof
            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Go'aaminta nooca qolka
            string room = "";
            decimal rate = 0m;
            int maxGuests = 0;

            if (rdoStandard.Checked)
            {
                room = "Standard";
                maxGuests = 2;
            }
            else if (rdoNormal.Checked)
            {
                room = "Normal";
                maxGuests = 4;
            }
            else if (rdoHigh.Checked)
            {
                room = "Hight";
                maxGuests = 6;
            }
            else
            {
                MessageBox.Show("Please select a room type.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Isticmaal switch si loo helo qiimaha qolka habeenkii
            switch (room)
            {
                case "Standard":
                    rate = 50m;
                    break;

                case "Normal":
                    rate = 80m;
                    break;

                case "Hight":
                    rate = 130m;
                    break;
            }

            // 7. Hubinta in tirada martidu ku habboon tahay qolka
            bool bookingApproved = true;
            string status = "Approved";

            if (guests > maxGuests)
            {
                bookingApproved = false;
                status = "Rejected (Too many guests for this room)";
            }

            // 8. Xisaabinta qiimaha aasaasiga ah ee qolka
            decimal roomCost = rate * nights;

            // 9. Xisaabinta discount-ka iyadoo lagu salaynayo habeenada
            decimal discountRate = 0m;

            if (nights >= 10)
            {
                discountRate = 0.12m; // 12% discount
            }
            else if (nights >= 5)
            {
                discountRate = 0.05m; // 5% discount
            }

            decimal nightDiscount = roomCost * discountRate;

            // 10. Discount dheeraad ah oo loogu talagalay martida 60 jir ama ka weyn
            decimal seniorDiscount = 0m;

            if (age >= 60)
            {
                seniorDiscount = roomCost * 0.05m; // 5% senior discount
            }

            // Isku gee labada discount
            decimal discount = nightDiscount + seniorDiscount;

            // 11. Xisaabinta qiimaha breakfast-ka
            // Breakfast-ku waa $10 qofkiiba habeenkiiba
            decimal breakfast = 0m;

            if (chkBreakfast.Checked)
            {
                breakfast = 10m * guests * nights;
            }

            // 12. Service surcharge haddii martidu ka badan tahay 4 qof
            decimal serviceSurcharge = 0m;

            if (guests > 4)
            {
                serviceSurcharge = roomCost * 0.05m; // 5% surcharge
            }

            // 13. Xisaabinta lacagta ugu dambaysa
            decimal total = roomCost + breakfast
                            + serviceSurcharge - discount;

            // 14. Soo bandhigista faahfaahinta booking-ka
            txtDetails.Text =
                "Booking Details" + Environment.NewLine +
                "-----------------------------------" + Environment.NewLine +
                "Guest Name       : " + guestName + Environment.NewLine +
                "Guest Age        : " + age + Environment.NewLine +
                "Number of Nights : " + nights + Environment.NewLine +
                "Number of Guests : " + guests + Environment.NewLine +
                "Room Type        : " + room + Environment.NewLine +
                "Rate per Night   : $" + rate.ToString("0.00") + Environment.NewLine +
                "Room Cost        : $" + roomCost.ToString("0.00") + Environment.NewLine +
                "Breakfast        : $" + breakfast.ToString("0.00") + Environment.NewLine +
                "Night Discount   : $" + nightDiscount.ToString("0.00") + Environment.NewLine +
                "Senior Discount  : $" + seniorDiscount.ToString("0.00") + Environment.NewLine +
                "Total Discount   : $" + discount.ToString("0.00") + Environment.NewLine +
                "Service Surcharge: $" + serviceSurcharge.ToString("0.00") + Environment.NewLine +
                "-----------------------------------" + Environment.NewLine +
                "Total Amount     : $" + total.ToString("0.00") + Environment.NewLine +
                "Booking Status   : " + status;

            // 15. Farriin muujinaysa in booking-ka la oggolaaday ama la diiday
            if (bookingApproved)
            {
                MessageBox.Show("Booking approved successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(status,
                    "Booking Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. Nadiifi magaca martida
            txtName.Clear();

            // 2. Nadiifi da'da martida
            txtAge.Clear();

            // 3. Nadiifi tirada habeenada
            txtNights.Clear();

            // 4. Nadiifi tirada martida
            txtGuests.Clear();

            // 5. Ka saar doorashadii nooca qolka
            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHigh.Checked = false;

            // 6. Ka saar doorashada breakfast-ka
            chkBreakfast.Checked = false;

            // 7. Nadiifi natiijadii hore oo soo celi cinwaanka
            txtDetails.Clear();
            txtDetails.Text = "Booking Details";

            // 8. Cursor-ka ku celi meesha magaca lagu qorayo
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Xir barnaamijka Hotel Booking
            Application.Exit();
        }
    }
}
