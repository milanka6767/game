using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace меню
{
    public partial class угадай_число : Form
    {
        Random rnd = new Random();
        int secretNumber;
        int attempts;

        public угадай_число()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            secretNumber = rnd.Next(1, 101);
            attempts = 0;
            IbIHint.Text = "Подсказка:";
            IbIAttempts.Text = "Попытки: 0";
            IbIWin.Visible = false;
            txtInput.Clear();
            txtInput.Enabled = true;
            btnGuess.Enabled = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int userNumber;
            if (!int.TryParse(txtInput.Text, out userNumber))
            {
                MessageBox.Show("Введите целое число!");
                return;
            }

            attempts++;
            IbIAttempts.Text = "Попытки: " + attempts;

            if (userNumber == secretNumber)
            {
                IbIWin.Visible = true;
                IbIHint.Text = "";
                btnGuess.Enabled = false;
            }
            else if (userNumber > secretNumber)
            {
                IbIHint.Text = "Подсказка: число меньше!";
            }
            else
            {
                IbIHint.Text = "Подсказка: число больше!";
            }
            txtInput.Clear();
            txtInput.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
