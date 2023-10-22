
namespace InventoryManagement
{
    partial class AddViewRemarksForm
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
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.remarksText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stockTypeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateAddedText = new System.Windows.Forms.TextBox();
            this.inStockCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode";
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeText.Location = new System.Drawing.Point(131, 29);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(100, 23);
            this.barcodeText.TabIndex = 1;
            this.barcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barcodeText.TextChanged += new System.EventHandler(this.barcodeText_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(248, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.barcodeText_TextChanged);
            // 
            // remarksText
            // 
            this.remarksText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksText.Location = new System.Drawing.Point(50, 173);
            this.remarksText.Multiline = true;
            this.remarksText.Name = "remarksText";
            this.remarksText.Size = new System.Drawing.Size(273, 112);
            this.remarksText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remarks";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(95, 300);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(214, 300);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock Type";
            // 
            // stockTypeText
            // 
            this.stockTypeText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stockTypeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTypeText.Location = new System.Drawing.Point(131, 76);
            this.stockTypeText.Name = "stockTypeText";
            this.stockTypeText.ReadOnly = true;
            this.stockTypeText.Size = new System.Drawing.Size(100, 23);
            this.stockTypeText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Added";
            // 
            // dateAddedText
            // 
            this.dateAddedText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dateAddedText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedText.Location = new System.Drawing.Point(131, 113);
            this.dateAddedText.Name = "dateAddedText";
            this.dateAddedText.ReadOnly = true;
            this.dateAddedText.Size = new System.Drawing.Size(192, 23);
            this.dateAddedText.TabIndex = 10;
            // 
            // inStockCheckBox
            // 
            this.inStockCheckBox.AutoSize = true;
            this.inStockCheckBox.Enabled = false;
            this.inStockCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStockCheckBox.Location = new System.Drawing.Point(256, 79);
            this.inStockCheckBox.Name = "inStockCheckBox";
            this.inStockCheckBox.Size = new System.Drawing.Size(67, 17);
            this.inStockCheckBox.TabIndex = 11;
            this.inStockCheckBox.Text = "In Stock";
            this.inStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddViewRemarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 335);
            this.Controls.Add(this.inStockCheckBox);
            this.Controls.Add(this.dateAddedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockTypeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remarksText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.barcodeText);
            this.Controls.Add(this.label1);
            this.Name = "AddViewRemarksForm";
            this.Text = "Add/View Remarks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox remarksText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockTypeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateAddedText;
        private System.Windows.Forms.CheckBox inStockCheckBox;
    }
}