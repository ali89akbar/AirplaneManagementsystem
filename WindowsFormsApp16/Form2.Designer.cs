namespace WindowsFormsApp16
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.fathertxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer_Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Father_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Address";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(232, 97);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(208, 20);
            this.nametxt.TabIndex = 2;
            // 
            // fathertxt
            // 
            this.fathertxt.Location = new System.Drawing.Point(232, 131);
            this.fathertxt.Name = "fathertxt";
            this.fathertxt.Size = new System.Drawing.Size(208, 20);
            this.fathertxt.TabIndex = 2;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(232, 192);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(208, 20);
            this.emailtxt.TabIndex = 2;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(232, 228);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(208, 20);
            this.phonetxt.TabIndex = 2;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(232, 260);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(208, 62);
            this.addresstxt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(232, 166);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(208, 20);
            this.birthdate.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp16.Properties.Resources.air3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 574);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.fathertxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Customerdetails";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox fathertxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker birthdate;
    }
}