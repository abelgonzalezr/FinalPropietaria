namespace RentCarGonzalez.Vehiculos
{
    partial class FrmAddVehiculos
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
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtNoChasis = new System.Windows.Forms.TextBox();
            this.txtNoPlaca = new System.Windows.Forms.TextBox();
            this.txtNoMotor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboCombustible = new System.Windows.Forms.ComboBox();
            this.ComboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Combustible = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.rentCarDataSetfinal = new RentCarGonzalez.rentCarDataSetfinal();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.MarcasTableAdapter();
            this.tipoVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoVehiculoTableAdapter = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.TipoVehiculoTableAdapter();
            this.tiposDeCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDeCombustibleTableAdapter = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.tiposDeCombustibleTableAdapter();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.estadosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMarca
            // 
            this.comboMarca.DataSource = this.marcasBindingSource;
            this.comboMarca.DisplayMember = "Nombre";
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(97, 72);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(307, 21);
            this.comboMarca.TabIndex = 0;
            this.comboMarca.ValueMember = "IdMarca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.txtNoChasis);
            this.groupBox1.Controls.Add(this.txtNoPlaca);
            this.groupBox1.Controls.Add(this.txtNoMotor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboCombustible);
            this.groupBox1.Controls.Add(this.ComboTipoVehiculo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.Combustible);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboMarca);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de vehiculo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.DataSource = this.estadosBindingSource;
            this.comboEstado.DisplayMember = "Nombre";
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(97, 278);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(307, 21);
            this.comboEstado.TabIndex = 14;
            this.comboEstado.ValueMember = "value";
            // 
            // txtNoChasis
            // 
            this.txtNoChasis.Location = new System.Drawing.Point(97, 242);
            this.txtNoChasis.Name = "txtNoChasis";
            this.txtNoChasis.Size = new System.Drawing.Size(307, 20);
            this.txtNoChasis.TabIndex = 13;
            // 
            // txtNoPlaca
            // 
            this.txtNoPlaca.Location = new System.Drawing.Point(97, 208);
            this.txtNoPlaca.Name = "txtNoPlaca";
            this.txtNoPlaca.Size = new System.Drawing.Size(307, 20);
            this.txtNoPlaca.TabIndex = 12;
            // 
            // txtNoMotor
            // 
            this.txtNoMotor.Location = new System.Drawing.Point(97, 177);
            this.txtNoMotor.Name = "txtNoMotor";
            this.txtNoMotor.Size = new System.Drawing.Size(307, 20);
            this.txtNoMotor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "No.Chasis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "No.Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "No.Motor";
            // 
            // ComboCombustible
            // 
            this.ComboCombustible.DataSource = this.tiposDeCombustibleBindingSource;
            this.ComboCombustible.DisplayMember = "Nombre";
            this.ComboCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCombustible.FormattingEnabled = true;
            this.ComboCombustible.Location = new System.Drawing.Point(97, 143);
            this.ComboCombustible.Name = "ComboCombustible";
            this.ComboCombustible.Size = new System.Drawing.Size(307, 21);
            this.ComboCombustible.TabIndex = 7;
            this.ComboCombustible.ValueMember = "IdCombustible";
            // 
            // ComboTipoVehiculo
            // 
            this.ComboTipoVehiculo.DataSource = this.tipoVehiculoBindingSource;
            this.ComboTipoVehiculo.DisplayMember = "Nombre";
            this.ComboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoVehiculo.FormattingEnabled = true;
            this.ComboTipoVehiculo.Location = new System.Drawing.Point(97, 101);
            this.ComboTipoVehiculo.Name = "ComboTipoVehiculo";
            this.ComboTipoVehiculo.Size = new System.Drawing.Size(307, 21);
            this.ComboTipoVehiculo.TabIndex = 6;
            this.ComboTipoVehiculo.ValueMember = "IdTipoVehiculo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(307, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // Combustible
            // 
            this.Combustible.AutoSize = true;
            this.Combustible.Location = new System.Drawing.Point(7, 146);
            this.Combustible.Name = "Combustible";
            this.Combustible.Size = new System.Drawing.Size(64, 13);
            this.Combustible.TabIndex = 4;
            this.Combustible.Text = "Combustible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // btnback
            // 
            this.btnback.Image = global::RentCarGonzalez.Properties.Resources.Go_back_icon;
            this.btnback.Location = new System.Drawing.Point(22, 380);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(61, 43);
            this.btnback.TabIndex = 2;
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::RentCarGonzalez.Properties.Resources.Save_icon__1_;
            this.btnsave.Location = new System.Drawing.Point(362, 381);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(61, 43);
            this.btnsave.TabIndex = 3;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rentCarDataSetfinal
            // 
            this.rentCarDataSetfinal.DataSetName = "rentCarDataSetfinal";
            this.rentCarDataSetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.rentCarDataSetfinal;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // tipoVehiculoBindingSource
            // 
            this.tipoVehiculoBindingSource.DataMember = "TipoVehiculo";
            this.tipoVehiculoBindingSource.DataSource = this.rentCarDataSetfinal;
            // 
            // tipoVehiculoTableAdapter
            // 
            this.tipoVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tiposDeCombustibleBindingSource
            // 
            this.tiposDeCombustibleBindingSource.DataMember = "tiposDeCombustible";
            this.tiposDeCombustibleBindingSource.DataSource = this.rentCarDataSetfinal;
            // 
            // tiposDeCombustibleTableAdapter
            // 
            this.tiposDeCombustibleTableAdapter.ClearBeforeFill = true;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.rentCarDataSetfinal;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 509);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddVehiculos";
            this.Text = "Añadir Vehiculo";
            this.Load += new System.EventHandler(this.FrmAddVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboCombustible;
        private System.Windows.Forms.ComboBox ComboTipoVehiculo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Combustible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtNoChasis;
        private System.Windows.Forms.TextBox txtNoPlaca;
        private System.Windows.Forms.TextBox txtNoMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private rentCarDataSetfinal rentCarDataSetfinal;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private rentCarDataSetfinalTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource tipoVehiculoBindingSource;
        private rentCarDataSetfinalTableAdapters.TipoVehiculoTableAdapter tipoVehiculoTableAdapter;
        private System.Windows.Forms.BindingSource tiposDeCombustibleBindingSource;
        private rentCarDataSetfinalTableAdapters.tiposDeCombustibleTableAdapter tiposDeCombustibleTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private rentCarDataSetfinalTableAdapters.estadosTableAdapter estadosTableAdapter;
    }
}