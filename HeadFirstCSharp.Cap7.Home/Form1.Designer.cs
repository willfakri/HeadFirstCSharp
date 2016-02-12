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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(17, 16);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(344, 178);
            this.txtDescription.TabIndex = 0;
            // 
            // btnGoHere
            // 
            this.btnGoHere.Location = new System.Drawing.Point(17, 203);
            this.btnGoHere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(75, 28);
            this.btnGoHere.TabIndex = 1;
            this.btnGoHere.Text = "Vá Para:";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Visible = false;
            this.btnGoHere.Click += new System.EventHandler(this.btnGoHere_Click);
            // 
            // ddlExits
            // 
            this.ddlExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExits.FormattingEnabled = true;
            this.ddlExits.Location = new System.Drawing.Point(115, 203);
            this.ddlExits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlExits.Name = "ddlExits";
            this.ddlExits.Size = new System.Drawing.Size(247, 24);
            this.ddlExits.TabIndex = 2;
            this.ddlExits.Visible = false;
            // 
            // btnGoThroughtTheDoor
            // 
            this.btnGoThroughtTheDoor.Location = new System.Drawing.Point(17, 240);
            this.btnGoThroughtTheDoor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoThroughtTheDoor.Name = "btnGoThroughtTheDoor";
            this.btnGoThroughtTheDoor.Size = new System.Drawing.Size(345, 28);
            this.btnGoThroughtTheDoor.TabIndex = 3;
            this.btnGoThroughtTheDoor.Text = "Passe pela porta";
            this.btnGoThroughtTheDoor.UseVisualStyleBackColor = true;
            this.btnGoThroughtTheDoor.Visible = false;
            this.btnGoThroughtTheDoor.Click += new System.EventHandler(this.btnGoThroughtTheDoor_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(17, 277);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(345, 28);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 314);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(345, 28);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Se esconda!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 359);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnGoThroughtTheDoor);
            this.Controls.Add(this.ddlExits);
            this.Controls.Add(this.btnGoHere);
            this.Controls.Add(this.txtDescription);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnStart;
    }
}

