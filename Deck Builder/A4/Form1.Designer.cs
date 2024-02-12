namespace A4
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
            this.GBCard = new System.Windows.Forms.GroupBox();
            this.BtnAddCustom = new System.Windows.Forms.Button();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtSuit = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblSuit = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.BtnDeal = new System.Windows.Forms.Button();
            this.lvCardsDealt = new System.Windows.Forms.ListView();
            this.lblCardsDealt = new System.Windows.Forms.Label();
            this.lblDeck = new System.Windows.Forms.Label();
            this.lvDeck = new System.Windows.Forms.ListView();
            this.BtnViewDeck = new System.Windows.Forms.Button();
            this.BtnShuffle = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GBDeal = new System.Windows.Forms.GroupBox();
            this.GBCard.SuspendLayout();
            this.GBDeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCard
            // 
            this.GBCard.Controls.Add(this.BtnAddCustom);
            this.GBCard.Controls.Add(this.txtRank);
            this.GBCard.Controls.Add(this.txtSuit);
            this.GBCard.Controls.Add(this.lblRank);
            this.GBCard.Controls.Add(this.lblSuit);
            this.GBCard.Enabled = false;
            this.GBCard.Location = new System.Drawing.Point(13, 13);
            this.GBCard.Name = "GBCard";
            this.GBCard.Size = new System.Drawing.Size(277, 100);
            this.GBCard.TabIndex = 0;
            this.GBCard.TabStop = false;
            this.GBCard.Text = "Card";
            // 
            // BtnAddCustom
            // 
            this.BtnAddCustom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustom.Location = new System.Drawing.Point(183, 24);
            this.BtnAddCustom.Name = "BtnAddCustom";
            this.BtnAddCustom.Size = new System.Drawing.Size(88, 44);
            this.BtnAddCustom.TabIndex = 4;
            this.BtnAddCustom.Text = "&Add Custom";
            this.toolTip1.SetToolTip(this.BtnAddCustom, "Press to add your custom card");
            this.BtnAddCustom.UseVisualStyleBackColor = true;
            this.BtnAddCustom.Click += new System.EventHandler(this.BtnAddCustom_Click);
            // 
            // txtRank
            // 
            this.txtRank.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.Location = new System.Drawing.Point(66, 47);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(100, 26);
            this.txtRank.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtRank, "Write the rank of the card");
            // 
            // txtSuit
            // 
            this.txtSuit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuit.Location = new System.Drawing.Point(66, 19);
            this.txtSuit.Name = "txtSuit";
            this.txtSuit.Size = new System.Drawing.Size(100, 26);
            this.txtSuit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSuit, "Write the suit for the card.");
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(7, 50);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(42, 18);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "Rank:";
            // 
            // lblSuit
            // 
            this.lblSuit.AutoSize = true;
            this.lblSuit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuit.Location = new System.Drawing.Point(7, 22);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(36, 18);
            this.lblSuit.TabIndex = 0;
            this.lblSuit.Text = "Suit:";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.Location = new System.Drawing.Point(7, 21);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(40, 18);
            this.lblDraw.TabIndex = 1;
            this.lblDraw.Text = "Draw";
            // 
            // txtDraw
            // 
            this.txtDraw.Location = new System.Drawing.Point(53, 19);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(100, 22);
            this.txtDraw.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtDraw, "Write the amount of cards you wish to deal");
            // 
            // BtnDeal
            // 
            this.BtnDeal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeal.Location = new System.Drawing.Point(168, 14);
            this.BtnDeal.Name = "BtnDeal";
            this.BtnDeal.Size = new System.Drawing.Size(88, 32);
            this.BtnDeal.TabIndex = 3;
            this.BtnDeal.Text = "&Deal";
            this.toolTip1.SetToolTip(this.BtnDeal, "Press to deal the cards.");
            this.BtnDeal.UseVisualStyleBackColor = true;
            this.BtnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // lvCardsDealt
            // 
            this.lvCardsDealt.HideSelection = false;
            this.lvCardsDealt.Location = new System.Drawing.Point(38, 196);
            this.lvCardsDealt.Name = "lvCardsDealt";
            this.lvCardsDealt.Size = new System.Drawing.Size(201, 97);
            this.lvCardsDealt.TabIndex = 5;
            this.lvCardsDealt.TabStop = false;
            this.toolTip1.SetToolTip(this.lvCardsDealt, "Your Dealt Cards");
            this.lvCardsDealt.UseCompatibleStateImageBehavior = false;
            this.lvCardsDealt.View = System.Windows.Forms.View.List;
            // 
            // lblCardsDealt
            // 
            this.lblCardsDealt.AutoSize = true;
            this.lblCardsDealt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardsDealt.Location = new System.Drawing.Point(88, 175);
            this.lblCardsDealt.Name = "lblCardsDealt";
            this.lblCardsDealt.Size = new System.Drawing.Size(78, 18);
            this.lblCardsDealt.TabIndex = 4;
            this.lblCardsDealt.Text = "Cards Dealt";
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Location = new System.Drawing.Point(380, 13);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(39, 16);
            this.lblDeck.TabIndex = 6;
            this.lblDeck.Text = "Deck";
            // 
            // lvDeck
            // 
            this.lvDeck.HideSelection = false;
            this.lvDeck.Location = new System.Drawing.Point(307, 32);
            this.lvDeck.Name = "lvDeck";
            this.lvDeck.Size = new System.Drawing.Size(187, 261);
            this.lvDeck.TabIndex = 7;
            this.lvDeck.TabStop = false;
            this.toolTip1.SetToolTip(this.lvDeck, "The deck of cards");
            this.lvDeck.UseCompatibleStateImageBehavior = false;
            this.lvDeck.View = System.Windows.Forms.View.List;
            // 
            // BtnViewDeck
            // 
            this.BtnViewDeck.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewDeck.Location = new System.Drawing.Point(500, 33);
            this.BtnViewDeck.Name = "BtnViewDeck";
            this.BtnViewDeck.Size = new System.Drawing.Size(96, 32);
            this.BtnViewDeck.TabIndex = 8;
            this.BtnViewDeck.Text = "&View Deck";
            this.toolTip1.SetToolTip(this.BtnViewDeck, "To view/hide the deck");
            this.BtnViewDeck.UseVisualStyleBackColor = true;
            this.BtnViewDeck.Click += new System.EventHandler(this.BtnViewDeck_Click);
            // 
            // BtnShuffle
            // 
            this.BtnShuffle.Enabled = false;
            this.BtnShuffle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShuffle.Location = new System.Drawing.Point(500, 81);
            this.BtnShuffle.Name = "BtnShuffle";
            this.BtnShuffle.Size = new System.Drawing.Size(96, 32);
            this.BtnShuffle.TabIndex = 9;
            this.BtnShuffle.Text = "&Shuffle";
            this.toolTip1.SetToolTip(this.BtnShuffle, "To Shuffle the deck");
            this.BtnShuffle.UseVisualStyleBackColor = true;
            this.BtnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnReset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(500, 130);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(96, 32);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.BtnReset, "To reset the app");
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(500, 179);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(96, 32);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.BtnExit, "To exit the app");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GBDeal
            // 
            this.GBDeal.Controls.Add(this.lblDraw);
            this.GBDeal.Controls.Add(this.txtDraw);
            this.GBDeal.Controls.Add(this.BtnDeal);
            this.GBDeal.Enabled = false;
            this.GBDeal.Location = new System.Drawing.Point(13, 119);
            this.GBDeal.Name = "GBDeal";
            this.GBDeal.Size = new System.Drawing.Size(277, 53);
            this.GBDeal.TabIndex = 12;
            this.GBDeal.TabStop = false;
            this.GBDeal.Text = "Deal";
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnViewDeck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnReset;
            this.ClientSize = new System.Drawing.Size(601, 312);
            this.Controls.Add(this.GBDeal);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnShuffle);
            this.Controls.Add(this.BtnViewDeck);
            this.Controls.Add(this.lvDeck);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.lblCardsDealt);
            this.Controls.Add(this.lvCardsDealt);
            this.Controls.Add(this.GBCard);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(619, 359);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(619, 346);
            this.Name = "MainForm";
            this.Text = "Deck Builder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GBCard.ResumeLayout(false);
            this.GBCard.PerformLayout();
            this.GBDeal.ResumeLayout(false);
            this.GBDeal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCard;
        private System.Windows.Forms.Button BtnAddCustom;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtSuit;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblSuit;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.Button BtnDeal;
        private System.Windows.Forms.ListView lvCardsDealt;
        private System.Windows.Forms.Label lblCardsDealt;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.ListView lvDeck;
        private System.Windows.Forms.Button BtnViewDeck;
        private System.Windows.Forms.Button BtnShuffle;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox GBDeal;
    }
}

