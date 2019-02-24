using RentCarGonzalez.TiposdeVehiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.TiposdeVehiculos
{
    public partial class FrmAddTipoVehiculo : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public int values { get; set; }
        public FrmAddTipoVehiculo()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            if (comboestado.SelectedValue.ToString() == "1")
            {
                estado = true;
            }
            if (this.values != 0)
            {
                var tipoVehiculo = entities.TipoVehiculoes.Find(this.values);
                tipoVehiculo.Nombre = txtNombre.Text;
                tipoVehiculo.estado = estado;
                entities.Entry(tipoVehiculo).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                MessageBox.Show("Datos editados con exito");
            }
            else
            {
                entities.TipoVehiculoes.Add(new TipoVehiculo
                {
                    Nombre = txtNombre.Text,
                    estado= Boolean.Parse(comboestado.SelectedValue.ToString())
            });
                entities.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
            }
            this.Hide();
            FrmTipoVehiculo mar = new FrmTipoVehiculo();
            mar.ShowDialog();
        }

        private void FrmAddTipoVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet2.estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.rentCarDataSet2.estados);
            if (this.values != 0)
            {
                var tipoVehiculo = entities.TipoVehiculoes.Find(this.values);
                txtNombre.Text = tipoVehiculo.Nombre;
            }
        }
    }
}
