using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap8.Deck.Business
{
    public class Deck
    {
        private List<Card> _cards;
        Random _random = new Random();
        public Deck()
        {
            InitializeFullDeck();
        }

        public Deck(int numberCards)
        {
            InitializeRandomDeck(numberCards);
        }

        public List<Card> Cards { get { return _cards; } }

        public int Count { get { return _cards.Count; } }

        public void InitializeFullDeck()
        {
            _cards = new List<Card>();
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Ace));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Ace));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Ace));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Ace));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Two));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Two));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Two));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Two));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Three));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Three));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Three));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Three));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Four));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Four));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Four));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Four));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Five));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Five));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Five));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Five));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Six));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Six));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Six));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Six));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Seven));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Seven));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Seven));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Seven));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Eight));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Eight));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Eight));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Eight));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Nine));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Nine));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Nine));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Nine));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Ten));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Ten));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Ten));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Ten));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Jack));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Jack));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Jack));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Jack));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.Queen));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.Queen));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.Queen));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.Queen));
            
            _cards.Add(new Card(Card.Suits.Spades, Card.Values.King));
            _cards.Add(new Card(Card.Suits.Clubs, Card.Values.King));
            _cards.Add(new Card(Card.Suits.Diamonds, Card.Values.King));
            _cards.Add(new Card(Card.Suits.Hearts, Card.Values.King));
        }

        public void InitializeRandomDeck(int numberCards)
        {            
            _cards = new List<Card>();
            for (int i = 0; i < numberCards; i++)
            {
                _cards.Add(new Card((Card.Suits)_random.Next(0, 3), (Card.Values)_random.Next(1, 13)));
            }
        }

        public Card Deal(int indexCard)
        {
            Card card = _cards[indexCard];
            _cards.RemoveAt(indexCard);
            return card;
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (Count > 0)
            {
                int cardToMove = _random.Next(Count);
                newCards.Add(_cards[cardToMove]);
                _cards.RemoveAt(cardToMove);
            }
            _cards.Clear();
            _cards.AddRange(newCards);
        }

        public void Sort()
        {
            CardComparer cardComparer = new CardComparer();
            _cards.Sort(cardComparer);
        }
    }
}