using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.TiposCombustible
{
    public partial class FrmAddTipoCombustible : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();
        public int values { get; set; }
        public FrmAddTipoCombustible()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (this.values != 0)
            {
                var tpcombustible = entities.tiposDeCombustibles.Find(this.values);
                tpcombustible.Nombre = txtNombre.Text;
                entities.Entry(tpcombustible).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                MessageBox.Show("Datos editados con exito");
            }
            else
            {
                entities.tiposDeCombustibles.Add(new tiposDeCombustible
                {
                    Nombre = txtNombre.Text
                });
                entities.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
            }
            this.Hide();
            FrmTipoCombustible mar = new FrmTipoCombustible();
            mar.ShowDialog();
        }

        private void FrmAddTipoCombustible_Load(object sender, EventArgs e)
        {
            if (this.values != 0)
            {
                var tpcombustible = entities.tiposDeCombustibles.Find(this.values);
                txtNombre.Text = tpcombustible.Nombre;
            }
        }
    }
}
