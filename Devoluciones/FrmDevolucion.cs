using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Devoluciones
{
    public partial class btnBack : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public btnBack()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetfinal.Renta' table. You can move, or remove it, as needed.
            this.rentaTableAdapter1.Fill(this.rentCarDataSetfinal.Renta);
            // TODO: This line of code loads data into the 'rentCarDataSetAct.Renta' table. You can move, or remove it, as needed.
            //this.rentaTableAdapter.Fill(this.rentCarDataSetAct.Renta);
            // TODO: This line of code loads data into the 'vehiculosrentados.VehiculosRentados' table. You can move, or remove it, as needed.
            //this.vehiculosRentadosTableAdapter.Fill(this.vehiculosrentados.VehiculosRentados);
            // TODO: This line of code loads data into the 'rentCarDataSet3.VehiculosRentados' table. You can move, or remove it, as needed.
          
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int idvehiculo = Int32.Parse(comboRenta.SelectedValue.ToString());

            Boolean estadorenta = false;
            var inspeccion = from re in entities.procesoInspeccions
                          where re.IdVehiculo ==  idvehiculo
                          select re;
            var inspecciones = inspeccion.ToList();
            //renta.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(comboRenta.SelectedValue.ToString());
            var vehiculos = from re in entities.vehiculos
                        where re.IdVehiculos == value
                        select re;
            comboVehiculo.DisplayMember = "Nombre";
            comboVehiculo.ValueMember = "IdVehiculo";
            var hola = vehiculos.ToList();
            comboVehiculo.DataSource = vehiculos.ToList();
        }
    }
}
