namespace A2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxSymbol2 = new System.Windows.Forms.TextBox();
            this.lblSymbol2 = new System.Windows.Forms.Label();
            this.txtBoxSymbol1 = new System.Windows.Forms.TextBox();
            this.lblSymbol1 = new System.Windows.Forms.Label();
            this.txtBoxName2 = new System.Windows.Forms.TextBox();
            this.txtBoxName1 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtBoxBorder1 = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.txtBoxNextTurn = new System.Windows.Forms.TextBox();
            this.lblNextTurn = new System.Windows.Forms.Label();
            this.BtnBottomRight = new System.Windows.Forms.Button();
            this.BtnBottomMiddle = new System.Windows.Forms.Button();
            this.BtnBottomLeft = new System.Windows.Forms.Button();
            this.BtnMiddleRight = new System.Windows.Forms.Button();
            this.BtnMiddle = new System.Windows.Forms.Button();
            this.BtnMiddleLeft = new System.Windows.Forms.Button();
            this.BtnTopRight = new System.Windows.Forms.Button();
            this.BtnTopMiddle = new System.Windows.Forms.Button();
            this.BtnTopLeft = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxWinner = new System.Windows.Forms.TextBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.txtBoxGameStats = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxSymbol2);
            this.groupBox1.Controls.Add(this.lblSymbol2);
            this.groupBox1.Controls.Add(this.txtBoxSymbol1);
            this.groupBox1.Controls.Add(this.lblSymbol1);
            this.groupBox1.Controls.Add(this.txtBoxName2);
            this.groupBox1.Controls.Add(this.txtBoxName1);
            this.groupBox1.Controls.Add(this.lblName2);
            this.groupBox1.Controls.Add(this.lblName1);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Setup";
            // 
            // txtBoxSymbol2
            // 
            this.txtBoxSymbol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSymbol2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSymbol2.Location = new System.Drawing.Point(548, 62);
            this.txtBoxSymbol2.Name = "txtBoxSymbol2";
            this.txtBoxSymbol2.Size = new System.Drawing.Size(57, 26);
            this.txtBoxSymbol2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtBoxSymbol2, "Enter a symbol for player 2. Must be x or o. (lowercase)");
            // 
            // lblSymbol2
            // 
            this.lblSymbol2.AutoSize = true;
            this.lblSymbol2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol2.Location = new System.Drawing.Point(416, 64);
            this.lblSymbol2.Name = "lblSymbol2";
            this.lblSymbol2.Size = new System.Drawing.Size(110, 18);
            this.lblSymbol2.TabIndex = 6;
            this.lblSymbol2.Text = "Player 2 Symbol:";
            // 
            // txtBoxSymbol1
            // 
            this.txtBoxSymbol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSymbol1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSymbol1.Location = new System.Drawing.Point(548, 24);
            this.txtBoxSymbol1.Name = "txtBoxSymbol1";
            this.txtBoxSymbol1.Size = new System.Drawing.Size(57, 26);
            this.txtBoxSymbol1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtBoxSymbol1, "Enter a symbol for player 1. Must be x or o. (lowercase)");
            // 
            // lblSymbol1
            // 
            this.lblSymbol1.AutoSize = true;
            this.lblSymbol1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol1.Location = new System.Drawing.Point(416, 27);
            this.lblSymbol1.Name = "lblSymbol1";
            this.lblSymbol1.Size = new System.Drawing.Size(110, 18);
            this.lblSymbol1.TabIndex = 2;
            this.lblSymbol1.Text = "Player 1 Symbol:";
            // 
            // txtBoxName2
            // 
            this.txtBoxName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName2.Location = new System.Drawing.Point(144, 62);
            this.txtBoxName2.Name = "txtBoxName2";
            this.txtBoxName2.Size = new System.Drawing.Size(147, 26);
            this.txtBoxName2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtBoxName2, "Enter the name of the second player.");
            // 
            // txtBoxName1
            // 
            this.txtBoxName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName1.Location = new System.Drawing.Point(144, 24);
            this.txtBoxName1.Name = "txtBoxName1";
            this.txtBoxName1.Size = new System.Drawing.Size(147, 26);
            this.txtBoxName1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtBoxName1, "Enter the name of the first player.");
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(19, 65);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(101, 18);
            this.lblName2.TabIndex = 4;
            this.lblName2.Text = "Player 2 Name:";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Location = new System.Drawing.Point(19, 27);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(101, 18);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Player 1 Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.txtBoxBorder1);
            this.groupBox2.Controls.Add(this.BtnReset);
            this.groupBox2.Controls.Add(this.BtnContinue);
            this.groupBox2.Controls.Add(this.BtnStart);
            this.groupBox2.Controls.Add(this.txtBoxNextTurn);
            this.groupBox2.Controls.Add(this.lblNextTurn);
            this.groupBox2.Controls.Add(this.BtnBottomRight);
            this.groupBox2.Controls.Add(this.BtnBottomMiddle);
            this.groupBox2.Controls.Add(this.BtnBottomLeft);
            this.groupBox2.Controls.Add(this.BtnMiddleRight);
            this.groupBox2.Controls.Add(this.BtnMiddle);
            this.groupBox2.Controls.Add(this.BtnMiddleLeft);
            this.groupBox2.Controls.Add(this.BtnTopRight);
            this.groupBox2.Controls.Add(this.BtnTopMiddle);
            this.groupBox2.Controls.Add(this.BtnTopLeft);
            this.groupBox2.Location = new System.Drawing.Point(28, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Area";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(206, 34);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(22, 297);
            this.textBox6.TabIndex = 15;
            this.textBox6.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(98, 32);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(22, 299);
            this.textBox5.TabIndex = 14;
            this.textBox5.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(17, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(287, 26);
            this.textBox4.TabIndex = 17;
            this.textBox4.TabStop = false;
            // 
            // txtBoxBorder1
            // 
            this.txtBoxBorder1.Enabled = false;
            this.txtBoxBorder1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBorder1.Location = new System.Drawing.Point(17, 113);
            this.txtBoxBorder1.Name = "txtBoxBorder1";
            this.txtBoxBorder1.ReadOnly = true;
            this.txtBoxBorder1.Size = new System.Drawing.Size(287, 26);
            this.txtBoxBorder1.TabIndex = 16;
            this.txtBoxBorder1.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnReset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(323, 173);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(99, 38);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.BtnReset, "Resets the application.");
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnContinue
            // 
            this.BtnContinue.Enabled = false;
            this.BtnContinue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.Location = new System.Drawing.Point(323, 113);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(99, 38);
            this.BtnContinue.TabIndex = 1;
            this.BtnContinue.Text = "&Continue";
            this.toolTip1.SetToolTip(this.BtnContinue, "Continue\'s the game after the match is over.");
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(323, 55);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(99, 38);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "&Start";
            this.toolTip1.SetToolTip(this.BtnStart, "Starts the game.");
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtBoxNextTurn
            // 
            this.txtBoxNextTurn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxNextTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNextTurn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNextTurn.Location = new System.Drawing.Point(126, 345);
            this.txtBoxNextTurn.Name = "txtBoxNextTurn";
            this.txtBoxNextTurn.ReadOnly = true;
            this.txtBoxNextTurn.Size = new System.Drawing.Size(114, 26);
            this.txtBoxNextTurn.TabIndex = 13;
            this.txtBoxNextTurn.TabStop = false;
            // 
            // lblNextTurn
            // 
            this.lblNextTurn.AutoSize = true;
            this.lblNextTurn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextTurn.Location = new System.Drawing.Point(48, 347);
            this.lblNextTurn.Name = "lblNextTurn";
            this.lblNextTurn.Size = new System.Drawing.Size(72, 18);
            this.lblNextTurn.TabIndex = 12;
            this.lblNextTurn.Text = "Next Turn:";
            // 
            // BtnBottomRight
            // 
            this.BtnBottomRight.Enabled = false;
            this.BtnBottomRight.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBottomRight.Location = new System.Drawing.Point(228, 252);
            this.BtnBottomRight.Name = "BtnBottomRight";
            this.BtnBottomRight.Size = new System.Drawing.Size(80, 80);
            this.BtnBottomRight.TabIndex = 11;
            this.BtnBottomRight.UseVisualStyleBackColor = true;
            this.BtnBottomRight.Click += new System.EventHandler(this.BtnBottomRight_Click);
            // 
            // BtnBottomMiddle
            // 
            this.BtnBottomMiddle.Enabled = false;
            this.BtnBottomMiddle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBottomMiddle.Location = new System.Drawing.Point(126, 251);
            this.BtnBottomMiddle.Name = "BtnBottomMiddle";
            this.BtnBottomMiddle.Size = new System.Drawing.Size(80, 80);
            this.BtnBottomMiddle.TabIndex = 10;
            this.BtnBottomMiddle.UseVisualStyleBackColor = true;
            this.BtnBottomMiddle.Click += new System.EventHandler(this.BtnBottomMiddle_Click);
            // 
            // BtnBottomLeft
            // 
            this.BtnBottomLeft.Enabled = false;
            this.BtnBottomLeft.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBottomLeft.Location = new System.Drawing.Point(17, 251);
            this.BtnBottomLeft.Name = "BtnBottomLeft";
            this.BtnBottomLeft.Size = new System.Drawing.Size(80, 80);
            this.BtnBottomLeft.TabIndex = 9;
            this.BtnBottomLeft.UseVisualStyleBackColor = true;
            this.BtnBottomLeft.Click += new System.EventHandler(this.BtnBottomLeft_Click);
            // 
            // BtnMiddleRight
            // 
            this.BtnMiddleRight.Enabled = false;
            this.BtnMiddleRight.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMiddleRight.Location = new System.Drawing.Point(228, 141);
            this.BtnMiddleRight.Name = "BtnMiddleRight";
            this.BtnMiddleRight.Size = new System.Drawing.Size(80, 80);
            this.BtnMiddleRight.TabIndex = 8;
            this.BtnMiddleRight.UseVisualStyleBackColor = true;
            this.BtnMiddleRight.Click += new System.EventHandler(this.BtnMiddleRight_Click);
            // 
            // BtnMiddle
            // 
            this.BtnMiddle.Enabled = false;
            this.BtnMiddle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMiddle.Location = new System.Drawing.Point(126, 141);
            this.BtnMiddle.Name = "BtnMiddle";
            this.BtnMiddle.Size = new System.Drawing.Size(80, 80);
            this.BtnMiddle.TabIndex = 7;
            this.BtnMiddle.UseVisualStyleBackColor = true;
            this.BtnMiddle.Click += new System.EventHandler(this.BtnMiddle_Click);
            // 
            // BtnMiddleLeft
            // 
            this.BtnMiddleLeft.Enabled = false;
            this.BtnMiddleLeft.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMiddleLeft.Location = new System.Drawing.Point(17, 141);
            this.BtnMiddleLeft.Name = "BtnMiddleLeft";
            this.BtnMiddleLeft.Size = new System.Drawing.Size(80, 80);
            this.BtnMiddleLeft.TabIndex = 6;
            this.BtnMiddleLeft.UseVisualStyleBackColor = true;
            this.BtnMiddleLeft.Click += new System.EventHandler(this.BtnMiddleLeft_Click);
            // 
            // BtnTopRight
            // 
            this.BtnTopRight.Enabled = false;
            this.BtnTopRight.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTopRight.Location = new System.Drawing.Point(228, 34);
            this.BtnTopRight.Name = "BtnTopRight";
            this.BtnTopRight.Size = new System.Drawing.Size(80, 80);
            this.BtnTopRight.TabIndex = 5;
            this.BtnTopRight.UseVisualStyleBackColor = true;
            this.BtnTopRight.Click += new System.EventHandler(this.BtnTopRight_Click);
            // 
            // BtnTopMiddle
            // 
            this.BtnTopMiddle.Enabled = false;
            this.BtnTopMiddle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTopMiddle.Location = new System.Drawing.Point(126, 34);
            this.BtnTopMiddle.Name = "BtnTopMiddle";
            this.BtnTopMiddle.Size = new System.Drawing.Size(80, 80);
            this.BtnTopMiddle.TabIndex = 4;
            this.BtnTopMiddle.UseVisualStyleBackColor = true;
            this.BtnTopMiddle.Click += new System.EventHandler(this.BtnTopMiddle_Click);
            // 
            // BtnTopLeft
            // 
            this.BtnTopLeft.Enabled = false;
            this.BtnTopLeft.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTopLeft.Location = new System.Drawing.Point(17, 34);
            this.BtnTopLeft.Name = "BtnTopLeft";
            this.BtnTopLeft.Size = new System.Drawing.Size(80, 80);
            this.BtnTopLeft.TabIndex = 3;
            this.BtnTopLeft.UseVisualStyleBackColor = true;
            this.BtnTopLeft.Click += new System.EventHandler(this.BtnTopLeft_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxWinner);
            this.groupBox3.Controls.Add(this.lblWinner);
            this.groupBox3.Controls.Add(this.txtBoxGameStats);
            this.groupBox3.Location = new System.Drawing.Point(482, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 395);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Stats";
            // 
            // txtBoxWinner
            // 
            this.txtBoxWinner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxWinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxWinner.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWinner.Location = new System.Drawing.Point(78, 345);
            this.txtBoxWinner.Name = "txtBoxWinner";
            this.txtBoxWinner.ReadOnly = true;
            this.txtBoxWinner.Size = new System.Drawing.Size(101, 26);
            this.txtBoxWinner.TabIndex = 2;
            this.txtBoxWinner.TabStop = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(13, 353);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(59, 18);
            this.lblWinner.TabIndex = 1;
            this.lblWinner.Text = "Winner:";
            // 
            // txtBoxGameStats
            // 
            this.txtBoxGameStats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxGameStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGameStats.Location = new System.Drawing.Point(16, 34);
            this.txtBoxGameStats.Multiline = true;
            this.txtBoxGameStats.Name = "txtBoxGameStats";
            this.txtBoxGameStats.ReadOnly = true;
            this.txtBoxGameStats.Size = new System.Drawing.Size(163, 297);
            this.txtBoxGameStats.TabIndex = 0;
            this.txtBoxGameStats.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.BtnReset;
            this.ClientSize = new System.Drawing.Size(714, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(736, 657);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(736, 657);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSymbol2;
        private System.Windows.Forms.Label lblSymbol1;
        private System.Windows.Forms.TextBox txtBoxName2;
        private System.Windows.Forms.TextBox txtBoxName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox txtBoxSymbol2;
        private System.Windows.Forms.TextBox txtBoxSymbol1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBottomRight;
        private System.Windows.Forms.Button BtnBottomMiddle;
        private System.Windows.Forms.Button BtnBottomLeft;
        private System.Windows.Forms.Button BtnMiddleRight;
        private System.Windows.Forms.Button BtnMiddle;
        private System.Windows.Forms.Button BtnMiddleLeft;
        private System.Windows.Forms.Button BtnTopRight;
        private System.Windows.Forms.Button BtnTopMiddle;
        private System.Windows.Forms.Button BtnTopLeft;
        private System.Windows.Forms.Label lblNextTurn;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox txtBoxNextTurn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxWinner;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.TextBox txtBoxGameStats;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtBoxBorder1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

