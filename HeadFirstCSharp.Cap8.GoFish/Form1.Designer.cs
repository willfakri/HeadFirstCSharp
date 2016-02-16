namespace HeadFirstCSharp.Cap8.GoFish
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHand = new System.Windows.Forms.Label();
            this.lbHand = new System.Windows.Forms.ListBox();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.btnAskCard = new System.Windows.Forms.Button();
            this.lblGameProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Seu Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(278, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "CUMEÇA!";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Location = new System.Drawing.Point(506, 13);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(64, 17);
            this.lblHand.TabIndex = 3;
            this.lblHand.Text = "Sua mão";
            // 
            // lbHand
            // 
            this.lbHand.FormattingEnabled = true;
            this.lbHand.ItemHeight = 16;
            this.lbHand.Location = new System.Drawing.Point(509, 34);
            this.lbHand.Name = "lbHand";
            this.lbHand.Size = new System.Drawing.Size(222, 484);
            this.lbHand.TabIndex = 4;
            // 
            // txtProgress
            // 
            this.txtProgress.Location = new System.Drawing.Point(16, 94);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.Size = new System.Drawing.Size(460, 295);
            this.txtProgress.TabIndex = 5;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(16, 410);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(39, 17);
            this.lblBook.TabIndex = 6;
            this.lblBook.Text = "Livro";
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(19, 431);
            this.txtBooks.Multiline = true;
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.ReadOnly = true;
            this.txtBooks.Size = new System.Drawing.Size(457, 122);
            this.txtBooks.TabIndex = 7;
            // 
            // btnAskCard
            // 
            this.btnAskCard.Location = new System.Drawing.Point(509, 524);
            this.btnAskCard.Name = "btnAskCard";
            this.btnAskCard.Size = new System.Drawing.Size(222, 30);
            this.btnAskCard.TabIndex = 8;
            this.btnAskCard.Text = "Perguntar por uma carta";
            this.btnAskCard.UseVisualStyleBackColor = true;
            this.btnAskCard.Click += new System.EventHandler(this.btnAskCard_Click);
            // 
            // lblGameProgress
            // 
            this.lblGameProgress.AutoSize = true;
            this.lblGameProgress.Location = new System.Drawing.Point(16, 74);
            this.lblGameProgress.Name = "lblGameProgress";
            this.lblGameProgress.Size = new System.Drawing.Size(128, 17);
            this.lblGameProgress.TabIndex = 9;
            this.lblGameProgress.Text = "Progresso do Jogo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 572);
            this.Controls.Add(this.lblGameProgress);
            this.Controls.Add(this.btnAskCard);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.lbHand);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Vai Pescar Vagabundo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.ListBox lbHand;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Button btnAskCard;
        private System.Windows.Forms.Label lblGameProgress;
    }
}

