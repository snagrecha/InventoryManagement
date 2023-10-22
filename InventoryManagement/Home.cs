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
    public partial class Home : Form
    {
        public static DataTable stockTypes = DBHandler.GetStockTypes(" ORDER BY Prefix");

        public static Dictionary<string, string> prefixToNameDict = new Dictionary<string, string>();
        public static Dictionary<string, string> nameToPrefixDict = new Dictionary<string, string>();

       


        public Home()
        {
            InitializeComponent();

            GeneralFunctions.CreatePrefixNameDict();
        }

        private void newStockTypeButton_Click(object sender, EventArgs e)
        {
            Form newStockTypeForm = new NewStockTypeForm();
            newStockTypeForm.Show();

        }

        public static bool CheckIfStockTypeExists(string newStockType)
        {
            
            if (stockTypes.Rows.Count > 0)
            {
                foreach (DataRow dataRow in stockTypes.Rows)
                {
                    string existingStockType = dataRow["Name"].ToString();
                    if (newStockType.Equals(existingStockType)) return true;
                }
            }
            return false;
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            Form addStockForm = new AddStockForm();
            addStockForm.Show();
        }

        private void barcodePrintButton_Click(object sender, EventArgs e)
        {
            Form barcodePrintForm = new BarcodePrintForm();
            barcodePrintForm.Show();
        }
        private void viewStockButton_Click(object sender, EventArgs e)
        {
            Form viewStockForm = new ViewStockForm();
            viewStockForm.Show();
        }

        private void scanBarcodeButton_Click(object sender, EventArgs e)
        {
            Form scanBarcodeForm = new ScanBarcodeForm();
            scanBarcodeForm.Show();
        }

        private void InitializeStockOverviewDataGrid()
        {
            stockOverviewDataGrid.RowHeadersVisible = false;
            stockOverviewDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        public void PopulateStockOverviewDataGrid()
        {
            DataTable dt = DBHandler.GetStockOverView();

            stockOverviewDataGrid.DataSource = dt;            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            PopulateStockOverviewDataGrid();
            InitializeStockOverviewDataGrid();
            barcodeTextBox.Focus();
        }

        private void addViewRemarksButton_Click(object sender, EventArgs e)
        {
            Form addViewRemarksForm = new AddViewRemarksForm();
            addViewRemarksForm.Show();
        }

        private void barcodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string barcode = barcodeTextBox.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (barcode.Length == 6)
                {
                    bool inStock = DBHandler.GetInStockStatus(barcode);
                    if (inStock)
                    {
                        DBHandler.RemoveFromStock(barcode);
                        PopulateStockOverviewDataGrid();
                        InitializeStockOverviewDataGrid();
                        MessageBox.Show("Barcode " + barcode + " removed from Stock successfully!");
                    }

                    else
                    {
                        MessageBox.Show("Barcode not in Stock!");
                    }
                    barcodeTextBox.Text = "";
                }
            }
        }
    }
}
