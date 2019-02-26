using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Modelos
{
    public partial class FrmAddModelo : Form
    {
        public int values { get; set; }
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmAddModelo()
        {
            InitializeComponent();
        }

        private void FrmAddModelo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet2.estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.rentCarDataSet2.estados);
            // TODO: This line of code loads data into the 'rentcarddatasetUltimate.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.rentcarddatasetUltimate.Marcas);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            if (comboEstado.SelectedValue.ToString() == "1")
            {
                estado = true;
            }
            if (this.values != 0)
            {
                var Modelo = entities.Modeloes.Find(this.values);
                Modelo.Nombre = txtNombre.Text;
                Modelo.IdMarca = Int32.Parse(comboMarca.SelectedValue.ToString());
                Modelo.estado = estado;
                entities.Entry(Modelo).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                MessageBox.Show("Datos editados con exito");
            }
            else
            {
                entities.Modeloes.Add(new Modelo
                {
                    Nombre = txtNombre.Text,
                    IdMarca= Int32.Parse(comboMarca.SelectedValue.ToString()),
                    estado=estado
                });
                entities.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
            }
            this.Hide();
            FrmModelo mar = new FrmModelo();
            mar.ShowDialog();
        }
    }
}
