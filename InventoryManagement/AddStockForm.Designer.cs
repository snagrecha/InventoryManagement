
namespace InventoryManagement
{
    partial class AddStockForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bundleSizeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalBundlesText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalQtyText = new System.Windows.Forms.TextBox();
            this.addNewStockButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.voucherNoText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.remarksText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(63, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bundle Size";
            // 
            // bundleSizeText
            // 
            this.bundleSizeText.Location = new System.Drawing.Point(173, 101);
            this.bundleSizeText.Name = "bundleSizeText";
            this.bundleSizeText.Size = new System.Drawing.Size(86, 20);
            this.bundleSizeText.TabIndex = 3;
            this.bundleSizeText.TextChanged += new System.EventHandler(this.totalBundlesText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Bundles";
            // 
            // totalBundlesText
            // 
            this.totalBundlesText.Location = new System.Drawing.Point(173, 143);
            this.totalBundlesText.Name = "totalBundlesText";
            this.totalBundlesText.Size = new System.Drawing.Size(86, 20);
            this.totalBundlesText.TabIndex = 5;
            this.totalBundlesText.TextChanged += new System.EventHandler(this.totalBundlesText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(63, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Qty";
            // 
            // totalQtyText
            // 
            this.totalQtyText.Location = new System.Drawing.Point(173, 185);
            this.totalQtyText.Name = "totalQtyText";
            this.totalQtyText.ReadOnly = true;
            this.totalQtyText.Size = new System.Drawing.Size(86, 20);
            this.totalQtyText.TabIndex = 7;
            // 
            // addNewStockButton
            // 
            this.addNewStockButton.Location = new System.Drawing.Point(110, 293);
            this.addNewStockButton.Name = "addNewStockButton";
            this.addNewStockButton.Size = new System.Drawing.Size(112, 39);
            this.addNewStockButton.TabIndex = 8;
            this.addNewStockButton.Text = "Add New Stock";
            this.addNewStockButton.UseVisualStyleBackColor = true;
            this.addNewStockButton.Click += new System.EventHandler(this.addNewStockButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(76, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "VOUCHER NO:";
            // 
            // voucherNoText
            // 
            this.voucherNoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.voucherNoText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.voucherNoText.Location = new System.Drawing.Point(201, 12);
            this.voucherNoText.Name = "voucherNoText";
            this.voucherNoText.ReadOnly = true;
            this.voucherNoText.Size = new System.Drawing.Size(49, 23);
            this.voucherNoText.TabIndex = 10;
            this.voucherNoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(63, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Remarks";
            // 
            // remarksText
            // 
            this.remarksText.Location = new System.Drawing.Point(173, 230);
            this.remarksText.Multiline = true;
            this.remarksText.Name = "remarksText";
            this.remarksText.Size = new System.Drawing.Size(136, 57);
            this.remarksText.TabIndex = 12;
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 344);
            this.Controls.Add(this.remarksText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.voucherNoText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addNewStockButton);
            this.Controls.Add(this.totalQtyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalBundlesText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bundleSizeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddStockForm";
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.AddStockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bundleSizeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalBundlesText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalQtyText;
        private System.Windows.Forms.Button addNewStockButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox voucherNoText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox remarksText;
    }
}