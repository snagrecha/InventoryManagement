using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ViewStockForm : Form
    {
        public ViewStockForm()
        {
            InitializeComponent();
        }

        private void stockTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prefix = stockTypeComboBox.SelectedValue.ToString();
            Debug.WriteLine("Selected Prefix from dropdown: " + prefix);

            string stockType = Home.prefixToNameDict[prefix];
            Debug.WriteLine("Selected Stock Type: " + stockType);

            string inStockClause = SetInStockClause();

            //DataTable dt = DBHandler.GetDetailedStock("Sr, Qty, DateAdded, DateConsumed, InStock", "WHERE InStock = '1' AND Name = '" + stockType + "' ORDER BY Sr DESC");
            DataTable dt = DBHandler.GetDetailedStock("Sr, Qty, DateAdded, DateConsumed, InStock, Remarks", "WHERE Name = '" + stockType + "'" + inStockClause + " ORDER BY Sr DESC");

            viewStockDataGrid.DataSource = dt;
            viewStockDataGrid.Columns["Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string totalBundles = dt.Rows.Count.ToString();
            string totalQty = DBHandler.GetTotalQtyofStockType(stockType);

            totalBundlesLabel.Text = totalBundles;
            totalQtyLabel.Text = totalQty;
            
        }

        private string SetInStockClause()
        {
            string inStockClause = "";

            if(inStockCheckbox.Checked && !outOfStockCheckbox.Checked)
            {
                inStockClause = " AND InStock = 1";
            }

            else if(outOfStockCheckbox.Checked && !inStockCheckbox.Checked)
            {
                inStockClause = " AND InStock = 0";
            }

            return inStockClause;
        }
        private void ViewStockForm_Load(object sender, EventArgs e)
        {

            stockTypeComboBox.DisplayMember = "Name";
            stockTypeComboBox.ValueMember = "Prefix";

            stockTypeComboBox.DataSource = Home.stockTypes;

            stockTypeComboBox.SelectedIndex = 0;
        }

        private void viewStockDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string barcode;

            barcode = viewStockDataGrid.Rows[e.RowIndex].Cells["Sr"].Value.ToString();

            Form addViewRemarksForm = new AddViewRemarksForm(barcode);
            addViewRemarksForm.Show();
        }

        
    }
}
