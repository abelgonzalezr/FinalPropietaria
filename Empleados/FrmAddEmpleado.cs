using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Empleados
{
    public partial class FrmAddEmpleado : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();
        public int values { get; set; }
        public FrmAddEmpleado()
        {
            InitializeComponent();
        }

        private void FrmAddEmpleado_Load(object sender, EventArgs e)
        {
            if (this.values != 0)
            {
                var empleado = entities.Empleadoes.Find(this.values);
                txtNombre.Text = empleado.Nombre;
                txtDireccion.Text = empleado.Decision;
                txtTelefono.Text = empleado.numeroTelefono;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Utilities utilities = new Utilities();
            bool cedulacorrecta = utilities.ValidaCedula(txtcedula.Text);
            bool telefonocorrecto = utilities.ValidaTelefono(txtTelefono.Text);
            if (telefonocorrecto == true)
            {
                if (cedulacorrecta == true)
                {
                    if (this.values != 0)
                    {
                        var empleado = entities.Empleadoes.Find(this.values);
                        empleado.Nombre = txtNombre.Text;
                        empleado.Decision = txtDireccion.Text;
                        empleado.numeroTelefono = txtTelefono.Text;
                        empleado.cedula = txtcedula.Text;
                        entities.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
                        entities.SaveChanges();
                        MessageBox.Show("Datos editados con exito");
                    }
                    else
                    {
                        entities.Empleadoes.Add(new Empleado
                        {
                            Nombre = txtNombre.Text,
                            Decision = txtDireccion.Text,
                            numeroTelefono = txtTelefono.Text,
                            cedula=txtcedula.Text
                        });
                        entities.SaveChanges();
                        MessageBox.Show("Datos guardados con exito");
                    }
                    this.Hide();
                    FrmEmpleado mar = new FrmEmpleado();
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
    }
}
