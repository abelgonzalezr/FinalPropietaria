using RentCarGonzalez.TiposdeVehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.TiposdeVehiculo
{
    public partial class FrmTipoVehiculo : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmTipoVehiculo()
        {
            InitializeComponent();
        }

        private void FrmTipoVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetfinal.TipoVehiculo' table. You can move, or remove it, as needed.
            this.tipoVehiculoTableAdapter.Fill(this.rentCarDataSetfinal.TipoVehiculo);
            // TODO: This line of code loads data into the 'rentcarddatasetUltimate.TipoVehiculo' table. You can move, or remove it, as needed.
            //this.tipoVehiculoTableAdapter1.Fill(this.rentcarddatasetUltimate.TipoVehiculo);
            // TODO: This line of code loads data into the 'rentCarDataSet.TipoVehiculo' table. You can move, or remove it, as needed.
            //this.tipoVehiculoTableAdapter.Fill(this.rentCarDataSet.TipoVehiculo);
            // TODO: This line of code loads data into the 'rentCarDataSet.vehiculos' table. You can move, or remove it, as needed.
            

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            var tipoVehiculos = from tpv in entities.TipoVehiculoes
                         where (tpv.Nombre.StartsWith(txtBuscar.Text))
                         select tpv;
            dataGridView1.DataSource = tipoVehiculos.ToList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FrmAddTipoVehiculo frm = new FrmAddTipoVehiculo();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            FrmAddTipoVehiculo fed = new FrmAddTipoVehiculo();
            this.Hide();
            fed.values = Int32.Parse(dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString());
            fed.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            var del = dataGridView1.Rows[rowindex].Cells[columnindex].Value;

            TipoVehiculo tpvehiculo = entities.TipoVehiculoes.Find(del);
            DialogResult dr = MessageBox.Show("Desea eliminar la marca No " + del + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (tpvehiculo != null)
                {
                    entities.TipoVehiculoes.Remove(tpvehiculo);
                    entities.SaveChanges();
                    MessageBox.Show("Marca eliminada con exito " + del);
                    this.Close();
                }
                else
                    MessageBox.Show("No existe la marca No" + del);

            }
        }
    }
}
