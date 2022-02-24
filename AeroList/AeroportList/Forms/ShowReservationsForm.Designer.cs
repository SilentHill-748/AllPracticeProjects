
namespace AeroportList.Forms
{
    partial class ShowReservationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowReservationsForm));
            this.reservationsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationsGrid
            // 
            this.reservationsGrid.AllowUserToAddRows = false;
            this.reservationsGrid.AllowUserToDeleteRows = false;
            this.reservationsGrid.AllowUserToResizeColumns = false;
            this.reservationsGrid.AllowUserToResizeRows = false;
            this.reservationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reservationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsGrid.Location = new System.Drawing.Point(12, 12);
            this.reservationsGrid.Name = "reservationsGrid";
            this.reservationsGrid.RowHeadersVisible = false;
            this.reservationsGrid.Size = new System.Drawing.Size(528, 411);
            this.reservationsGrid.TabIndex = 0;
            // 
            // ShowReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(555, 433);
            this.Controls.Add(this.reservationsGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные по бронированию";
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationsGrid;
    }
}