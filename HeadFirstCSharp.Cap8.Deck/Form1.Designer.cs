namespace HeadFirstCSharp.Cap8.Deck
{
    partial class Form1
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
            this.btnNewCard = new System.Windows.Forms.Button();
            this.txtCardsUnsorted = new System.Windows.Forms.TextBox();
            this.txtCardsSorted = new System.Windows.Forms.TextBox();
            this.lblUnsorted = new System.Windows.Forms.Label();
            this.lblSorted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewCard
            // 
            this.btnNewCard.Location = new System.Drawing.Point(12, 15);
            this.btnNewCard.Name = "btnNewCard";
            this.btnNewCard.Size = new System.Drawing.Size(372, 34);
            this.btnNewCard.TabIndex = 0;
            this.btnNewCard.Text = "CUMEÇA!";
            this.btnNewCard.UseVisualStyleBackColor = true;
            this.btnNewCard.Click += new System.EventHandler(this.btnNewCard_Click);
            // 
            // txtCardsUnsorted
            // 
            this.txtCardsUnsorted.Location = new System.Drawing.Point(12, 86);
            this.txtCardsUnsorted.Multiline = true;
            this.txtCardsUnsorted.Name = "txtCardsUnsorted";
            this.txtCardsUnsorted.ReadOnly = true;
            this.txtCardsUnsorted.Size = new System.Drawing.Size(183, 120);
            this.txtCardsUnsorted.TabIndex = 1;
            this.txtCardsUnsorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCardsSorted
            // 
            this.txtCardsSorted.Location = new System.Drawing.Point(201, 86);
            this.txtCardsSorted.Multiline = true;
            this.txtCardsSorted.Name = "txtCardsSorted";
            this.txtCardsSorted.ReadOnly = true;
            this.txtCardsSorted.Size = new System.Drawing.Size(183, 120);
            this.txtCardsSorted.TabIndex = 2;
            this.txtCardsSorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnsorted
            // 
            this.lblUnsorted.AutoSize = true;
            this.lblUnsorted.Location = new System.Drawing.Point(13, 63);
            this.lblUnsorted.Name = "lblUnsorted";
            this.lblUnsorted.Size = new System.Drawing.Size(64, 17);
            this.lblUnsorted.TabIndex = 3;
            this.lblUnsorted.Text = "Aleatório";
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Location = new System.Drawing.Point(198, 63);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(72, 17);
            this.lblSorted.TabIndex = 4;
            this.lblSorted.Text = "Ordenado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 222);
            this.Controls.Add(this.lblSorted);
            this.Controls.Add(this.lblUnsorted);
            this.Controls.Add(this.txtCardsSorted);
            this.Controls.Add(this.txtCardsUnsorted);
            this.Controls.Add(this.btnNewCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Deck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCard;
        private System.Windows.Forms.TextBox txtCardsUnsorted;
        private System.Windows.Forms.TextBox txtCardsSorted;
        private System.Windows.Forms.Label lblUnsorted;
        private System.Windows.Forms.Label lblSorted;
    }
}

