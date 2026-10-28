using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2
{
    public partial class текст_на_кнопках : Form
    {
        public текст_на_кнопках()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = txtText.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = txtText.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = txtText.Text;
        }
    }
}
