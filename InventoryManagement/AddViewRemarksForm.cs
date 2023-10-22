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
    public partial class AddViewRemarksForm : Form
    {
        public string barcode ;

        public AddViewRemarksForm()
        {
            InitializeComponent();
        }

        public AddViewRemarksForm(string passedBarcode)
        {
            InitializeComponent();
            barcodeText.Text = passedBarcode;
        }

        private void ClearAllFields()
        {
            barcodeText.Text = "";
            stockTypeText.Text = "";
            dateAddedText.Text = "";
            inStockCheckBox.Checked = false;
            remarksText.Text = "";
        }

        public void SetBarcodeText(string barcode)
        {
            barcodeText.Text = barcode;
        }

        private void barcodeText_TextChanged(object sender, EventArgs e)
        {
            barcode = barcodeText.Text;

            if(barcode.Length == 6)
            {
                DataTable dt = DBHandler.GetDetailedStock("*", "WHERE Sr = '" + barcode + "'");

                if(dt.Rows.Count>0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        remarksText.Text = row["Remarks"].ToString();
                        stockTypeText.Text = row["Name"].ToString();
                        dateAddedText.Text = row["DateAdded"].ToString();

                        bool inStock = false;
                        bool.TryParse(row["InStock"].ToString(), out inStock);

                        inStockCheckBox.Checked = inStock;

                        break;
                    }

                }

                else
                {
                    MessageBox.Show("Barcode " + barcode + " is Invalid!");
                    ClearAllFields();
                }
            }

            else
            {
                remarksText.Text = "";
                stockTypeText.Text = "";
                dateAddedText.Text = "";
                inStockCheckBox.Checked = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string barcode = barcodeText.Text;
            string remarks = remarksText.Text;

            if(barcode.Length == 6)
            {
                DataTable dt = DBHandler.GetDetailedStock("*", "WHERE Sr = '" + barcode + "'");

                if(dt.Rows.Count>0)
                {
                    int success = DBHandler.UpdateRemarks(barcode, remarks);

                    if (success == 1) MessageBox.Show("Remarks for barcode " + barcode + " updated successfully!");

                    ClearAllFields();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
