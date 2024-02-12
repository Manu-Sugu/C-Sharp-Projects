// Name: Manu Sugunakumar
// Date: November 27, 2023
// App Name: Deck Builder
// Desc: Create, Display, Deal cards from a deck
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A4
{
    public partial class MainForm : Form
    {
        // Deck
        StandardDeck standardDeck = new StandardDeck();
        CustomDeck customDeck = new CustomDeck();

        // Global Validation Variable
        bool isCustomDeck = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This method controls the reset button on the app
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Reset the decks
            standardDeck = new StandardDeck();
            customDeck = new CustomDeck();

            // Clear textboxes
            txtDraw.Text = string.Empty;
            txtRank.Text = string.Empty;
            txtSuit.Text = string.Empty;

            // disable stuff
            BtnShuffle.Enabled = false;
            GBCard.Enabled = false;
            GBDeal.Enabled = false;

            // Reset Button
            BtnViewDeck.Text = "&View Deck";

            // Set focus
            txtSuit.Focus();

            // Clear the listview
            lvDeck.Items.Clear();
            lvCardsDealt.Items.Clear();
        }

        // This method allows the listview to be populated
        private void LoadDeck()
        {
            // Checking if the current deck at play is standard or custom
            if(isCustomDeck == false)
            {
                lvDeck.Items.Clear();
                standardDeck.ToListView(lvDeck);
            }
            else
            {
                lvDeck.Items.Clear();
                customDeck.ToListView(lvDeck);
            }
        }

        // This method controls the view deck/hide deck button
        private void BtnViewDeck_Click(object sender, EventArgs e)
        {
            // This controls wether the button is view deck or hide deck
            if(BtnViewDeck.Text.Equals("&View Deck"))
            {
                LoadDeck();
                BtnShuffle.Enabled = true;
                GBCard.Enabled = true;
                GBDeal.Enabled = true;
                BtnViewDeck.Text = "&Hide Deck";
            }
            else
            {
                BtnShuffle.Enabled = false;
                GBCard.Enabled = false;
                GBDeal.Enabled = false;
                lvDeck.Items.Clear();
                BtnViewDeck.Text = "&View Deck";
            }
        }

        // This method validates wether theres a card input in the textbox
        private Boolean CardValidation(string suit, string rank)
        {
            if(suit.Trim().Equals(""))
            {
                MessageBox.Show("You left suit blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(rank.Trim().Equals(""))
            {
                MessageBox.Show("You left rank blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // This method controls the add custom card button
        private void BtnAddCustom_Click(object sender, EventArgs e)
        {
            // Stores the user values into variables
            string suit = txtSuit.Text;
            string rank = txtRank.Text;

            // check for valid inputs
            if (CardValidation(suit, rank))
            {
                // Add the new card
                customDeck.Add(suit,rank);
                customDeck.ToListView(lvDeck);
                // change the deck at play to custom deck
                isCustomDeck = true;
                // loads new deck
                LoadDeck();
                // Resets the textboxes
                txtRank.Text = string.Empty;
                txtSuit.Text = string.Empty;
            }
        }

        // This method controls the deal button
        private void BtnDeal_Click(object sender, EventArgs e)
        {
            // checking if the inputed value is an integar
            if (int.TryParse(txtDraw.Text, out int draw))
            {
                // creating new list of temp cards
                List<Card> newCards;
                // determine if the custom or standard deck is at play then deals the cards
                if(isCustomDeck == true)
                {
                    newCards = customDeck.Deal(draw);
                }
                else
                {
                    newCards = standardDeck.Deal(draw);
                }

                // clears the old list 
                lvCardsDealt.Items.Clear();

                // Sets the new list using the new card deck
                foreach (var card in newCards)
                {
                    lvCardsDealt.Items.Add(card.ToString());
                }
                // reloads the list
                LoadDeck();
                // resets the textbox
                txtDraw.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("You must enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method controls the shuffle button
        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            // determines which deck is at play then calls the shuffle method
            if(isCustomDeck == false) 
            { 
                standardDeck.Shuffle();
                LoadDeck();
            }
            else
            {
                customDeck.Shuffle();
                LoadDeck();
            }
        }
    }
}
