namespace RentCarGonzalez.Vehiculos
{
    partial class FrmVehiculos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datGridVehiculos = new System.Windows.Forms.DataGridView();
            this.idVehiculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCombustibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSet = new RentCarGonzalez.rentCarDataSet();
            this.vehiculosTableAdapter = new RentCarGonzalez.rentCarDataSetTableAdapters.vehiculosTableAdapter();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datGridVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::RentCarGonzalez.Properties.Resources.search_icon1;
            this.btnBuscar.Location = new System.Drawing.Point(549, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(52, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(464, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // datGridVehiculos
            // 
            this.datGridVehiculos.AllowUserToAddRows = false;
            this.datGridVehiculos.AllowUserToDeleteRows = false;
            this.datGridVehiculos.AutoGenerateColumns = false;
            this.datGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculosDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idMarcaDataGridViewTextBoxColumn,
            this.idTipoVehiculoDataGridViewTextBoxColumn,
            this.idCombustibleDataGridViewTextBoxColumn});
            this.datGridVehiculos.DataSource = this.vehiculosBindingSource;
            this.datGridVehiculos.Location = new System.Drawing.Point(29, 130);
            this.datGridVehiculos.Name = "datGridVehiculos";
            this.datGridVehiculos.ReadOnly = true;
            this.datGridVehiculos.Size = new System.Drawing.Size(546, 150);
            this.datGridVehiculos.TabIndex = 1;
            // 
            // idVehiculosDataGridViewTextBoxColumn
            // 
            this.idVehiculosDataGridViewTextBoxColumn.DataPropertyName = "IdVehiculos";
            this.idVehiculosDataGridViewTextBoxColumn.HeaderText = "IdVehiculos";
            this.idVehiculosDataGridViewTextBoxColumn.Name = "idVehiculosDataGridViewTextBoxColumn";
            this.idVehiculosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMarcaDataGridViewTextBoxColumn
            // 
            this.idMarcaDataGridViewTextBoxColumn.DataPropertyName = "IdMarca";
            this.idMarcaDataGridViewTextBoxColumn.HeaderText = "IdMarca";
            this.idMarcaDataGridViewTextBoxColumn.Name = "idMarcaDataGridViewTextBoxColumn";
            this.idMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTipoVehiculoDataGridViewTextBoxColumn
            // 
            this.idTipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.HeaderText = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.Name = "idTipoVehiculoDataGridViewTextBoxColumn";
            this.idTipoVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCombustibleDataGridViewTextBoxColumn
            // 
            this.idCombustibleDataGridViewTextBoxColumn.DataPropertyName = "IdCombustible";
            this.idCombustibleDataGridViewTextBoxColumn.HeaderText = "IdCombustible";
            this.idCombustibleDataGridViewTextBoxColumn.Name = "idCombustibleDataGridViewTextBoxColumn";
            this.idCombustibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "vehiculos";
            this.vehiculosBindingSource.DataSource = this.rentCarDataSet;
            // 
            // rentCarDataSet
            // 
            this.rentCarDataSet.DataSetName = "rentCarDataSet";
            this.rentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // btnadd
            // 
            this.btnadd.Image = global::RentCarGonzalez.Properties.Resources.Add_icon;
            this.btnadd.Location = new System.Drawing.Point(584, 130);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 42);
            this.btnadd.TabIndex = 2;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::RentCarGonzalez.Properties.Resources.edit_validated_icon;
            this.btnedit.Location = new System.Drawing.Point(584, 178);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 42);
            this.btnedit.TabIndex = 3;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::RentCarGonzalez.Properties.Resources.Button_Close_icon__1_;
            this.btndelete.Location = new System.Drawing.Point(584, 238);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 42);
            this.btndelete.TabIndex = 4;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 310);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.datGridVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datGridVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datGridVehiculos;
        private rentCarDataSet rentCarDataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private rentCarDataSetTableAdapters.vehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCombustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
    }
}