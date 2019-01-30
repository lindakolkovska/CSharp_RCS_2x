using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var x = txtXValue.Text;
            var y = txtYValue.Text;

            var action = txtActionValue.Text;

            int xValue = int.Parse(x);
            int yValue = int.Parse(y);


            /*if (double.TryParse(x, out xValue))
            {
                
                //izdevās pārveidot par skaitli
            }
            else
            {
                // neizdevās pārveidot
            }

            //double yValue = double.Parse(y);
            //var convResult = double.TryParse(x, out xValue);*/

            switch (action)
            {
                case "+":
                    double sum = xValue + yValue;
                    lblResult.Text = sum.ToString();
                    break;
                case "-":
                    double detraction = xValue - yValue;
                    lblResult.Text = detraction.ToString();
                    break;
                case "*":
                    double sum1 = xValue * yValue;
                    lblResult.Text = sum1.ToString();
                    break;
                case "/":
                    double sum3 = xValue / yValue;
                    lblResult.Text = sum3.ToString();
                    break;
                default:
                    break;
            }

        }


    }
}
