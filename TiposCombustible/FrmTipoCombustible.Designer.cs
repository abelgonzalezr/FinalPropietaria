namespace RentCarGonzalez.TiposCombustible
{
    partial class FrmTipoCombustible
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
            this.tiposDeCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridcombustible = new System.Windows.Forms.DataGridView();
            this.rentCarDataSet1 = new RentCarGonzalez.rentCarDataSet();
            this.tiposDeCombustibleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDeCombustibleTableAdapter1 = new RentCarGonzalez.rentCarDataSetTableAdapters.tiposDeCombustibleTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tiposDeCombustibleBindingSource
            // 
            this.tiposDeCombustibleBindingSource.DataMember = "tiposDeCombustible";
            // 
            // btnadd
            // 
            this.btnadd.Image = global::RentCarGonzalez.Properties.Resources.Add_icon;
            this.btnadd.Location = new System.Drawing.Point(281, 82);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 43);
            this.btnadd.TabIndex = 1;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::RentCarGonzalez.Properties.Resources.edit_validated_icon;
            this.btnedit.Location = new System.Drawing.Point(281, 131);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 43);
            this.btnedit.TabIndex = 2;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::RentCarGonzalez.Properties.Resources.Button_Close_icon__1_;
            this.btndelete.Location = new System.Drawing.Point(281, 180);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 43);
            this.btndelete.TabIndex = 3;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::RentCarGonzalez.Properties.Resources.search_icon1;
            this.btnbuscar.Location = new System.Drawing.Point(269, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 45);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(54, 20);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(186, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // datagridcombustible
            // 
            this.datagridcombustible.AllowUserToAddRows = false;
            this.datagridcombustible.AllowUserToDeleteRows = false;
            this.datagridcombustible.AutoGenerateColumns = false;
            this.datagridcombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcombustible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.datagridcombustible.DataSource = this.tiposDeCombustibleBindingSource1;
            this.datagridcombustible.Location = new System.Drawing.Point(12, 82);
            this.datagridcombustible.Name = "datagridcombustible";
            this.datagridcombustible.ReadOnly = true;
            this.datagridcombustible.Size = new System.Drawing.Size(240, 150);
            this.datagridcombustible.TabIndex = 5;
            // 
            // rentCarDataSet1
            // 
            this.rentCarDataSet1.DataSetName = "rentCarDataSet";
            this.rentCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDeCombustibleBindingSource1
            // 
            this.tiposDeCombustibleBindingSource1.DataMember = "tiposDeCombustible";
            this.tiposDeCombustibleBindingSource1.DataSource = this.rentCarDataSet1;
            // 
            // tiposDeCombustibleTableAdapter1
            // 
            this.tiposDeCombustibleTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCombustible";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCombustible";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmTipoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 234);
            this.Controls.Add(this.datagridcombustible);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Name = "FrmTipoCombustible";
            this.Text = "FrmTipoCombustible";
            this.Load += new System.EventHandler(this.FrmTipoCombustible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCombustibleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private rentCarDataSet rentCarDataSet;
        private System.Windows.Forms.BindingSource tiposDeCombustibleBindingSource;
        private rentCarDataSetTableAdapters.tiposDeCombustibleTableAdapter tiposDeCombustibleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCombustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridcombustible;
        private rentCarDataSet rentCarDataSet1;
        private System.Windows.Forms.BindingSource tiposDeCombustibleBindingSource1;
        private rentCarDataSetTableAdapters.tiposDeCombustibleTableAdapter tiposDeCombustibleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}