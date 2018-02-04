namespace Final_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAirlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFlightsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAirlines = new System.Windows.Forms.TabPage();
            this.dgvAirlines = new System.Windows.Forms.DataGridView();
            this.airlineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesManager = new Final_Project.AirlinesManager();
            this.tabFlights = new System.Windows.Forms.TabPage();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.flightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesTableAdapter = new Final_Project.AirlinesManagerTableAdapters.AirlinesTableAdapter();
            this.flightsTableAdapter = new Final_Project.AirlinesManagerTableAdapters.FlightsTableAdapter();
            this.customerTableAdapter = new Final_Project.AirlinesManagerTableAdapters.CustomerTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAirlines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManager)).BeginInit();
            this.tabFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).BeginInit();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPTIONSToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPTIONSToolStripMenuItem
            // 
            this.oPTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAirlinesToolStripMenuItem,
            this.manageFlightsToolStripMenuItem1,
            this.manageCustomersToolStripMenuItem});
            this.oPTIONSToolStripMenuItem.Name = "oPTIONSToolStripMenuItem";
            this.oPTIONSToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.oPTIONSToolStripMenuItem.Text = "OPTIONS";
            // 
            // manageAirlinesToolStripMenuItem
            // 
            this.manageAirlinesToolStripMenuItem.Name = "manageAirlinesToolStripMenuItem";
            this.manageAirlinesToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.manageAirlinesToolStripMenuItem.Text = "Manage Airlines";
            this.manageAirlinesToolStripMenuItem.Click += new System.EventHandler(this.manageAirlinesToolStripMenuItem_Click);
            // 
            // manageFlightsToolStripMenuItem1
            // 
            this.manageFlightsToolStripMenuItem1.Name = "manageFlightsToolStripMenuItem1";
            this.manageFlightsToolStripMenuItem1.Size = new System.Drawing.Size(251, 30);
            this.manageFlightsToolStripMenuItem1.Text = "Manage Flights";
            this.manageFlightsToolStripMenuItem1.Click += new System.EventHandler(this.manageFlightsToolStripMenuItem1_Click);
            // 
            // manageCustomersToolStripMenuItem
            // 
            this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.manageCustomersToolStripMenuItem.Text = "Manage Customers";
            this.manageCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageCustomersToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAirlines);
            this.tabControl1.Controls.Add(this.tabFlights);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Location = new System.Drawing.Point(13, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 337);
            this.tabControl1.TabIndex = 1;
            // 
            // tabAirlines
            // 
            this.tabAirlines.BackColor = System.Drawing.Color.MistyRose;
            this.tabAirlines.Controls.Add(this.dgvAirlines);
            this.tabAirlines.Location = new System.Drawing.Point(4, 29);
            this.tabAirlines.Name = "tabAirlines";
            this.tabAirlines.Padding = new System.Windows.Forms.Padding(3);
            this.tabAirlines.Size = new System.Drawing.Size(912, 304);
            this.tabAirlines.TabIndex = 0;
            this.tabAirlines.Text = "View Airlines";
            // 
            // dgvAirlines
            // 
            this.dgvAirlines.AutoGenerateColumns = false;
            this.dgvAirlines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirlines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airlineIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.mealDataGridViewTextBoxColumn});
            this.dgvAirlines.DataSource = this.airlinesBindingSource2;
            this.dgvAirlines.Location = new System.Drawing.Point(30, 19);
            this.dgvAirlines.Name = "dgvAirlines";
            this.dgvAirlines.RowTemplate.Height = 28;
            this.dgvAirlines.Size = new System.Drawing.Size(833, 270);
            this.dgvAirlines.TabIndex = 0;
            // 
            // airlineIDDataGridViewTextBoxColumn
            // 
            this.airlineIDDataGridViewTextBoxColumn.DataPropertyName = "AirlineID";
            this.airlineIDDataGridViewTextBoxColumn.HeaderText = "AirlineID";
            this.airlineIDDataGridViewTextBoxColumn.Name = "airlineIDDataGridViewTextBoxColumn";
            this.airlineIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AirlineType";
            this.dataGridViewTextBoxColumn1.HeaderText = "AirlineType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SeatsAvailable";
            this.dataGridViewTextBoxColumn7.HeaderText = "SeatsAvailable";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // mealDataGridViewTextBoxColumn
            // 
            this.mealDataGridViewTextBoxColumn.DataPropertyName = "Meal";
            this.mealDataGridViewTextBoxColumn.HeaderText = "Meal";
            this.mealDataGridViewTextBoxColumn.Name = "mealDataGridViewTextBoxColumn";
            // 
            // airlinesBindingSource2
            // 
            this.airlinesBindingSource2.DataMember = "Airlines";
            this.airlinesBindingSource2.DataSource = this.airlinesManager;
            // 
            // airlinesManager
            // 
            this.airlinesManager.DataSetName = "AirlinesManager";
            this.airlinesManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabFlights
            // 
            this.tabFlights.BackColor = System.Drawing.Color.MistyRose;
            this.tabFlights.Controls.Add(this.dgvFlights);
            this.tabFlights.Location = new System.Drawing.Point(4, 29);
            this.tabFlights.Name = "tabFlights";
            this.tabFlights.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlights.Size = new System.Drawing.Size(1008, 304);
            this.tabFlights.TabIndex = 1;
            this.tabFlights.Text = "View Flights";
            // 
            // dgvFlights
            // 
            this.dgvFlights.AutoGenerateColumns = false;
            this.dgvFlights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.airlinesDataGridViewTextBoxColumn});
            this.dgvFlights.DataSource = this.flightsBindingSource1;
            this.dgvFlights.Location = new System.Drawing.Point(6, 22);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowTemplate.Height = 28;
            this.dgvFlights.Size = new System.Drawing.Size(969, 241);
            this.dgvFlights.TabIndex = 0;
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            this.flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.HeaderText = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            this.flightIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartureCity";
            this.dataGridViewTextBoxColumn3.HeaderText = "DepartureCity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ArrivalCity";
            this.dataGridViewTextBoxColumn4.HeaderText = "ArrivalCity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepartureDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepartureDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ArrivalDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "ArrivalDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // airlinesDataGridViewTextBoxColumn
            // 
            this.airlinesDataGridViewTextBoxColumn.DataPropertyName = "Airlines";
            this.airlinesDataGridViewTextBoxColumn.HeaderText = "Airlines";
            this.airlinesDataGridViewTextBoxColumn.Name = "airlinesDataGridViewTextBoxColumn";
            // 
            // flightsBindingSource1
            // 
            this.flightsBindingSource1.DataMember = "Flights";
            this.flightsBindingSource1.DataSource = this.airlinesManager;
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.Color.MistyRose;
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 29);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(912, 304);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "View Customers";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvCustomers.DataSource = this.customerBindingSource;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 19);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(876, 279);
            this.dgvCustomers.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.airlinesManager;
            // 
            // airlinesBindingSource1
            // 
            this.airlinesBindingSource1.DataMember = "Airlines";
            this.airlinesBindingSource1.DataSource = this.airlinesManager;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airlinesManager;
            // 
            // airlinesBindingSource
            // 
            this.airlinesBindingSource.DataMember = "Airlines";
            this.airlinesBindingSource.DataSource = this.airlinesManager;
            // 
            // airlinesTableAdapter
            // 
            this.airlinesTableAdapter.ClearBeforeFill = true;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(715, 453);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(214, 53);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "REFRESH DATA";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 620);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAirlines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManager)).EndInit();
            this.tabFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPTIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAirlinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFlightsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAirlines;
        private System.Windows.Forms.TabPage tabFlights;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private AirlinesManager airlinesManager;
        private System.Windows.Forms.BindingSource airlinesBindingSource;
        private AirlinesManagerTableAdapters.AirlinesTableAdapter airlinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirlinesManagerTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AirlinesManagerTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource airlinesBindingSource1;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightsBindingSource1;
        private System.Windows.Forms.DataGridView dgvAirlines;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource airlinesBindingSource2;
        private System.Windows.Forms.Button btnRefresh;
    }
}