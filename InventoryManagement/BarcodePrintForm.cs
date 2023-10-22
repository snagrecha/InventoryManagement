using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class BarcodePrintForm : Form
    {
        static int firstVoucherNo, lastVoucherNo, currentVoucherNo;

        public BarcodePrintForm()
        {
            InitializeComponent();

            
        }

        private DataTable AddPrintColumn(DataTable dt)
        {
            DataColumn printColumn = dt.Columns.Add("Print", typeof(Boolean));
            //printColumn.DefaultValue = true;
            //printColumn.ReadOnly = false;
            printColumn.SetOrdinal(0);
            //dt.Columns["Print"].ReadOnly = false;

            return dt;
        }

        private void SetPrintColumnValue(bool printValue = true)
        {
            foreach (DataGridViewRow row in barcodePrintDataGrid.Rows)
            {
                Boolean inStock = (Boolean)row.Cells["InStock"].Value;
                if (inStock)
                {
                    row.Cells["Print"].Value = printValue;
                }
            }
        }

        private void DisableEditableColumns()
        {
            //barcodePrintDataGrid.ReadOnly = true;
            barcodePrintDataGrid.Columns["InStock"].ReadOnly = true;
            barcodePrintDataGrid.Columns["Print"].ReadOnly = false;

            //barcodePrintDataGrid.Columns[0].ReadOnly = false;

        }
        private void PopulateBarcodePrintDataGrid(int voucherNo)
        {
            DataTable dt = new DataTable();

            if (voucherNo > 0)
            {
                voucherNoText.Text = voucherNo.ToString();

                dt = DBHandler.GetDetailedStock("Sr, Name AS 'Stock Type', Qty, DateAdded AS Date, InStock", "WHERE VoucherNo = '" + voucherNo + "'");
            }

            if (dt.Rows.Count > 0)
            {
                dt = AddPrintColumn(dt);

                barcodePrintDataGrid.DataSource = dt;
                barcodePrintDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                barcodePrintDataGrid.AllowUserToAddRows = false;

                DisableEditableColumns();
                SetPrintColumnValue(true);

            }
        }
        private void BarcodePrintForm_Load(object sender, EventArgs e)
        {
            lastVoucherNo = DBHandler.GetLatestVoucherNo();
            firstVoucherNo = 1;
            currentVoucherNo = lastVoucherNo;

            PopulateBarcodePrintDataGrid(currentVoucherNo);
            
        }

        private void printBarcodeButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Sr", typeof(string));
            dt.Columns.Add("Stock Type", typeof(string));
            dt.Columns.Add("Qty", typeof(string));
            dt.Columns.Add("Date", typeof(string));

            foreach(DataGridViewRow row in barcodePrintDataGrid.Rows)
            {
                Boolean print = (Boolean)row.Cells["Print"].Value;

                //COPY ALL ROWS WITH PRINT SET TO TRUE TO A NEW DataTable FOR PRINTING
                if(print)
                {
                    DataRow drow = dt.NewRow();
                    drow["Sr"] = row.Cells["Sr"].Value.ToString();
                    drow["Stock Type"] = row.Cells["Stock Type"].Value.ToString();
                    drow["Qty"] = row.Cells["Qty"].Value.ToString();
                    drow["Date"] = row.Cells["Date"].Value.ToString();

                    dt.Rows.Add(drow);
                }
            }
            //dt = DBHandler.GetDetailedStock("Sr, Name as 'Stock Type', Qty, DateAdded as Date", "WHERE VoucherNo = '" + currentVoucherNo + "' AND InStock = 1");

            GeneralFunctions.WriteToExcel(dt);
            GeneralFunctions.OpenWordFile();

        }

        private void previousVoucherButton_Click(object sender, EventArgs e)
        {
            currentVoucherNo -= 1;

            if(currentVoucherNo < firstVoucherNo)
            {
                currentVoucherNo = firstVoucherNo;
                MessageBox.Show("Reached First Voucher!");
            }

            else
            {
                PopulateBarcodePrintDataGrid(currentVoucherNo);
            }
        }

        private void nextVoucherButton_Click(object sender, EventArgs e)
        {
            currentVoucherNo += 1;

            if(currentVoucherNo > lastVoucherNo)
            {
                currentVoucherNo = lastVoucherNo;
                MessageBox.Show("Reached Last Voucher!");
            }

            else
            {
                PopulateBarcodePrintDataGrid(currentVoucherNo);
            }
        }
    }
}
