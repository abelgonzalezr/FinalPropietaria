using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Empleados
{
    public partial class FrmEmpleado : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetfinal.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.rentCarDataSetfinal.Empleado);
            // TODO: This line of code loads data into the 'datasetCedula.Empleado' table. You can move, or remove it, as needed.
           // this.empleadoTableAdapter1.Fill(this.datasetCedula.Empleado);
            // TODO: This line of code loads data into the 'rentCarDataSetAct.Empleado' table. You can move, or remove it, as needed.
           // this.empleadoTableAdapter.Fill(this.rentCarDataSetAct.Empleado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var empleado = from ma in entities.Empleadoes
                         where (ma.Nombre.StartsWith(txtBuscar.Text))
                         select ma;
            dataGridEmpleados.DataSource = empleado.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEmpleado frm = new FrmAddEmpleado();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridEmpleados.CurrentCell.RowIndex;
            int columnindex = dataGridEmpleados.CurrentCell.ColumnIndex;
            FrmAddEmpleado fed = new FrmAddEmpleado();
            this.Hide();
            fed.values = Int32.Parse(dataGridEmpleados.Rows[rowindex].Cells[columnindex].Value.ToString());
            fed.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridEmpleados.CurrentCell.RowIndex;
            int columnindex = dataGridEmpleados.CurrentCell.ColumnIndex;
            var delmarca = dataGridEmpleados.Rows[rowindex].Cells[columnindex].Value;

            Empleado empleado = entities.Empleadoes.Find(delmarca);
            DialogResult dr = MessageBox.Show("Desea eliminar el registro  No " + delmarca + " ?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (empleado != null)
                {
                    entities.Empleadoes.Remove(empleado);
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
