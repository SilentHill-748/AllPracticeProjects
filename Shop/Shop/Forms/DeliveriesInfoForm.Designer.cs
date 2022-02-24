
namespace Shop.Forms
{
    partial class DeliveriesInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveriesInfoForm));
            this.deliveriesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveriesGrid
            // 
            this.deliveriesGrid.AllowUserToAddRows = false;
            this.deliveriesGrid.AllowUserToDeleteRows = false;
            this.deliveriesGrid.AllowUserToResizeColumns = false;
            this.deliveriesGrid.AllowUserToResizeRows = false;
            this.deliveriesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveriesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.deliveriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveriesGrid.Location = new System.Drawing.Point(12, 12);
            this.deliveriesGrid.Name = "deliveriesGrid";
            this.deliveriesGrid.RowHeadersVisible = false;
            this.deliveriesGrid.Size = new System.Drawing.Size(726, 234);
            this.deliveriesGrid.TabIndex = 0;
            // 
            // DeliveriesInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(750, 258);
            this.Controls.Add(this.deliveriesGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveriesInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные по всем поставкам";
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deliveriesGrid;
    }
}