namespace HeadFirstCSharp.Cap8.Deck
{
    partial class FormTwoDecks
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
            this.lbDeck1 = new System.Windows.Forms.ListBox();
            this.lblDeck1 = new System.Windows.Forms.Label();
            this.btnDeck1ToDeck2 = new System.Windows.Forms.Button();
            this.lblDeck2 = new System.Windows.Forms.Label();
            this.lbDeck2 = new System.Windows.Forms.ListBox();
            this.btnDeck1Organize = new System.Windows.Forms.Button();
            this.btnDeck2Organize = new System.Windows.Forms.Button();
            this.btnDeck1Shuffle = new System.Windows.Forms.Button();
            this.btnDeck2Shuffle = new System.Windows.Forms.Button();
            this.brnReset = new System.Windows.Forms.Button();
            this.btnDeck2ToDeck1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDeck1
            // 
            this.lbDeck1.FormattingEnabled = true;
            this.lbDeck1.ItemHeight = 16;
            this.lbDeck1.Location = new System.Drawing.Point(22, 42);
            this.lbDeck1.Name = "lbDeck1";
            this.lbDeck1.Size = new System.Drawing.Size(253, 372);
            this.lbDeck1.TabIndex = 0;
            // 
            // lblDeck1
            // 
            this.lblDeck1.AutoSize = true;
            this.lblDeck1.Location = new System.Drawing.Point(22, 19);
            this.lblDeck1.Name = "lblDeck1";
            this.lblDeck1.Size = new System.Drawing.Size(126, 17);
            this.lblDeck1.TabIndex = 1;
            this.lblDeck1.Text = "Barai 1 (10 cartas)";
            // 
            // btnDeck1ToDeck2
            // 
            this.btnDeck1ToDeck2.Location = new System.Drawing.Point(292, 195);
            this.btnDeck1ToDeck2.Name = "btnDeck1ToDeck2";
            this.btnDeck1ToDeck2.Size = new System.Drawing.Size(75, 30);
            this.btnDeck1ToDeck2.TabIndex = 2;
            this.btnDeck1ToDeck2.Text = "> >";
            this.btnDeck1ToDeck2.UseVisualStyleBackColor = true;
            this.btnDeck1ToDeck2.Click += new System.EventHandler(this.btnDeck1ToDeck2_Click);
            // 
            // lblDeck2
            // 
            this.lblDeck2.AutoSize = true;
            this.lblDeck2.Location = new System.Drawing.Point(382, 19);
            this.lblDeck2.Name = "lblDeck2";
            this.lblDeck2.Size = new System.Drawing.Size(126, 17);
            this.lblDeck2.TabIndex = 5;
            this.lblDeck2.Text = "Barai 2 (52 cartas)";
            // 
            // lbDeck2
            // 
            this.lbDeck2.FormattingEnabled = true;
            this.lbDeck2.ItemHeight = 16;
            this.lbDeck2.Location = new System.Drawing.Point(382, 42);
            this.lbDeck2.Name = "lbDeck2";
            this.lbDeck2.Size = new System.Drawing.Size(253, 372);
            this.lbDeck2.TabIndex = 4;
            // 
            // btnDeck1Organize
            // 
            this.btnDeck1Organize.Location = new System.Drawing.Point(22, 420);
            this.btnDeck1Organize.Name = "btnDeck1Organize";
            this.btnDeck1Organize.Size = new System.Drawing.Size(250, 34);
            this.btnDeck1Organize.TabIndex = 6;
            this.btnDeck1Organize.Text = "Organizar Barai 1";
            this.btnDeck1Organize.UseVisualStyleBackColor = true;
            this.btnDeck1Organize.Click += new System.EventHandler(this.btnDeck1Organize_Click);
            // 
            // btnDeck2Organize
            // 
            this.btnDeck2Organize.Location = new System.Drawing.Point(382, 420);
            this.btnDeck2Organize.Name = "btnDeck2Organize";
            this.btnDeck2Organize.Size = new System.Drawing.Size(250, 34);
            this.btnDeck2Organize.TabIndex = 7;
            this.btnDeck2Organize.Text = "Organizar Barai 2";
            this.btnDeck2Organize.UseVisualStyleBackColor = true;
            this.btnDeck2Organize.Click += new System.EventHandler(this.btnDeck2Organize_Click);
            // 
            // btnDeck1Shuffle
            // 
            this.btnDeck1Shuffle.Location = new System.Drawing.Point(22, 460);
            this.btnDeck1Shuffle.Name = "btnDeck1Shuffle";
            this.btnDeck1Shuffle.Size = new System.Drawing.Size(250, 34);
            this.btnDeck1Shuffle.TabIndex = 8;
            this.btnDeck1Shuffle.Text = "Embaralhar Barai 1";
            this.btnDeck1Shuffle.UseVisualStyleBackColor = true;
            this.btnDeck1Shuffle.Click += new System.EventHandler(this.btnDeck1Shuffle_Click);
            // 
            // btnDeck2Shuffle
            // 
            this.btnDeck2Shuffle.Location = new System.Drawing.Point(382, 460);
            this.btnDeck2Shuffle.Name = "btnDeck2Shuffle";
            this.btnDeck2Shuffle.Size = new System.Drawing.Size(250, 34);
            this.btnDeck2Shuffle.TabIndex = 9;
            this.btnDeck2Shuffle.Text = "Embaralhar Barai 2";
            this.btnDeck2Shuffle.UseVisualStyleBackColor = true;
            this.btnDeck2Shuffle.Click += new System.EventHandler(this.btnDeck2Shuffle_Click);
            // 
            // brnReset
            // 
            this.brnReset.Location = new System.Drawing.Point(292, 460);
            this.brnReset.Name = "brnReset";
            this.brnReset.Size = new System.Drawing.Size(75, 34);
            this.brnReset.TabIndex = 10;
            this.brnReset.Text = "RESET";
            this.brnReset.UseVisualStyleBackColor = true;
            this.brnReset.Click += new System.EventHandler(this.brnReset_Click);
            // 
            // btnDeck2ToDeck1
            // 
            this.btnDeck2ToDeck1.Location = new System.Drawing.Point(292, 231);
            this.btnDeck2ToDeck1.Name = "btnDeck2ToDeck1";
            this.btnDeck2ToDeck1.Size = new System.Drawing.Size(75, 30);
            this.btnDeck2ToDeck1.TabIndex = 11;
            this.btnDeck2ToDeck1.Text = "< <";
            this.btnDeck2ToDeck1.UseVisualStyleBackColor = true;
            this.btnDeck2ToDeck1.Click += new System.EventHandler(this.btnDeck2ToDeck1_Click);
            // 
            // FormTwoDecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 514);
            this.Controls.Add(this.btnDeck2ToDeck1);
            this.Controls.Add(this.brnReset);
            this.Controls.Add(this.btnDeck2Shuffle);
            this.Controls.Add(this.btnDeck1Shuffle);
            this.Controls.Add(this.btnDeck2Organize);
            this.Controls.Add(this.btnDeck1Organize);
            this.Controls.Add(this.lblDeck2);
            this.Controls.Add(this.lbDeck2);
            this.Controls.Add(this.btnDeck1ToDeck2);
            this.Controls.Add(this.lblDeck1);
            this.Controls.Add(this.lbDeck1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTwoDecks";
            this.Text = "Dois Barai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDeck1;
        private System.Windows.Forms.Label lblDeck1;
        private System.Windows.Forms.Button btnDeck1ToDeck2;
        private System.Windows.Forms.Label lblDeck2;
        private System.Windows.Forms.ListBox lbDeck2;
        private System.Windows.Forms.Button btnDeck1Organize;
        private System.Windows.Forms.Button btnDeck2Organize;
        private System.Windows.Forms.Button btnDeck1Shuffle;
        private System.Windows.Forms.Button btnDeck2Shuffle;
        private System.Windows.Forms.Button brnReset;
        private System.Windows.Forms.Button btnDeck2ToDeck1;
    }
}