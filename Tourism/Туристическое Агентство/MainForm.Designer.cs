
namespace Tourism
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vouchersInfoGrid = new System.Windows.Forms.DataGridView();
            this.addNewRecordBut = new System.Windows.Forms.Button();
            this.clientInfoBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vouchersInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vouchersInfoGrid
            // 
            this.vouchersInfoGrid.AllowUserToAddRows = false;
            this.vouchersInfoGrid.AllowUserToDeleteRows = false;
            this.vouchersInfoGrid.AllowUserToResizeColumns = false;
            this.vouchersInfoGrid.AllowUserToResizeRows = false;
            this.vouchersInfoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vouchersInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vouchersInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vouchersInfoGrid.Location = new System.Drawing.Point(-2, 38);
            this.vouchersInfoGrid.Name = "vouchersInfoGrid";
            this.vouchersInfoGrid.RowHeadersVisible = false;
            this.vouchersInfoGrid.Size = new System.Drawing.Size(1003, 530);
            this.vouchersInfoGrid.TabIndex = 0;
            // 
            // addNewRecordBut
            // 
            this.addNewRecordBut.Location = new System.Drawing.Point(9, 9);
            this.addNewRecordBut.Name = "addNewRecordBut";
            this.addNewRecordBut.Size = new System.Drawing.Size(75, 23);
            this.addNewRecordBut.TabIndex = 1;
            this.addNewRecordBut.Text = "Добавить";
            this.addNewRecordBut.UseVisualStyleBackColor = true;
            this.addNewRecordBut.Click += new System.EventHandler(this.AddNewRecordBut_Click);
            // 
            // clientInfoBut
            // 
            this.clientInfoBut.Location = new System.Drawing.Point(90, 9);
            this.clientInfoBut.Name = "clientInfoBut";
            this.clientInfoBut.Size = new System.Drawing.Size(112, 23);
            this.clientInfoBut.TabIndex = 2;
            this.clientInfoBut.Text = "Карточка клиента";
            this.clientInfoBut.UseVisualStyleBackColor = true;
            this.clientInfoBut.Click += new System.EventHandler(this.ClientInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 566);
            this.Controls.Add(this.clientInfoBut);
            this.Controls.Add(this.addNewRecordBut);
            this.Controls.Add(this.vouchersInfoGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристическое агентство";
            ((System.ComponentModel.ISupportInitialize)(this.vouchersInfoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vouchersInfoGrid;
        private System.Windows.Forms.Button addNewRecordBut;
        private System.Windows.Forms.Button clientInfoBut;
    }
}

