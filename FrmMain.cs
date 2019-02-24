using RentCarGonzalez.Clientes;
using RentCarGonzalez.Empleados;
using RentCarGonzalez.Marcas;
using RentCarGonzalez.Rentas;
using RentCarGonzalez.Reportes;
using RentCarGonzalez.TiposCombustible;
using RentCarGonzalez.TiposdeVehiculo;
using RentCarGonzalez.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Text = "Hacer gestion de "+comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                FrmMarcas fed = new FrmMarcas();
                fed.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmClientes fed = new FrmClientes();
            fed.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmTipoVehiculo fed = new FrmTipoVehiculo();
            fed.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTipoCombustible fed = new FrmTipoCombustible();
            fed.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmVehiculos fed = new FrmVehiculos();
            fed.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRenta fed = new FrmRenta();
            fed.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmEmpleado fed = new FrmEmpleado();
            fed.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportesRentCar fed = new ReportesRentCar();
            fed.ShowDialog();
        }
    }
}
