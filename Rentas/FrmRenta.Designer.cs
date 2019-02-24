namespace RentCarGonzalez.Rentas
{
    partial class FrmRenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRenta = new System.Windows.Forms.DataGridView();
            this.idRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSetAct = new RentCarGonzalez.rentCarDataSetAct();
            this.rentaTableAdapter = new RentCarGonzalez.rentCarDataSetActTableAdapters.RentaTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateTimebuscar = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimebuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::RentCarGonzalez.Properties.Resources.search_icon;
            this.btnBuscar.Location = new System.Drawing.Point(651, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 48);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // dataGridRenta
            // 
            this.dataGridRenta.AllowUserToAddRows = false;
            this.dataGridRenta.AllowUserToDeleteRows = false;
            this.dataGridRenta.AutoGenerateColumns = false;
            this.dataGridRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRentaDataGridViewTextBoxColumn,
            this.idVehiculoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.detalleRentaDataGridViewTextBoxColumn});
            this.dataGridRenta.DataSource = this.rentaBindingSource;
            this.dataGridRenta.Location = new System.Drawing.Point(13, 108);
            this.dataGridRenta.Name = "dataGridRenta";
            this.dataGridRenta.ReadOnly = true;
            this.dataGridRenta.Size = new System.Drawing.Size(645, 150);
            this.dataGridRenta.TabIndex = 1;
            // 
            // idRentaDataGridViewTextBoxColumn
            // 
            this.idRentaDataGridViewTextBoxColumn.DataPropertyName = "IdRenta";
            this.idRentaDataGridViewTextBoxColumn.HeaderText = "IdRenta";
            this.idRentaDataGridViewTextBoxColumn.Name = "idRentaDataGridViewTextBoxColumn";
            this.idRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            this.idVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRentaDataGridViewTextBoxColumn
            // 
            this.fechaRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.HeaderText = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.Name = "fechaRentaDataGridViewTextBoxColumn";
            this.fechaRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleRentaDataGridViewTextBoxColumn
            // 
            this.detalleRentaDataGridViewTextBoxColumn.DataPropertyName = "DetalleRenta";
            this.detalleRentaDataGridViewTextBoxColumn.HeaderText = "DetalleRenta";
            this.detalleRentaDataGridViewTextBoxColumn.Name = "detalleRentaDataGridViewTextBoxColumn";
            this.detalleRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentaBindingSource
            // 
            this.rentaBindingSource.DataMember = "Renta";
            this.rentaBindingSource.DataSource = this.rentCarDataSetAct;
            // 
            // rentCarDataSetAct
            // 
            this.rentCarDataSetAct.DataSetName = "rentCarDataSetAct";
            this.rentCarDataSetAct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentaTableAdapter
            // 
            this.rentaTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::RentCarGonzalez.Properties.Resources.Button_Close_icon__1_;
            this.btnDelete.Location = new System.Drawing.Point(665, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::RentCarGonzalez.Properties.Resources.edit_validated_icon;
            this.btnEdit.Location = new System.Drawing.Point(665, 164);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 46);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::RentCarGonzalez.Properties.Resources.Add_icon;
            this.btnAdd.Location = new System.Drawing.Point(665, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimebuscar
            // 
            this.dateTimebuscar.Location = new System.Drawing.Point(54, 29);
            this.dateTimebuscar.Name = "dateTimebuscar";
            this.dateTimebuscar.Size = new System.Drawing.Size(591, 20);
            this.dateTimebuscar.TabIndex = 2;
            // 
            // FrmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 271);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridRenta);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRenta";
            this.Text = "Formulario de Renta";
            this.Load += new System.EventHandler(this.FrmRenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridRenta;
        private rentCarDataSetAct rentCarDataSetAct;
        private System.Windows.Forms.BindingSource rentaBindingSource;
        private rentCarDataSetActTableAdapters.RentaTableAdapter rentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateTimebuscar;
    }
}