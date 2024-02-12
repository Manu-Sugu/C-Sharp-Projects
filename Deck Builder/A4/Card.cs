// Name: Manu Sugunakumar
// Date: November 27, 2023
// Class Name: Card
// Desc: Create Card objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4
{
    internal class Card
    {
        // Class Varaibles
        protected string suit;
        protected string rank;

        // Default Constructor
        public Card() 
        { 
            suit = string.Empty;
            rank = string.Empty;
        }

        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        // Overrides the to string method to display card information
        public override string ToString()
        {
            return rank + " of " + suit;
        }

        // To send the card into a listview
        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem(this.ToString());

            return item;
        }
    }
}
