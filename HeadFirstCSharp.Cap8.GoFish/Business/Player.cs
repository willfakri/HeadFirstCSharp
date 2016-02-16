using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstCSharp.Cap8.GoFish.Business
{
    public class Player
    {
        private string _name;        
        private Random _random;
        private Deck _cards;
        private TextBox _textBoxOnForm;
        public string Name { get { return _name; } }

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            _name = name;
            _random = random;
            _textBoxOnForm = textBoxOnForm;
            _cards.InitializeRandomDeck(4);
            _textBoxOnForm.Text += $"{_name} entrou no jogo.\r\n";
        }

        public List<Card.Values> PullOutBooks()
        {
            List<Card.Values> Books = new List<Card.Values>();
            for (int i = 1; i <= 13; i++)
            {
                Card.Values value = (Card.Values)i;
                int howMany = 0;
                for (int card = 0; card < _cards.Count; card++)
                    if (_cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    Books.Add(value);
                    for (int card = _cards.Count - 1; card >= 0; card--)
                        _cards.Deal(card);
                }
            }
            return Books;
        }


        public int CardCount { get { return _cards.Count; } }

        public void TakeCard(Card card) { _cards.Cards.Add(card); }

        public string[] GetCardNames() { return _cards.GetCardNames(); }

        public Card Peek(int cardNumber) { return _cards.Peek(cardNumber); }

        public void SortHand() { _cards.SortByValue(); }
        
        public Card.Values GetRandomValue()
        {
            var indexCard = _random.Next(_cards.Cards.Count);
            return _cards.Cards[indexCard].Value;
        }

        public Deck DoYouHaveAny(Card.Values value)
        {
            Deck deckToReturn = _cards.PullOutValues(value);
            _textBoxOnForm.Text += $"{_name} tem {deckToReturn.Count} {value}.";
            return deckToReturn;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            AskForACard(players, myIndex, stock, (Card.Values)_random.Next(1, 13));
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Card.Values value)
        {
            foreach (var player in players)
            {
                player.DoYouHaveAny(value);
            }
        }
    }
}