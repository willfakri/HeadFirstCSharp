using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap8.Deck.Business
{
    public class Card
    {
        /// <summary>
        /// Naipe
        /// </summary>
        public string Suit { get; set; }

        public string Value { get; set; }

        public string Name
        {
            get
            {
                return $"{Value} de {Suit}";
            }
        }

        /// <summary>
        /// Naipes
        /// </summary>
        public enum Suits
        {
            /// <summary>
            /// Espadas
            /// </summary>
            Spades = 0,
            /// <summary>
            /// Paus
            /// </summary>
            Clubs = 1,
            /// <summary>
            /// Ouros
            /// </summary>
            Diamonds = 2,
            /// <summary>
            /// Copas
            /// </summary>
            Hearts = 3
        }

        public enum Values
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }
    }
}