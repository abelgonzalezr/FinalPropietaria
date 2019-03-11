namespace RentCarGonzalez.Rentas
{
    partial class FrmAddRenta
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
            this.combovehiculo = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.txtDetalleRenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fecharenta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.rentCarDataSetfinal = new RentCarGonzalez.rentCarDataSetfinal();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.vehiculosTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.ClientesTableAdapter();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.EmpleadoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combovehiculo);
            this.groupBox1.Controls.Add(this.comboCliente);
            this.groupBox1.Controls.Add(this.comboEmpleado);
            this.groupBox1.Controls.Add(this.txtDetalleRenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fecharenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de renta";
            // 
            // combovehiculo
            // 
            this.combovehiculo.DataSource = this.vehiculosBindingSource;
            this.combovehiculo.DisplayMember = "Nombre";
            this.combovehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combovehiculo.FormattingEnabled = true;
            this.combovehiculo.Location = new System.Drawing.Point(96, 32);
            this.combovehiculo.Name = "combovehiculo";
            this.combovehiculo.Size = new System.Drawing.Size(200, 21);
            this.combovehiculo.TabIndex = 9;
            this.combovehiculo.ValueMember = "IdVehiculos";
            this.combovehiculo.SelectedIndexChanged += new System.EventHandler(this.combovehiculo_SelectedIndexChanged);
            // 
            // comboCliente
            // 
            this.comboCliente.DataSource = this.clientesBindingSource;
            this.comboCliente.DisplayMember = "Nombre";
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(96, 62);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(200, 21);
            this.comboCliente.TabIndex = 8;
            this.comboCliente.ValueMember = "IdCliente";
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.DataSource = this.empleadoBindingSource;
            this.comboEmpleado.DisplayMember = "Nombre";
            this.comboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(96, 100);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(200, 21);
            this.comboEmpleado.TabIndex = 7;
            this.comboEmpleado.ValueMember = "IdEmpleado";
            // 
            // txtDetalleRenta
            // 
            this.txtDetalleRenta.Location = new System.Drawing.Point(96, 185);
            this.txtDetalleRenta.Name = "txtDetalleRenta";
            this.txtDetalleRenta.Size = new System.Drawing.Size(200, 20);
            this.txtDetalleRenta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Renta";
            // 
            // fecharenta
            // 
            this.fecharenta.Location = new System.Drawing.Point(96, 143);
            this.fecharenta.Name = "fecharenta";
            this.fecharenta.Size = new System.Drawing.Size(200, 20);
            this.fecharenta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detalle Renta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clienta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculo";
            // 
            // btnback
            // 
            this.btnback.Image = global::RentCarGonzalez.Properties.Resources.Go_back_icon;
            this.btnback.Location = new System.Drawing.Point(12, 266);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(64, 55);
            this.btnback.TabIndex = 1;
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::RentCarGonzalez.Properties.Resources.Save_icon__1_;
            this.btnsave.Location = new System.Drawing.Point(267, 266);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(65, 55);
            this.btnsave.TabIndex = 2;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rentCarDataSetfinal
            // 
            this.rentCarDataSetfinal.DataSetName = "rentCarDataSetfinal";
            this.rentCarDataSetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "vehiculos";
            this.vehiculosBindingSource.DataSource = this.rentCarDataSetfinal;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.rentCarDataSetfinal;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.rentCarDataSetfinal;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 347);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddRenta";
            this.Text = "Formulario de renta";
            this.Load += new System.EventHandler(this.FrmAddRenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.TextBox txtDetalleRenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecharenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox comboCliente;
        protected internal System.Windows.Forms.ComboBox combovehiculo;
        private rentCarDataSetfinal rentCarDataSetfinal;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private rentCarDataSetfinalTableAdapters.vehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private rentCarDataSetfinalTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private rentCarDataSetfinalTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
    }
}