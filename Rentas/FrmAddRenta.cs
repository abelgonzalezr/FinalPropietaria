using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Rentas
{
    public partial class FrmAddRenta : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public int values { get; set; }
        public FrmAddRenta()
        {
            InitializeComponent();
        }

        private void FrmAddRenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetAct.vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.rentCarDataSetAct.vehiculos);
            // TODO: This line of code loads data into the 'rentCarDataSetAct.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.rentCarDataSetAct.Clientes);
            // TODO: This line of code loads data into the 'rentCarDataSetAct.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.rentCarDataSetAct.Empleado);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (this.values != 0)
            {
                var renta = entities.Rentas.Find(this.values);
                renta.IdVehiculo = Int32.Parse(combovehiculo.SelectedValue.ToString());
                renta.IdCliente = Int32.Parse(comboCliente.SelectedValue.ToString());
                renta.IdEmpleado = Int32.Parse(comboEmpleado.SelectedValue.ToString());
                renta.FechaRenta = fecharenta.Value;
                renta.DetalleRenta = txtDetalleRenta.Text;
                entities.Entry(renta).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                MessageBox.Show("Datos editados con exito");
            }
            else
            {
                entities.Rentas.Add(new Renta
                {
                    IdVehiculo = Int32.Parse(combovehiculo.SelectedValue.ToString()),
                    IdCliente = Int32.Parse(comboCliente.SelectedValue.ToString()),
                    IdEmpleado = Int32.Parse(comboEmpleado.SelectedValue.ToString()),
                    FechaRenta = fecharenta.Value,
                    DetalleRenta = txtDetalleRenta.Text
            });
                entities.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
            }
            this.Hide();
            FrmRenta mar = new FrmRenta();
            mar.ShowDialog();
        }

        private void combovehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
