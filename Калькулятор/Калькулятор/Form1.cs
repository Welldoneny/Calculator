using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        static private string output;
        private string newstr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        static void CheckException(ref string output, TextBox textBox)
        {
            if (output == " Cannot divide by zero" || output == " Invalid input")
            {
                output = string.Empty;
                textBox.Text = string.Empty;
            }
        }
        private void Button_zero_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '0';
            output += '0';
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '1';
            output += '1';
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '2';
            output += '2';
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '3';
            output += '3';
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '4';
            output += '4';
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '5';
            output += '5';
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '6';
            output += '6';
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '7';
            output += '7';
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '8';
            output += '8';
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '9';
            output += '9';
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            CheckException(ref output, textBox);
            textBox.Text += '+';
            output += "+";
        }

        static void arrRemove(ref double[] arr, int index, string action)
        {
            double[] newarr = new double[arr.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newarr[i] = arr[i];
            }

            if (action == "multiply")
            {
                newarr[index] = arr[index] * arr[index + 1];
            }
            if (action == "divide")
            {
                try
                {
                    newarr[index] = arr[index] / arr[index + 1];
                }
                catch (Exception)
                {
                    output = " Cannot divide by zero";
                }
            }
            for (int i = index + 1; i < newarr.Length; i++)
            {
                newarr[i] = arr[i + 1];
            }
            arr = newarr;
        }
        static void strRemove(ref string sign, int index)
        {
            char[] temp = new char[sign.Length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = sign[i];
            }
            for (int i = index; i < temp.Length; i++)
            {
                temp[i] = sign[i + 1];
            }
            sign = new string(temp);
        }
        static string Result(string output)
        {
            string[] numers = output.Split('+', '-', '*', '/');
            double[] arr = new double[numers.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    arr[i] = double.Parse(numers[i]);
                }
                catch (Exception)
                {

                    return " Invalid input";
                }
                
            }

            string sign = "";
            for (int i = 0; i < output.Length-1; i++)
            {
                if (output[i] == '+' || output[i] == '-' || output[i] == '*' || output[i] == '/')
                {
                    sign += output[i];
                }
            }

            for (int i = 0; i < sign.Length; i++)
            {
                if (sign[i] == '*')
                {
                    arrRemove(ref arr, i,"multiply");
                    strRemove(ref sign, i);
                    i--;
                }
                else if (sign[i] == '/')
                {
                    arrRemove(ref arr, i, "divide");
                    strRemove(ref sign, i);
                    i--;
                }
            }

            for (int i = 0; i < sign.Length; i++)
            {
                if (sign[i] == '+')
                {
                    arr[0] = arr[0] + arr[i + 1];
                }
                else if (sign[i] == '-')
                {
                    arr[0] = arr[0] - arr[i + 1];
                }
            }

            string answer = Convert.ToString(arr[0]);
            return answer;
        }
        private void Button_result_Click(object sender, EventArgs e)
        {
            output = Result(output);
            textBox.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            output = textBox.Text;
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            textBox.Text += '*';
            output += "*";
        }

        private void Button_AllClear_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
            output = string.Empty;
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
            output += "-";
        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
            output += "/";
        }
        static string DeleteLast(string str)
        {
            if (str.Length == 0)
            {
                return string.Empty;
            }

            char[] temp = new char[str.Length-1];
            for (int i = 0; i < str.Length-1; i++)
            {
                temp[i] = str[i];
            }
            str = new string(temp); 
            return str;
        }
        private void Button_clear_Click(object sender, EventArgs e)
        {
            newstr = DeleteLast(output);
            textBox.Text = newstr;
            output = newstr;
        }
    }
}
