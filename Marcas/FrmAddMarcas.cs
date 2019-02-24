using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Marcas
{
    public partial class FrmAddMarcas : Form
    {
        public int values { get; set; }

        private rentCarEntities2 entities = new rentCarEntities2();
        public FrmAddMarcas()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (this.values != 0)
            {
                var Marcas=entities.Marcas.Find(this.values);
                Marcas.Nombre = txtNombre.Text;
                entities.Entry(Marcas).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                MessageBox.Show("Datos editados con exito");
            }
            else
            {
                entities.Marcas.Add(new Marca
                {
                    Nombre = txtNombre.Text
                });
                entities.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
            }
            this.Hide();
            FrmMarcas mar = new FrmMarcas();
            mar.ShowDialog();
        }

        private void FrmAddMarcas_Load(object sender, EventArgs e)
        {

            if (this.values != 0)
            {
                var Marcas = entities.Marcas.Find(this.values);
                txtNombre.Text = Marcas.Nombre;
            }
        }
    }
}
