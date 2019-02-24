using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Rentas
{
    public partial class FrmRenta : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmRenta()
        {
            InitializeComponent();
        }

        private void FrmRenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetAct.Renta' table. You can move, or remove it, as needed.
            this.rentaTableAdapter.Fill(this.rentCarDataSetAct.Renta);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var renta = from ma in entities.Rentas
                         where (ma.FechaRenta > dateTimebuscar.Value)
                         select ma;
            dataGridRenta.DataSource = renta.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddRenta frm = new FrmAddRenta();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridRenta.CurrentCell.RowIndex;
            int columnindex = dataGridRenta.CurrentCell.ColumnIndex;
            FrmAddRenta fed = new FrmAddRenta();
            this.Hide();
            fed.values = Int32.Parse(dataGridRenta.Rows[rowindex].Cells[columnindex].Value.ToString());
            fed.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridRenta.CurrentCell.RowIndex;
            int columnindex = dataGridRenta.CurrentCell.ColumnIndex;
            var delmarca = dataGridRenta.Rows[rowindex].Cells[columnindex].Value;

            Renta renta = entities.Rentas.Find(delmarca);
            DialogResult dr = MessageBox.Show("Desea eliminar el registro  No " + delmarca + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (renta != null)
                {
                    entities.Rentas.Remove(renta);
                    entities.SaveChanges();
                    MessageBox.Show("registro eliminado con exito " + delmarca);
                    this.Close();
                }
                else
                    MessageBox.Show("el registro no existe No.registro" + delmarca);

            }
        }
    }
}
