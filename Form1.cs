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
             designation = "Junior Software Developer";
        
        private double 
            rates1 = 0,
             cutoffs1 = 0,
             rates2 = 0,
             cutoffs2 = 0,
             rates3 = 0,
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

        private void txtphilcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrate1(object sender, KeyPressEventArgs e)
        {

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
        {
            try
            {

                if (!double.TryParse(txtrate3.Text, out rates3))
                {
                    MessageBox.Show("Please enter a valid number.");
                    txtrate.Clear();
                }
                else
                {
                    double.TryParse(txtrate3.Text, out rates3);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong value");
            }
        }

        private void txtrate2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!double.TryParse(txtrate2.Text, out rates2))
                {
                    MessageBox.Show("Please enter a valid number.");
                    txtrate.Clear();
                }
                else
                {
                    double.TryParse(txtrate2.Text, out rates2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong value");
            }
        }

        private void txtrate_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (!double.TryParse(txtrate.Text, out rates1))
                {
                    MessageBox.Show("Please enter a valid number.");
                    txtrate.Clear();
                }
                else
                {
                    double.TryParse(txtrate.Text, out rates1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong value");
            }
        }

        private void txtcutoff3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtcutoff3.Text, out cutoffs3))
                {
                    MessageBox.Show("Please enter a valid number for cutoff.");
                    txtcutoff3.Clear();
                }
                else
                {
                    double.TryParse(txtrate3.Text, out rates3);
                    double.TryParse(txtcutoff3.Text, out cutoffs3);


                    txtincomcut3.Text = (rates3 * cutoffs3).ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no value inside");
            }
        }

        private void txtcutoff2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtcutoff2.Text, out cutoffs2))
                {
                    MessageBox.Show("Please enter a valid number for cutoff.");
                    txtcutoff2.Clear();
                }
                else
                {
                    double.TryParse(txtrate2.Text, out rates2);
                    double.TryParse(txtcutoff2.Text, out cutoffs2);


                    txtincomcut2.Text = (rates2 * cutoffs2).ToString();
             
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no value inside");
            }
        }

        private void txtcutoff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(!double.TryParse(txtcutoff.Text, out cutoffs1))
                {
                    MessageBox.Show("Please enter a valid number for cutoff.");
                    txtcutoff.Clear();
                }
                else
                {
                    double.TryParse(txtrate.Text, out rates1);
                    double.TryParse(txtcutoff.Text, out cutoffs1);
                    txtincomcut.Text = (rates1 * cutoffs1).ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no value inside");
            }
            
        }

        public Form1()
        {
            InitializeComponent();
          


        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNet_Click(object sender, EventArgs e)
        {
            try
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
                    total_deduction = philhealth_Loand + sss_Loand + pagibig_Loand + salary_loan + Faculty_deposit + Faculty_savings + Other_loan 
                        + double.Parse(txtssscon.Text) + double.Parse(txtpagibigcon.Text) + double.Parse(txtphilcon.Text); 
                    
                    txttotaldeduc.Text = total_deduction.ToString();
                    net_income = (grosspay - total_deduction);
                    txtinetincome.Text = net_income.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong Value");
            }
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            
            try
            {
                double.TryParse(txtrate.Text, out rates1);
                double.TryParse(txtcutoff.Text, out cutoffs1);
                double.TryParse(txtrate2.Text, out rates2);
                double.TryParse(txtcutoff2.Text, out cutoffs2);
                double.TryParse(txtrate3.Text, out rates3);
                double.TryParse(txtcutoff3.Text, out cutoffs3);
                if (!double.TryParse(txtrate.Text, out rates1) ||
                    !double.TryParse(txtcutoff.Text, out cutoffs1) ||
                    !double.TryParse(txtrate2.Text, out rates2) ||
                    !double.TryParse(txtcutoff2.Text, out cutoffs2) ||
                    !double.TryParse(txtrate3.Text, out rates3) ||
                    !double.TryParse(txtcutoff3.Text, out cutoffs3))
                {
                    MessageBox.Show("Put a value inside the box");
                    txtrate.Clear();
                    txtcutoff.Clear();
                    txtrate2.Clear();
                    txtcutoff2.Clear();
                    txtcutoff3.Clear();
                    txtrate3.Clear();
                    txtincomcut.Clear();
                    txtincomcut2.Clear();
                    txtincomcut3.Clear();
                    txtrate.Focus();
                }
                else
                {
                    try
                    {
                       
                        double.TryParse(txtgross.Text, out grosspay);
                        double.TryParse(txtssscon.Text, out ssscon);
                        double.TryParse(txtpagibigcon.Text, out pagibigcon);
                        double.TryParse(txtphilcon.Text, out philhealthcon);
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
                        } else
                        {
                            MessageBox.Show("Please put a valid number inside the box");
                            txtgross.Clear();
                            txtssscon.Clear();
                        }

                        //philhealth Contribution
                        if (grosspay <= 10000)
                        {
                            mscphil = 500;
                        }
                        else if (grosspay >= 100000)
                        {
                            mscphil = 5000;
                        }
                        else if (grosspay > 10000 | grosspay < 100000)
                        {
                            mscphil = (grosspay / 500) * 500;
                        }
                        else
                        {
                            MessageBox.Show("Please put a valid number inside the box");
                            txtgross.Clear();
                            txtssscon.Clear();
                        }
                        //pagibig contribution
                        if (grosspay <= 1500)
                        {
                            mscpagibig = 200;
                        }
                        else if (grosspay > 10000)
                        {
                            mscpagibig = 10000;
                        }
                        else if (grosspay > 1500 | grosspay < 10000) 
                        {
                            mscpagibig = (grosspay / 500) * 500;
                        }
                        else
                        {
                            MessageBox.Show("Please put a valid number inside the box");
                            txtgross.Clear();
                            txtssscon.Clear();
                        }
                        ssscon = msc * .015;
                       philhealthcon = mscphil * 0.05;
                        pagibigcon = mscpagibig * 0.02;
                        txtssscon.Text = ssscon.ToString();
                        txtphilcon.Text = philhealthcon.ToString();
                        txtpagibigcon.Text = pagibigcon.ToString();
                        txtgross.Text = (double.Parse(txtincomcut.Text) + double.Parse(txtincomcut2.Text) + double.Parse(txtincomcut3.Text)).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There is no value inside");
                    }
                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something Happened while running the system...");
            }



        }

        private void btnsave_Click(object sender, EventArgs e)
        {
             
            Form2 form2 = new Form2();
            form2.ShowDialog();
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
                //txtEmploystats = employeestats;


            }

        }

        private void txtEmployeenum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                

                double.TryParse(txtEmployeenum.Text, out employeenumber);
                if (!double.TryParse(txtEmployeenum.Text, out employeenumber))
                {
                    MessageBox.Show("Please put a number inside");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong Value Please try again");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
    }
}
