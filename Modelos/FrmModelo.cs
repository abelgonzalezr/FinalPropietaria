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
    public partial class FrmModelo : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmModelo()
        {
            InitializeComponent();
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentcarddatasetUltimate.Modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.rentcarddatasetUltimate.Modelo);
            // TODO: This line of code loads data into the 'rentcarddatasetUltimate.Modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.rentcarddatasetUltimate.Modelo);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var modelo  = from ma in entities.Modeloes
                         where (ma.Nombre.StartsWith(txtBuscar.Text))
                         select ma;
            dataGridModelo.DataSource = modelo.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddModelo fed = new FrmAddModelo();
            this.Hide();
            fed.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridModelo.CurrentCell.RowIndex;
            int columnindex = dataGridModelo.CurrentCell.ColumnIndex;

            FrmAddModelo fed = new FrmAddModelo();
            this.Hide();
            fed.values = Int32.Parse(dataGridModelo.Rows[rowindex].Cells[columnindex].Value.ToString());
            fed.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridModelo.CurrentCell.RowIndex;
            int columnindex = dataGridModelo.CurrentCell.ColumnIndex;
            var delmodelo = dataGridModelo.Rows[rowindex].Cells[columnindex].Value;

            Modelo modelo = entities.Modeloes.Find(delmodelo);
            DialogResult dr = MessageBox.Show("Desea eliminar el registro No " + delmodelo + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (modelo != null)
                {
                    entities.Modeloes.Remove(modelo);
                    entities.SaveChanges();
                    MessageBox.Show("Registro eliminado con exito " + delmodelo);
                    this.Close();
                }
                else
                    MessageBox.Show("No existe registro No" + delmodelo);

            }
        }

        private void dataGridModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
