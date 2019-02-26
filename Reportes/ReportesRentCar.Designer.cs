namespace RentCarGonzalez.Reportes
{
    partial class ReportesRentCar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.datefechaFin = new System.Windows.Forms.DateTimePicker();
            this.datefechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCriterio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rentCarDataSet = new RentCarGonzalez.rentCarDataSet();
            this.rentCarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSetAct = new RentCarGonzalez.rentCarDataSetAct();
            this.rentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentaTableAdapter = new RentCarGonzalez.rentCarDataSetActTableAdapters.RentaTableAdapter();
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            this.rentCarDataSet1 = new RentCarGonzalez.rentCarDataSet1();
            this.reportevehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportevehiculosTableAdapter = new RentCarGonzalez.rentCarDataSet1TableAdapters.ReportevehiculosTableAdapter();
            this.vehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportevehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaFin);
            this.groupBox1.Controls.Add(this.datefechaFin);
            this.groupBox1.Controls.Add(this.datefechaInicio);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboCriterio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(320, 63);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 9;
            this.lblFechaFin.Text = "Fecha Fin";
            this.lblFechaFin.Visible = false;
            // 
            // datefechaFin
            // 
            this.datefechaFin.Location = new System.Drawing.Point(380, 57);
            this.datefechaFin.Name = "datefechaFin";
            this.datefechaFin.Size = new System.Drawing.Size(200, 20);
            this.datefechaFin.TabIndex = 8;
            this.datefechaFin.Visible = false;
            // 
            // datefechaInicio
            // 
            this.datefechaInicio.Location = new System.Drawing.Point(90, 57);
            this.datefechaInicio.Name = "datefechaInicio";
            this.datefechaInicio.Size = new System.Drawing.Size(200, 20);
            this.datefechaInicio.TabIndex = 7;
            this.datefechaInicio.Visible = false;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(19, 57);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(64, 13);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha inicio";
            this.lblFechaInicio.Visible = false;
            // 
            // btnReport
            // 
            this.btnReport.Image = global::RentCarGonzalez.Properties.Resources.Product_sale_report_icon;
            this.btnReport.Location = new System.Drawing.Point(643, 52);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 34);
            this.btnReport.TabIndex = 5;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::RentCarGonzalez.Properties.Resources.search_icon1;
            this.btnBuscar.Location = new System.Drawing.Point(643, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(380, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar";
            // 
            // comboCriterio
            // 
            this.comboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriterio.FormattingEnabled = true;
            this.comboCriterio.Items.AddRange(new object[] {
            "Tipo Vehiculo",
            "Fecha",
            "Combustible"});
            this.comboCriterio.Location = new System.Drawing.Point(90, 17);
            this.comboCriterio.Name = "comboCriterio";
            this.comboCriterio.Size = new System.Drawing.Size(200, 21);
            this.comboCriterio.TabIndex = 1;
            this.comboCriterio.SelectedIndexChanged += new System.EventHandler(this.comboCriterio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // rentCarDataSet
            // 
            this.rentCarDataSet.DataSetName = "rentCarDataSet";
            this.rentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentCarDataSetBindingSource
            // 
            this.rentCarDataSetBindingSource.DataSource = this.rentCarDataSet;
            this.rentCarDataSetBindingSource.Position = 0;
            // 
            // rentCarDataSetAct
            // 
            this.rentCarDataSetAct.DataSetName = "rentCarDataSetAct";
            this.rentCarDataSetAct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentaBindingSource
            // 
            this.rentaBindingSource.DataMember = "Renta";
            this.rentaBindingSource.DataSource = this.rentCarDataSetAct;
            // 
            // rentaTableAdapter
            // 
            this.rentaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.AllowUserToAddRows = false;
            this.dataGridReporte.AllowUserToDeleteRows = false;
            this.dataGridReporte.AutoGenerateColumns = false;
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehiculoDataGridViewTextBoxColumn,
            this.combustibleDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.tipoVehiculoDataGridViewTextBoxColumn,
            this.detalleRentaDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn});
            this.dataGridReporte.DataSource = this.reportevehiculosBindingSource;
            this.dataGridReporte.Location = new System.Drawing.Point(13, 128);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.ReadOnly = true;
            this.dataGridReporte.Size = new System.Drawing.Size(746, 150);
            this.dataGridReporte.TabIndex = 1;
            // 
            // rentCarDataSet1
            // 
            this.rentCarDataSet1.DataSetName = "rentCarDataSet1";
            this.rentCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportevehiculosBindingSource
            // 
            this.reportevehiculosBindingSource.DataMember = "Reportevehiculos";
            this.reportevehiculosBindingSource.DataSource = this.rentCarDataSet1;
            // 
            // reportevehiculosTableAdapter
            // 
            this.reportevehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculoDataGridViewTextBoxColumn
            // 
            this.vehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.HeaderText = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.Name = "vehiculoDataGridViewTextBoxColumn";
            this.vehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // combustibleDataGridViewTextBoxColumn
            // 
            this.combustibleDataGridViewTextBoxColumn.DataPropertyName = "Combustible";
            this.combustibleDataGridViewTextBoxColumn.HeaderText = "Combustible";
            this.combustibleDataGridViewTextBoxColumn.Name = "combustibleDataGridViewTextBoxColumn";
            this.combustibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            this.tipoVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleRentaDataGridViewTextBoxColumn
            // 
            this.detalleRentaDataGridViewTextBoxColumn.DataPropertyName = "DetalleRenta";
            this.detalleRentaDataGridViewTextBoxColumn.HeaderText = "DetalleRenta";
            this.detalleRentaDataGridViewTextBoxColumn.Name = "detalleRentaDataGridViewTextBoxColumn";
            this.detalleRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRentaDataGridViewTextBoxColumn
            // 
            this.fechaRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.HeaderText = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.Name = "fechaRentaDataGridViewTextBoxColumn";
            this.fechaRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportesRentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.dataGridReporte);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportesRentCar";
            this.Text = "ReportesRentCar";
            this.Load += new System.EventHandler(this.ReportesRentCar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportevehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCriterio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker datefechaFin;
        private System.Windows.Forms.DateTimePicker datefechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.BindingSource rentCarDataSetBindingSource;
        private rentCarDataSet rentCarDataSet;
        private rentCarDataSetAct rentCarDataSetAct;
        private System.Windows.Forms.BindingSource rentaBindingSource;
        private rentCarDataSetActTableAdapters.RentaTableAdapter rentaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridReporte;
        private rentCarDataSet1 rentCarDataSet1;
        private System.Windows.Forms.BindingSource reportevehiculosBindingSource;
        private rentCarDataSet1TableAdapters.ReportevehiculosTableAdapter reportevehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
    }
}