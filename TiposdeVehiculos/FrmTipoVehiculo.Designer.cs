namespace RentCarGonzalez.TiposdeVehiculo
{
    partial class FrmTipoVehiculo
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipoVehiculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentcarddatasetUltimate = new RentCarGonzalez.RentcarddatasetUltimate();
            this.tipoVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSet = new RentCarGonzalez.rentCarDataSet();
            this.tipoVehiculoTableAdapter = new RentCarGonzalez.rentCarDataSetTableAdapters.TipoVehiculoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoVehiculoTableAdapter1 = new RentCarGonzalez.RentcarddatasetUltimateTableAdapters.TipoVehiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarddatasetUltimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Image = global::RentCarGonzalez.Properties.Resources.Add_icon;
            this.btnadd.Location = new System.Drawing.Point(345, 90);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 46);
            this.btnadd.TabIndex = 0;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::RentCarGonzalez.Properties.Resources.edit_validated_icon;
            this.btnedit.Location = new System.Drawing.Point(345, 142);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 46);
            this.btnedit.TabIndex = 1;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::RentCarGonzalez.Properties.Resources.Button_Close_icon__1_;
            this.btndelete.Location = new System.Drawing.Point(345, 195);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 46);
            this.btndelete.TabIndex = 2;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoVehiculoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.estado});
            this.dataGridView1.DataSource = this.tipoVehiculoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(327, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idTipoVehiculoDataGridViewTextBoxColumn
            // 
            this.idTipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.HeaderText = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.Name = "idTipoVehiculoDataGridViewTextBoxColumn";
            this.idTipoVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // tipoVehiculoBindingSource1
            // 
            this.tipoVehiculoBindingSource1.DataMember = "TipoVehiculo";
            this.tipoVehiculoBindingSource1.DataSource = this.rentcarddatasetUltimate;
            // 
            // rentcarddatasetUltimate
            // 
            this.rentcarddatasetUltimate.DataSetName = "RentcarddatasetUltimate";
            this.rentcarddatasetUltimate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoVehiculoBindingSource
            // 
            this.tipoVehiculoBindingSource.DataMember = "TipoVehiculo";
            this.tipoVehiculoBindingSource.DataSource = this.rentCarDataSet;
            // 
            // rentCarDataSet
            // 
            this.rentCarDataSet.DataSetName = "rentCarDataSet";
            this.rentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoVehiculoTableAdapter
            // 
            this.tipoVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::RentCarGonzalez.Properties.Resources.search_icon1;
            this.btnbuscar.Location = new System.Drawing.Point(333, 7);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 49);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(53, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(190, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // tipoVehiculoTableAdapter1
            // 
            this.tipoVehiculoTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Name = "FrmTipoVehiculo";
            this.Text = "Tipo Vehiculo";
            this.Load += new System.EventHandler(this.FrmTipoVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarddatasetUltimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rentCarDataSet rentCarDataSet;
        private System.Windows.Forms.BindingSource tipoVehiculoBindingSource;
        private rentCarDataSetTableAdapters.TipoVehiculoTableAdapter tipoVehiculoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private RentcarddatasetUltimate rentcarddatasetUltimate;
        private System.Windows.Forms.BindingSource tipoVehiculoBindingSource1;
        private RentcarddatasetUltimateTableAdapters.TipoVehiculoTableAdapter tipoVehiculoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
    }
}