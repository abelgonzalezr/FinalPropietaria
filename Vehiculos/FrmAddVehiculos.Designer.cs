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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Combustible = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ComboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.ComboCombustible = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.rentCarDataSet = new RentCarGonzalez.rentCarDataSet();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new RentCarGonzalez.rentCarDataSetTableAdapters.MarcasTableAdapter();
            this.tipoVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoVehiculoTableAdapter = new RentCarGonzalez.rentCarDataSetTableAdapters.TipoVehiculoTableAdapter();
            this.tiposDeCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDeCombustibleTableAdapter = new RentCarGonzalez.rentCarDataSetTableAdapters.tiposDeCombustibleTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMarca
            // 
            this.comboMarca.DataSource = this.marcasBindingSource;
            this.comboMarca.DisplayMember = "Nombre";
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(97, 72);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(307, 21);
            this.comboMarca.TabIndex = 0;
            this.comboMarca.ValueMember = "IdMarca";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(410, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de vehiculo";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Vehiculo";
            // 
            // Combustible
            // 
            this.Combustible.AutoSize = true;
            this.Combustible.Location = new System.Drawing.Point(10, 143);
            this.Combustible.Name = "Combustible";
            this.Combustible.Size = new System.Drawing.Size(64, 13);
            this.Combustible.TabIndex = 4;
            this.Combustible.Text = "Combustible";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(307, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // ComboTipoVehiculo
            // 
            this.ComboTipoVehiculo.DataSource = this.tipoVehiculoBindingSource;
            this.ComboTipoVehiculo.DisplayMember = "Nombre";
            this.ComboTipoVehiculo.FormattingEnabled = true;
            this.ComboTipoVehiculo.Location = new System.Drawing.Point(97, 101);
            this.ComboTipoVehiculo.Name = "ComboTipoVehiculo";
            this.ComboTipoVehiculo.Size = new System.Drawing.Size(307, 21);
            this.ComboTipoVehiculo.TabIndex = 6;
            this.ComboTipoVehiculo.ValueMember = "IdTipoVehiculo";
            // 
            // ComboCombustible
            // 
            this.ComboCombustible.DataSource = this.tiposDeCombustibleBindingSource;
            this.ComboCombustible.DisplayMember = "Nombre";
            this.ComboCombustible.FormattingEnabled = true;
            this.ComboCombustible.Location = new System.Drawing.Point(97, 143);
            this.ComboCombustible.Name = "ComboCombustible";
            this.ComboCombustible.Size = new System.Drawing.Size(307, 21);
            this.ComboCombustible.TabIndex = 7;
            this.ComboCombustible.ValueMember = "IdCombustible";
            // 
            // btnback
            // 
            this.btnback.Image = global::RentCarGonzalez.Properties.Resources.Go_back_icon;
            this.btnback.Location = new System.Drawing.Point(12, 251);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(61, 44);
            this.btnback.TabIndex = 2;
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::RentCarGonzalez.Properties.Resources.Save_icon__1_;
            this.btnsave.Location = new System.Drawing.Point(361, 251);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(61, 43);
            this.btnsave.TabIndex = 3;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rentCarDataSet
            // 
            this.rentCarDataSet.DataSetName = "rentCarDataSet";
            this.rentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.rentCarDataSet;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // tipoVehiculoBindingSource
            // 
            this.tipoVehiculoBindingSource.DataMember = "TipoVehiculo";
            this.tipoVehiculoBindingSource.DataSource = this.rentCarDataSet;
            // 
            // tipoVehiculoTableAdapter
            // 
            this.tipoVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tiposDeCombustibleBindingSource
            // 
            this.tiposDeCombustibleBindingSource.DataMember = "tiposDeCombustible";
            this.tiposDeCombustibleBindingSource.DataSource = this.rentCarDataSet;
            // 
            // tiposDeCombustibleTableAdapter
            // 
            this.tiposDeCombustibleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 309);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddVehiculos";
            this.Text = "FrmAddVehiculos";
            this.Load += new System.EventHandler(this.FrmAddVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource)).EndInit();
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
        private rentCarDataSet rentCarDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private rentCarDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource tipoVehiculoBindingSource;
        private rentCarDataSetTableAdapters.TipoVehiculoTableAdapter tipoVehiculoTableAdapter;
        private System.Windows.Forms.BindingSource tiposDeCombustibleBindingSource;
        private rentCarDataSetTableAdapters.tiposDeCombustibleTableAdapter tiposDeCombustibleTableAdapter;
    }
}