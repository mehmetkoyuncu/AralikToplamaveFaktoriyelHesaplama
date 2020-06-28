using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForOrnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = Convert.ToInt32(txtFirstNumber.Text);
                int number2 = Convert.ToInt32(txtSecondNumber.Text);
                int sum = 0;

                listBox1.Items.Clear();

                for (int i = number1; i <= number2; i++)
                {
                    listBox1.Items.Add(i);
                    sum += i;

                }
                lblFirstResult.Text = sum.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Format Hatası");
            }

        }



        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {

            try
            {
                int i = 1;
                int faktoriyel = 1;
                listBox2.Items.Clear();
                int number = Convert.ToInt32(txtFaktoriyelSayi.Text);

                for (i = 1; i <= number; i++)
                {
                    faktoriyel = faktoriyel * i;
                    listBox2.Items.Add(i);
                    lblFactResult.Text = faktoriyel.ToString();
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Format Hatası");
            }

        }
    }
}
