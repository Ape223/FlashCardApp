namespace FlashCardApp
{
    partial class CreateFlashcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFlashcard));
            this.saveDeck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDeck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.definition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addCard = new System.Windows.Forms.Button();
            this.removeCard = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // saveDeck
            // 
            this.saveDeck.Font = new System.Drawing.Font("Yu Mincho", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDeck.Location = new System.Drawing.Point(577, 12);
            this.saveDeck.Name = "saveDeck";
            this.saveDeck.Size = new System.Drawing.Size(99, 38);
            this.saveDeck.TabIndex = 0;
            this.saveDeck.Text = "Save";
            this.saveDeck.UseVisualStyleBackColor = true;
            this.saveDeck.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Mincho", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Your Flashcard deck";
            // 
            // loadDeck
            // 
            this.loadDeck.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDeck.Location = new System.Drawing.Point(119, 58);
            this.loadDeck.Name = "loadDeck";
            this.loadDeck.Size = new System.Drawing.Size(555, 39);
            this.loadDeck.TabIndex = 2;
            this.loadDeck.Text = "Load your deck here";
            this.loadDeck.UseVisualStyleBackColor = true;
            this.loadDeck.Click += new System.EventHandler(this.loadDeck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deck:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Mincho", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Term:";
            // 
            // term
            // 
            this.term.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term.Location = new System.Drawing.Point(10, 190);
            this.term.MinimumSize = new System.Drawing.Size(343, 80);
            this.term.Multiline = true;
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(343, 80);
            this.term.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Mincho", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Definition:";
            // 
            // definition
            // 
            this.definition.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definition.Location = new System.Drawing.Point(10, 306);
            this.definition.MinimumSize = new System.Drawing.Size(343, 80);
            this.definition.Multiline = true;
            this.definition.Name = "definition";
            this.definition.Size = new System.Drawing.Size(343, 80);
            this.definition.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Mincho", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(403, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Flashcards in deck:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(403, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 172);
            this.listBox1.TabIndex = 19;
            // 
            // addCard
            // 
            this.addCard.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCard.Location = new System.Drawing.Point(403, 333);
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(273, 27);
            this.addCard.TabIndex = 20;
            this.addCard.Text = "Add to deck";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // removeCard
            // 
            this.removeCard.Font = new System.Drawing.Font("Yu Mincho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCard.Location = new System.Drawing.Point(403, 365);
            this.removeCard.Name = "removeCard";
            this.removeCard.Size = new System.Drawing.Size(273, 26);
            this.removeCard.TabIndex = 21;
            this.removeCard.Text = "Remove from deck";
            this.removeCard.UseVisualStyleBackColor = true;
            this.removeCard.Click += new System.EventHandler(this.removeCard_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateFlashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 398);
            this.Controls.Add(this.removeCard);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.definition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.term);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadDeck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveDeck);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "CreateFlashcard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Create Your flashcard deck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFlashcard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveDeck;
        private Label label1;
        private Button loadDeck;
        private Label label2;
        private Label label3;
        private TextBox term;
        private Label label4;
        private TextBox definition;
        private Label label5;
        private ListBox listBox1;
        private Button addCard;
        private Button removeCard;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}