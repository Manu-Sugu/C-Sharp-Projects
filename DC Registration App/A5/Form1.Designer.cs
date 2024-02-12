namespace A5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBStudentInformation = new System.Windows.Forms.GroupBox();
            this.cmbHighSchoolGrade = new System.Windows.Forms.ComboBox();
            this.cmbTestScore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSinNum = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSinNum = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.GBAvailiblePrograms = new System.Windows.Forms.GroupBox();
            this.lblTotalCostNum = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblStudyPeriodNum = new System.Windows.Forms.Label();
            this.lblStudyPeriod = new System.Windows.Forms.Label();
            this.cmbPrograms = new System.Windows.Forms.ComboBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.cmbCampusLocation = new System.Windows.Forms.ComboBox();
            this.lblCampusLocation = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.DGStudentInformation = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblSin = new System.Windows.Forms.Label();
            this.cmbSinNum = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.GBStudentInformation.SuspendLayout();
            this.GBAvailiblePrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGStudentInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.deleteAllRecordsToolStripMenuItem,
            this.loadAllRecordsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.ToolTipText = "Click to register a Student";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // updateRecordToolStripMenuItem
            // 
            this.updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            this.updateRecordToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.updateRecordToolStripMenuItem.Text = "Update Record";
            this.updateRecordToolStripMenuItem.ToolTipText = "Click to update a record";
            this.updateRecordToolStripMenuItem.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.ToolTipText = "Click to delete a record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // deleteAllRecordsToolStripMenuItem
            // 
            this.deleteAllRecordsToolStripMenuItem.Name = "deleteAllRecordsToolStripMenuItem";
            this.deleteAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.deleteAllRecordsToolStripMenuItem.Text = "Delete All Records";
            this.deleteAllRecordsToolStripMenuItem.ToolTipText = "Click to delete all records";
            this.deleteAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // loadAllRecordsToolStripMenuItem
            // 
            this.loadAllRecordsToolStripMenuItem.Name = "loadAllRecordsToolStripMenuItem";
            this.loadAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.loadAllRecordsToolStripMenuItem.Text = "Load All Records";
            this.loadAllRecordsToolStripMenuItem.ToolTipText = "Click to load all records";
            this.loadAllRecordsToolStripMenuItem.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Click to exit the app";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readHelpToolStripMenuItem,
            this.technicalSupportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readHelpToolStripMenuItem
            // 
            this.readHelpToolStripMenuItem.Name = "readHelpToolStripMenuItem";
            this.readHelpToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.readHelpToolStripMenuItem.Text = "Read Help";
            this.readHelpToolStripMenuItem.ToolTipText = "Click to get help";
            this.readHelpToolStripMenuItem.Click += new System.EventHandler(this.readHelpToolStripMenuItem_Click);
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.technicalSupportToolStripMenuItem.Text = "Technical Support";
            this.technicalSupportToolStripMenuItem.ToolTipText = "Click to get support";
            this.technicalSupportToolStripMenuItem.Click += new System.EventHandler(this.technicalSupportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.aboutToolStripMenuItem.Text = "About DC - Registration App";
            this.aboutToolStripMenuItem.ToolTipText = "Click to read about me";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GBStudentInformation
            // 
            this.GBStudentInformation.Controls.Add(this.cmbHighSchoolGrade);
            this.GBStudentInformation.Controls.Add(this.cmbTestScore);
            this.GBStudentInformation.Controls.Add(this.label2);
            this.GBStudentInformation.Controls.Add(this.label1);
            this.GBStudentInformation.Controls.Add(this.txtEmail);
            this.GBStudentInformation.Controls.Add(this.txtSinNum);
            this.GBStudentInformation.Controls.Add(this.lblEmail);
            this.GBStudentInformation.Controls.Add(this.lblSinNum);
            this.GBStudentInformation.Controls.Add(this.txtLastName);
            this.GBStudentInformation.Controls.Add(this.txtFirstName);
            this.GBStudentInformation.Controls.Add(this.lblLastName);
            this.GBStudentInformation.Controls.Add(this.lblFirstName);
            this.GBStudentInformation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBStudentInformation.Location = new System.Drawing.Point(13, 36);
            this.GBStudentInformation.Name = "GBStudentInformation";
            this.GBStudentInformation.Size = new System.Drawing.Size(1036, 120);
            this.GBStudentInformation.TabIndex = 1;
            this.GBStudentInformation.TabStop = false;
            this.GBStudentInformation.Text = "Student Information";
            // 
            // cmbHighSchoolGrade
            // 
            this.cmbHighSchoolGrade.FormattingEnabled = true;
            this.cmbHighSchoolGrade.Location = new System.Drawing.Point(870, 64);
            this.cmbHighSchoolGrade.Name = "cmbHighSchoolGrade";
            this.cmbHighSchoolGrade.Size = new System.Drawing.Size(121, 26);
            this.cmbHighSchoolGrade.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmbHighSchoolGrade, "Enter the high school grade");
            // 
            // cmbTestScore
            // 
            this.cmbTestScore.FormattingEnabled = true;
            this.cmbTestScore.Location = new System.Drawing.Point(870, 21);
            this.cmbTestScore.Name = "cmbTestScore";
            this.cmbTestScore.Size = new System.Drawing.Size(121, 26);
            this.cmbTestScore.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cmbTestScore, "Enter the student\'s admission test score");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "High School Grade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admission Test Score:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(355, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 26);
            this.txtEmail.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtEmail, "Enter the student\'s email");
            // 
            // txtSinNum
            // 
            this.txtSinNum.Location = new System.Drawing.Point(355, 21);
            this.txtSinNum.Name = "txtSinNum";
            this.txtSinNum.Size = new System.Drawing.Size(255, 26);
            this.txtSinNum.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtSinNum, "Enter the student\'s sin number");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(299, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblSinNum
            // 
            this.lblSinNum.AutoSize = true;
            this.lblSinNum.Location = new System.Drawing.Point(299, 25);
            this.lblSinNum.Name = "lblSinNum";
            this.lblSinNum.Size = new System.Drawing.Size(33, 18);
            this.lblSinNum.TabIndex = 4;
            this.lblSinNum.Text = "SIN:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(88, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 26);
            this.txtLastName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtLastName, "Enter the student\'s last name");
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(88, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 26);
            this.txtFirstName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFirstName, "Enter the student\'s first name");
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 18);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Location = new System.Drawing.Point(13, 162);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(132, 27);
            this.BtnCheck.TabIndex = 2;
            this.BtnCheck.Text = "&Check";
            this.toolTip1.SetToolTip(this.BtnCheck, "Press to check if the student can be registered");
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // GBAvailiblePrograms
            // 
            this.GBAvailiblePrograms.Controls.Add(this.lblTotalCostNum);
            this.GBAvailiblePrograms.Controls.Add(this.lblTotalCost);
            this.GBAvailiblePrograms.Controls.Add(this.lblStudyPeriodNum);
            this.GBAvailiblePrograms.Controls.Add(this.lblStudyPeriod);
            this.GBAvailiblePrograms.Controls.Add(this.cmbPrograms);
            this.GBAvailiblePrograms.Controls.Add(this.lblProgram);
            this.GBAvailiblePrograms.Controls.Add(this.cmbCampusLocation);
            this.GBAvailiblePrograms.Controls.Add(this.lblCampusLocation);
            this.GBAvailiblePrograms.Enabled = false;
            this.GBAvailiblePrograms.Location = new System.Drawing.Point(13, 196);
            this.GBAvailiblePrograms.Name = "GBAvailiblePrograms";
            this.GBAvailiblePrograms.Size = new System.Drawing.Size(1036, 84);
            this.GBAvailiblePrograms.TabIndex = 3;
            this.GBAvailiblePrograms.TabStop = false;
            this.GBAvailiblePrograms.Text = "Availible Programs";
            // 
            // lblTotalCostNum
            // 
            this.lblTotalCostNum.AutoSize = true;
            this.lblTotalCostNum.Location = new System.Drawing.Point(951, 49);
            this.lblTotalCostNum.Name = "lblTotalCostNum";
            this.lblTotalCostNum.Size = new System.Drawing.Size(33, 18);
            this.lblTotalCostNum.TabIndex = 7;
            this.lblTotalCostNum.Text = "0.0$";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(933, 31);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(68, 18);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblStudyPeriodNum
            // 
            this.lblStudyPeriodNum.AutoSize = true;
            this.lblStudyPeriodNum.Location = new System.Drawing.Point(852, 49);
            this.lblStudyPeriodNum.Name = "lblStudyPeriodNum";
            this.lblStudyPeriodNum.Size = new System.Drawing.Size(15, 18);
            this.lblStudyPeriodNum.TabIndex = 5;
            this.lblStudyPeriodNum.Text = "0";
            // 
            // lblStudyPeriod
            // 
            this.lblStudyPeriod.AutoSize = true;
            this.lblStudyPeriod.Location = new System.Drawing.Point(820, 31);
            this.lblStudyPeriod.Name = "lblStudyPeriod";
            this.lblStudyPeriod.Size = new System.Drawing.Size(87, 18);
            this.lblStudyPeriod.TabIndex = 4;
            this.lblStudyPeriod.Text = "Study Period";
            // 
            // cmbPrograms
            // 
            this.cmbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrograms.Enabled = false;
            this.cmbPrograms.FormattingEnabled = true;
            this.cmbPrograms.Location = new System.Drawing.Point(468, 35);
            this.cmbPrograms.Name = "cmbPrograms";
            this.cmbPrograms.Size = new System.Drawing.Size(288, 26);
            this.cmbPrograms.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbPrograms, "Select a program name");
            this.cmbPrograms.SelectedIndexChanged += new System.EventHandler(this.cmbPrograms_SelectedIndexChanged);
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(378, 38);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(70, 18);
            this.lblProgram.TabIndex = 2;
            this.lblProgram.Text = "Programs:";
            // 
            // cmbCampusLocation
            // 
            this.cmbCampusLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampusLocation.FormattingEnabled = true;
            this.cmbCampusLocation.Location = new System.Drawing.Point(132, 31);
            this.cmbCampusLocation.Name = "cmbCampusLocation";
            this.cmbCampusLocation.Size = new System.Drawing.Size(180, 26);
            this.cmbCampusLocation.TabIndex = 1;
            this.cmbCampusLocation.SelectedIndexChanged += new System.EventHandler(this.cmbCampusLocation_SelectedIndexChanged);
            // 
            // lblCampusLocation
            // 
            this.lblCampusLocation.AutoSize = true;
            this.lblCampusLocation.Location = new System.Drawing.Point(10, 38);
            this.lblCampusLocation.Name = "lblCampusLocation";
            this.lblCampusLocation.Size = new System.Drawing.Size(115, 18);
            this.lblCampusLocation.TabIndex = 0;
            this.lblCampusLocation.Text = "Campus Location:";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Enabled = false;
            this.BtnRegister.Location = new System.Drawing.Point(13, 286);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(132, 27);
            this.BtnRegister.TabIndex = 4;
            this.BtnRegister.Text = "&Register Student";
            this.toolTip1.SetToolTip(this.BtnRegister, "Press to register a student");
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // DGStudentInformation
            // 
            this.DGStudentInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGStudentInformation.Location = new System.Drawing.Point(13, 320);
            this.DGStudentInformation.Name = "DGStudentInformation";
            this.DGStudentInformation.RowHeadersWidth = 51;
            this.DGStudentInformation.RowTemplate.Height = 24;
            this.DGStudentInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGStudentInformation.Size = new System.Drawing.Size(1036, 153);
            this.DGStudentInformation.TabIndex = 5;
            this.DGStudentInformation.TabStop = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(13, 499);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(132, 27);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "&Delete Record";
            this.toolTip1.SetToolTip(this.BtnDelete, "Press to delete a record");
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(151, 499);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(132, 27);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "&Update Record";
            this.toolTip1.SetToolTip(this.BtnUpdate, "Press to update a record");
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnRemoveAll.Location = new System.Drawing.Point(429, 499);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(194, 27);
            this.BtnRemoveAll.TabIndex = 8;
            this.BtnRemoveAll.Text = "Remove &All Records";
            this.toolTip1.SetToolTip(this.BtnRemoveAll, "Press to remove all records");
            this.BtnRemoveAll.UseVisualStyleBackColor = true;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(686, 499);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(194, 27);
            this.BtnLoad.TabIndex = 9;
            this.BtnLoad.Text = "&Load Records to Server";
            this.toolTip1.SetToolTip(this.BtnLoad, "Press to load the records to the server");
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(967, 546);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(82, 27);
            this.BtnExit.TabIndex = 12;
            this.BtnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.BtnExit, "Press to exit");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblSin
            // 
            this.lblSin.AutoSize = true;
            this.lblSin.Location = new System.Drawing.Point(13, 546);
            this.lblSin.Name = "lblSin";
            this.lblSin.Size = new System.Drawing.Size(33, 18);
            this.lblSin.TabIndex = 10;
            this.lblSin.Text = "SIN:";
            // 
            // cmbSinNum
            // 
            this.cmbSinNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinNum.FormattingEnabled = true;
            this.cmbSinNum.Location = new System.Drawing.Point(52, 543);
            this.cmbSinNum.Name = "cmbSinNum";
            this.cmbSinNum.Size = new System.Drawing.Size(273, 26);
            this.cmbSinNum.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmbSinNum, "Select a sin number");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnRemoveAll;
            this.ClientSize = new System.Drawing.Size(1061, 585);
            this.Controls.Add(this.cmbSinNum);
            this.Controls.Add(this.lblSin);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnRemoveAll);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DGStudentInformation);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.GBAvailiblePrograms);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.GBStudentInformation);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1079, 632);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1079, 632);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DC Registration App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBStudentInformation.ResumeLayout(false);
            this.GBStudentInformation.PerformLayout();
            this.GBAvailiblePrograms.ResumeLayout(false);
            this.GBAvailiblePrograms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGStudentInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBStudentInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSinNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSinNum;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbHighSchoolGrade;
        private System.Windows.Forms.ComboBox cmbTestScore;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.GroupBox GBAvailiblePrograms;
        private System.Windows.Forms.Label lblCampusLocation;
        private System.Windows.Forms.Label lblStudyPeriod;
        private System.Windows.Forms.ComboBox cmbPrograms;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cmbCampusLocation;
        private System.Windows.Forms.Label lblTotalCostNum;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblStudyPeriodNum;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.DataGridView DGStudentInformation;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblSin;
        private System.Windows.Forms.ComboBox cmbSinNum;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

