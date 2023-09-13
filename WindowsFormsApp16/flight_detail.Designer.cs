namespace WindowsFormsApp16
{
    partial class flight_detail
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flightnametxt = new System.Windows.Forms.TextBox();
            this.destinationtxt = new System.Windows.Forms.TextBox();
            this.sourcetxt = new System.Windows.Forms.TextBox();
            this.arrivaltxt = new System.Windows.Forms.TextBox();
            this.departuretxt = new System.Windows.Forms.TextBox();
            this.classtxt = new System.Windows.Forms.TextBox();
            this.chargetxt = new System.Windows.Forms.TextBox();
            this.seatstxt = new System.Windows.Forms.TextBox();
            this.Add_Flight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Source";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Arrival_time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Departure_time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Flight_Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Flight_Charges";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Seats";
            // 
            // flightnametxt
            // 
            this.flightnametxt.Location = new System.Drawing.Point(171, 76);
            this.flightnametxt.Name = "flightnametxt";
            this.flightnametxt.Size = new System.Drawing.Size(186, 20);
            this.flightnametxt.TabIndex = 2;
            // 
            // destinationtxt
            // 
            this.destinationtxt.Location = new System.Drawing.Point(171, 155);
            this.destinationtxt.Name = "destinationtxt";
            this.destinationtxt.Size = new System.Drawing.Size(186, 20);
            this.destinationtxt.TabIndex = 2;
            // 
            // sourcetxt
            // 
            this.sourcetxt.Location = new System.Drawing.Point(171, 115);
            this.sourcetxt.Name = "sourcetxt";
            this.sourcetxt.Size = new System.Drawing.Size(186, 20);
            this.sourcetxt.TabIndex = 2;
            this.sourcetxt.TextChanged += new System.EventHandler(this.sourcetxt_TextChanged);
            // 
            // arrivaltxt
            // 
            this.arrivaltxt.Location = new System.Drawing.Point(171, 196);
            this.arrivaltxt.Name = "arrivaltxt";
            this.arrivaltxt.Size = new System.Drawing.Size(186, 20);
            this.arrivaltxt.TabIndex = 2;
            // 
            // departuretxt
            // 
            this.departuretxt.Location = new System.Drawing.Point(171, 231);
            this.departuretxt.Name = "departuretxt";
            this.departuretxt.Size = new System.Drawing.Size(186, 20);
            this.departuretxt.TabIndex = 2;
            // 
            // classtxt
            // 
            this.classtxt.Location = new System.Drawing.Point(171, 269);
            this.classtxt.Name = "classtxt";
            this.classtxt.Size = new System.Drawing.Size(186, 20);
            this.classtxt.TabIndex = 2;
            // 
            // chargetxt
            // 
            this.chargetxt.Location = new System.Drawing.Point(171, 308);
            this.chargetxt.Name = "chargetxt";
            this.chargetxt.Size = new System.Drawing.Size(186, 20);
            this.chargetxt.TabIndex = 2;
            // 
            // seatstxt
            // 
            this.seatstxt.Location = new System.Drawing.Point(171, 344);
            this.seatstxt.Name = "seatstxt";
            this.seatstxt.Size = new System.Drawing.Size(186, 20);
            this.seatstxt.TabIndex = 2;
            // 
            // Add_Flight
            // 
            this.Add_Flight.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add_Flight.Location = new System.Drawing.Point(171, 384);
            this.Add_Flight.Name = "Add_Flight";
            this.Add_Flight.Size = new System.Drawing.Size(103, 23);
            this.Add_Flight.TabIndex = 3;
            this.Add_Flight.Text = "Add_Flight";
            this.Add_Flight.UseVisualStyleBackColor = true;
            this.Add_Flight.Click += new System.EventHandler(this.Add_Flight_Click);
            // 
            // flight_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp16.Properties.Resources.air5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_Flight);
            this.Controls.Add(this.sourcetxt);
            this.Controls.Add(this.seatstxt);
            this.Controls.Add(this.chargetxt);
            this.Controls.Add(this.classtxt);
            this.Controls.Add(this.departuretxt);
            this.Controls.Add(this.arrivaltxt);
            this.Controls.Add(this.destinationtxt);
            this.Controls.Add(this.flightnametxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "flight_detail";
            this.Text = "flight_detail";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox flightnametxt;
        private System.Windows.Forms.TextBox destinationtxt;
        private System.Windows.Forms.TextBox sourcetxt;
        private System.Windows.Forms.TextBox arrivaltxt;
        private System.Windows.Forms.TextBox departuretxt;
        private System.Windows.Forms.TextBox classtxt;
        private System.Windows.Forms.TextBox chargetxt;
        private System.Windows.Forms.TextBox seatstxt;
        private System.Windows.Forms.Button Add_Flight;
    }
}