namespace FlashCardApp
{
    partial class StudyDeck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary
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
            this.decksList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDeck = new System.Windows.Forms.Button();
            this.card = new System.Windows.Forms.Button();
            this.removeDeck = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.easy = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currCard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decksList
            // 
            this.decksList.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decksList.FormattingEnabled = true;
            this.decksList.ItemHeight = 19;
            this.decksList.Location = new System.Drawing.Point(3, 122);
            this.decksList.Name = "decksList";
            this.decksList.Size = new System.Drawing.Size(175, 251);
            this.decksList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Study Flashcard";
            // 
            // loadDeck
            // 
            this.loadDeck.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDeck.Location = new System.Drawing.Point(3, 62);
            this.loadDeck.Name = "loadDeck";
            this.loadDeck.Size = new System.Drawing.Size(175, 25);
            this.loadDeck.TabIndex = 2;
            this.loadDeck.Text = "Load deck";
            this.loadDeck.UseVisualStyleBackColor = true;
            this.loadDeck.Click += new System.EventHandler(this.LoadDeck_Click);
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(222, 62);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(412, 324);
            this.card.TabIndex = 5;
            this.card.UseVisualStyleBackColor = true;
            this.card.EnabledChanged += new System.EventHandler(this.card_EnabledChanged);
            this.card.Click += new System.EventHandler(this.card_Click);
            // 
            // removeDeck
            // 
            this.removeDeck.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDeck.Location = new System.Drawing.Point(3, 92);
            this.removeDeck.Name = "removeDeck";
            this.removeDeck.Size = new System.Drawing.Size(175, 25);
            this.removeDeck.TabIndex = 6;
            this.removeDeck.Text = "Remove Deck";
            this.removeDeck.UseVisualStyleBackColor = true;
            this.removeDeck.Click += new System.EventHandler(this.RemoveDeck_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(183, 62);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(35, 324);
            this.previous.TabIndex = 7;
            this.previous.Text = "<-";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(640, 62);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(35, 324);
            this.next.TabIndex = 8;
            this.next.Text = "->";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cards loaded:";
            // 
            // easy
            // 
            this.easy.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.easy.Location = new System.Drawing.Point(475, 352);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(78, 26);
            this.easy.TabIndex = 10;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // medium
            // 
            this.medium.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.Location = new System.Drawing.Point(391, 352);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(78, 26);
            this.medium.TabIndex = 11;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // hard
            // 
            this.hard.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(307, 352);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(78, 26);
            this.hard.TabIndex = 12;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // currCard
            // 
            this.currCard.AutoSize = true;
            this.currCard.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.currCard.Location = new System.Drawing.Point(405, 32);
            this.currCard.Name = "currCard";
            this.currCard.Size = new System.Drawing.Size(97, 19);
            this.currCard.TabIndex = 14;
            this.currCard.Text = "Current card:";
            // 
            // StudyDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.currCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.removeDeck);
            this.Controls.Add(this.card);
            this.Controls.Add(this.loadDeck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decksList);
            this.Name = "StudyDeck";
            this.Text = "StudyDeck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudyDeck_FormClosing);
            this.Load += new System.EventHandler(this.StudyDeck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox decksList;
        private Label label1;
        private Button loadDeck;
        private Button card;
        private Button removeDeck;
        private Button previous;
        private Button next;
        private Label label2;
        private Button easy;
        private Button medium;
        private Button hard;
        private Label label3;
        private Label currCard;
    }
}