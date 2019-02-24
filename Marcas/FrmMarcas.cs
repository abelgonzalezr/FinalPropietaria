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
    public partial class FrmMarcas : Form
    {
        rentCarEntities2 entities = new rentCarEntities2();
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.rentCarDataSet.Marcas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddMarcas fed = new FrmAddMarcas();
            this.Hide();
            fed.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
             
            FrmAddMarcas fed = new FrmAddMarcas();
            this.Hide();
            fed.values = Int32.Parse(dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString()); 
            fed.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            var delmarca = dataGridView1.Rows[rowindex].Cells[columnindex].Value;

            Marca marcas = entities.Marcas.Find(delmarca);
            DialogResult dr = MessageBox.Show("Desea eliminar la marca No " + delmarca + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (marcas != null)
                {
                    entities.Marcas.Remove(marcas);
                    entities.SaveChanges();
                    MessageBox.Show("Marca eliminada con exito " + delmarca);
                    this.Close();
                }
                else
                    MessageBox.Show("No existe la marca No" + delmarca);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var marcas = from ma in entities.Marcas
                         where (ma.Nombre.StartsWith(txtbuscar.Text))
                         select ma;
            dataGridView1.DataSource = marcas.ToList();
        }
    }
}
