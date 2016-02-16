using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstCSharp.Cap8.GoFish
{
    public partial class Form1 : Form
    {
        private Game _game;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Põe seu nome ae", "Não tem como começar desse jeito.");
                return;
            }
            _game = new Game(txtName.Text, new string[] { "Joe", "Bob" }, txtProgress);
            btnStart.Enabled = false;
            txtName.Enabled = false;
            btnAskCard.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lbHand.Items.Clear();
            foreach (string cardName in _game.GetPlayerCardNames())
                lbHand.Items.Add(cardName);
            txtBooks.Text = _game.DescribeBooks();
            txtProgress.Text += _game.DescribePlayerHands();
            txtProgress.SelectionStart = txtProgress.Text.Length;
            txtProgress.ScrollToCaret();
        }

        private void btnAskCard_Click(object sender, EventArgs e)
        {
            txtProgress.Text = "";
            if (lbHand.SelectedIndex < 0)
            {
                MessageBox.Show("Seleciona uma carta jumento.");
                return;
            }
            if (_game.PlayOneRound(lbHand.SelectedIndex))
            {
                txtProgress.Text += "O cápião é... " + _game.GetWinnerName();
                txtBooks.Text = _game.DescribeBooks();
                btnAskCard.Enabled = false;
            }
            else
                UpdateForm();
        }
    }
}
