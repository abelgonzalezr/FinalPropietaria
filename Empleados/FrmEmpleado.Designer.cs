namespace RentCarGonzalez.Empleados
{
    partial class FrmEmpleado
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
            this.dataGridEmpleados = new System.Windows.Forms.DataGridView();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSetAct = new RentCarGonzalez.rentCarDataSetAct();
            this.empleadoTableAdapter = new RentCarGonzalez.rentCarDataSetActTableAdapters.EmpleadoTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.datasetCedula = new RentCarGonzalez.DatasetCedula();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter1 = new RentCarGonzalez.DatasetCedulaTableAdapters.EmpleadoTableAdapter();
            this.empleadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::RentCarGonzalez.Properties.Resources.search_icon1;
            this.btnBuscar.Location = new System.Drawing.Point(566, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(82, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(366, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // dataGridEmpleados
            // 
            this.dataGridEmpleados.AllowUserToAddRows = false;
            this.dataGridEmpleados.AllowUserToDeleteRows = false;
            this.dataGridEmpleados.AutoGenerateColumns = false;
            this.dataGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.decisionDataGridViewTextBoxColumn,
            this.cedula,
            this.numeroTelefonoDataGridViewTextBoxColumn});
            this.dataGridEmpleados.DataSource = this.empleadoBindingSource2;
            this.dataGridEmpleados.Location = new System.Drawing.Point(32, 124);
            this.dataGridEmpleados.Name = "dataGridEmpleados";
            this.dataGridEmpleados.ReadOnly = true;
            this.dataGridEmpleados.Size = new System.Drawing.Size(553, 139);
            this.dataGridEmpleados.TabIndex = 1;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.rentCarDataSetAct;
            // 
            // rentCarDataSetAct
            // 
            this.rentCarDataSetAct.DataSetName = "rentCarDataSetAct";
            this.rentCarDataSetAct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::RentCarGonzalez.Properties.Resources.Add_icon;
            this.btnAdd.Location = new System.Drawing.Point(591, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::RentCarGonzalez.Properties.Resources.edit_validated_icon;
            this.btnEdit.Location = new System.Drawing.Point(591, 173);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::RentCarGonzalez.Properties.Resources.Button_Close_icon__1_;
            this.btnDelete.Location = new System.Drawing.Point(591, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // datasetCedula
            // 
            this.datasetCedula.DataSetName = "DatasetCedula";
            this.datasetCedula.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataMember = "Empleado";
            this.empleadoBindingSource1.DataSource = this.datasetCedula;
            // 
            // empleadoTableAdapter1
            // 
            this.empleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // empleadoBindingSource2
            // 
            this.empleadoBindingSource2.DataMember = "Empleado";
            this.empleadoBindingSource2.DataSource = this.datasetCedula;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // decisionDataGridViewTextBoxColumn
            // 
            this.decisionDataGridViewTextBoxColumn.DataPropertyName = "Decision";
            this.decisionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.decisionDataGridViewTextBoxColumn.Name = "decisionDataGridViewTextBoxColumn";
            this.decisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula";
            this.cedula.HeaderText = "cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // numeroTelefonoDataGridViewTextBoxColumn
            // 
            this.numeroTelefonoDataGridViewTextBoxColumn.DataPropertyName = "numeroTelefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.HeaderText = "numeroTelefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.Name = "numeroTelefonoDataGridViewTextBoxColumn";
            this.numeroTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 276);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridEmpleados);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmpleado";
            this.Text = "Formulario de Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridEmpleados;
        private rentCarDataSetAct rentCarDataSetAct;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private rentCarDataSetActTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private DatasetCedula datasetCedula;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private DatasetCedulaTableAdapters.EmpleadoTableAdapter empleadoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoBindingSource2;
    }
}