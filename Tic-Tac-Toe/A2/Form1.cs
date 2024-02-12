// Name: Manu Sugunakumar
// Date: October 16, 2023
// App Name: Tic-Tac-Toe
// Desc: App that allows you to play tic tac toe
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Global stuff
        string[,] gameBoard = new string[3, 3]; 
        int buttonCount = 0;
        int playerWins1 = 0;
        int playerWins2 = 0;

        // Validates the game setup
        private Boolean Validation(string name1, string name2, string symbol1, string symbol2)
        {
            // Checks if the name is empty
            if(!name1.Equals(""))
            {
                if(!name2.Equals(""))
                {
                    // checks if the names are the same
                    if (!name1.Trim().Equals(name2.Trim()))
                    {
                        // checks if the symbols are set correctly
                        if (symbol1.Equals("x") || symbol1.Equals("o"))
                        {
                            if (symbol2.Equals("x") || symbol2.Equals("o"))
                            {
                                if (!symbol1.Equals(symbol2))
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Both players can not have the same symbol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("You must enter x or o for the second player's symbol. You entered " + symbol2 + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("You must enter x or o for the first player's symbol. You entered " + symbol1 + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Both players can not have the same name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("The name of the second player is blank. You must enter a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("The name of the first player is blank. You must enter a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Determines if there is a winner
        private Boolean Winnner(string buttonName, string symbol)
        {
            if (buttonName.Equals("TopLeft"))
            {
                // horizontal
                if (gameBoard[0, 0].Equals(symbol) && gameBoard[0, 1].Equals(symbol) && gameBoard[0, 2].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if(gameBoard[0, 0].Equals(symbol) && gameBoard[1, 0].Equals(symbol) && gameBoard[2, 0].Equals(symbol))
                {
                    return true;
                }
                // diagonal
                else if(gameBoard[0, 0].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[2, 2].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("TopMiddle"))
            {
                // horizontal
                if(gameBoard[0, 0].Equals(symbol) && gameBoard[0, 1].Equals(symbol) && gameBoard[0, 2].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if(gameBoard[0, 1].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[2, 1].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("TopRight"))
            {
                // horizontal
                if(gameBoard[0, 2].Equals(symbol) && gameBoard[0, 1].Equals(symbol) && gameBoard[0, 0].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if(gameBoard[0, 2].Equals(symbol) && gameBoard[1, 2].Equals(symbol) && gameBoard[2, 2].Equals(symbol))
                {
                    return true;
                }
                // diagonal
                else if(gameBoard[0, 2].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[2, 0].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("MiddleLeft"))
            {
                // horizontal
                if(gameBoard[1, 0].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[1, 2].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if(gameBoard[0, 0].Equals(symbol) && gameBoard[1, 0].Equals(symbol) && gameBoard[2, 0].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("Middle"))
            {
                // left diagonal
                if(gameBoard[0, 0].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[2, 2].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if(gameBoard[0, 1].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[2, 1].Equals(symbol))
                { 
                    return true; 
                }
                // right diagonal
                else if(gameBoard[0, 2].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[2, 0].Equals(symbol))
                {
                    return true;
                }
                // horizontal
                else if(gameBoard[1, 0].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[1, 2].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("MiddleRight"))
            {
                // horizontal
                if (gameBoard[1, 0].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[1, 2].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if (gameBoard[0, 2].Equals(symbol) && gameBoard[1, 2].Equals(symbol) && gameBoard[2, 2].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("BottomLeft"))
            {
                // horizontal
                if (gameBoard[2, 0].Equals(symbol) && gameBoard[2, 1].Equals(symbol) && gameBoard[2, 2].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if (gameBoard[2, 0].Equals(symbol) && gameBoard[1, 0].Equals(symbol) && gameBoard[0, 0].Equals(symbol))
                {
                    return true;
                }
                // diagonal
                else if (gameBoard[2, 0].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[0, 2].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("BottomMiddle"))
            {
                // horizontal
                if (gameBoard[2, 0].Equals(symbol) && gameBoard[2, 1].Equals(symbol) && gameBoard[2, 2].Equals(symbol))
                {
                    return true;
                }
                //vertical
                else if (gameBoard[2, 1].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[0, 1].Equals(symbol))
                {
                    return true;
                }
            }
            else if(buttonName.Equals("BottomRight"))
            {
                // horizontal
                if (gameBoard[2, 2].Equals(symbol) && gameBoard[2, 1].Equals(symbol) && gameBoard[2, 0].Equals(symbol))
                {
                    return true;
                }
                // vertical
                else if (gameBoard[2, 2].Equals(symbol) && gameBoard[1, 2].Equals(symbol) && gameBoard[0, 2].Equals(symbol))
                {
                    return true;
                }
                // diagonal
                else if (gameBoard[2, 2].Equals(symbol) && gameBoard[1, 1].Equals(symbol) && gameBoard[0, 0].Equals(symbol))
                {
                    return true;
                }
            }
            return false;
        }

        // enables the game board
        private void gameButtonEnable()
        {
            BtnTopLeft.Enabled = true;
            BtnTopMiddle.Enabled = true;
            BtnTopRight.Enabled = true;
            BtnMiddleLeft.Enabled = true;
            BtnMiddle.Enabled = true;
            BtnMiddleRight.Enabled = true;
            BtnBottomLeft.Enabled = true;
            BtnBottomMiddle.Enabled = true;
            BtnBottomRight.Enabled = true;
        }

        // disables the game board
        private void gameButtonDisable()
        {
            BtnTopLeft.Enabled = false;
            BtnTopMiddle.Enabled = false;
            BtnTopRight.Enabled = false;
            BtnMiddleLeft.Enabled = false;
            BtnMiddle.Enabled = false;
            BtnMiddleRight.Enabled = false;
            BtnBottomLeft.Enabled = false;
            BtnBottomMiddle.Enabled = false;
            BtnBottomRight.Enabled = false;
        }

        // Updates the game stats
        private void updateGameStats(string symbol)
        {
            // Update the game stats and sets the winner
            if (symbol.Equals(txtBoxSymbol1.Text))
            {
                playerWins1++;
                txtBoxGameStats.Text += txtBoxName1.Text + " has won!\r\n";
            }
            else
            {
                playerWins2++;
                txtBoxGameStats.Text += txtBoxName2.Text + " has won!\r\n";
            }

            // updates the player winner textbox
            if (playerWins1 > playerWins2)
            {
                txtBoxWinner.Text = txtBoxName1.Text;
            }
            else if (playerWins2 > playerWins1)
            {
                txtBoxWinner.Text = txtBoxName2.Text;
            }
            else
            {
                txtBoxWinner.Text = "Tie";
            }
        }

        // changes the turn
        private void turnChanger()
        {
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                txtBoxNextTurn.Text = txtBoxName2.Text;
            }
            else
            {
                txtBoxNextTurn.Text = txtBoxName1.Text;
            }
        }

        // Resets the app when the button reset is pressed
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Clears all the text boxes
            txtBoxName1.Clear();
            txtBoxName2.Clear();
            txtBoxSymbol1.Clear();
            txtBoxSymbol2.Clear();
            txtBoxGameStats.Clear();
            txtBoxNextTurn.Clear();
            txtBoxWinner.Clear();

            // Clears the gameboard
            BtnTopLeft.Text = "";
            BtnTopMiddle.Text = "";
            BtnTopRight.Text = "";
            BtnMiddleLeft.Text = "";
            BtnMiddle.Text = "";
            BtnMiddleRight.Text = "";
            BtnBottomLeft.Text = "";
            BtnBottomMiddle.Text = "";
            BtnBottomRight.Text = "";

            // Disables stuff
            BtnContinue.Enabled = false;
            gameButtonDisable();

            // Renable stuff
            txtBoxName1.Enabled = true;
            txtBoxName2.Enabled = true;
            txtBoxSymbol1.Enabled = true;
            txtBoxSymbol2.Enabled = true;
            BtnStart.Enabled = true;

            // Fill the game board array with empty strings resetting it
            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int column = 0; column < gameBoard.GetLength(1); column++)
                {
                    gameBoard[row, column] = "";
                }
            }

            // resets the button count
            buttonCount = 0;

            // resets the win counts
            playerWins1 = 0;
            playerWins2 = 0;
        }

        // starts the game
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // checks if there are valid inputs before starting the game
            if (Validation(txtBoxName1.Text, txtBoxName2.Text, txtBoxSymbol1.Text, txtBoxSymbol2.Text))
            {
                // disables the game setup
                txtBoxName1.Enabled = false;
                txtBoxName2.Enabled = false;
                txtBoxSymbol1.Enabled = false;
                txtBoxSymbol2.Enabled = false;
                BtnStart.Enabled = false;
                
                // enables the game board
                gameButtonEnable();

                // setting the next turn to the first player
                txtBoxNextTurn.Text = txtBoxName1.Text;

                // Fill the game board array with empty strings
                for (int row = 0; row < gameBoard.GetLength(0); row++)
                {
                    for (int column = 0; column < gameBoard.GetLength(1); column++)
                    {
                        gameBoard[row, column] = "";
                    }
                }
            }
        }


        private void BtnContinue_Click(object sender, EventArgs e)
        {
            // resets the button count
            buttonCount = 0;

            // Fill the game board array with empty strings resetting it
            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int column = 0; column < gameBoard.GetLength(1); column++)
                {
                    gameBoard[row, column] = "";
                }
            }
            // Clears the gameboard
            BtnTopLeft.Text = "";
            BtnTopMiddle.Text = "";
            BtnTopRight.Text = "";
            BtnMiddleLeft.Text = "";
            BtnMiddle.Text = "";
            BtnMiddleRight.Text = "";
            BtnBottomLeft.Text = "";
            BtnBottomMiddle.Text = "";
            BtnBottomRight.Text = "";

            // enabling the gameboard
            gameButtonEnable();

            // setting the next turn to the first player
            txtBoxNextTurn.Text = txtBoxName1.Text;
            
            // Disables the continue button
            BtnContinue.Enabled = false;
        }

        // Button for the top left of the game board
        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if(txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }
            
            // updating the symbol on the array gameboard and the display
            gameBoard[0, 0] = symbol;
            BtnTopLeft.Text = symbol;
            // updating the count
            buttonCount++;

            if(Winnner("TopLeft", symbol))
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);   
            }
            // tie
            else if(buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnTopLeft.Enabled = false;
                turnChanger();
            }
        }

        private void BtnTopMiddle_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[0, 1] = symbol;
            BtnTopMiddle.Text = symbol; 
            // updating the count
            buttonCount++;

            if (Winnner("TopMiddle", symbol)) 
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnTopMiddle.Enabled = false;
                turnChanger();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[0, 2] = symbol;
            BtnTopRight.Text = symbol; 
            // updating the count
            buttonCount++;

            if (Winnner("TopRight", symbol)) 
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnTopRight.Enabled = false;
                turnChanger();
            }
        }

        private void BtnMiddleLeft_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[1, 0] = symbol;
            BtnMiddleLeft.Text = symbol; 
            // updating the count
            buttonCount++;

            if (Winnner("MiddleLeft", symbol)) 
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnMiddleLeft.Enabled = false;
                turnChanger();
            }
        }

        private void BtnMiddle_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[1, 1] = symbol;
            BtnMiddle.Text = symbol; 
            // updating the count
            buttonCount++;

            if (Winnner("Middle", symbol)) 
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnMiddle.Enabled = false;
                turnChanger();
            }
        }

        private void BtnMiddleRight_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[1, 2] = symbol; //
            BtnMiddleRight.Text = symbol; // 
            // updating the count
            buttonCount++;

            if (Winnner("MiddleRight", symbol)) //
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnMiddleRight.Enabled = false; //
                turnChanger();
            }
        }

        private void BtnBottomLeft_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[2, 0] = symbol; 
            BtnBottomLeft.Text = symbol; 
            // updating the count
            buttonCount++;

            if (Winnner("BottomLeft", symbol)) 
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnBottomLeft.Enabled = false;
                turnChanger();
            }
        }

        private void BtnBottomMiddle_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[2, 1] = symbol; 
            BtnBottomMiddle.Text = symbol; 
            // updating the count
            buttonCount++;

            if (Winnner("BottomMiddle", symbol)) 
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnBottomMiddle.Enabled = false;
                turnChanger();
            }
        }

        private void BtnBottomRight_Click(object sender, EventArgs e)
        {
            // variables
            string symbol;
            // checking which player is on the current turn
            if (txtBoxNextTurn.Text.Equals(txtBoxName1.Text))
            {
                symbol = txtBoxSymbol1.Text;
            }
            else
            {
                symbol = txtBoxSymbol2.Text;
            }

            // updating the symbol on the array gameboard and the display
            gameBoard[2, 2] = symbol; 
            BtnBottomRight.Text = symbol; 
            // updating the count
            buttonCount++;

            if (Winnner("BottomRight", symbol)) 
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                updateGameStats(symbol);
            }
            // tie
            else if (buttonCount == 9)
            {
                // Turns off the game board
                gameButtonDisable();

                // clears the next turn box
                txtBoxNextTurn.Clear();

                // enables the continue button
                BtnContinue.Enabled = true;

                txtBoxGameStats.Text += "Tie game!\r\n";
            }
            else
            {
                // otherwise no winner yet disable the button
                BtnBottomRight.Enabled = false;
                turnChanger();
            }
        }
    }
}
