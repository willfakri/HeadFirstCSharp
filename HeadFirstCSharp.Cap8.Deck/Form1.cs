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
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Card.Suits)_random.Next(0, 3), (Card.Values)_random.Next(1, 13)));
            }
            
            txtCardsUnsorted.Text = WriteResult(cards);

            CardComparer cardComparer = new CardComparer();
            cards.Sort(cardComparer);
            txtCardsSorted.Text = WriteResult(cards);
        }

        private string WriteResult(List<Card> cards)
        {
            string result = "";
            foreach (var item in cards)
            {
                result += "\r\n" + item.Name;
            }
            return result;
        }
    }
}
