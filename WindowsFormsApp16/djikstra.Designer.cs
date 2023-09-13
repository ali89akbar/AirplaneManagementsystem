namespace WindowsFormsApp16
{
    partial class djikstra
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
            this.lblDestination5 = new System.Windows.Forms.Label();
            this.lblDestination6 = new System.Windows.Forms.Label();
            this.lblDestination7 = new System.Windows.Forms.Label();
            this.lblDestination4 = new System.Windows.Forms.Label();
            this.lblDestination3 = new System.Windows.Forms.Label();
            this.lblDestination2 = new System.Windows.Forms.Label();
            this.lblDestination1 = new System.Windows.Forms.Label();
            this.txtSourceCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrundjikstra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDestination5
            // 
            this.lblDestination5.AutoSize = true;
            this.lblDestination5.Location = new System.Drawing.Point(551, 264);
            this.lblDestination5.Name = "lblDestination5";
            this.lblDestination5.Size = new System.Drawing.Size(35, 13);
            this.lblDestination5.TabIndex = 21;
            this.lblDestination5.Text = "label2";
            // 
            // lblDestination6
            // 
            this.lblDestination6.AutoSize = true;
            this.lblDestination6.Location = new System.Drawing.Point(551, 312);
            this.lblDestination6.Name = "lblDestination6";
            this.lblDestination6.Size = new System.Drawing.Size(35, 13);
            this.lblDestination6.TabIndex = 20;
            this.lblDestination6.Text = "label2";
            // 
            // lblDestination7
            // 
            this.lblDestination7.AutoSize = true;
            this.lblDestination7.Location = new System.Drawing.Point(551, 350);
            this.lblDestination7.Name = "lblDestination7";
            this.lblDestination7.Size = new System.Drawing.Size(35, 13);
            this.lblDestination7.TabIndex = 19;
            this.lblDestination7.Text = "label2";
            // 
            // lblDestination4
            // 
            this.lblDestination4.AutoSize = true;
            this.lblDestination4.Location = new System.Drawing.Point(551, 217);
            this.lblDestination4.Name = "lblDestination4";
            this.lblDestination4.Size = new System.Drawing.Size(35, 13);
            this.lblDestination4.TabIndex = 18;
            this.lblDestination4.Text = "label2";
            // 
            // lblDestination3
            // 
            this.lblDestination3.AutoSize = true;
            this.lblDestination3.Location = new System.Drawing.Point(551, 169);
            this.lblDestination3.Name = "lblDestination3";
            this.lblDestination3.Size = new System.Drawing.Size(35, 13);
            this.lblDestination3.TabIndex = 17;
            this.lblDestination3.Text = "label4";
            // 
            // lblDestination2
            // 
            this.lblDestination2.AutoSize = true;
            this.lblDestination2.Location = new System.Drawing.Point(551, 115);
            this.lblDestination2.Name = "lblDestination2";
            this.lblDestination2.Size = new System.Drawing.Size(35, 13);
            this.lblDestination2.TabIndex = 16;
            this.lblDestination2.Text = "label3";
            // 
            // lblDestination1
            // 
            this.lblDestination1.AutoSize = true;
            this.lblDestination1.Location = new System.Drawing.Point(551, 75);
            this.lblDestination1.Name = "lblDestination1";
            this.lblDestination1.Size = new System.Drawing.Size(35, 13);
            this.lblDestination1.TabIndex = 15;
            this.lblDestination1.Text = "label2";
            // 
            // txtSourceCity
            // 
            this.txtSourceCity.Location = new System.Drawing.Point(350, 108);
            this.txtSourceCity.Name = "txtSourceCity";
            this.txtSourceCity.Size = new System.Drawing.Size(100, 20);
            this.txtSourceCity.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Source-City";
            // 
            // btnrundjikstra
            // 
            this.btnrundjikstra.Location = new System.Drawing.Point(316, 336);
            this.btnrundjikstra.Name = "btnrundjikstra";
            this.btnrundjikstra.Size = new System.Drawing.Size(159, 40);
            this.btnrundjikstra.TabIndex = 12;
            this.btnrundjikstra.Text = "Apply Djisktra";
            this.btnrundjikstra.UseVisualStyleBackColor = true;
            // 
            // djikstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDestination5);
            this.Controls.Add(this.lblDestination6);
            this.Controls.Add(this.lblDestination7);
            this.Controls.Add(this.lblDestination4);
            this.Controls.Add(this.lblDestination3);
            this.Controls.Add(this.lblDestination2);
            this.Controls.Add(this.lblDestination1);
            this.Controls.Add(this.txtSourceCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrundjikstra);
            this.Name = "djikstra";
            this.Text = "djikstra";
            this.Load += new System.EventHandler(this.djikstra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestination5;
        private System.Windows.Forms.Label lblDestination6;
        private System.Windows.Forms.Label lblDestination7;
        private System.Windows.Forms.Label lblDestination4;
        private System.Windows.Forms.Label lblDestination3;
        private System.Windows.Forms.Label lblDestination2;
        private System.Windows.Forms.Label lblDestination1;
        private System.Windows.Forms.TextBox txtSourceCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrundjikstra;
    }
}