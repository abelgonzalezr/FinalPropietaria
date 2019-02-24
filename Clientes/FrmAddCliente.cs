using RentCarGonzalez.Marcas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Clientes
{
    public partial class FrmAddCliente : Form
    {
        public int values { get; set; }
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet2.vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter1.Fill(this.rentCarDataSet2.vehiculos);
            if (this.values != 0)
            {
                var clientes = entities.Clientes.Find(this.values);
                txtNombre.Text = clientes.Nombre;
                txtTelefono.Text = clientes.numeroTelefono;
                txtDireccion.Text = clientes.direccion;
                txtcedula.Text = clientes.cedula;
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Utilities utilities = new Utilities();
            bool cedulacorrecta = utilities.ValidaCedula(txtcedula.Text);
            bool telefonocorrecto = utilities.ValidaTelefono(txtTelefono.Text);
            if (telefonocorrecto == true) { 
            if (cedulacorrecta == true)
            {
                if (this.values != 0)
                {
                    var Cliente = entities.Clientes.Find(this.values);
                    Cliente.Nombre = txtNombre.Text;
                    Cliente.direccion = txtDireccion.Text;
                    Cliente.numeroTelefono = txtTelefono.Text;
                    Cliente.cedula = txtcedula.Text;
                    entities.Entry(Cliente).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                    MessageBox.Show("Datos editados con exito");
                }
                else
                {
                    entities.Clientes.Add(new Cliente
                    {
                        Nombre = txtNombre.Text,
                        direccion = txtDireccion.Text,
                        numeroTelefono = txtTelefono.Text
                    });
                    entities.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                }
                this.Hide();
                FrmClientes mar = new FrmClientes();
                mar.ShowDialog();
            }
            else
            {
                MessageBox.Show("La cedula no es correcta favor verificar");
            }
            }
            else
            {
                MessageBox.Show("El teléfono introducido no es correcto, favor verificar que contiene mas de 10 dígitos y el código de área es 809,829 o 849");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
