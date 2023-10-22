
namespace InventoryManagement
{
    partial class ViewStockForm
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
            this.stockTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalBundlesLabel = new System.Windows.Forms.Label();
            this.totalQtyLabel = new System.Windows.Forms.Label();
            this.viewStockDataGrid = new System.Windows.Forms.DataGridView();
            this.inStockCheckbox = new System.Windows.Forms.CheckBox();
            this.outOfStockCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewStockDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Type:";
            // 
            // stockTypeComboBox
            // 
            this.stockTypeComboBox.FormattingEnabled = true;
            this.stockTypeComboBox.Location = new System.Drawing.Point(201, 31);
            this.stockTypeComboBox.Name = "stockTypeComboBox";
            this.stockTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.stockTypeComboBox.TabIndex = 1;
            this.stockTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.stockTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Bundles: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Qty: ";
            // 
            // totalBundlesLabel
            // 
            this.totalBundlesLabel.AutoSize = true;
            this.totalBundlesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBundlesLabel.Location = new System.Drawing.Point(537, 28);
            this.totalBundlesLabel.Name = "totalBundlesLabel";
            this.totalBundlesLabel.Size = new System.Drawing.Size(19, 21);
            this.totalBundlesLabel.TabIndex = 4;
            this.totalBundlesLabel.Text = "0";
            // 
            // totalQtyLabel
            // 
            this.totalQtyLabel.AutoSize = true;
            this.totalQtyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQtyLabel.Location = new System.Drawing.Point(668, 28);
            this.totalQtyLabel.Name = "totalQtyLabel";
            this.totalQtyLabel.Size = new System.Drawing.Size(19, 21);
            this.totalQtyLabel.TabIndex = 5;
            this.totalQtyLabel.Text = "0";
            // 
            // viewStockDataGrid
            // 
            this.viewStockDataGrid.AllowUserToAddRows = false;
            this.viewStockDataGrid.AllowUserToDeleteRows = false;
            this.viewStockDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewStockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStockDataGrid.Location = new System.Drawing.Point(16, 92);
            this.viewStockDataGrid.MultiSelect = false;
            this.viewStockDataGrid.Name = "viewStockDataGrid";
            this.viewStockDataGrid.ReadOnly = true;
            this.viewStockDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewStockDataGrid.Size = new System.Drawing.Size(818, 266);
            this.viewStockDataGrid.TabIndex = 6;
            this.viewStockDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewStockDataGrid_CellDoubleClick);
            // 
            // inStockCheckbox
            // 
            this.inStockCheckbox.AutoSize = true;
            this.inStockCheckbox.Checked = true;
            this.inStockCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inStockCheckbox.Location = new System.Drawing.Point(460, 65);
            this.inStockCheckbox.Name = "inStockCheckbox";
            this.inStockCheckbox.Size = new System.Drawing.Size(66, 17);
            this.inStockCheckbox.TabIndex = 9;
            this.inStockCheckbox.Text = "In Stock";
            this.inStockCheckbox.UseVisualStyleBackColor = true;
            this.inStockCheckbox.CheckedChanged += new System.EventHandler(this.stockTypeComboBox_SelectedIndexChanged);
            // 
            // outOfStockCheckbox
            // 
            this.outOfStockCheckbox.AutoSize = true;
            this.outOfStockCheckbox.Location = new System.Drawing.Point(601, 65);
            this.outOfStockCheckbox.Name = "outOfStockCheckbox";
            this.outOfStockCheckbox.Size = new System.Drawing.Size(86, 17);
            this.outOfStockCheckbox.TabIndex = 10;
            this.outOfStockCheckbox.Text = "Out of Stock";
            this.outOfStockCheckbox.UseVisualStyleBackColor = true;
            this.outOfStockCheckbox.CheckedChanged += new System.EventHandler(this.stockTypeComboBox_SelectedIndexChanged);
            // 
            // ViewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 441);
            this.Controls.Add(this.outOfStockCheckbox);
            this.Controls.Add(this.inStockCheckbox);
            this.Controls.Add(this.viewStockDataGrid);
            this.Controls.Add(this.totalQtyLabel);
            this.Controls.Add(this.totalBundlesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewStockForm";
            this.Text = "View Stock";
            this.Load += new System.EventHandler(this.ViewStockForm_Load);
            this.Click += new System.EventHandler(this.stockTypeComboBox_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.viewStockDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stockTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalBundlesLabel;
        private System.Windows.Forms.Label totalQtyLabel;
        private System.Windows.Forms.DataGridView viewStockDataGrid;
        private System.Windows.Forms.CheckBox inStockCheckbox;
        private System.Windows.Forms.CheckBox outOfStockCheckbox;
    }
}