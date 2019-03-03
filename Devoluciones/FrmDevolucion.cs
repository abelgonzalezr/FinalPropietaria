using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarGonzalez.Devoluciones
{
    public partial class btnBack : Form
    {
        public btnBack()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehiculosrentados.VehiculosRentados' table. You can move, or remove it, as needed.
            this.vehiculosRentadosTableAdapter.Fill(this.vehiculosrentados.VehiculosRentados);
            // TODO: This line of code loads data into the 'rentCarDataSet3.VehiculosRentados' table. You can move, or remove it, as needed.
          
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}
