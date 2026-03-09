using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5_Villanueva
{
    public partial class Form2 : Form
    {
        public Form2(string txtcompanyname, double employeenumber, string emplyeename,
            string department, string datepaydate1, double taxcut, double income_cut1, 
            double income_cut2, double income_cut3, double honorarium_adjust, double  subs,
            double  tards, double ssscon, double philhealthcon, double pagibigcon,double  ssswisp,
            double HDMF,string taxes2, double grosspay, double total_deduction)
        {
            InitializeComponent();
            lblcompany.Text = txtcompanyname;
            lblcompanycode.Text = employeenumber.ToString("n");
            lblemployeename.Text = emplyeename;
            lbldepartment.Text = department;
            lblcutoff.Text = datepaydate1;
            lblpayperiod.Text = datepaydate1;
            lblbasic.Text = income_cut1.ToString("n");
            lbloter.Text = income_cut3.ToString("n");
            lblhono.Text = income_cut2.ToString("n");
            lbltaxes.Text = taxes2.ToString();
            lblsss.Text = ssscon.ToString("n");
            lblPhilhealt_contribution.Text = philhealthcon.ToString("n");
            lblpagibig.Text = pagibigcon.ToString();
            lblmaxgross.Text = grosspay.ToString("n");
            double final_deduction = total_deduction + 750;
            lbltotaldeduc.Text = final_deduction.ToString("n");











        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
