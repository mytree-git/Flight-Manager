namespace Final_Project
{
    partial class ManageFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFlights));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDCity = new System.Windows.Forms.TextBox();
            this.txtACity = new System.Windows.Forms.TextBox();
            this.dtDDate = new System.Windows.Forms.DateTimePicker();
            this.dtADate = new System.Windows.Forms.DateTimePicker();
            this.cmbAirlineID = new System.Windows.Forms.ComboBox();
            this.airlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesManager = new Final_Project.AirlinesManager();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsTableAdapter = new Final_Project.AirlinesManagerTableAdapters.FlightsTableAdapter();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.flightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.airlinesTableAdapter = new Final_Project.AirlinesManagerTableAdapters.AirlinesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departure City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Airline";
            // 
            // txtDCity
            // 
            this.txtDCity.Location = new System.Drawing.Point(250, 40);
            this.txtDCity.Name = "txtDCity";
            this.txtDCity.Size = new System.Drawing.Size(100, 26);
            this.txtDCity.TabIndex = 5;
            // 
            // txtACity
            // 
            this.txtACity.Location = new System.Drawing.Point(855, 40);
            this.txtACity.Name = "txtACity";
            this.txtACity.Size = new System.Drawing.Size(100, 26);
            this.txtACity.TabIndex = 6;
            // 
            // dtDDate
            // 
            this.dtDDate.Location = new System.Drawing.Point(250, 137);
            this.dtDDate.Name = "dtDDate";
            this.dtDDate.Size = new System.Drawing.Size(200, 26);
            this.dtDDate.TabIndex = 7;
            // 
            // dtADate
            // 
            this.dtADate.Location = new System.Drawing.Point(855, 143);
            this.dtADate.Name = "dtADate";
            this.dtADate.Size = new System.Drawing.Size(200, 26);
            this.dtADate.TabIndex = 8;
            // 
            // cmbAirlineID
            // 
            this.cmbAirlineID.DataSource = this.airlinesBindingSource;
            this.cmbAirlineID.DisplayMember = "AirlineID";
            this.cmbAirlineID.FormattingEnabled = true;
            this.cmbAirlineID.Location = new System.Drawing.Point(250, 219);
            this.cmbAirlineID.Name = "cmbAirlineID";
            this.cmbAirlineID.Size = new System.Drawing.Size(121, 28);
            this.cmbAirlineID.TabIndex = 9;
            this.cmbAirlineID.ValueMember = "AirlineID";
            // 
            // airlinesBindingSource
            // 
            this.airlinesBindingSource.DataMember = "Airlines";
            this.airlinesBindingSource.DataSource = this.airlinesManager;
            // 
            // airlinesManager
            // 
            this.airlinesManager.DataSetName = "AirlinesManager";
            this.airlinesManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airlinesManager;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvFlights
            // 
            this.dgvFlights.AutoGenerateColumns = false;
            this.dgvFlights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.airlinesDataGridViewTextBoxColumn});
            this.dgvFlights.DataSource = this.flightsBindingSource1;
            this.dgvFlights.Location = new System.Drawing.Point(31, 324);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowTemplate.Height = 28;
            this.dgvFlights.Size = new System.Drawing.Size(1033, 255);
            this.dgvFlights.TabIndex = 10;
            this.dgvFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlights_CellContentClick);
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            this.flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.HeaderText = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            this.flightIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DepartureCity";
            this.dataGridViewTextBoxColumn1.HeaderText = "DepartureCity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ArrivalCity";
            this.dataGridViewTextBoxColumn2.HeaderText = "ArrivalCity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartureDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DepartureDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ArrivalDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ArrivalDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(715, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // airlinesTableAdapter
            // 
            this.airlinesTableAdapter.ClearBeforeFill = true;
            // 
            // ManageFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1195, 601);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.cmbAirlineID);
            this.Controls.Add(this.dtADate);
            this.Controls.Add(this.dtDDate);
            this.Controls.Add(this.txtACity);
            this.Controls.Add(this.txtDCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageFlights";
            this.Text = "ManageFlights";
            this.Load += new System.EventHandler(this.ManageFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDCity;
        private System.Windows.Forms.TextBox txtACity;
        private System.Windows.Forms.DateTimePicker dtDDate;
        private System.Windows.Forms.DateTimePicker dtADate;
        private System.Windows.Forms.ComboBox cmbAirlineID;
        private AirlinesManager airlinesManager;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirlinesManagerTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightsBindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource airlinesBindingSource;
        private AirlinesManagerTableAdapters.AirlinesTableAdapter airlinesTableAdapter;
    }
}