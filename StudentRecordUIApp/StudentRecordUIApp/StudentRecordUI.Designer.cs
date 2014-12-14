namespace StudentRecordUIApp
{
    partial class StudentRecordUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.regNotextBox = new System.Windows.Forms.TextBox();
            this.naMetextBox = new System.Windows.Forms.TextBox();
            this.saVebutton = new System.Windows.Forms.Button();
            this.Showbutton = new System.Windows.Forms.Button();
            this.studentRecordlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // regNotextBox
            // 
            this.regNotextBox.Location = new System.Drawing.Point(136, 25);
            this.regNotextBox.Name = "regNotextBox";
            this.regNotextBox.Size = new System.Drawing.Size(226, 20);
            this.regNotextBox.TabIndex = 2;
            // 
            // naMetextBox
            // 
            this.naMetextBox.Location = new System.Drawing.Point(136, 57);
            this.naMetextBox.Name = "naMetextBox";
            this.naMetextBox.Size = new System.Drawing.Size(226, 20);
            this.naMetextBox.TabIndex = 3;
            // 
            // saVebutton
            // 
            this.saVebutton.Location = new System.Drawing.Point(136, 100);
            this.saVebutton.Name = "saVebutton";
            this.saVebutton.Size = new System.Drawing.Size(87, 23);
            this.saVebutton.TabIndex = 4;
            this.saVebutton.Text = "Save";
            this.saVebutton.UseVisualStyleBackColor = true;
            this.saVebutton.Click += new System.EventHandler(this.saVebutton_Click);
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(279, 99);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(82, 23);
            this.Showbutton.TabIndex = 5;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // studentRecordlistBox
            // 
            this.studentRecordlistBox.FormattingEnabled = true;
            this.studentRecordlistBox.Location = new System.Drawing.Point(136, 150);
            this.studentRecordlistBox.Name = "studentRecordlistBox";
            this.studentRecordlistBox.Size = new System.Drawing.Size(226, 251);
            this.studentRecordlistBox.TabIndex = 6;
            // 
            // StudentRecordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 445);
            this.Controls.Add(this.studentRecordlistBox);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.saVebutton);
            this.Controls.Add(this.naMetextBox);
            this.Controls.Add(this.regNotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentRecordUI";
            this.Text = "StudentRecordUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regNotextBox;
        private System.Windows.Forms.TextBox naMetextBox;
        private System.Windows.Forms.Button saVebutton;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.ListBox studentRecordlistBox;
    }
}

