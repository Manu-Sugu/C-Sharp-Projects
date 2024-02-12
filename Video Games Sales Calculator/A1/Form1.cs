using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Manu Sugunakumar
// Date: October 02, 2023
// App Name: Average Weekly Video Games Sales Calculator
// Description: This app will calculate the amount of sales inputted into the app.

namespace A1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Global Variables
        int countNumDays = 0;
        double total = 0;

        /**
         * This method will check for input validation and run a message box if theres an error
         */
        private Boolean Validation(String input)
        {
            // Variable to store the new input
            int newInput = 0;

            // Checking if the input is a whole number
            if(int.TryParse(input, out newInput)) 
            {
                // Checking if the input is greater then zero
                if(newInput > 0) 
                {
                    // Returns true if all conditions valid
                    return true;
                } else 
                {
                    // Displays error message clears the input and returns false if not valid
                    MessageBox.Show("The input must be a positive whole number. You entered " + newInput + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInput.Clear();
                    return false; 
                }
            } else 
            {
                // Displays error message clears the input and returns false if not valid
                MessageBox.Show("The input must be a whole number. You entered " + input + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Clear();
                return false; 
            }
        }

        /**
         * This method will control the Exit button allow for the user to exit the app
         */
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**
         * This method will control the reset button allow for the user to reset the app
         */
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Reset Global Variables
            total = 0;
            countNumDays = 0;
            // Clears the input boxes
            txtInput.Clear();
            txtInput.ReadOnly = false;
            // Reset the labels
            lblDayNum.Text = "Day 1";
            // Reset the input Display
            txtInputDisplay.Clear();
            // Reset the output box
            txtOutput.Text = "Average Video Game Sales: $0.00";
            // Re-enable the enter button
            BtnEnter.Enabled = true;
            // Set the cursor to the input box
            txtInput.Focus();
        }

        /**
         * This method will control the enter button allow for the user to enter numbers into the app.
         */
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // Variables
            double input = 0;
            double averageGameSales = 0;
            
            // Checking if theres a valid input
            if(Validation(txtInput.Text)) 
            {
                // setting the input to the display box
                txtInputDisplay.Text += (txtInput.Text + "\r\n");
                // Increase the number of days
                countNumDays++;
                // Setting the number of days label to a new day
                lblDayNum.Text = "Day " + (countNumDays + 1).ToString();
                // storing our new input into a double
                Double.TryParse(txtInput.Text, out input);
                // Adding to the total
                total += input;
                // Calculate the average
                averageGameSales = total / countNumDays;
                // Display the average
                txtOutput.Text = "Average Video Game Sales: $" + string.Format("{0:f}", averageGameSales);
                // Clear the input box and set the cursor to it
                txtInput.Clear();
                txtInput.Focus();
                // Checking if we have reached 7 days or not
                if(countNumDays > 6)
                {
                    // Preventing furthur input by disabling the input box and enter button
                    lblDayNum.Text = "Day 7";
                    txtInput.ReadOnly = true;
                    BtnEnter.Enabled = false;
                }
            }
        }
    }
}
