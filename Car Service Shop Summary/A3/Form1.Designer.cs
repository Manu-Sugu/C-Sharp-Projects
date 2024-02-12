namespace A3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbCarInformation = new System.Windows.Forms.GroupBox();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cbAirFiliter = new System.Windows.Forms.CheckBox();
            this.cbTransmission = new System.Windows.Forms.CheckBox();
            this.cbEngineOil = new System.Windows.Forms.CheckBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.gbCarServiceSummary = new System.Windows.Forms.GroupBox();
            this.lvCarServiceSummary = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbCustomerInformation.SuspendLayout();
            this.gbCarInformation.SuspendLayout();
            this.gbCarServiceSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerInformation
            // 
            this.gbCustomerInformation.Controls.Add(this.txtPhone);
            this.gbCustomerInformation.Controls.Add(this.txtLastName);
            this.gbCustomerInformation.Controls.Add(this.txtFirstName);
            this.gbCustomerInformation.Controls.Add(this.lblPhone);
            this.gbCustomerInformation.Controls.Add(this.lblLastName);
            this.gbCustomerInformation.Controls.Add(this.lblFirstName);
            this.gbCustomerInformation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerInformation.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerInformation.Name = "gbCustomerInformation";
            this.gbCustomerInformation.Size = new System.Drawing.Size(316, 142);
            this.gbCustomerInformation.TabIndex = 0;
            this.gbCustomerInformation.TabStop = false;
            this.gbCustomerInformation.Text = "Customer Information";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(91, 88);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 26);
            this.txtPhone.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtPhone, "Enter a phone number");
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(91, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 26);
            this.txtLastName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtLastName, "Enter your last name");
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 26);
            this.txtFirstName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFirstName, "Enter your FIrst Name");
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 91);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 18);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 18);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // gbCarInformation
            // 
            this.gbCarInformation.Controls.Add(this.calender);
            this.gbCarInformation.Controls.Add(this.txtCost);
            this.gbCarInformation.Controls.Add(this.cbAirFiliter);
            this.gbCarInformation.Controls.Add(this.cbTransmission);
            this.gbCarInformation.Controls.Add(this.cbEngineOil);
            this.gbCarInformation.Controls.Add(this.txtColour);
            this.gbCarInformation.Controls.Add(this.cmbYear);
            this.gbCarInformation.Controls.Add(this.txtModel);
            this.gbCarInformation.Controls.Add(this.cmbMake);
            this.gbCarInformation.Controls.Add(this.lblCost);
            this.gbCarInformation.Controls.Add(this.lblServices);
            this.gbCarInformation.Controls.Add(this.lblColour);
            this.gbCarInformation.Controls.Add(this.lblYear);
            this.gbCarInformation.Controls.Add(this.lblModel);
            this.gbCarInformation.Controls.Add(this.lblMake);
            this.gbCarInformation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarInformation.Location = new System.Drawing.Point(12, 161);
            this.gbCarInformation.Name = "gbCarInformation";
            this.gbCarInformation.Size = new System.Drawing.Size(316, 495);
            this.gbCarInformation.TabIndex = 1;
            this.gbCarInformation.TabStop = false;
            this.gbCarInformation.Text = "Car Information";
            // 
            // calender
            // 
            this.calender.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calender.Location = new System.Drawing.Point(6, 239);
            this.calender.Name = "calender";
            this.calender.TabIndex = 12;
            this.toolTip1.SetToolTip(this.calender, "Select a date for the apointment");
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(120, 452);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(181, 26);
            this.txtCost.TabIndex = 14;
            this.txtCost.Text = "0.00 $";
            this.toolTip1.SetToolTip(this.txtCost, "This is where the total cost of your services come down to");
            // 
            // cbAirFiliter
            // 
            this.cbAirFiliter.AutoSize = true;
            this.cbAirFiliter.Location = new System.Drawing.Point(91, 205);
            this.cbAirFiliter.Name = "cbAirFiliter";
            this.cbAirFiliter.Size = new System.Drawing.Size(133, 22);
            this.cbAirFiliter.TabIndex = 11;
            this.cbAirFiliter.Text = "Air Filter Change";
            this.toolTip1.SetToolTip(this.cbAirFiliter, "Select if you need an air filter change");
            this.cbAirFiliter.UseVisualStyleBackColor = true;
            this.cbAirFiliter.CheckedChanged += new System.EventHandler(this.cbAirFiliter_CheckedChanged);
            // 
            // cbTransmission
            // 
            this.cbTransmission.AutoSize = true;
            this.cbTransmission.Location = new System.Drawing.Point(91, 178);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.Size = new System.Drawing.Size(180, 22);
            this.cbTransmission.TabIndex = 10;
            this.cbTransmission.Text = "Transmission Oil Change";
            this.toolTip1.SetToolTip(this.cbTransmission, "Select if you need a transmission oil change");
            this.cbTransmission.UseVisualStyleBackColor = true;
            this.cbTransmission.CheckedChanged += new System.EventHandler(this.cbTransmission_CheckedChanged);
            // 
            // cbEngineOil
            // 
            this.cbEngineOil.AutoSize = true;
            this.cbEngineOil.Location = new System.Drawing.Point(91, 151);
            this.cbEngineOil.Name = "cbEngineOil";
            this.cbEngineOil.Size = new System.Drawing.Size(142, 22);
            this.cbEngineOil.TabIndex = 9;
            this.cbEngineOil.Text = "Engine Oil Change";
            this.toolTip1.SetToolTip(this.cbEngineOil, "Select if you need an engine oil change");
            this.cbEngineOil.UseVisualStyleBackColor = true;
            this.cbEngineOil.CheckedChanged += new System.EventHandler(this.cbEngineOil_CheckedChanged);
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(91, 117);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(181, 26);
            this.txtColour.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtColour, "Enter your car colour");
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(91, 89);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(181, 26);
            this.cmbYear.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cmbYear, "Enter your car year");
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(91, 61);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(181, 26);
            this.txtModel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtModel, "Enter your car model");
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(91, 34);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(181, 26);
            this.cmbMake.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbMake, "Enter your car make");
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(6, 455);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(39, 18);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "Cost:";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(6, 151);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(63, 18);
            this.lblServices.TabIndex = 8;
            this.lblServices.Text = "Services:";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(6, 120);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(53, 18);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 92);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 18);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 64);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(55, 18);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model: ";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(6, 37);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 18);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make:";
            // 
            // gbCarServiceSummary
            // 
            this.gbCarServiceSummary.Controls.Add(this.lvCarServiceSummary);
            this.gbCarServiceSummary.Location = new System.Drawing.Point(334, 12);
            this.gbCarServiceSummary.Name = "gbCarServiceSummary";
            this.gbCarServiceSummary.Size = new System.Drawing.Size(725, 644);
            this.gbCarServiceSummary.TabIndex = 2;
            this.gbCarServiceSummary.TabStop = false;
            this.gbCarServiceSummary.Text = "Car Service Summary";
            // 
            // lvCarServiceSummary
            // 
            this.lvCarServiceSummary.FullRowSelect = true;
            this.lvCarServiceSummary.HideSelection = false;
            this.lvCarServiceSummary.Location = new System.Drawing.Point(7, 22);
            this.lvCarServiceSummary.Name = "lvCarServiceSummary";
            this.lvCarServiceSummary.Size = new System.Drawing.Size(712, 354);
            this.lvCarServiceSummary.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lvCarServiceSummary, "Displays the service requests as you add them");
            this.lvCarServiceSummary.UseCompatibleStateImageBehavior = false;
            this.lvCarServiceSummary.View = System.Windows.Forms.View.Details;
            this.lvCarServiceSummary.SelectedIndexChanged += new System.EventHandler(this.lvCarServiceSummary_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(21, 662);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Add to the list of service summaries");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(144, 662);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 28);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Resets the app");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(267, 662);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 28);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.toolTip1.SetToolTip(this.btnUpdate, "Updates the selected the service on the sumarry list");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(390, 662);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 28);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "&Remove";
            this.toolTip1.SetToolTip(this.btnRemove, "removes a service from the summary list");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(514, 662);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveAll.TabIndex = 7;
            this.btnRemoveAll.Text = "Re&move All";
            this.toolTip1.SetToolTip(this.btnRemoveAll, "deletes all the entries on the list.");
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(638, 662);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits the app");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1071, 730);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbCarServiceSummary);
            this.Controls.Add(this.gbCarInformation);
            this.Controls.Add(this.gbCustomerInformation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1089, 777);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1089, 777);
            this.Name = "MainForm";
            this.Text = "Car Service Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbCustomerInformation.ResumeLayout(false);
            this.gbCustomerInformation.PerformLayout();
            this.gbCarInformation.ResumeLayout(false);
            this.gbCarInformation.PerformLayout();
            this.gbCarServiceSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerInformation;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox gbCarInformation;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.CheckBox cbAirFiliter;
        private System.Windows.Forms.CheckBox cbTransmission;
        private System.Windows.Forms.CheckBox cbEngineOil;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.GroupBox gbCarServiceSummary;
        private System.Windows.Forms.ListView lvCarServiceSummary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

