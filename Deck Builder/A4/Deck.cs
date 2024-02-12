// Name: Manu Sugunakumar
// Date: November 27, 2023
// Class Name: Deck
// Desc: Manages a collection of cards and intializes a deck of 52
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace A4
{
    internal class Deck
    {
        // Class Variables
        protected List<Card> deck = new List<Card>();
        protected string[] suits = { "♥", "♦", "♣", "♠" };
        protected string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        public Deck()
        {

        }

        // Deals a card from the deck
        public List<Card> Deal(int numOfCards)
        {
            List<Card> cards = new List<Card>();

            if(deck.Count > numOfCards ) 
            { 
                // Sends the number of cards to the cards list
                cards = deck.Take(numOfCards).ToList();

                // removes the given cards from the deck
                deck.RemoveRange(0, numOfCards);
            }
            else
            {
                // Error if you can't deal any cards
                MessageBox.Show("The number of cards you selected cannont be given due to the lack of cards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Returns the cards
            return cards;
        }

        // Shuffles the deck of cards
        public void Shuffle()
        {
            // Start an instance for random
            Random random = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                // Makes a random card between 0 and i and I is the number of cards in the deck
                int randomCard = random.Next(0, i + 1);

                // Swap the two cards
                Card tempCard = deck[i];
                deck[i] = deck[randomCard];
                deck[randomCard] = tempCard;
            }
        }

        // Method to send the deck to the listview
        public void ToListView(ListView listView)
        {
            foreach (var card in deck)
            {
                listView.Items.Add(card.ToListViewItem());
            }
        }
    }

    // Name: Manu Sugunakumar
    // Date: November 27, 2023
    // Class Name: StandardDeck
    // Desc: Inherits from the deck class and intiates a standard deck of 52 cards
    internal class StandardDeck : Deck
    {
        public StandardDeck()
        { 
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Card a = new Card(suit, rank);
                    deck.Add(a);
                }
            }
        }
    }

    // Name: Manu Sugunakumar
    // Date: November 27, 2023
    // Class Name: CustomDeck
    // Desc: Inherits from the deck class and creates a custom deck which allows new cards to be added to it
    internal class CustomDeck : Deck
    {
        // Constructor for the custom deck
        public CustomDeck()
        {
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Card a = new Card(suit, rank);
                    deck.Add(a);
                }
            }
        }

        // Method to add a new card to the custom deck
        public void Add(string newSuit, string newRank)
        {
            Card newCard = new Card(newSuit, newRank);
            deck.Add(newCard);
        }
    }
}
