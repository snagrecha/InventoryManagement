using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class NewStockTypeForm : Form
    {
        public NewStockTypeForm()
        {
            InitializeComponent();
        }

        private void addNewStockTypeButton_Click(object sender, EventArgs e)
        {
            string newStockType = newStockTypeTextBox.Text.ToString();
            string defaultBundleSize = defaultBundleSizeText.Text.ToString();

            bool duplicate = Home.CheckIfStockTypeExists(newStockType);

            if (duplicate) MessageBox.Show("Stock type already exists!");

            else
            {
                int added = 0;

                added = DBHandler.AddNewStockType(newStockType, defaultBundleSize);

                if (added == 1) MessageBox.Show("New stock type added: " + newStockType);

                Home.stockTypes = DBHandler.GetStockTypes("ORDER BY Prefix");
                GeneralFunctions.CreatePrefixNameDict();
            }

            newStockTypeTextBox.Text = "";
            defaultBundleSizeText.Text = "";
        }
    }
}
