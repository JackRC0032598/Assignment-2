using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the total resistance in a series circuit with 2 resistors
            try
            {
                Double R1, R2, Resistance;
                R1 = Convert.ToDouble(textBox1.Text);
                R2 = Convert.ToDouble(textBox2.Text);
                Resistance = R1 + R2;
                label3.Text = "Resistance = " + Resistance;
            }
            catch
            {
                MessageBox.Show("Error, Please type in two numbers");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calculate the total resistance in the series circuit with 3 Resistors
            try
            {
                Double R1, R2, R3, Resistance;
                R1 = Convert.ToDouble(textBox3.Text);
                R2 = Convert.ToDouble(textBox4.Text);
                R3 = Convert.ToDouble(textBox5.Text);
                Resistance = R1 + R2 + R3;
                label7.Text = "Resistance = " + Resistance;
            }
            catch
            {
                MessageBox.Show("Error, Please type in three numbers");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Calculate the total resitance in the parallel circuit with 2 resistors
            try
            {
                Double R1, R2, Resistance;
                R1 = Convert.ToDouble(textBox6.Text);
                R2 = Convert.ToDouble(textBox7.Text);
                Resistance = 1 / (1 / R1 + 1 / R2);
                label10.Text = "resistance = " + Resistance;
            }
            catch
            {
                MessageBox.Show("Error, Please type in 2 numbers");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calculate the total resitance in the parallel circuit with 3 resistors
            try
            {
                Double R1, R2, R3, Resistance;
                R1 = Convert.ToDouble(textBox8.Text);
                R2 = Convert.ToDouble(textBox9.Text);
                R3 = Convert.ToDouble(textBox10.Text);
                Resistance = 1 / (1 / R1 + 1 / R2 + 1 / R3);
                label14.Text = "resistance = " + Resistance;
            }
            catch
            {
                MessageBox.Show("Error, Please type in 3 numbers");
            }
        }
    }
}
