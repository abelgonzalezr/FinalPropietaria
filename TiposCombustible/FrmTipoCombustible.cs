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
    public partial class FrmTipoCombustible : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmTipoCombustible()
        {
            InitializeComponent();
        }

        private void FrmTipoCombustible_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet1.tiposDeCombustible' table. You can move, or remove it, as needed.
            this.tiposDeCombustibleTableAdapter1.Fill(this.rentCarDataSet1.tiposDeCombustible);
            // TODO: This line of code loads data into the 'rentCarDataSet.tiposDeCombustible' table. You can move, or remove it, as needed.
            // this.tiposDeCombustibleTableAdapter.Fill(this.rentCarDataSet.tiposDeCombustible);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FrmAddTipoCombustible frm = new FrmAddTipoCombustible();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int rowindex = datagridcombustible.CurrentCell.RowIndex;
            int columnindex = datagridcombustible.CurrentCell.ColumnIndex;
            FrmAddTipoCombustible fed = new FrmAddTipoCombustible();
            this.Hide();
            fed.values = Int32.Parse(datagridcombustible.Rows[rowindex].Cells[columnindex].Value.ToString());
            fed.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rowindex = datagridcombustible.CurrentCell.RowIndex;
            int columnindex = datagridcombustible.CurrentCell.ColumnIndex;
            var delmarca = datagridcombustible.Rows[rowindex].Cells[columnindex].Value;

            tiposDeCombustible tpcombustible = entities.tiposDeCombustibles.Find(delmarca);
            DialogResult dr = MessageBox.Show("Desea eliminar la marca No " + delmarca + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (tpcombustible != null)
                {
                    entities.tiposDeCombustibles.Remove(tpcombustible);
                    entities.SaveChanges();
                    MessageBox.Show("Marca eliminada con exito " + delmarca);
                    this.Close();
                }
                else
                    MessageBox.Show("No existe la marca No" + delmarca);

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            var tpcombustibles = from ma in entities.tiposDeCombustibles
                         where (ma.Nombre.StartsWith(txtbuscar.Text))
                         select ma;
            datagridcombustible.DataSource = tpcombustibles.ToList();
        }
    }
}
