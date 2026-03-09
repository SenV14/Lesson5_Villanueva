using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson5_Villanueva
{
    public partial class Form1 : Form
    {
        private string fname = "Sean",
             lname = "Espineli",
             mname = "Villanueva",
             civilstatus = "SINGLE",
             quali_stats = "Yes",
             //employeestats = "Unemployed",
             designation = "Junior Software Developer",
               department = "College of Engineering,Computer Studies and Architecture";


        private double
            rates1 = 0,
             cutoffs1 = 0,
             rates2 = 0,
             cutoffs2 = 0,
             rates3 = 0,
            income_cut1 = 0,
            income_cut2 = 0,
             income_cut3 = 0,
             cutoffs3 = 0,
             grosspay = 0,
             net_income = 0,
             sss_Loand = 0,
             pagibig_Loand = 0,
            philhealth_Loand = 0,
             Faculty_deposit = 0,
             Faculty_savings = 0,
             salary_loan = 0,
             Other_loand = 0,
             total_Deduction = 0,
            employeenumber = 0,
               ssscon = 0,
            pagibigcon = 0,
            philhealthcon = 0,
            total_deduction = 0,
            Other_loan = 0,
            msc = 0,
            mscphil = 0,
            mscpagibig = 0;

            private double
            taxcut = 0;


        private void txtincomecon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkeypress_employeenum(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
         txtDepartment.Text = department;
        }

        private void txtcut3_kepress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtincomcut_TextChanged(object sender, EventArgs e)
        {
      

        }

        private void txtincomcut2_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void txtpress_cut2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtpress_cut3(object sender, KeyPressEventArgs e)
        {

        }

        private void txtincomcut3_TextChanged(object sender, EventArgs e)
        {
     
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void keypress_cut1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void keypress_rate3(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_keypressrate1(object sender, KeyPressEventArgs e)
        {
         if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void rate2_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtphilcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrate1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;

            }
        }

        private void txt(object sender, KeyPressEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtfirst.Clear();
            txtlast.Clear();
            txtmiddle.Clear();
            txtcivil.Clear();
            txtstatus.Clear();
            txtcivil.Clear();
            txtdesig.Clear();
            txtEmploystats.Clear();
            txtrate.Clear();
            txtrate2.Clear();
            txtrate3.Clear();
            txtcutoff.Clear();
            txtcutoff2.Clear();
            txtcutoff3.Clear();
            txtincomcut.Clear();
            txtincomcut2.Clear();
            txtincomcut3.Clear();
            txtgross.Clear();
            txtinetincome.Clear();
            txttotaldeduc.Clear();
            txtEmployeenum.Clear();
            txtssscon.Clear();
            txtpagibigcon.Clear();
            txtphilcon.Clear();
            txtpagibigload.Clear();
            txtsssloan.Clear();
            txtdeposit.Clear();
            txtsavings.Clear();
            txtsalary.Clear();
            txtother.Clear();
        }

        private void txtssscon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtgross_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtinetincome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrate3_TextChanged(object sender, EventArgs e)
        { }
           //
        
        //
        private void txtrate2_TextChanged(object sender, EventArgs e)
        { }
        private void txtrate_TextChanged(object sender, EventArgs e)
        {
            //
            //
        }
        //

        private void txtcutoff3_TextChanged(object sender, EventArgs e)
        { }
          //
        //
        
        //
        private void txtcutoff2_TextChanged(object sender, EventArgs e)
        { }
       //
       //
        private void txtcutoff_TextChanged(object sender, EventArgs e)
        { 
        //
        //
        }//
        //
        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNet_Click(object sender, EventArgs e)
        {
            
                if (!double.TryParse(txtgross.Text, out grosspay) ||
                    !double.TryParse(txtssscon.Text, out ssscon) ||
                    !double.TryParse(txtpagibigcon.Text, out pagibigcon) ||
                    !double.TryParse(txtphilcon.Text, out philhealthcon))
                {
                    MessageBox.Show("Please enter valid numbers for gross pay and contributions.");
                    txtgross.Clear();
                    txtssscon.Clear();
                    txtpagibigcon.Clear();
                    txtphilcon.Clear();
                }
                else
                {
                    double.TryParse(txtsssloan.Text, out grosspay);
                    double.TryParse(txtpagibigload.Text, out sss_Loand);
                    double.TryParse(txtdeposit.Text, out pagibig_Loand);
                    double.TryParse(txtsalary.Text, out salary_loan);
                    double.TryParse(txtsavings.Text, out salary_loan);
                    double.TryParse(txtother.Text, out Other_loan);
                    double.TryParse(txtgross.Text, out grosspay);
                    double.TryParse(txtssscon.Text, out ssscon);
                    double.TryParse(txtpagibigcon.Text, out pagibigcon);
                    double.TryParse(txtphilcon.Text, out philhealthcon);
                    //Operation for total deduction
                    total_deduction = philhealth_Loand + sss_Loand + pagibig_Loand + salary_loan + Faculty_deposit + Faculty_savings + Other_loan 
                        + ssscon + pagibigcon + philhealthcon;
                    // operation for net income
                    txttotaldeduc.Text = total_deduction.ToString();
                    net_income = (grosspay - total_deduction);
                    txtinetincome.Text = net_income.ToString();
                }
            
        }

        private void btncross_Click(object sender, EventArgs e)
        {

            try
            { //validation for gross pay and contributions
                double.TryParse(txtgross.Text, out grosspay);
                double.TryParse(txtssscon.Text, out ssscon);
                double.TryParse(txtpagibigcon.Text, out pagibigcon);
                double.TryParse(txtphilcon.Text, out philhealthcon);
                double.TryParse(txtincomcut.Text, out income_cut1);
                double.TryParse(txtincomcut2.Text, out income_cut2);
                double.TryParse(txtincomcut3.Text, out income_cut3);
                double.TryParse(txtcutoff.Text, out cutoffs1);
                double.TryParse(txtcutoff2.Text, out cutoffs2);
                double.TryParse(txtcutoff3.Text, out cutoffs3);
                double.TryParse(txtrate.Text, out rates1);
                double.TryParse(txtrate2.Text, out rates2);
                double.TryParse(txtrate3.Text, out rates3);
                double.TryParse(txtincomecon.Text, out taxcut);
                txtincomcut.Text = (cutoffs1 * rates1).ToString();
                txtincomcut2.Text = (cutoffs2 * rates2).ToString();
                txtincomcut3.Text = (cutoffs3 * rates3).ToString();
                txtgross.Text = (income_cut1 + income_cut2 + income_cut3).ToString();
                if (grosspay <= 5250)
                {
                    msc = 5000;
                }
                else if (grosspay >= 34750)
                {
                    msc = 35000;
                }
                else if (grosspay > 5250 | grosspay < 34750)
                {
                    msc = (grosspay / 500) * 500;

                }

                //philhealth Contribution
                if (grosspay <= 10000)
                {
                    mscphil = 500 /2;
                    philhealthcon = mscphil;
                }
                else if (grosspay >= 100000)
                {
                    mscphil = 5000 /2;
                    philhealthcon = mscphil;
                }
                else if (grosspay > 10000 | grosspay < 100000)
                {

                    mscphil = (grosspay * 0.05) / 2;
                    philhealthcon = mscphil;

                }

                //pagibig contribution
                if (grosspay <= 1500)
                {
                    pagibigcon = grosspay * 0.01;
                }
                else if (grosspay > 10000)
                {
                    
                    pagibigcon = 200;
                   

                }
                else if (grosspay > 1500 | grosspay < 10000)
                {
                    pagibigcon = grosspay * 0.02;
                    
                }
                //Income tax contribution
                if (grosspay <= 20833)
                {
                    taxcut = grosspay * 0.2;
                }
                else if (grosspay > 20833 | grosspay <= 33332)
                {
                    taxcut = grosspay * 0.25;
                }
                else if (grosspay > 33332 | grosspay <= 66666)
                {
                    taxcut = grosspay * 0.3;
                }
                else if (grosspay > 66666 | grosspay <= 166666)
                {
                    taxcut = grosspay * 0.32;
                }
                else if (grosspay > 166666 | grosspay <= 666666)
                {
                    taxcut = grosspay * 0.35;
                }
                else if (grosspay > 666666)
                {
                    taxcut = grosspay * 0.35;
                }
                ssscon = msc * 0.15 ;
                pagibigcon = Math.Round(pagibigcon);
                txtssscon.Text = ssscon.ToString();
                txtphilcon.Text = philhealthcon.ToString();
                txtpagibigcon.Text = pagibigcon.ToString();
                txtincomecon.Text = taxcut.ToString();
                income_cut3.ToString();
                income_cut1.ToString();
                income_cut2.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There is no value inside");
            }
        }//
                  //

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {   
                    if (string.IsNullOrEmpty(txtgross.Text) && string.IsNullOrEmpty(txtinetincome.Text))
                    {
                        MessageBox.Show("Please calculate the gross pay and net income before saving.");
                }
                 
                    else 
                        {
                            string txtcompanyname = "Lyceum of the Philippines Cavite";
                            double.TryParse(txtEmployeenum.Text, out double employeenumber);
                            string department = txtDepartment.Text;
                            string emplyeename = $"{txtfirst.Text} {txtmiddle.Text} {txtlast.Text}";
                            datepaydate.Text = DateTime.Now.ToShortDateString();
                            string datepaydate1 = datepaydate.Text;
                            double.TryParse(txtincomecon.Text, out double taxcut);
                            double.TryParse(txtincomcut.Text, out double income_cut1);
                            double.TryParse(txtincomcut2.Text, out double income_cut2);
                            double.TryParse(txtincomcut3.Text, out double income_cut3);
                            double honorarium_adjust = 0;
                            double subs = 0;
                            double tards = 0;
                            double.TryParse(txtssscon.Text, out double ssscon);
                            double.TryParse(txtphilcon.Text, out double philhealthcon);
                            double.TryParse(txtpagibigcon.Text, out double pagibigcon);
                            double ssswisp = 750;
                            double HDMF = 200;
                            string taxes2 = txtincomecon.Text;
                            double.TryParse(txtgross.Text, out grosspay);
                            double.TryParse(txttotaldeduc.Text, out total_deduction);



                            Form2 form2 = new Form2(txtcompanyname, employeenumber, emplyeename, department, datepaydate1,
                                                    taxcut, income_cut1, income_cut2, income_cut3, honorarium_adjust,
                                                    subs, tards, ssscon, philhealthcon, pagibigcon, ssswisp, HDMF, taxes2, grosspay, total_deduction);
                            form2.ShowDialog();
                            this.Hide();
                        }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for gross pay and contributions.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 2. Set title and filter for images
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                txtfirst.Text = fname;
                txtmiddle.Text = mname;
                txtlast.Text = lname;
                txtdesig.Text = designation;
                txtstatus.Text = quali_stats;
                txtcivil.Text = civilstatus;
                txtdesig.Text = designation;

                //txtEmploystats = civilstatus.ToString();
                


            }

        }

        private void txtEmployeenum_TextChanged(object sender, EventArgs e)
        {
            //
            //
            double.TryParse(txtEmployeenum.Text, out employeenumber);
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
    }
}
