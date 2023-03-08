namespace FlashCardApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.studyFlashcard = new System.Windows.Forms.Button();
            this.createFlashcard = new System.Windows.Forms.Button();
            this.quitProgram = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studyFlashcard
            // 
            this.studyFlashcard.Font = new System.Drawing.Font("Yu Mincho", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.studyFlashcard.Location = new System.Drawing.Point(0, 94);
            this.studyFlashcard.Name = "studyFlashcard";
            this.studyFlashcard.Size = new System.Drawing.Size(665, 89);
            this.studyFlashcard.TabIndex = 0;
            this.studyFlashcard.Text = "Study a deck";
            this.studyFlashcard.UseVisualStyleBackColor = true;
            this.studyFlashcard.Click += new System.EventHandler(this.button1_Click);
            // 
            // createFlashcard
            // 
            this.createFlashcard.Font = new System.Drawing.Font("Yu Mincho", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createFlashcard.Location = new System.Drawing.Point(0, 198);
            this.createFlashcard.Name = "createFlashcard";
            this.createFlashcard.Size = new System.Drawing.Size(665, 89);
            this.createFlashcard.TabIndex = 1;
            this.createFlashcard.Text = "Create a deck";
            this.createFlashcard.UseVisualStyleBackColor = true;
            this.createFlashcard.Click += new System.EventHandler(this.button2_Click);
            // 
            // quitProgram
            // 
            this.quitProgram.Font = new System.Drawing.Font("Yu Mincho", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.quitProgram.Location = new System.Drawing.Point(0, 301);
            this.quitProgram.Name = "quitProgram";
            this.quitProgram.Size = new System.Drawing.Size(665, 89);
            this.quitProgram.TabIndex = 2;
            this.quitProgram.Text = "Quit the app\r\n";
            this.quitProgram.UseVisualStyleBackColor = true;
            this.quitProgram.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 82);
            this.label1.TabIndex = 3;
            this.label1.Text = "FlashCard App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitProgram);
            this.Controls.Add(this.createFlashcard);
            this.Controls.Add(this.studyFlashcard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button studyFlashcard;
        private Button createFlashcard;
        private Button quitProgram;
        private Label label1;
    }
}