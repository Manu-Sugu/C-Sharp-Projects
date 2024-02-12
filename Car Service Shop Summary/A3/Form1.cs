// Name: Manu Sugunakumar
// Date: November 13, 2023
// App Name: Car Service Summary
// Desc: App that stores entered car service summary into the list view
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    public partial class MainForm : Form
    {
        // Global Variables
        Decimal price = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        // Runs when the form loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate the list view upon load
            lvCarServiceSummary.Clear();
            lvCarServiceSummary.Columns.Add("NO", 30);
            lvCarServiceSummary.Columns.Add("FirstName", 60);
            lvCarServiceSummary.Columns.Add("LastName", 100);
            lvCarServiceSummary.Columns.Add("Phone", 75);
            lvCarServiceSummary.Columns.Add("Make", 50);
            lvCarServiceSummary.Columns.Add("Model", 50);
            lvCarServiceSummary.Columns.Add("Year", 40);
            lvCarServiceSummary.Columns.Add("Colour", 50);
            lvCarServiceSummary.Columns.Add("Engine Oil Change", 100);
            lvCarServiceSummary.Columns.Add("Transmission Oil Change", 128);
            lvCarServiceSummary.Columns.Add("Air Filter Change", 90);
            lvCarServiceSummary.Columns.Add("Date", 80);
            lvCarServiceSummary.Columns.Add("Price", 80);

            // Populate the dropdown boxes
            // make dropdown box
            cmbMake.Items.Clear();
            string[] carMake = {"Honda", "Toyota", "Ford", "Hyundai", "Dodge" };
            foreach(string cars in carMake)
            {
                cmbMake.Items.Add(cars);
            }

            // year dropdown box
            cmbYear.Items.Clear();
            for (int yearCount = 2005; yearCount < 2025; yearCount++)
            {
                cmbYear.Items.Add(yearCount);
            }

            // clears the items in the listview
            lvCarServiceSummary.Items.Clear();

            txtFirstName.Focus();

            // ignore this just me testing stuff but leaving incase I need it
            //Service service = new Service("John", "Smith", "123", "Toyota", "Corrolla", "Bronze", 2010, false, false, false, "20231113", 100);
            //Service service1 = new Service("Mark", "Smith", "321, "Toyota", "Corrolla", "Bronze", 2010, false, false, false, "20231113", 100);
            //string[] serviceSummary = service.GetServiceData().Split(',');
            // LoadCarServiceSummary(serviceSummary[0], serviceSummary[1], serviceSummary[2], serviceSummary[3], serviceSummary[4], serviceSummary[5], serviceSummary[6], serviceSummary[7], serviceSummary[8], serviceSummary[9], serviceSummary[10], serviceSummary[11], serviceSummary[12]);
            //serviceSummary = service1.GetServiceData().Split(',');
            // LoadCarServiceSummary(serviceSummary[0], serviceSummary[1], serviceSummary[2], serviceSummary[3], serviceSummary[4], serviceSummary[5], serviceSummary[6], serviceSummary[7], serviceSummary[8], serviceSummary[9], serviceSummary[10], serviceSummary[11], serviceSummary[12]);
            // LoadCarServiceSummary(1, "John", "Smith", "312", "Toyota", "Corrolla", "2010", "Bronze", false, false, false, "20231113");

        }

        // This function loads a row for a car service summary
        private void LoadCarServiceSummary(string NO, string firstName, string lastName, string phone, string make, string model, string colour, string year, string oilChange, string transmissionOilChange, string airFilterChange, string date, string price)
        {
            // Creates a list view object for the row
            ListViewItem lvItem = new ListViewItem(NO.ToString());
            // adds the items to the row
            lvItem.SubItems.Add(firstName);
            lvItem.SubItems.Add(lastName);
            lvItem.SubItems.Add(phone);
            lvItem.SubItems.Add(make);
            lvItem.SubItems.Add(model);
            lvItem.SubItems.Add(year);
            lvItem.SubItems.Add(colour);
            if(oilChange.Equals("True"))
            {
                lvItem.SubItems.Add("yes");
            }
            else
            {
                lvItem.SubItems.Add("no");
            }
            if (transmissionOilChange.Equals("True"))
            {
                lvItem.SubItems.Add("yes");
            }
            else
            {
                lvItem.SubItems.Add("no");
            }
            if (airFilterChange.Equals("True"))
            {
                lvItem.SubItems.Add("yes");
            }
            else
            {
                lvItem.SubItems.Add("no");
            }
            lvItem.SubItems.Add(date);
            lvItem.SubItems.Add(price);
            lvCarServiceSummary.Items.Add(lvItem);
        }

        // This function checks the validation for the textboxes to see if they are empty
        private Boolean emptyValidation(string valid)
        {
            if(valid.Trim().Equals(""))
            {
                MessageBox.Show("You left something blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // This controls the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // this controls the reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            // clears all the text boxes and drop down boxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cmbMake.Text = "";
            txtModel.Clear();
            cmbYear.Text = "";
            txtColour.Clear();
            cbEngineOil.Checked = false;
            cbTransmission.Checked = false;
            cbAirFiliter.Checked = false;
            txtCost.Text = "0.00 $";

            // Load the car service summary
            lvCarServiceSummary.Clear();
            lvCarServiceSummary.Columns.Add("NO", 30);
            lvCarServiceSummary.Columns.Add("FirstName", 60);
            lvCarServiceSummary.Columns.Add("LastName", 100);
            lvCarServiceSummary.Columns.Add("Phone", 75);
            lvCarServiceSummary.Columns.Add("Make", 50);
            lvCarServiceSummary.Columns.Add("Model", 50);
            lvCarServiceSummary.Columns.Add("Year", 40);
            lvCarServiceSummary.Columns.Add("Colour", 50);
            lvCarServiceSummary.Columns.Add("Engine Oil Change", 100);
            lvCarServiceSummary.Columns.Add("Transmission Oil Change", 128);
            lvCarServiceSummary.Columns.Add("Air Filter Change", 90);
            lvCarServiceSummary.Columns.Add("Date", 80);
            lvCarServiceSummary.Columns.Add("Price", 80);

            // Populate the dropdown boxes
            // make dropdown box
            cmbMake.Items.Clear();
            string[] carMake = { "Honda", "Toyota", "Ford", "Hyundai", "Dodge" };
            foreach (string cars in carMake)
            {
                cmbMake.Items.Add(cars);
            }

            // year dropdown box
            cmbYear.Items.Clear();
            for (int yearCount = 2000; yearCount < 2025; yearCount++)
            {
                cmbYear.Items.Add(yearCount);
            }

            // Clears Global Stuff
            price = 0;

            // sets focus
            txtFirstName.Focus();
        }

        // this controls the add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Variables
            string date;
            Boolean valid = true;
            // array for textboxes
            TextBox[] tbArray= { txtFirstName, txtLastName, txtModel, txtColour };
            // checking if textboxes are empty
            foreach(TextBox tb in tbArray) 
            {
                if(!emptyValidation(tb.Text))
                {
                    valid = false;
                    break;
                }
            }

            // array for combo boxes
            ComboBox[] cmbArray = { cmbMake, cmbYear};
            // checking if the combo boxes are empty
            if(valid)
            {
                foreach (ComboBox cb in cmbArray)
                {
                    if (!emptyValidation(cb.Text))
                    {
                        valid = false;
                        break;
                    }
                }
            }

            // validation for phone number
            if(valid)
            {
                if(!double.TryParse(txtPhone.Text, out double phone)) 
                {
                    valid = false;
                    MessageBox.Show("This is not a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // validation for year
            if (!int.TryParse(cmbYear.Text, out int year) && valid)
            {
                MessageBox.Show("This is not a valid year!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            // get the selected date
            DateTime selectedDate = calender.SelectionStart;
            date = selectedDate.ToShortDateString();

            // run only if valid
            if (valid) 
            {
                // make a new srvice summary object
                Service service = new Service(txtFirstName.Text, txtLastName.Text, txtPhone.Text, cmbMake.Text, txtModel.Text, txtColour.Text, year, cbEngineOil.Checked, cbTransmission.Checked, cbAirFiliter.Checked, date, price);
                // splits the data into an array
                string[] serviceSummary = service.GetServiceData().Split(',');
                // loads the array into the function to load into the listview
                LoadCarServiceSummary(serviceSummary[0], serviceSummary[1], serviceSummary[2], serviceSummary[3], serviceSummary[4], serviceSummary[5], serviceSummary[6], serviceSummary[7], serviceSummary[8], serviceSummary[9], serviceSummary[10], serviceSummary[11], serviceSummary[12]);
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                cmbMake.Text = "";
                txtModel.Clear();
                cmbYear.Text = "";
                txtColour.Clear();
                cbEngineOil.Checked = false;
                cbTransmission.Checked = false;
                cbAirFiliter.Checked = false;

                // sets focus
                txtFirstName.Focus();
            }
        }

        // These three functions controls the check boxes for the 3 services
        private void cbEngineOil_CheckedChanged(object sender, EventArgs e)
        {
            // Adds a price to the price when selected
            if (cbEngineOil.Checked)
            {
                price += 60;
            }
            else
            { 
                price -= 60; 
            }
            // updates the cost textbox
            txtCost.Text = price.ToString() + " $";
        }

        private void cbTransmission_CheckedChanged(object sender, EventArgs e)
        {
            // adds a price to the price when selected
            if (cbTransmission.Checked)
            {
                price += 120;
            }
            else
            {
                price -= 120;
            }
            // updates the cost textbox
            txtCost.Text = price.ToString() + " $";
        }

        private void cbAirFiliter_CheckedChanged(object sender, EventArgs e)
        {
            // adds a price to the price when selected
            if (cbAirFiliter.Checked)
            {
                price += 40.50M;
            }
            else
            {
                price -= 40.5M;
            }
            // updates the cost textbox
            txtCost.Text = price.ToString() + " $";
        }

        // this function controls the update function
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Checks if anything is selected
            if (lvCarServiceSummary.SelectedItems.Count > 0)
            {
                // Variables
                string date;
                Boolean valid = true;

                // array for textboxes
                TextBox[] tbArray = { txtFirstName, txtLastName, txtModel, txtColour };
                // checking if textboxes are empty
                foreach (TextBox tb in tbArray)
                {
                    if (!emptyValidation(tb.Text))
                    {
                        valid = false;
                        break;
                    }
                }

                // array for combo boxes
                ComboBox[] cmbArray = { cmbMake, cmbYear };
                // checking if the combo boxes are empty
                if (valid)
                {
                    foreach (ComboBox cb in cmbArray)
                    {
                        if (!emptyValidation(cb.Text))
                        {
                            valid = false;
                            break;
                        }
                    }
                }

                // validation for phone number
                if (valid)
                {
                    if (!double.TryParse(txtPhone.Text, out double phone))
                    {
                        valid = false;
                        MessageBox.Show("This is not a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // validation for year
                if (!int.TryParse(cmbYear.Text, out int year) && valid)
                {
                    MessageBox.Show("This is not a valid year!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }

                // get the selected date
                DateTime selectedDate = calender.SelectionStart;
                date = selectedDate.ToShortDateString();

                // run only if valid
                if (valid)
                {
                    // Creates an update object for the service summary
                    Service serviceUpdate = new Service(int.Parse(lvCarServiceSummary.SelectedItems[0].SubItems[0].Text) ,txtFirstName.Text, txtLastName.Text, txtPhone.Text, cmbMake.Text, txtModel.Text, txtColour.Text, year, cbEngineOil.Checked, cbTransmission.Checked, cbAirFiliter.Checked, date, price);
                    // removes the selected item
                    lvCarServiceSummary.Items.Remove(lvCarServiceSummary.SelectedItems[0]);
                    // splits the data into an array of data
                    string[] serviceSummary = serviceUpdate.GetServiceData().Split(',');
                    // loads that array of data
                    LoadCarServiceSummary(serviceSummary[0], serviceSummary[1], serviceSummary[2], serviceSummary[3], serviceSummary[4], serviceSummary[5], serviceSummary[6], serviceSummary[7], serviceSummary[8], serviceSummary[9], serviceSummary[10], serviceSummary[11], serviceSummary[12]);
                    // clears all the textboxes and checkboxes
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    cmbMake.Text = "";
                    txtModel.Clear();
                    cmbYear.Text = "";
                    txtColour.Clear();
                    cbEngineOil.Checked = false;
                    cbTransmission.Checked = false;
                    cbAirFiliter.Checked = false;

                    // sets focus
                    txtFirstName.Focus();
                }
            }
        }

        // this function controls the remove button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Checks if anything is selected
            if (lvCarServiceSummary.SelectedItems.Count > 0)
            {
                // removes the selected item
                lvCarServiceSummary.Items.Remove(lvCarServiceSummary.SelectedItems[0]);
                
                // sets focus
                txtFirstName.Focus();
            }
            else
            {
                // Shows warning if nothing is selected
                MessageBox.Show("Please select an item from the list!", "Nothing Selection!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // this function controls the remove all function
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            // Clears the data in the listview
            lvCarServiceSummary.Items.Clear();

            // sets focus
            txtFirstName.Focus();
        }

        // this function checks for which item was selected
        private void lvCarServiceSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks if there is an item selected
            if (lvCarServiceSummary.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lvCarServiceSummary.SelectedItems[0];

                // Populate the textboxes and combo boxes with the data from the selected item
                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtLastName.Text = selectedItem.SubItems[2].Text;
                txtPhone.Text = selectedItem.SubItems[3].Text;
                cmbMake.Text = selectedItem.SubItems[4].Text;
                txtModel.Text = selectedItem.SubItems[5].Text;
                cmbYear.Text = selectedItem.SubItems[6].Text;
                txtColour.Text = selectedItem.SubItems[7].Text;

                // Checks the checkboxes based on what was selected
                cbEngineOil.Checked = selectedItem.SubItems[8].Text.Equals("yes");
                cbTransmission.Checked = selectedItem.SubItems[9].Text.Equals("yes");
                cbAirFiliter.Checked = selectedItem.SubItems[10].Text.Equals("yes");
            }
            // otherwise if there is nothing selected clear the textboxes
            else
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                cmbMake.Text = "";
                txtModel.Clear();
                cmbYear.Text = "";
                txtColour.Clear();
                cbEngineOil.Checked = false;
                cbTransmission.Checked = false;
                cbAirFiliter.Checked = false;
            }
        }
    }
}
