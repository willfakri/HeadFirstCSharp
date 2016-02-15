using HeadFirstCSharp.Cap8.Deck.Business;
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
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private Card _card;
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            _card = new Card((Card.Suits)_random.Next(0, 3), (Card.Values)_random.Next(1, 13));
            txtCard.Text = _card.Name;
        }
    }
}
