namespace RentCarGonzalez.Devoluciones
{
    partial class btnBack
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.vehiculosRentadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosrentados = new RentCarGonzalez.vehiculosrentados();
            this.label2 = new System.Windows.Forms.Label();
            this.comboInspeccion = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vehiculosRentadosTableAdapter = new RentCarGonzalez.vehiculosrentadosTableAdapters.VehiculosRentadosTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRenta = new System.Windows.Forms.ComboBox();
            this.rentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSetAct = new RentCarGonzalez.rentCarDataSetAct();
            this.rentaTableAdapter = new RentCarGonzalez.rentCarDataSetActTableAdapters.RentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosRentadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosrentados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(117, 44);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(121, 21);
            this.comboVehiculo.TabIndex = 1;
            // 
            // vehiculosRentadosBindingSource
            // 
            this.vehiculosRentadosBindingSource.DataMember = "VehiculosRentados";
            this.vehiculosRentadosBindingSource.DataSource = this.vehiculosrentados;
            // 
            // vehiculosrentados
            // 
            this.vehiculosrentados.DataSetName = "vehiculosrentados";
            this.vehiculosrentados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inspeccion";
            // 
            // comboInspeccion
            // 
            this.comboInspeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInspeccion.FormattingEnabled = true;
            this.comboInspeccion.Items.AddRange(new object[] {
            "Completa",
            "Incompleta"});
            this.comboInspeccion.Location = new System.Drawing.Point(117, 88);
            this.comboInspeccion.Name = "comboInspeccion";
            this.comboInspeccion.Size = new System.Drawing.Size(121, 21);
            this.comboInspeccion.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::RentCarGonzalez.Properties.Resources.Save_icon__1_;
            this.btnsave.Location = new System.Drawing.Point(247, 156);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 49);
            this.btnsave.TabIndex = 5;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button1
            // 
            this.button1.Image = global::RentCarGonzalez.Properties.Resources.Go_back_icon;
            this.button1.Location = new System.Drawing.Point(33, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vehiculosRentadosTableAdapter
            // 
            this.vehiculosRentadosTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Renta";
            // 
            // comboRenta
            // 
            this.comboRenta.DataSource = this.rentaBindingSource;
            this.comboRenta.DisplayMember = "DetalleRenta";
            this.comboRenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRenta.FormattingEnabled = true;
            this.comboRenta.Location = new System.Drawing.Point(117, 4);
            this.comboRenta.Name = "comboRenta";
            this.comboRenta.Size = new System.Drawing.Size(121, 21);
            this.comboRenta.TabIndex = 8;
            this.comboRenta.ValueMember = "IdVehiculo";
            this.comboRenta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // btnBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 254);
            this.Controls.Add(this.comboRenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.comboInspeccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboVehiculo);
            this.Controls.Add(this.label1);
            this.Name = "btnBack";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.btnBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosRentadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosrentados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboInspeccion;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button1;
        private vehiculosrentados vehiculosrentados;
        private System.Windows.Forms.BindingSource vehiculosRentadosBindingSource;
        private vehiculosrentadosTableAdapters.VehiculosRentadosTableAdapter vehiculosRentadosTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRenta;
        private rentCarDataSetAct rentCarDataSetAct;
        private System.Windows.Forms.BindingSource rentaBindingSource;
        private rentCarDataSetActTableAdapters.RentaTableAdapter rentaTableAdapter;
    }
}