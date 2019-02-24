﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Vehiculos
{
    public partial class FrmAddVehiculos : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public int values { get; set; }
        public FrmAddVehiculos()
        {
            InitializeComponent();
        }

        private void FrmAddVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet.tiposDeCombustible' table. You can move, or remove it, as needed.
            this.tiposDeCombustibleTableAdapter.Fill(this.rentCarDataSet.tiposDeCombustible);
            // TODO: This line of code loads data into the 'rentCarDataSet.TipoVehiculo' table. You can move, or remove it, as needed.
            this.tipoVehiculoTableAdapter.Fill(this.rentCarDataSet.TipoVehiculo);
            // TODO: This line of code loads data into the 'rentCarDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.rentCarDataSet.Marcas);

            if (this.values != 0)
            {
                var vehiculo = entities.vehiculos.Find(this.values);
                txtNombre.Text = vehiculo.Nombre;
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.values != 0)
            {
                var vehiculo = entities.vehiculos.Find(this.values);
                vehiculo.Nombre = txtNombre.Text;
                entities.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                MessageBox.Show("Datos editados con exito");
            }
            else
            {
                entities.vehiculos.Add(new vehiculo
                {
                    Nombre = txtNombre.Text,
                    IdMarca = Int32.Parse(comboMarca.SelectedValue.ToString()),
                    IdTipoVehiculo= Int32.Parse(ComboTipoVehiculo.SelectedValue.ToString()),
                    IdCombustible= Int32.Parse(ComboCombustible.SelectedValue.ToString())
                });
                entities.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
            }
            this.Hide();
            FrmVehiculos mar = new FrmVehiculos();
            mar.ShowDialog();
        }
    }
}