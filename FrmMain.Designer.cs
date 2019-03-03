namespace RentCarGonzalez
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInspeccion = new System.Windows.Forms.Button();
            this.btndevolucion = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnCombustible = new System.Windows.Forms.Button();
            this.btnRenta = new System.Windows.Forms.Button();
            this.btnTipoVehiculo = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de interes";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clientes",
            "Empleados",
            "Inspección",
            "Marcas",
            "Modelos",
            "Renta de vehiculo",
            "Tipos de vehiculo",
            "Tipos de combustibles",
            "Vehiculos",
            "Devolucion",
            "Reportes",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(144, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(435, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione gestion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInspeccion);
            this.groupBox2.Controls.Add(this.btndevolucion);
            this.groupBox2.Controls.Add(this.btnModelo);
            this.groupBox2.Controls.Add(this.btnEmpleado);
            this.groupBox2.Controls.Add(this.btnReportes);
            this.groupBox2.Controls.Add(this.btnVehiculos);
            this.groupBox2.Controls.Add(this.btnCombustible);
            this.groupBox2.Controls.Add(this.btnRenta);
            this.groupBox2.Controls.Add(this.btnTipoVehiculo);
            this.groupBox2.Controls.Add(this.btnClientes);
            this.groupBox2.Controls.Add(this.btnMarcas);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 415);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnInspeccion
            // 
            this.btnInspeccion.Image = global::RentCarGonzalez.Properties.Resources.Network_Panel_Settings_icon;
            this.btnInspeccion.Location = new System.Drawing.Point(245, 163);
            this.btnInspeccion.Name = "btnInspeccion";
            this.btnInspeccion.Size = new System.Drawing.Size(131, 108);
            this.btnInspeccion.TabIndex = 12;
            this.btnInspeccion.UseVisualStyleBackColor = true;
            // 
            // btndevolucion
            // 
            this.btndevolucion.Image = global::RentCarGonzalez.Properties.Resources.Undo_icon;
            this.btndevolucion.Location = new System.Drawing.Point(448, 286);
            this.btndevolucion.Name = "btndevolucion";
            this.btndevolucion.Size = new System.Drawing.Size(130, 90);
            this.btndevolucion.TabIndex = 11;
            this.btndevolucion.UseVisualStyleBackColor = true;
            this.btndevolucion.Click += new System.EventHandler(this.btndevolucion_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.Image = global::RentCarGonzalez.Properties.Resources.car_icon;
            this.btnModelo.Location = new System.Drawing.Point(37, 286);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(131, 90);
            this.btnModelo.TabIndex = 10;
            this.btnModelo.UseVisualStyleBackColor = true;
            this.btnModelo.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Image = global::RentCarGonzalez.Properties.Resources.Preppy_icon;
            this.btnEmpleado.Location = new System.Drawing.Point(448, 163);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(130, 108);
            this.btnEmpleado.TabIndex = 9;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Image = global::RentCarGonzalez.Properties.Resources.Preview_icon;
            this.btnReportes.Location = new System.Drawing.Point(313, 286);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(130, 90);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Image = global::RentCarGonzalez.Properties.Resources.cars_icon;
            this.btnVehiculos.Location = new System.Drawing.Point(174, 286);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(131, 90);
            this.btnVehiculos.TabIndex = 7;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCombustible
            // 
            this.btnCombustible.Image = global::RentCarGonzalez.Properties.Resources._42568_fuel_pump_icon__1_;
            this.btnCombustible.Location = new System.Drawing.Point(37, 163);
            this.btnCombustible.Name = "btnCombustible";
            this.btnCombustible.Size = new System.Drawing.Size(131, 108);
            this.btnCombustible.TabIndex = 6;
            this.btnCombustible.UseVisualStyleBackColor = true;
            this.btnCombustible.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRenta
            // 
            this.btnRenta.Image = global::RentCarGonzalez.Properties.Resources.rent_a_car_icon;
            this.btnRenta.Location = new System.Drawing.Point(447, 46);
            this.btnRenta.Name = "btnRenta";
            this.btnRenta.Size = new System.Drawing.Size(131, 94);
            this.btnRenta.TabIndex = 5;
            this.btnRenta.UseVisualStyleBackColor = true;
            this.btnRenta.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTipoVehiculo
            // 
            this.btnTipoVehiculo.Image = global::RentCarGonzalez.Properties.Resources.objects_icon;
            this.btnTipoVehiculo.Location = new System.Drawing.Point(311, 46);
            this.btnTipoVehiculo.Name = "btnTipoVehiculo";
            this.btnTipoVehiculo.Size = new System.Drawing.Size(131, 94);
            this.btnTipoVehiculo.TabIndex = 4;
            this.btnTipoVehiculo.UseVisualStyleBackColor = true;
            this.btnTipoVehiculo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::RentCarGonzalez.Properties.Resources.Clients_icon;
            this.btnClientes.Location = new System.Drawing.Point(174, 46);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(131, 94);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Image = global::RentCarGonzalez.Properties.Resources.repuestos_para_carros_D_NQ_NP_316721_MLV20834796872_072016_F1;
            this.btnMarcas.Location = new System.Drawing.Point(37, 46);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(131, 94);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "González Rent Car";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnTipoVehiculo;
        private System.Windows.Forms.Button btnRenta;
        private System.Windows.Forms.Button btnCombustible;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnModelo;
        private System.Windows.Forms.Button btndevolucion;
        private System.Windows.Forms.Button btnInspeccion;
    }
}

