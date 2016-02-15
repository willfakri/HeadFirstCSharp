using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstCSharp.Cap8.Deck
{
    public partial class FormTwoDecks : Form
    {
        private Business.Deck _deck1;
        private Business.Deck _deck2;

        public FormTwoDecks()
        {
            InitializeComponent();
            
            InitializeDecks();
        }

        private void InitializeDecks()
        {
            _deck1 = new Business.Deck(10);
            _deck2 = new Business.Deck();

            LoadLeft();
            LoadRight();
        }        

        private void brnReset_Click(object sender, EventArgs e)
        {
            InitializeDecks();
        }

        private void btnDeck1Shuffle_Click(object sender, EventArgs e)
        {
            _deck1.Shuffle();
            LoadLeft();
        }

        private void btnDeck2Shuffle_Click(object sender, EventArgs e)
        {
            _deck2.Shuffle();
            LoadRight();
        }

        private void btnDeck1Organize_Click(object sender, EventArgs e)
        {
            _deck1.Sort();
            LoadLeft();
        }

        private void LoadLeft()
        {
            lbDeck1.Items.Clear();
            foreach (var item in _deck1.Cards)
            {
                lbDeck1.Items.Add(item.Name);
            }
            lblDeck1.Text = $"Barai 1: {_deck1.Cards.Count} cartas";
        }

        private void LoadRight()
        {
            lbDeck2.Items.Clear();
            foreach (var item in _deck2.Cards)
            {
                lbDeck2.Items.Add(item.Name);
            }
            lblDeck2.Text = $"Barai 2: {_deck2.Cards.Count} cartas";
        }

        private void btnDeck2Organize_Click(object sender, EventArgs e)
        {
            _deck2.Sort();
            LoadRight();
        }

        private void btnDeck1ToDeck2_Click(object sender, EventArgs e)
        {
            if (lbDeck1.SelectedIndex >= 0)
            {
                _deck2.Cards.Add(_deck1.Deal(lbDeck1.SelectedIndex));
                LoadAll();
            }
        }

        private void LoadAll()
        {
            LoadLeft();
            LoadRight();
        }

        private void btnDeck2ToDeck1_Click(object sender, EventArgs e)
        {
            if (lbDeck2.SelectedIndex >= 0)
            {
                _deck1.Cards.Add(_deck2.Deal(lbDeck2.SelectedIndex));
                LoadAll();
            }            
        }
    }
}