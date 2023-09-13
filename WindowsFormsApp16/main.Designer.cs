namespace WindowsFormsApp16
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.djikstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightDetailsToolStripMenuItem,
            this.customerDetailsToolStripMenuItem,
            this.ticketDetailsToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.lagguageToolStripMenuItem,
            this.kruskalToolStripMenuItem,
            this.djikstraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // flightDetailsToolStripMenuItem
            // 
            this.flightDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFlightToolStripMenuItem,
            this.searchFlightToolStripMenuItem,
            this.sortFlightsToolStripMenuItem});
            this.flightDetailsToolStripMenuItem.Name = "flightDetailsToolStripMenuItem";
            this.flightDetailsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.flightDetailsToolStripMenuItem.Text = "Flight Details";
            // 
            // addNewFlightToolStripMenuItem
            // 
            this.addNewFlightToolStripMenuItem.Name = "addNewFlightToolStripMenuItem";
            this.addNewFlightToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewFlightToolStripMenuItem.Text = "Add New Flight";
            this.addNewFlightToolStripMenuItem.Click += new System.EventHandler(this.addNewFlightToolStripMenuItem_Click);
            // 
            // searchFlightToolStripMenuItem
            // 
            this.searchFlightToolStripMenuItem.Name = "searchFlightToolStripMenuItem";
            this.searchFlightToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchFlightToolStripMenuItem.Text = "Search Flight ";
            this.searchFlightToolStripMenuItem.Click += new System.EventHandler(this.searchFlightToolStripMenuItem_Click);
            // 
            // sortFlightsToolStripMenuItem
            // 
            this.sortFlightsToolStripMenuItem.Name = "sortFlightsToolStripMenuItem";
            this.sortFlightsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sortFlightsToolStripMenuItem.Text = "Sort Flights";
            this.sortFlightsToolStripMenuItem.Click += new System.EventHandler(this.sortFlightsToolStripMenuItem_Click);
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.searchCustomerToolStripMenuItem,
            this.sortCustomerToolStripMenuItem});
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // searchCustomerToolStripMenuItem
            // 
            this.searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            this.searchCustomerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.searchCustomerToolStripMenuItem.Text = "Search Customer";
            this.searchCustomerToolStripMenuItem.Click += new System.EventHandler(this.searchCustomerToolStripMenuItem_Click);
            // 
            // sortCustomerToolStripMenuItem
            // 
            this.sortCustomerToolStripMenuItem.Name = "sortCustomerToolStripMenuItem";
            this.sortCustomerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sortCustomerToolStripMenuItem.Text = "Sort Customer";
            this.sortCustomerToolStripMenuItem.Click += new System.EventHandler(this.sortCustomerToolStripMenuItem_Click);
            // 
            // ticketDetailsToolStripMenuItem
            // 
            this.ticketDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTicketToolStripMenuItem});
            this.ticketDetailsToolStripMenuItem.Name = "ticketDetailsToolStripMenuItem";
            this.ticketDetailsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.ticketDetailsToolStripMenuItem.Text = "Ticket Details";
            // 
            // addNewTicketToolStripMenuItem
            // 
            this.addNewTicketToolStripMenuItem.Name = "addNewTicketToolStripMenuItem";
            this.addNewTicketToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.addNewTicketToolStripMenuItem.Text = "Book Ticket";
            this.addNewTicketToolStripMenuItem.Click += new System.EventHandler(this.addNewTicketToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lagguageToolStripMenuItem
            // 
            this.lagguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lagyageToolStripMenuItem});
            this.lagguageToolStripMenuItem.Name = "lagguageToolStripMenuItem";
            this.lagguageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.lagguageToolStripMenuItem.Text = "Lagguage";
            // 
            // lagyageToolStripMenuItem
            // 
            this.lagyageToolStripMenuItem.Name = "lagyageToolStripMenuItem";
            this.lagyageToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.lagyageToolStripMenuItem.Text = "lagyage";
            this.lagyageToolStripMenuItem.Click += new System.EventHandler(this.lagyageToolStripMenuItem_Click);
            // 
            // kruskalToolStripMenuItem
            // 
            this.kruskalToolStripMenuItem.Name = "kruskalToolStripMenuItem";
            this.kruskalToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kruskalToolStripMenuItem.Text = "Kruskal";
            this.kruskalToolStripMenuItem.Click += new System.EventHandler(this.kruskalToolStripMenuItem_Click);
            // 
            // djikstraToolStripMenuItem
            // 
            this.djikstraToolStripMenuItem.Name = "djikstraToolStripMenuItem";
            this.djikstraToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.djikstraToolStripMenuItem.Text = "Djikstra";
            this.djikstraToolStripMenuItem.Click += new System.EventHandler(this.djikstraToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp16.Properties.Resources.air11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagyageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kruskalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem djikstraToolStripMenuItem;
    }
}