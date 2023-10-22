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
    public partial class AddStockForm : Form
    {
        public static int voucherNo = 0;
        public AddStockForm()
        {
            InitializeComponent();

            voucherNo = DBHandler.GetLatestVoucherNo();

            voucherNoText.Text = (voucherNo + 1).ToString();
        }

        private void AddStockForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Home.stockTypes;
            
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Prefix";

            comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int prefix;
            int.TryParse(comboBox1.SelectedValue.ToString(), out prefix);
            Debug.WriteLine("Selected dropdown prefix: " + prefix);
            if (prefix > 0)
            {
                string bundleSize = DBHandler.GetDefaultBundleSize(prefix).ToString();
                bundleSizeText.Text = bundleSize;
            }
        }

        private void totalBundlesText_TextChanged(object sender, EventArgs e)
        {
            
            int bundleSize, totalBundles;
            
            int.TryParse(bundleSizeText.Text.ToString(), out bundleSize);
            int.TryParse(totalBundlesText.Text.ToString(), out totalBundles);

            totalQtyText.Text = (bundleSize * totalBundles).ToString();
        }

        private void addNewStockButton_Click(object sender, EventArgs e)
        {
            string prefix = comboBox1.SelectedValue.ToString();
            string bundleSize = bundleSizeText.Text.ToString();
            string totalBundles = totalBundlesText.Text.ToString();
            string totalQty = totalQtyText.Text.ToString();
            string stockType = Home.prefixToNameDict[prefix];
            string standardisedPrefix = GeneralFunctions.StandardiseIntToString(int.Parse(prefix), 2);
            string remarks = remarksText.Text;

            System.Data.DataTable newStock = new System.Data.DataTable();
            newStock.Columns.Add("Sr", typeof(string));
            newStock.Columns.Add("Stock Type", typeof(string));
            newStock.Columns.Add("Qty", typeof(string));
            newStock.Columns.Add("Date", typeof(string));
            
            voucherNo += 1;

            if(!(totalQty.Equals("")||totalQty.Equals("0")))
            {
                string sr = DBHandler.GetLatestSr(standardisedPrefix);
                string index;
                if (sr.Length > 0)
                {
                    int indexInt;
                    int.TryParse(sr.Substring(2), out indexInt);
                    indexInt++;

                    index = GeneralFunctions.StandardiseIntToString(indexInt, 4);
                }
                else index = "0001";

                sr = standardisedPrefix + index;
                
                int totalBundlesInt = 0;
                int.TryParse(totalBundles, out totalBundlesInt);

                for (int i = 0; i < totalBundlesInt; i++)
                {
                    //MessageBox.Show("New Sr: " + sr + "\nCurrent loop: " + i + "\nTotal Loops: " + totalBundlesInt);
                    //Debug.WriteLine("New Name: " + Home.prefixToNameDict[prefix]);
                    DBHandler.AddNewStock(sr, stockType, bundleSize, voucherNo.ToString(), remarks);

                    newStock.Rows.Add(sr, stockType, bundleSize, DateTime.Now.ToString());

                    sr = GeneralFunctions.IncrementString(sr);

                }

                MessageBox.Show(totalBundles + "x" + bundleSize + "=" + totalQty + " Bags added successfully");
                GeneralFunctions.WriteToExcel(newStock);
                GeneralFunctions.OpenWordFile();

                totalBundlesText.Text = "";
                voucherNoText.Text = (voucherNo + 1).ToString();
            }
        }
    }
}
