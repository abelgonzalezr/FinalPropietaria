using RentCarGonzalez.Clientes;
using RentCarGonzalez.Empleados;
using RentCarGonzalez.Marcas;
using RentCarGonzalez.Modelos;
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
            btnClientes.Visible = false;
            btnCombustible.Visible = false;
            btndevolucion.Visible = false;
            btnEmpleado.Visible = false;
            btnMarcas.Visible = false;
            btnModelo.Visible = false;
            btnRenta.Visible = false;
            btnReportes.Visible = false;
            btnTipoVehiculo.Visible = false;
            btnVehiculos.Visible = false;

            if (comboBox1.SelectedItem.ToString() == "Modelos")
            {
                btnModelo.Visible = true;

            }
            if (comboBox1.SelectedItem.ToString() == "Clientes")
            {
                btnClientes.Visible = true;

            }
            if (comboBox1.SelectedItem.ToString() == "Tipos de combustibles")
            {
                btnCombustible.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Devolucion")
            {
                btndevolucion.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Empleados")
            {
                btnEmpleado.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Marcas")
            {
                btnMarcas.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Renta de vehiculo")
            {
                btnRenta.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Reportes")
            {
                btnReportes.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Tipos de vehiculo")
            {
                btnTipoVehiculo.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Vehiculos")
            {
                btnVehiculos.Visible = true;
            }

            if (comboBox1.SelectedItem.ToString() == "Todos")
            {
                btnClientes.Visible = true;
                btnCombustible.Visible = true;
                btndevolucion.Visible = true;
                btnEmpleado.Visible = true;
                btnMarcas.Visible = true;
                btnModelo.Visible = true;
                btnRenta.Visible = true;
                btnReportes.Visible = true;
                btnTipoVehiculo.Visible = true;
                btnVehiculos.Visible = true;
            }
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

        private void btnModel_Click(object sender, EventArgs e)
        {
            FrmModelo fed = new FrmModelo();
            fed.ShowDialog();
        }
    }
}
