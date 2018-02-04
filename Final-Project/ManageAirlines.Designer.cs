namespace Final_Project
{
    partial class ManageAirlines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAirlines));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.airlinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesManager = new Final_Project.AirlinesManager();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.airlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesTableAdapter = new Final_Project.AirlinesManagerTableAdapters.AirlinesTableAdapter();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.airlinesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAirlines = new System.Windows.Forms.DataGridView();
            this.airlineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Airline Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seats Available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Meal";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(187, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(187, 131);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 26);
            this.txtType.TabIndex = 5;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(187, 220);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(100, 26);
            this.txtSeats.TabIndex = 6;
            // 
            // cmbID
            // 
            this.cmbID.DataSource = this.airlinesBindingSource1;
            this.cmbID.DisplayMember = "AirlineID";
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(542, 45);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(242, 28);
            this.cmbID.TabIndex = 8;
            this.cmbID.ValueMember = "AirlineID";
            // 
            // airlinesBindingSource1
            // 
            this.airlinesBindingSource1.DataMember = "Airlines";
            this.airlinesBindingSource1.DataSource = this.airlinesManager;
            // 
            // airlinesManager
            // 
            this.airlinesManager.DataSetName = "AirlinesManager";
            this.airlinesManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(542, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(242, 51);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(542, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(242, 46);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(542, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(242, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // airlinesBindingSource
            // 
            this.airlinesBindingSource.DataMember = "Airlines";
            this.airlinesBindingSource.DataSource = this.airlinesManager;
            // 
            // airlinesManagerBindingSource
            // 
            this.airlinesManagerBindingSource.DataSource = this.airlinesManager;
            this.airlinesManagerBindingSource.Position = 0;
            // 
            // airlinesTableAdapter
            // 
            this.airlinesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMeals
            // 
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Location = new System.Drawing.Point(187, 295);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(121, 28);
            this.cmbMeals.TabIndex = 13;
            // 
            // airlinesBindingSource2
            // 
            this.airlinesBindingSource2.DataMember = "Airlines";
            this.airlinesBindingSource2.DataSource = this.airlinesManager;
            // 
            // airlinesBindingSource3
            // 
            this.airlinesBindingSource3.DataMember = "Airlines";
            this.airlinesBindingSource3.DataSource = this.airlinesManager;
            // 
            // dgvAirlines
            // 
            this.dgvAirlines.AutoGenerateColumns = false;
            this.dgvAirlines.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirlines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airlineIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.mealDataGridViewTextBoxColumn});
            this.dgvAirlines.DataSource = this.airlinesBindingSource4;
            this.dgvAirlines.Location = new System.Drawing.Point(30, 379);
            this.dgvAirlines.Name = "dgvAirlines";
            this.dgvAirlines.RowTemplate.Height = 28;
            this.dgvAirlines.Size = new System.Drawing.Size(828, 232);
            this.dgvAirlines.TabIndex = 14;
            this.dgvAirlines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SeatsAvailable";
            this.dataGridViewTextBoxColumn3.HeaderText = "SeatsAvailable";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // mealDataGridViewTextBoxColumn
            // 
            this.mealDataGridViewTextBoxColumn.DataPropertyName = "Meal";
            this.mealDataGridViewTextBoxColumn.HeaderText = "Meal";
            this.mealDataGridViewTextBoxColumn.Name = "mealDataGridViewTextBoxColumn";
            // 
            // airlinesBindingSource4
            // 
            this.airlinesBindingSource4.DataMember = "Airlines";
            this.airlinesBindingSource4.DataSource = this.airlinesManager;
            // 
            // ManageAirlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1148, 648);
            this.Controls.Add(this.dgvAirlines);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageAirlines";
            this.Text = "ManageAirlines";
            this.Load += new System.EventHandler(this.ManageAirlines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource airlinesManagerBindingSource;
        private AirlinesManager airlinesManager;
        private System.Windows.Forms.BindingSource airlinesBindingSource;
        private AirlinesManagerTableAdapters.AirlinesTableAdapter airlinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource airlinesBindingSource1;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.BindingSource airlinesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource airlinesBindingSource3;
        private System.Windows.Forms.DataGridView dgvAirlines;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource airlinesBindingSource4;
    }
}