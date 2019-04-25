using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int op = 0;
   double a, b, c = 0;
        string st;
            private void btn1(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            st = Display.Text ;
            Display.Text =st+ "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "9";
        }

        

        private void botao0_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + "0";
        }

        private void botao_virgula_Click(object sender, EventArgs e)
        {
            st = Display.Text;
            Display.Text = st + ",";
        }



        private void botao_soma_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display.Text);
            Display.Text = "";
            op = 1;
        }

        

        private void botao_subtracao_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display.Text);
            Display.Text = "";
            op = 2;
        }

       

        private void botao_divisao_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display.Text);
            Display.Text = "";
            op = 3;
        }

       
        

        private void botao_multiplicacao_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display.Text);
            Display.Text = "";
            op = 4;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            string str;
            str = Display.Text;
            if (str.Length > 0)
            {
                Display.Text = str.Substring(0, str.Length - 1);
            }
        }


        private void botao_igual_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {

                b = Convert.ToDouble(Display.Text);
                c = a + b;
                Display.Text = Convert.ToString(c);
            }

            if (op == 2)
            {

                b = Convert.ToDouble(Display.Text);
                c = a - b;
                Display.Text = Convert.ToString(c);
            }

            if (op == 3)
            {

                b = Convert.ToDouble(Display.Text);
                c = a / b;
                Display.Text = Convert.ToString(c);
            }
            if (op == 4)
            {

                b = Convert.ToDouble(Display.Text);
                c = a * b;
                Display.Text = Convert.ToString(c);
            }
        }
    }
}
