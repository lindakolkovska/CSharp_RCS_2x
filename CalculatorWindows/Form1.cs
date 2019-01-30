using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = txtone.Text;
            var y = txttwo.Text;
            var oper = txtoper.Text;

            int one = int.Parse(x);
            int two = int.Parse(y);

            switch (oper)
            {
                case "+":
                    var sum = one + two;
                    lblResult.Text = sum.ToString();
                    break;
                case "-":
                    var sum1 = one - two;
                    lblResult.Text = sum1.ToString();
                    break;
                case "*":
                    var sum2 = one * two;
                    lblResult.Text = sum2.ToString();
                    break;
                case "/":
                    var sum3 = one / two;
                    lblResult.Text = sum3.ToString();
                    break;
            }

        }

        private void Skaitlis2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
