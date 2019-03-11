using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Clientes
{
    public partial class FrmClientes : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetfinal.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter1.Fill(this.rentCarDataSetfinal.Clientes);
            // TODO: This line of code loads data into the 'rentCarDataSetfinal.Clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter3.Fill(this.rentCarDataSetfinal.Clientes);
            // TODO: This line of code loads data into the 'datasetCedula.Clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter1.Fill(this.datasetCedula.Clientes);
            // TODO: This line of code loads data into the 'rentCarDataSetAct.Clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter2.Fill(this.rentCarDataSetAct.Clientes);
            // TODO: This line of code loads data into the 'rentCarDataSetAct.vehiculos' table. You can move, or remove it, as needed.
         

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddCliente fed = new FrmAddCliente();
            this.Hide();
            fed.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridClientes.CurrentCell.RowIndex;
            int columnindex = dataGridClientes.CurrentCell.ColumnIndex;
            FrmAddCliente fed = new FrmAddCliente();
            this.Hide();
            fed.values = Int32.Parse(dataGridClientes.Rows[rowindex].Cells[columnindex].Value.ToString());
            fed.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridClientes.CurrentCell.RowIndex;
            int columnindex = dataGridClientes.CurrentCell.ColumnIndex;
            var delmarca = dataGridClientes.Rows[rowindex].Cells[columnindex].Value;

            Cliente clientes = entities.Clientes.Find(delmarca);
            DialogResult dr = MessageBox.Show("Desea eliminar el registro  No " + delmarca + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (clientes != null)
                {
                    entities.Clientes.Remove(clientes);
                    entities.SaveChanges();
                    MessageBox.Show("registro eliminado con exito " + delmarca);
                    this.Close();
                }
                else
                    MessageBox.Show("el registro no existe No.registro" + delmarca);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = from cl in entities.Clientes
                         where (cl.Nombre.StartsWith(txtBuscar.Text))
                         select cl;
            dataGridClientes.DataSource = cliente.ToList();
        }
    }
}
