namespace A5
{
    partial class AboutDCForm
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(512, 54);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(82, 27);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.BtnExit, "Press to exit!");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "This app will allow you to add new students to the data grid view and upload them" +
    " to a server.";
            // 
            // AboutDCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(606, 93);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(624, 140);
            this.Name = "AboutDCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutDCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}