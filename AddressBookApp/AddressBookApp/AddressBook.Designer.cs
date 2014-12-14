namespace AddressBookApp
{
    partial class AddressBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contacttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Showbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameradioButton = new System.Windows.Forms.RadioButton();
            this.contactradioButton = new System.Windows.Forms.RadioButton();
            this.emailradioButton = new System.Windows.Forms.RadioButton();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(122, 23);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(342, 20);
            this.nametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact No.";
            // 
            // contacttextBox
            // 
            this.contacttextBox.Location = new System.Drawing.Point(122, 57);
            this.contacttextBox.Name = "contacttextBox";
            this.contacttextBox.Size = new System.Drawing.Size(342, 20);
            this.contacttextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(122, 94);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(342, 20);
            this.emailtextBox.TabIndex = 5;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(389, 120);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 10;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(150, 552);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(75, 23);
            this.Showbutton.TabIndex = 11;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(122, 120);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 12;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(117, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 225);
            this.listBox1.TabIndex = 13;
            // 
            // nameradioButton
            // 
            this.nameradioButton.AutoSize = true;
            this.nameradioButton.Location = new System.Drawing.Point(328, 179);
            this.nameradioButton.Name = "nameradioButton";
            this.nameradioButton.Size = new System.Drawing.Size(51, 17);
            this.nameradioButton.TabIndex = 14;
            this.nameradioButton.TabStop = true;
            this.nameradioButton.Text = "name";
            this.nameradioButton.UseVisualStyleBackColor = true;
            this.nameradioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // contactradioButton
            // 
            this.contactradioButton.AutoSize = true;
            this.contactradioButton.Location = new System.Drawing.Point(328, 202);
            this.contactradioButton.Name = "contactradioButton";
            this.contactradioButton.Size = new System.Drawing.Size(82, 17);
            this.contactradioButton.TabIndex = 15;
            this.contactradioButton.TabStop = true;
            this.contactradioButton.Text = "Contact No.";
            this.contactradioButton.UseVisualStyleBackColor = true;
            this.contactradioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // emailradioButton
            // 
            this.emailradioButton.AutoSize = true;
            this.emailradioButton.Location = new System.Drawing.Point(329, 225);
            this.emailradioButton.Name = "emailradioButton";
            this.emailradioButton.Size = new System.Drawing.Size(50, 17);
            this.emailradioButton.TabIndex = 16;
            this.emailradioButton.TabStop = true;
            this.emailradioButton.Text = "Email";
            this.emailradioButton.UseVisualStyleBackColor = true;
            this.emailradioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(117, 179);
            this.searchtextBox.Multiline = true;
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(167, 63);
            this.searchtextBox.TabIndex = 17;
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 587);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.emailradioButton);
            this.Controls.Add(this.contactradioButton);
            this.Controls.Add(this.nameradioButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contacttextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddressBook";
            this.Text = "AddressBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contacttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton nameradioButton;
        private System.Windows.Forms.RadioButton contactradioButton;
        private System.Windows.Forms.RadioButton emailradioButton;
        private System.Windows.Forms.TextBox searchtextBox;
    }
}

