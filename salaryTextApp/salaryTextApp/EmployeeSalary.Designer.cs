namespace salaryTextApp
{
    partial class EmployeeSalary
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.naMetextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.salaRytextBox = new System.Windows.Forms.TextBox();
            this.saVebutton = new System.Windows.Forms.Button();
            this.ShoWbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totaltextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary Amount";
            // 
            // naMetextBox
            // 
            this.naMetextBox.Location = new System.Drawing.Point(101, 33);
            this.naMetextBox.Name = "naMetextBox";
            this.naMetextBox.Size = new System.Drawing.Size(283, 20);
            this.naMetextBox.TabIndex = 3;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(101, 69);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(283, 20);
            this.IDtextBox.TabIndex = 4;
            // 
            // salaRytextBox
            // 
            this.salaRytextBox.Location = new System.Drawing.Point(101, 105);
            this.salaRytextBox.Name = "salaRytextBox";
            this.salaRytextBox.Size = new System.Drawing.Size(283, 20);
            this.salaRytextBox.TabIndex = 5;
            // 
            // saVebutton
            // 
            this.saVebutton.Location = new System.Drawing.Point(308, 157);
            this.saVebutton.Name = "saVebutton";
            this.saVebutton.Size = new System.Drawing.Size(75, 23);
            this.saVebutton.TabIndex = 6;
            this.saVebutton.Text = "Save";
            this.saVebutton.UseVisualStyleBackColor = true;
            this.saVebutton.Click += new System.EventHandler(this.saVebutton_Click);
            // 
            // ShoWbutton
            // 
            this.ShoWbutton.Location = new System.Drawing.Point(307, 206);
            this.ShoWbutton.Name = "ShoWbutton";
            this.ShoWbutton.Size = new System.Drawing.Size(75, 23);
            this.ShoWbutton.TabIndex = 7;
            this.ShoWbutton.Text = "Show";
            this.ShoWbutton.UseVisualStyleBackColor = true;
            this.ShoWbutton.Click += new System.EventHandler(this.ShoWbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(101, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 134);
            this.listBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // totaltextbox
            // 
            this.totaltextbox.Location = new System.Drawing.Point(273, 402);
            this.totaltextbox.Name = "totaltextbox";
            this.totaltextbox.Size = new System.Drawing.Size(111, 20);
            this.totaltextbox.TabIndex = 10;
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 455);
            this.Controls.Add(this.totaltextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShoWbutton);
            this.Controls.Add(this.saVebutton);
            this.Controls.Add(this.salaRytextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.naMetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeSalary";
            this.Text = "EmployeeSalary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox naMetextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox salaRytextBox;
        private System.Windows.Forms.Button saVebutton;
        private System.Windows.Forms.Button ShoWbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totaltextbox;
    }
}

