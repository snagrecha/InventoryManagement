
namespace InventoryManagement
{
    partial class NewStockTypeForm
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
            this.newStockTypeTextBox = new System.Windows.Forms.TextBox();
            this.addNewStockTypeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultBundleSizeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Stock Type";
            // 
            // newStockTypeTextBox
            // 
            this.newStockTypeTextBox.Location = new System.Drawing.Point(91, 74);
            this.newStockTypeTextBox.Name = "newStockTypeTextBox";
            this.newStockTypeTextBox.Size = new System.Drawing.Size(139, 23);
            this.newStockTypeTextBox.TabIndex = 1;
            // 
            // addNewStockTypeButton
            // 
            this.addNewStockTypeButton.Location = new System.Drawing.Point(109, 203);
            this.addNewStockTypeButton.Name = "addNewStockTypeButton";
            this.addNewStockTypeButton.Size = new System.Drawing.Size(94, 33);
            this.addNewStockTypeButton.TabIndex = 3;
            this.addNewStockTypeButton.Text = "ADD";
            this.addNewStockTypeButton.UseVisualStyleBackColor = true;
            this.addNewStockTypeButton.Click += new System.EventHandler(this.addNewStockTypeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Bundle Size";
            // 
            // defaultBundleSizeText
            // 
            this.defaultBundleSizeText.Location = new System.Drawing.Point(91, 156);
            this.defaultBundleSizeText.Name = "defaultBundleSizeText";
            this.defaultBundleSizeText.Size = new System.Drawing.Size(139, 23);
            this.defaultBundleSizeText.TabIndex = 2;
            // 
            // NewStockTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 267);
            this.Controls.Add(this.defaultBundleSizeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewStockTypeButton);
            this.Controls.Add(this.newStockTypeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewStockTypeForm";
            this.Text = "NewStockType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newStockTypeTextBox;
        private System.Windows.Forms.Button addNewStockTypeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox defaultBundleSizeText;
    }
}