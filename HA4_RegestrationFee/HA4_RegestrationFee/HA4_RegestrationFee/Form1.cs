using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HA4_RegestrationFee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Hubi in magaca iyo Student ID la buuxiyey
            if (txtName.Text.Trim() == "" || txtId.Text.Trim() == "")
            {
                MessageBox.Show("Fadlan geli magaca ardayga iyo Student ID.");
                return;
            }

            // Hubi in tirada koorsooyinka iyo heerka waxbarashadu tiro sax ah yihiin
            if (!int.TryParse(txtCourses.Text, out int courses) ||
                !int.TryParse(txtLevel.Text, out int level) ||
                !decimal.TryParse(txtTransport.Text, out decimal transport))
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah.");
                return;
            }

            // Hubi xadka koorsooyinka, heerka iyo kharashka transport-ka
            if (courses < 1 || courses > 8 ||
                level < 1 || level > 4 ||
                transport < 0)
            {
                MessageBox.Show("Courses waa 1–8, Level waa 1–4, Transport-na eber kama yaraan karo.");
                return;
            }

            // Go'aami lacagta koorso kasta iyadoo lagu salaynayo heerka
            decimal feePerCourse;

            switch (level)
            {
                case 1:
                    feePerCourse = 40m;
                    break;
                case 2:
                    feePerCourse = 45m;
                    break;
                case 3:
                    feePerCourse = 50m;
                    break;
                case 4:
                    feePerCourse = 55m;
                    break;
                default:
                    MessageBox.Show("Heerka waxbarashadu sax ma aha.");
                    return;
            }

            // Xisaabi lacagta guud ee waxbarashada
            decimal tuition = courses * feePerCourse;

            // 10% qiimo-dhimis haddii ardaygu qaato 6 koorso ama ka badan
            decimal discount = courses >= 6 ? tuition * 0.10m : 0m;

            // Xisaabi lacagta ugu dambaysa
            decimal finalFee = tuition - discount + transport;

            // Soo bandhig natiijada
            lblOutName.Text = "Name: " + txtName.Text;
            lblOutId.Text = "Student ID: " + txtId.Text;
            lblOutCourses.Text = "Courses: " + courses;
            lblOutYear.Text = "Year: " + level;
            lblOutTuition.Text = "Tuition Fee: " + tuition.ToString("C");
            lblOutTransport.Text = "Transport Fee: " + transport.ToString("C");
            lblOutDiscount.Text = "Discount: " + discount.ToString("C");
            lblOutFinal.Text = "Final Fee: " + finalFee.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Nadiifi meelaha xogta lagu qoro
            txtName.Clear();
            txtId.Clear();
            txtCourses.Clear();
            txtLevel.Clear();
            txtTransport.Clear();

            // Dib ugu celi labels-ka xaaladdoodii hore
            lblOutName.Text = "Name:";
            lblOutId.Text = "Student ID:";
            lblOutCourses.Text = "Courses:";
            lblOutYear.Text = "Year:";
            lblOutTuition.Text = "Tuition Fee:";
            lblOutTransport.Text = "Transport Fee:";
            lblOutDiscount.Text = "Discount:";
            lblOutFinal.Text = "Final Fee:";

            // Ku celi cursor-ka meesha magaca lagu qoro
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Xir barnaamijka
            this.Close();
        }
    }
}
