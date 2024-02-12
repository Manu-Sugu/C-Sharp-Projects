namespace A1
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
            this.LblVGSales = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDayNum = new System.Windows.Forms.Label();
            this.txtInputDisplay = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // LblVGSales
            // 
            this.LblVGSales.AutoSize = true;
            this.LblVGSales.Location = new System.Drawing.Point(49, 44);
            this.LblVGSales.Name = "LblVGSales";
            this.LblVGSales.Size = new System.Drawing.Size(128, 16);
            this.LblVGSales.TabIndex = 0;
            this.LblVGSales.Text = "Video Games Sales";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(195, 41);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(176, 22);
            this.txtInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtInput, "This box is where you will input your total sales for the day.");
            // 
            // lblDayNum
            // 
            this.lblDayNum.AutoSize = true;
            this.lblDayNum.Location = new System.Drawing.Point(416, 44);
            this.lblDayNum.Name = "lblDayNum";
            this.lblDayNum.Size = new System.Drawing.Size(42, 16);
            this.lblDayNum.TabIndex = 2;
            this.lblDayNum.Text = "Day 1";
            // 
            // txtInputDisplay
            // 
            this.txtInputDisplay.Location = new System.Drawing.Point(52, 86);
            this.txtInputDisplay.Multiline = true;
            this.txtInputDisplay.Name = "txtInputDisplay";
            this.txtInputDisplay.ReadOnly = true;
            this.txtInputDisplay.Size = new System.Drawing.Size(406, 247);
            this.txtInputDisplay.TabIndex = 3;
            this.txtInputDisplay.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(52, 362);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(406, 22);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TabStop = false;
            this.txtOutput.Text = "Average Video Game Sales: $0.00";
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(52, 404);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(104, 27);
            this.BtnEnter.TabIndex = 5;
            this.BtnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.BtnEnter, "This button will add the current input to the display box.");
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnReset.Location = new System.Drawing.Point(206, 404);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(104, 27);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.BtnReset, "This button will Reset the form.");
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(354, 404);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(104, 27);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.BtnExit, "This button will exit the form.");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnReset;
            this.ClientSize = new System.Drawing.Size(512, 473);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInputDisplay);
            this.Controls.Add(this.lblDayNum);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.LblVGSales);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 520);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Video Games Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVGSales;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDayNum;
        private System.Windows.Forms.TextBox txtInputDisplay;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

