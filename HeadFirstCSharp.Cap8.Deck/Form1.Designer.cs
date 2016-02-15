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
            this.txtCard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewCard
            // 
            this.btnNewCard.Location = new System.Drawing.Point(12, 32);
            this.btnNewCard.Name = "btnNewCard";
            this.btnNewCard.Size = new System.Drawing.Size(183, 23);
            this.btnNewCard.TabIndex = 0;
            this.btnNewCard.Text = "Nova Carta";
            this.btnNewCard.UseVisualStyleBackColor = true;
            this.btnNewCard.Click += new System.EventHandler(this.btnNewCard_Click);
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(12, 72);
            this.txtCard.Name = "txtCard";
            this.txtCard.ReadOnly = true;
            this.txtCard.Size = new System.Drawing.Size(183, 22);
            this.txtCard.TabIndex = 1;
            this.txtCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 124);
            this.Controls.Add(this.txtCard);
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
        private System.Windows.Forms.TextBox txtCard;
    }
}

