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
            this.label2 = new System.Windows.Forms.Label();
            this.comboInspeccion = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRenta = new System.Windows.Forms.ComboBox();
            this.rentCarDataSetfinal = new RentCarGonzalez.rentCarDataSetfinal();
            this.rentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentaTableAdapter1 = new RentCarGonzalez.rentCarDataSetfinalTableAdapters.RentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource1)).BeginInit();
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
            this.comboRenta.DataSource = this.rentaBindingSource1;
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
            // rentCarDataSetfinal
            // 
            this.rentCarDataSetfinal.DataSetName = "rentCarDataSetfinal";
            this.rentCarDataSetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentaBindingSource1
            // 
            this.rentaBindingSource1.DataMember = "Renta";
            this.rentaBindingSource1.DataSource = this.rentCarDataSetfinal;
            // 
            // rentaTableAdapter1
            // 
            this.rentaTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRenta;
        private rentCarDataSetfinal rentCarDataSetfinal;
        private System.Windows.Forms.BindingSource rentaBindingSource1;
        private rentCarDataSetfinalTableAdapters.RentaTableAdapter rentaTableAdapter1;
    }
}