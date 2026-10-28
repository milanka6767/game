using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class калькулятор : Form
    {
        private double firstNumber = 0;
        private string operation = "";
        private bool isNewEntry = true;

        public калькулятор()
        {
            InitializeComponent();
        }

        private void HandleButtonClick(object sender)
        {
            Button btn = (Button)sender;
            string text = btn.Text.Trim();
            string lower = text.ToLower();

            if (text == "0" || text == "1" || text == "2" || text == "3" ||
                text == "4" || text == "5" || text == "6" || text == "7" ||
                text == "8" || text == "9")
            {
                AddDigit(text);
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                SetOperation(text);
            }
            else if (text == "=")
            {
                Calculate();
            }
            else if (lower == "стереть")
            {
                ClearAll();
            }
        }


        private void AddDigit(string digit)
        {
            if (isNewEntry)
            {
                txtDisplay.Text = "";
                isNewEntry = false;
            }
            txtDisplay.Text += digit;
        }

        private void SetOperation(string op)
        {
            if (!double.TryParse(txtDisplay.Text, out firstNumber))
            {
                MessageBox.Show("Введите число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            operation = op;
            isNewEntry = true;
        }

        private void Calculate()
        {
            double secondNumber;
            if (!double.TryParse(txtDisplay.Text, out secondNumber))
            {
                MessageBox.Show("Введите число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = 0;
            switch (operation)
            {
                case "+": result = firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
                default:
                    MessageBox.Show("Сначала выберите операцию!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            txtDisplay.Text = result.ToString();
            isNewEntry = true;
        }

        private void ClearAll()
        {
            txtDisplay.Text = "";
            firstNumber = 0;
            operation = "";
            isNewEntry = true;
        }


        private void button1_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button2_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button3_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button4_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button5_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button6_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button7_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button8_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button9_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button10_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button11_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button12_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button13_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button14_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button15_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
        private void button16_Click(object sender, EventArgs e) { HandleButtonClick(sender); }
    }
}
