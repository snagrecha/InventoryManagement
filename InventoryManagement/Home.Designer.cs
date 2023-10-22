
namespace InventoryManagement
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStockButton = new System.Windows.Forms.Button();
            this.scanBarcodeButton = new System.Windows.Forms.Button();
            this.viewStockButton = new System.Windows.Forms.Button();
            this.newStockTypeButton = new System.Windows.Forms.Button();
            this.barcodePrintButton = new System.Windows.Forms.Button();
            this.stockOverviewDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.addViewRemarksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockOverviewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addStockButton
            // 
            this.addStockButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.addStockButton.Location = new System.Drawing.Point(61, 51);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(182, 97);
            this.addStockButton.TabIndex = 0;
            this.addStockButton.Text = "ADD STOCK";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // scanBarcodeButton
            // 
            this.scanBarcodeButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.scanBarcodeButton.Location = new System.Drawing.Point(388, 51);
            this.scanBarcodeButton.Name = "scanBarcodeButton";
            this.scanBarcodeButton.Size = new System.Drawing.Size(182, 97);
            this.scanBarcodeButton.TabIndex = 1;
            this.scanBarcodeButton.Text = "SCAN BARCODE";
            this.scanBarcodeButton.UseVisualStyleBackColor = true;
            this.scanBarcodeButton.Click += new System.EventHandler(this.scanBarcodeButton_Click);
            // 
            // viewStockButton
            // 
            this.viewStockButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.viewStockButton.Location = new System.Drawing.Point(61, 219);
            this.viewStockButton.Name = "viewStockButton";
            this.viewStockButton.Size = new System.Drawing.Size(182, 97);
            this.viewStockButton.TabIndex = 2;
            this.viewStockButton.Text = "VIEW STOCK";
            this.viewStockButton.UseVisualStyleBackColor = true;
            this.viewStockButton.Click += new System.EventHandler(this.viewStockButton_Click);
            // 
            // newStockTypeButton
            // 
            this.newStockTypeButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.newStockTypeButton.Location = new System.Drawing.Point(388, 219);
            this.newStockTypeButton.Name = "newStockTypeButton";
            this.newStockTypeButton.Size = new System.Drawing.Size(182, 97);
            this.newStockTypeButton.TabIndex = 3;
            this.newStockTypeButton.Text = "NEW STOCK TYPE";
            this.newStockTypeButton.UseVisualStyleBackColor = true;
            this.newStockTypeButton.Click += new System.EventHandler(this.newStockTypeButton_Click);
            // 
            // barcodePrintButton
            // 
            this.barcodePrintButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.barcodePrintButton.Location = new System.Drawing.Point(61, 377);
            this.barcodePrintButton.Name = "barcodePrintButton";
            this.barcodePrintButton.Size = new System.Drawing.Size(182, 97);
            this.barcodePrintButton.TabIndex = 4;
            this.barcodePrintButton.Text = "BARCODE PRINT";
            this.barcodePrintButton.UseVisualStyleBackColor = true;
            this.barcodePrintButton.Click += new System.EventHandler(this.barcodePrintButton_Click);
            // 
            // stockOverviewDataGrid
            // 
            this.stockOverviewDataGrid.AllowUserToAddRows = false;
            this.stockOverviewDataGrid.AllowUserToDeleteRows = false;
            this.stockOverviewDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockOverviewDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.stockOverviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOverviewDataGrid.Location = new System.Drawing.Point(638, 51);
            this.stockOverviewDataGrid.Name = "stockOverviewDataGrid";
            this.stockOverviewDataGrid.ReadOnly = true;
            this.stockOverviewDataGrid.Size = new System.Drawing.Size(282, 423);
            this.stockOverviewDataGrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scan Barcode:";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTextBox.Location = new System.Drawing.Point(191, 508);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(100, 25);
            this.barcodeTextBox.TabIndex = 7;
            this.barcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barcodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeTextBox_KeyDown);
            // 
            // addViewRemarksButton
            // 
            this.addViewRemarksButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.addViewRemarksButton.Location = new System.Drawing.Point(388, 377);
            this.addViewRemarksButton.Name = "addViewRemarksButton";
            this.addViewRemarksButton.Size = new System.Drawing.Size(182, 97);
            this.addViewRemarksButton.TabIndex = 8;
            this.addViewRemarksButton.Text = "ADD/VIEW REMARKS";
            this.addViewRemarksButton.UseVisualStyleBackColor = true;
            this.addViewRemarksButton.Click += new System.EventHandler(this.addViewRemarksButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 567);
            this.Controls.Add(this.addViewRemarksButton);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockOverviewDataGrid);
            this.Controls.Add(this.barcodePrintButton);
            this.Controls.Add(this.newStockTypeButton);
            this.Controls.Add(this.viewStockButton);
            this.Controls.Add(this.scanBarcodeButton);
            this.Controls.Add(this.addStockButton);
            this.Name = "Home";
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.Home_Load);
            this.Load += new System.EventHandler(this.Home_Load);
            this.Enter += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockOverviewDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.Button scanBarcodeButton;
        private System.Windows.Forms.Button viewStockButton;
        private System.Windows.Forms.Button newStockTypeButton;
        private System.Windows.Forms.Button barcodePrintButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeTextBox;
        public System.Windows.Forms.DataGridView stockOverviewDataGrid;
        private System.Windows.Forms.Button addViewRemarksButton;
    }
}

