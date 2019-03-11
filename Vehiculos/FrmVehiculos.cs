using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Vehiculos
{
    public partial class FrmVehiculos : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetfinal.vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.rentCarDataSetfinal.vehiculos);
            // TODO: This line of code loads data into the 'rentCarDataSet.vehiculos' table. You can move, or remove it, as needed.
            //this.vehiculosTableAdapter.Fill(this.rentCarDataSet.vehiculos);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var vehiculos = from ma in entities.vehiculos
                         where (ma.Nombre.StartsWith(txtBuscar.Text))
                         select ma;
            datGridVehiculos.DataSource = vehiculos.ToList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FrmAddVehiculos frm = new FrmAddVehiculos();
            this.Hide();
            frm.ShowDialog();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int rowindex = datGridVehiculos.CurrentCell.RowIndex;
            int columnindex = datGridVehiculos.CurrentCell.ColumnIndex;
            FrmAddVehiculos fed = new FrmAddVehiculos();
            this.Hide();
            fed.values = Int32.Parse(datGridVehiculos.Rows[rowindex].Cells[columnindex].Value.ToString());
            fed.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rowindex = datGridVehiculos.CurrentCell.RowIndex;
            int columnindex = datGridVehiculos.CurrentCell.ColumnIndex;
            var delmarca = datGridVehiculos.Rows[rowindex].Cells[columnindex].Value;

            vehiculo vehiculos = entities.vehiculos.Find(delmarca);
            DialogResult dr = MessageBox.Show("Desea eliminar el vehiculo No " + delmarca + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (vehiculos != null)
                {
                    entities.vehiculos.Remove(vehiculos);
                    entities.SaveChanges();
                    MessageBox.Show("Vehiculo eliminada con exito " + delmarca);
                    this.Close();
                }
                else
                    MessageBox.Show("No existe vehiculo No" + delmarca);

            }
        }
    }
}
