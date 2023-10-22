
namespace InventoryManagement
{
    partial class BarcodePrintForm
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
            this.barcodePrintDataGrid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.previousVoucherButton = new System.Windows.Forms.Button();
            this.nextVoucherButton = new System.Windows.Forms.Button();
            this.voucherNoText = new System.Windows.Forms.TextBox();
            this.printBarcodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePrintDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodePrintDataGrid
            // 
            this.barcodePrintDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.barcodePrintDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barcodePrintDataGrid.Location = new System.Drawing.Point(35, 106);
            this.barcodePrintDataGrid.Name = "barcodePrintDataGrid";
            this.barcodePrintDataGrid.Size = new System.Drawing.Size(489, 310);
            this.barcodePrintDataGrid.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Voucher No:";
            // 
            // previousVoucherButton
            // 
            this.previousVoucherButton.FlatAppearance.BorderSize = 0;
            this.previousVoucherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousVoucherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousVoucherButton.Location = new System.Drawing.Point(154, 35);
            this.previousVoucherButton.Name = "previousVoucherButton";
            this.previousVoucherButton.Size = new System.Drawing.Size(23, 27);
            this.previousVoucherButton.TabIndex = 2;
            this.previousVoucherButton.Text = "<";
            this.previousVoucherButton.UseVisualStyleBackColor = true;
            this.previousVoucherButton.Click += new System.EventHandler(this.previousVoucherButton_Click);
            // 
            // nextVoucherButton
            // 
            this.nextVoucherButton.FlatAppearance.BorderSize = 0;
            this.nextVoucherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextVoucherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextVoucherButton.Location = new System.Drawing.Point(245, 35);
            this.nextVoucherButton.Name = "nextVoucherButton";
            this.nextVoucherButton.Size = new System.Drawing.Size(23, 27);
            this.nextVoucherButton.TabIndex = 3;
            this.nextVoucherButton.Text = ">";
            this.nextVoucherButton.UseVisualStyleBackColor = true;
            this.nextVoucherButton.Click += new System.EventHandler(this.nextVoucherButton_Click);
            // 
            // voucherNoText
            // 
            this.voucherNoText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherNoText.Location = new System.Drawing.Point(177, 36);
            this.voucherNoText.Name = "voucherNoText";
            this.voucherNoText.ReadOnly = true;
            this.voucherNoText.Size = new System.Drawing.Size(67, 25);
            this.voucherNoText.TabIndex = 4;
            this.voucherNoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printBarcodeButton
            // 
            this.printBarcodeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBarcodeButton.Location = new System.Drawing.Point(202, 431);
            this.printBarcodeButton.Name = "printBarcodeButton";
            this.printBarcodeButton.Size = new System.Drawing.Size(159, 57);
            this.printBarcodeButton.TabIndex = 5;
            this.printBarcodeButton.Text = "Print Barcode";
            this.printBarcodeButton.UseVisualStyleBackColor = true;
            this.printBarcodeButton.Click += new System.EventHandler(this.printBarcodeButton_Click);
            // 
            // BarcodePrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 500);
            this.Controls.Add(this.printBarcodeButton);
            this.Controls.Add(this.voucherNoText);
            this.Controls.Add(this.nextVoucherButton);
            this.Controls.Add(this.previousVoucherButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.barcodePrintDataGrid);
            this.Name = "BarcodePrintForm";
            this.Text = "BarcodePrintForm";
            this.Load += new System.EventHandler(this.BarcodePrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePrintDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView barcodePrintDataGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button previousVoucherButton;
        private System.Windows.Forms.Button nextVoucherButton;
        private System.Windows.Forms.TextBox voucherNoText;
        private System.Windows.Forms.Button printBarcodeButton;
    }
}