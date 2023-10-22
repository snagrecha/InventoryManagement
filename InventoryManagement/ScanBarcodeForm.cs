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
    public partial class ScanBarcodeForm : Form
    {
        public ScanBarcodeForm()
        {
            InitializeComponent();
        }

        private void InitializeScannedBarcodeDataGrid()
        {
            
            scannedBarcodeDataGrid.ColumnCount = 5;
            scannedBarcodeDataGrid.Columns[0].Name = "Sr";
            scannedBarcodeDataGrid.Columns[1].Name = "Name";
            scannedBarcodeDataGrid.Columns[2].Name = "Qty";
            scannedBarcodeDataGrid.Columns[3].Name = "DateAdded";
            scannedBarcodeDataGrid.Columns[4].Name = "VoucherNo";

            scannedBarcodeDataGrid.ReadOnly = true;
            scannedBarcodeDataGrid.AllowUserToAddRows = false;
        }

        private void ClearScannedBarcodeDataGrid()
        {
            scannedBarcodeDataGrid.Rows.Clear();
        }
        private void barcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            string barcode = barcodeTextBox.Text;

            if(barcode != "")
            {
                if(barcode.Length == 6)
                {
                    DataTable dt = DBHandler.GetDetailedStock("Sr, Name, Qty, DateAdded, VoucherNo", "WHERE Sr = " + barcode + " AND InStock = 1");

                    if (dt.Rows.Count > 0)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(scannedBarcodeDataGrid);
                        foreach (DataRow drow in dt.Rows)
                        {
                            row.Cells[0].Value = drow[0].ToString();
                            row.Cells[1].Value = drow[1].ToString();
                            row.Cells[2].Value = drow[2].ToString();
                            row.Cells[3].Value = drow[3].ToString();
                            row.Cells[4].Value = drow[4].ToString();

                        }
                      
                        scannedBarcodeDataGrid.Rows.Add(row);
                    }

                    else
                    {
                        MessageBox.Show("Barcode not in stock!");
                    }

                    barcodeTextBox.Text = "";
                }
            }
        }

        private void submitBarcodeButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in scannedBarcodeDataGrid.Rows)
            {
                string sr = row.Cells["Sr"].Value.ToString();

                DBHandler.RemoveFromStock(sr);
            }
            
            MessageBox.Show("Removed scanned barcodes from stock!");
            ClearScannedBarcodeDataGrid();
            
        }

        private void ScanBarcodeForm_Load(object sender, EventArgs e)
        {
            InitializeScannedBarcodeDataGrid();

        }
    }
}
