using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using меню;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            угадай_число f = new угадай_число();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            случайный_цвет f = new случайный_цвет();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            messageBox f = new messageBox();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            текст_на_кнопках f = new текст_на_кнопках();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            метки_Visible f = new метки_Visible();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            блокировка f = new блокировка();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            заметки f = new заметки();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            калькулятор f = new калькулятор();
            f.Show();
        }
    }
}
