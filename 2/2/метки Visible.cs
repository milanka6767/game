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
    public partial class метки_Visible : Form
    {
        public метки_Visible()
        {
            InitializeComponent();
        }

        private void метки_Visible_Load(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbl2.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl3.Visible = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl4.Visible = true;
        }
    }
}
