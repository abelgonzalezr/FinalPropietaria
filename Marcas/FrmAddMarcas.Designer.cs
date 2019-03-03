namespace RentCarGonzalez.Marcas
{
    partial class FrmAddMarcas
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
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentCarDataSet2 = new RentCarGonzalez.rentCarDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.estadosTableAdapter = new RentCarGonzalez.rentCarDataSet2TableAdapters.estadosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboestado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboestado
            // 
            this.comboestado.DataSource = this.estadosBindingSource;
            this.comboestado.DisplayMember = "Nombre";
            this.comboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Location = new System.Drawing.Point(107, 69);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(259, 21);
            this.comboestado.TabIndex = 3;
            this.comboestado.ValueMember = "value";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.rentCarDataSet2;
            // 
            // rentCarDataSet2
            // 
            this.rentCarDataSet2.DataSetName = "rentCarDataSet2";
            this.rentCarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::RentCarGonzalez.Properties.Resources.Go_back_icon;
            this.btnBack.Location = new System.Drawing.Point(120, 169);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::RentCarGonzalez.Properties.Resources.Save_icon__1_;
            this.btnsave.Location = new System.Drawing.Point(246, 169);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(55, 39);
            this.btnsave.TabIndex = 1;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 220);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddMarcas";
            this.Text = "Añadir Marca";
            this.Load += new System.EventHandler(this.FrmAddMarcas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboestado;
        private rentCarDataSet2 rentCarDataSet2;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private rentCarDataSet2TableAdapters.estadosTableAdapter estadosTableAdapter;
    }
}