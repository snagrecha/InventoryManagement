
namespace InventoryManagement
{
    partial class ScanBarcodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.scannedBarcodeDataGrid = new System.Windows.Forms.DataGridView();
            this.submitBarcodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scannedBarcodeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTextBox.Location = new System.Drawing.Point(156, 45);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(100, 25);
            this.barcodeTextBox.TabIndex = 1;
            this.barcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barcodeTextBox.TextChanged += new System.EventHandler(this.barcodeTextBox_TextChanged);
            // 
            // scannedBarcodeDataGrid
            // 
            this.scannedBarcodeDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.scannedBarcodeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scannedBarcodeDataGrid.Location = new System.Drawing.Point(26, 106);
            this.scannedBarcodeDataGrid.Name = "scannedBarcodeDataGrid";
            this.scannedBarcodeDataGrid.Size = new System.Drawing.Size(459, 259);
            this.scannedBarcodeDataGrid.TabIndex = 2;
            // 
            // submitBarcodeButton
            // 
            this.submitBarcodeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBarcodeButton.Location = new System.Drawing.Point(199, 386);
            this.submitBarcodeButton.Name = "submitBarcodeButton";
            this.submitBarcodeButton.Size = new System.Drawing.Size(75, 27);
            this.submitBarcodeButton.TabIndex = 3;
            this.submitBarcodeButton.Text = "SUBMIT";
            this.submitBarcodeButton.UseVisualStyleBackColor = true;
            this.submitBarcodeButton.Click += new System.EventHandler(this.submitBarcodeButton_Click);
            // 
            // ScanBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.submitBarcodeButton);
            this.Controls.Add(this.scannedBarcodeDataGrid);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ScanBarcodeForm";
            this.Text = "ScanBarcodeForm";
            this.Load += new System.EventHandler(this.ScanBarcodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scannedBarcodeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.DataGridView scannedBarcodeDataGrid;
        private System.Windows.Forms.Button submitBarcodeButton;
    }
}