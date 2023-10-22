
namespace InventoryManagement
{
    partial class IndividualStockView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.srLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srLabel
            // 
            this.srLabel.AutoSize = true;
            this.srLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.srLabel.Location = new System.Drawing.Point(11, 11);
            this.srLabel.Name = "srLabel";
            this.srLabel.Size = new System.Drawing.Size(34, 21);
            this.srLabel.TabIndex = 0;
            this.srLabel.Text = "Sr: ";
            this.srLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qtyLabel.Location = new System.Drawing.Point(21, 41);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(41, 21);
            this.qtyLabel.TabIndex = 1;
            this.qtyLabel.Text = "Qty:";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IndividualStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.srLabel);
            this.Name = "IndividualStockView";
            this.Size = new System.Drawing.Size(129, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label srLabel;
        private System.Windows.Forms.Label qtyLabel;
    }
}
