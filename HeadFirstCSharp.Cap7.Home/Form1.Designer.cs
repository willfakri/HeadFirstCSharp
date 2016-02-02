namespace HeadFirstCSharp.Cap7.Home
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGoHere = new System.Windows.Forms.Button();
            this.ddlExits = new System.Windows.Forms.ComboBox();
            this.btnGoThroughtTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(13, 13);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 145);
            this.txtDescription.TabIndex = 0;
            // 
            // btnGoHere
            // 
            this.btnGoHere.Location = new System.Drawing.Point(13, 165);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(56, 23);
            this.btnGoHere.TabIndex = 1;
            this.btnGoHere.Text = "Vá Para:";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Click += new System.EventHandler(this.btnGoHere_Click);
            // 
            // ddlExits
            // 
            this.ddlExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExits.FormattingEnabled = true;
            this.ddlExits.Location = new System.Drawing.Point(86, 165);
            this.ddlExits.Name = "ddlExits";
            this.ddlExits.Size = new System.Drawing.Size(186, 21);
            this.ddlExits.TabIndex = 2;
            // 
            // btnGoThroughtTheDoor
            // 
            this.btnGoThroughtTheDoor.Location = new System.Drawing.Point(13, 195);
            this.btnGoThroughtTheDoor.Name = "btnGoThroughtTheDoor";
            this.btnGoThroughtTheDoor.Size = new System.Drawing.Size(259, 23);
            this.btnGoThroughtTheDoor.TabIndex = 3;
            this.btnGoThroughtTheDoor.Text = "Passe pela porta";
            this.btnGoThroughtTheDoor.UseVisualStyleBackColor = true;
            this.btnGoThroughtTheDoor.Click += new System.EventHandler(this.btnGoThroughtTheDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.btnGoThroughtTheDoor);
            this.Controls.Add(this.ddlExits);
            this.Controls.Add(this.btnGoHere);
            this.Controls.Add(this.txtDescription);
            this.Name = "Form1";
            this.Text = "Rolê pela casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGoHere;
        private System.Windows.Forms.ComboBox ddlExits;
        private System.Windows.Forms.Button btnGoThroughtTheDoor;
    }
}

