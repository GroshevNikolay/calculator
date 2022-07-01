using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static calculator.TwoArgumentsFactory;
using static calculator.ITwoCalculator;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string operation;
        public string firstArg, secondArg;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button A = (Button)sender;
            operation = A.Text;
            firstArg = textBox1.Text;
            secondArg = textBox2.Text;

            double firstNum = Convert.ToDouble(firstArg);
            double secondNum = Convert.ToDouble(secondArg);

            double calc = Creator(operation);
            double result = calc;
            if (operation=="Степень")
            {
                if(firstNum<0)
                {
                    textBox3.Text = "Число должно быть >0";
                    return;
                }
            }
            
            if (operation =="Деление")
            {
                if(secondNum==0)
                {
                    textBox3.Text = "На ноль делить нельзя";
                    return;
                }
            }
            textBox3.Text = result.ToString();
        }
    }
}