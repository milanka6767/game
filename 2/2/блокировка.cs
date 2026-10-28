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
    public partial class блокировка : Form
    {
        public блокировка()
        {
            InitializeComponent();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            txtInput.Enabled = false;
        }

        private void btnUnblock_Click(object sender, EventArgs e)
        {
            txtInput.Enabled = true;
        }
    }
}
