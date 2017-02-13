using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
       
        string Op = "";      
        double value,sum ;
        int count=0;
        public bool op_paressed = false;
        bool button_paressed = true;
        bool point_paressed = true;
        
             
        private void button0_Click(object sender, EventArgs e)
        {           
            Button Bt = (Button)sender;  
   
            if (op_paressed == true)
            {
                textBox1.Text = "0";
                op_paressed = false;
            }
            if (button_paressed == true)
            {
                textBox1.Text = "";
                button_paressed = false;
            }
      
            switch (Bt.Text)
            {
                case "0":
                    textBox1.Text += Bt.Text;
                    break;
                case "1":
                    textBox1.Text += Bt.Text;
                    break;
                case "2":
                    textBox1.Text += Bt.Text;
                    break;
                case "3":
                    textBox1.Text += Bt.Text;
                    break;
                case "4":
                    textBox1.Text += Bt.Text;
                    break;
                case "5":
                    textBox1.Text += Bt.Text;
                    break;
                case "6":
                    textBox1.Text += Bt.Text;
                    break;
                case "7":
                    textBox1.Text += Bt.Text;
                    break;
                case "8":
                    textBox1.Text += Bt.Text;
                    break;
                case "9":
                    textBox1.Text += Bt.Text;
                    break;
                case ".":
                    if (point_paressed == true)
                    {
                        if (textBox1.Text == "")
                            textBox1.Text += "0.";
                        else
                            textBox1.Text += Bt.Text;
                    }
                    point_paressed = false;
                    break;
                case "BackSpace":
                    if (textBox1.Text.Length > 1)
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    else
                    {
                        textBox1.Text = "0";
                    }
                    button_paressed = true;
                    break;
                case "CE":
                    textBox1.Text = "0";
                    button_paressed = true;
                    break;
            }           
        }
      
        private void button_add_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
    
            value = Convert.ToDouble(textBox1.Text);
          
            button_paressed = true;
            point_paressed = true;
            
            if (op_paressed == false)
            {                
                if (count < 1)
                {
                    sum = value;                                      
                }
                else if (count >= 1)
                {
                    sum = clc.math(Op, value, sum);
                    textBox1.Text = sum.ToString();
                }
                count++;
                Op = op.Text;
                equation.Text += value.ToString() + Op;
            }

            if (op_paressed == true)
            {
                Op = op.Text;
                equation.Text = equation.Text.Substring(0, equation.Text.Length - 1);
                equation.Text += Op;
            }

            op_paressed = true;                
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            point_paressed = true;
            button_paressed = true;
            count = 0;
            equation.Text = "" ;
            value = Convert.ToDouble(textBox1.Text);
            sum = clc.math(Op, value, sum);
            textBox1.Text = sum.ToString();                      
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            point_paressed = true;
            textBox1.Text = "0";
            equation.Text = "";
            value = 0;
            sum = 0;
            count = 0;
            button_paressed = true;
        }

        private void negate_Click(object sender, EventArgs e)
        {
            point_paressed = true;
            textBox1.Text = clc.negate(textBox1.Text);            
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            point_paressed = true;
            value = Convert.ToDouble(textBox1.Text);
            sum = value;
            sum = Math.Sqrt(sum);
            textBox1.Text = sum.ToString();
            equation.Text = "sqrt(" + value + ")";
        }

        private void reciproc_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(textBox1.Text);
            sum = value;
            sum = 1 / sum;
            textBox1.Text = sum.ToString();
            equation.Text = "reciproc(" + value + ")";
        }
            
    }
}
