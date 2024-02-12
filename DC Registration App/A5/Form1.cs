// Name: Manu Sugunakumar
// Date: December 4, 2023
// App Name: DC Registration App
// Desc: App that allows you to register students.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5
{
    public partial class MainForm : Form
    {
        // Global Variables
        List<string> sinNumber = new List<string>();
        List<Student> students = new List<Student>();

        // Create the campuses
        List<Campus> campuses = new List<Campus>
        {
            new Campus("Ontario", 85, 90, 5000),
            new Campus("Quebec", 80, 85, 4800),
            new Campus("Nova Scotia", 78, 88, 5200),
            new Campus("New Brunswick", 82, 92, 5500),
            new Campus("Manitoba", 86, 95, 4900),
            new Campus("British Columbia", 88, 91, 5300),
            new Campus("Prince Edward Island", 80, 87, 5100),
            new Campus("Saskatchewan", 85, 89, 5050),
            new Campus("Alberta", 87, 93, 5400),
            new Campus("Newfoundland and Labrador", 83, 94, 5250)
        };

        public MainForm()
        {
            InitializeComponent();
        }

        /**
         * This method controls what loads when the form loads up
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Setup the combo boxes for highschool grade and testscores
            for (int i = 10; i < 100; i += 10)
            {
                cmbHighSchoolGrade.Items.Add(i);
                cmbTestScore.Items.Add(i);
            }
            // Setup the location combo box
            for (int i = 0; i < campuses.Count; i++)
            {
                cmbCampusLocation.Items.Add(campuses[i].CampusName);
            }

            // Populate the datagridview
            // Create the columns
            DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn();
            firstNameColumn.HeaderText = "First Name";
            firstNameColumn.Name = "FirstName";

            DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn.HeaderText = "Last Name";
            lastNameColumn.Name = "LastName";

            DataGridViewTextBoxColumn sinNumColumn = new DataGridViewTextBoxColumn();
            sinNumColumn.HeaderText = "SIN";
            sinNumColumn.Name = "SinNum";

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.Name = "email";

            DataGridViewTextBoxColumn highSchoolGradeColumn = new DataGridViewTextBoxColumn();
            highSchoolGradeColumn.HeaderText = "High School Grade";
            highSchoolGradeColumn.Name = "highSchoolGrade";

            DataGridViewTextBoxColumn admissionTestScoresColumn = new DataGridViewTextBoxColumn();
            admissionTestScoresColumn.HeaderText = "Admission Test Scores";
            admissionTestScoresColumn.Name = "admissionTestScore";

            DataGridViewTextBoxColumn campusLocationColumn = new DataGridViewTextBoxColumn();
            campusLocationColumn.HeaderText = "Campus Location";
            campusLocationColumn.Name = "campusLocation";

            DataGridViewTextBoxColumn programColumn = new DataGridViewTextBoxColumn();
            programColumn.HeaderText = "Program";
            programColumn.Name = "program";

            // Add the columns to the datagridview
            DGStudentInformation.Columns.AddRange(firstNameColumn, lastNameColumn, sinNumColumn, emailColumn, highSchoolGradeColumn, admissionTestScoresColumn, campusLocationColumn, programColumn);
            
            // Sets the datagridview to read only
            DGStudentInformation.ReadOnly = true;
        }

        // This method updates the program combo box whenever a campus is selected
        private void cmbCampusLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the items in programs combob box
            cmbPrograms.Items.Clear();

            // Get the name of the selected campus
            string selectedCampusName = cmbCampusLocation.SelectedItem.ToString();

            // Goes through all the campuses and finds the campus that was selected
            for (int i = 0; i < campuses.Count; i++)
            {
                if (selectedCampusName.Equals(campuses[i].CampusName))
                {
                    // Loops through all the programs for that campus and adds to the combo box
                    foreach (CampusProgram program in campuses[i].Programs)
                    {
                        cmbPrograms.Items.Add(program.ProgramName);
                    }
                }
            }

            // Change the comobo box for program from enabled to disabled depending on if its empty or not
            if(cmbPrograms.Items != null)
            {
                cmbPrograms.Enabled = true;
            }
        }
        private void cmbPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Variables
            int totalFees = 0;

            // Get the name of the selected program
            string selectedProgram = cmbPrograms.SelectedItem.ToString();

            // Get the name of the selected campus
            string selectedCampusName = cmbCampusLocation.SelectedItem.ToString();

            for (int i = 0; i < campuses.Count; i++)
            {
                if (selectedCampusName.Equals(campuses[i].CampusName))
                {
                    // Loops through all the programs for that campus and adds to the combo box
                    foreach (CampusProgram program in campuses[i].Programs)
                    {
                        lblStudyPeriodNum.Text = program.ProgramDuration.ToString();
                        totalFees += campuses[i].RegFees + program.ProgramFees;
                        lblTotalCostNum.Text = $"${totalFees}";
                    }
                }
            }
        }

        // Resets the app without clearing the list
        private void reset()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSinNum.Text = string.Empty;
            cmbHighSchoolGrade.Text = string.Empty;
            cmbTestScore.Text = string.Empty;

            cmbCampusLocation.Text = string.Empty;
            cmbPrograms.Items.Clear();

            cmbSinNum.Text = string.Empty;

            lblStudyPeriodNum.Text = "0";
            lblTotalCostNum.Text = "0.0$";

            GBAvailiblePrograms.Enabled = false;
            BtnRegister.Enabled = true;
            BtnCheck.Enabled = true;
            GBStudentInformation.Enabled = true;
        }

        // This method controls the button exit
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This method controls the read help button in the menu strip
        private void readHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the form
            ReadHelpForm readHelpForm = new ReadHelpForm();

            // Call the form as a dialog box so the user must close it before going back to the original form
            readHelpForm.ShowDialog();
        }

        // This method controls the technical support button in the menu 
        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the form
            TechnicalSupportForm technicalSupportForm = new TechnicalSupportForm();

            // Call the form as a dialog box so the user must close it before going back to the original form
            technicalSupportForm.ShowDialog();
        }

        // This method controls the about dc form support button in the menu 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the form
            AboutDCForm aboutDCForm = new AboutDCForm();

            // Call the form as a dialog box so the user must close it before going back to the original form
            aboutDCForm.ShowDialog();
        }

        // This method checks if the inputted string is blank
        private bool EmptyValidation(string valid)
        {
            if (valid.Trim().Equals(""))
            {
                MessageBox.Show("You left something blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // This method checks if the input is numeric
        private bool isNumeric(string input)
        {
            // Checks if the inputted string is a number then returns true or false
            return int.TryParse(input, out int a);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // Variables
            bool valid = true;
            string thisSinNum = txtSinNum.Text.Trim();
            // checking each text box is empty
            TextBox[] txtBoxList = { txtFirstName, txtLastName, txtSinNum, txtEmail };
            foreach (TextBox txtBox in txtBoxList) 
            { 
                if(!EmptyValidation(txtBox.Text))
                {
                    valid = false;
                    break;
                }
            }

            // Checking if the comboboxes are empty
            ComboBox[] cmbList = { cmbHighSchoolGrade, cmbTestScore };
            foreach (ComboBox cmb in cmbList)
            {
                if (!EmptyValidation(cmb.Text)) 
                {
                    valid = false;
                    break;
                }
            }

            // Checking if the inputs for the combo boxes are numeric and within range
            if(!isNumeric(cmbHighSchoolGrade.Text)) 
            { 
                MessageBox.Show("High School Grade is not a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if(int.Parse(cmbHighSchoolGrade.Text) < 0 || int.Parse(cmbHighSchoolGrade.Text) > 100)
            {
                MessageBox.Show("High School Grade is not within range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (!isNumeric(cmbTestScore.Text))
            {
                MessageBox.Show("Admission Test Score is not a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else if (int.Parse(cmbTestScore.Text) < 0 || int.Parse(cmbTestScore.Text) > 100)
            {
                MessageBox.Show("Admission Test Score is not within range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            // Checking if the sin number is unique
            // checks if the sin number is a numeric int
            if (isNumeric(thisSinNum) && thisSinNum.Length == 9) 
            { 
                for (int i = 0; i < sinNumber.Count; i++) 
                {
                    if (!thisSinNum.Equals(sinNumber[i]))
                    {
                        valid = false;
                        MessageBox.Show("This sin number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("This sin number is not a valid sin number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (valid) 
            {
                foreach (Campus campus in campuses)
                {
                    if (int.Parse(cmbHighSchoolGrade.Text) >= campus.HSGradeReq && int.Parse(cmbTestScore.Text)>= campus.AdmissionTSReq)
                    {
                        // Disable the ability to input a new student so they can't change that information
                        GBStudentInformation.Enabled = false;
                        BtnCheck.Enabled = false;
                        // enable the availible program section
                        GBAvailiblePrograms.Enabled = true;
                        BtnRegister.Enabled = true;
                        valid = true;
                        break;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                if(!valid)
                {
                    MessageBox.Show("This student does not meet the requirment of any campus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (TextBox txtBox in txtBoxList)
                    {
                        txtBox.Text = string.Empty;
                    }
                    foreach (ComboBox cmb in  cmbList)
                    {
                        cmb.Text = string.Empty;
                    }
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            students.Add(new Student(txtFirstName.Text, txtLastName.Text, int.Parse(txtSinNum.Text), txtEmail.Text, int.Parse(cmbHighSchoolGrade.Text), int.Parse(cmbTestScore.Text), cmbCampusLocation.Text, cmbPrograms.Text));
            sinNumber.Add(txtSinNum.Text);
            cmbSinNum.Items.Add(txtSinNum.Text);
            GBAvailiblePrograms.Enabled = false;
            DGStudentInformation.Rows.Add(txtFirstName.Text, txtLastName.Text, int.Parse(txtSinNum.Text), txtEmail.Text, int.Parse(cmbHighSchoolGrade.Text), int.Parse(cmbTestScore.Text), cmbCampusLocation.Text, cmbPrograms.Text);
            reset();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            DGStudentInformation.Rows.Clear();
            reset();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
