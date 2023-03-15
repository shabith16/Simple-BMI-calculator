using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        float weight, height;
        CALCULATOR ob = new CALCULATOR();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (AGE.Text!=double)
            //{MessageBox.Show("Emter correct value");
            //     AGE.Text = String.Empty;
            //}

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            float al;
            String ai,l;
            weight = float.Parse(WEIGHT.Text);
            height = float.Parse(HEIGHT.Text);
         //   weight = Convert.ToFloat(WEIGHT.Text);
           // height = Convert.ToDouble(HEIGHT.Text); 
            string ak = (string)comboBox1.SelectedItem;
            if (ak == "US UNITS: in and lbs")
            {
               al= ob.Imperial(weight, height);
               ai = ob.index(al);
               l = Convert.ToString(al);
               MessageBox.Show(l+" "+ai, "BMI");
            }
            else if (ak == "METRIC UNITS: cm and kg")
            {
                al = ob.Metric(weight, height);
                ai = ob.index(al);
                l = Convert.ToString(al);
                MessageBox.Show(l + " " + ai, "BMI");
            }
        }

        private void WEIGHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            WEIGHT.Text = String.Empty;
            HEIGHT.Text = String.Empty;
            AGE.Text = String.Empty;
            comboBox1.Text = String.Empty;
            male.Checked = false;
            FEMALE.Checked = false;

          //  male_CheckedChanged.Checked = false;
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            //if (male.Checked)
            //{
            //                MessageBox.Show("you select male");
            //}
           
        }

        private void FEMALE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
