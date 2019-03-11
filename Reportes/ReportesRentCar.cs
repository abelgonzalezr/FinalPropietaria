using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RentCarGonzalez.Reportes
{
    public partial class ReportesRentCar : Form
    {
        private rentCarEntities2 entities = new rentCarEntities2();

        public ReportesRentCar()
        {
            InitializeComponent();
        }

        private void comboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboCriterio.SelectedItem == "Fecha")
            {
                lblFechaFin.Visible = true;
                lblFechaInicio.Visible = true;
                datefechaFin.Visible = true;
                datefechaInicio.Visible = true;
            }
            else
            {
                lblFechaFin.Visible = false;
                lblFechaInicio.Visible = false;
                datefechaFin.Visible = false;
                datefechaInicio.Visible = false;
            }
        }

        private void ReportesRentCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSetfinal.Reportevehiculos' table. You can move, or remove it, as needed.
            this.reportevehiculosTableAdapter.Fill(this.rentCarDataSetfinal.Reportevehiculos);
            // TODO: This line of code loads data into the 'rentCarDataSet1.Reportevehiculos' table. You can move, or remove it, as needed.
           // this.reportevehiculosTableAdapter.Fill(this.rentCarDataSet1.Reportevehiculos);
            // TODO: This line of code loads data into the 'rentCarDataSetAct.Renta' table. You can move, or remove it, as needed.
           // this.rentaTableAdapter.Fill(this.rentCarDataSetAct.Renta);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (comboCriterio.SelectedItem == "Tipo Vehiculo")
            {
                var marcas = from ma in entities.Reportevehiculos
                             where (ma.TipoVehiculo.StartsWith(txtBuscar.Text))
                             select ma;
                dataGridReporte.DataSource = marcas.ToList();
            }
            if (comboCriterio.SelectedItem == "Combustible")
            {
                var marcas = from ma in entities.Reportevehiculos
                             where (ma.Combustible.StartsWith(txtBuscar.Text))
                             select ma;
                dataGridReporte.DataSource = marcas.ToList();
            }
            if (comboCriterio.SelectedItem == "Fecha")
            {
                var marcas = from ma in entities.Reportevehiculos
                             where (ma.FechaRenta > datefechaInicio.Value) && (ma.FechaRenta < datefechaFin.Value)
                             select ma;
                dataGridReporte.DataSource = marcas.ToList();
            }
        }


        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dataGridReporte.ColumnHeadersVisible = true;
            dataGridReporte.RowHeadersVisible = false;
            dataGridReporte.SelectAll();
            dataGridReporte.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = dataGridReporte.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
