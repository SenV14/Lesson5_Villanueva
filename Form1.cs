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
           

        }

        private void btncross_Click(object sender, EventArgs e)
        {
            double value1, value2, value3, value4, value5, value6;
            double.TryParse(txtrate.Text, out value1);
            double.TryParse(txtcutoff.Text, out value2);
            double.TryParse(txtrate2.Text, out value3);
            double.TryParse(txtcutoff2.Text, out value4);
            double.TryParse(txtrate3.Text, out value5);
            double.TryParse(txtcutoff3.Text, out value6);

            if (!double.TryParse(txtrate.Text, out value1) || 
                !double.TryParse(txtcutoff.Text, out value2)|| 
                !double.TryParse(txtrate2.Text, out value3) ||
                !double.TryParse(txtcutoff2.Text, out value4)|| 
                !double.TryParse(txtrate3.Text, out value5)|| 
                !double.TryParse(txtcutoff3.Text, out value6))
            {
                MessageBox.Show("Put a value inside the box");
                txtrate.Clear();
                txtcutoff.Clear();
                txtrate2.Clear();
                txtcutoff2.Clear();
                txtcutoff3.Clear();
                txtrate3.Clear();
                textBox5.Clear();
                textBox8.Clear();
                textBox11.Clear();
                txtrate.Focus();
            }   
            else
            {
                textBox5.Text = (value1 * value2).ToString();
                textBox8.Text = (value3 * value4).ToString();
                textBox11.Text = (value5 * value6).ToString();
            }
  
       
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

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
            }

        }

        private void txtEmployeenum_TextChanged(object sender, EventArgs e)
        {
            double value1;
            int employee1 = 1;
            int employee2 = 2;
            double.TryParse(txtEmployeenum.Text, out value1);
            if (value1 != employee1 || value1 != employee2)
            {
                MessageBox.Show("Please put a number inside");
            }
            
        }
    }
}
