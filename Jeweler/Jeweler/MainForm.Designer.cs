
namespace Jeweler
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.addProductBut = new System.Windows.Forms.Button();
            this.addOrderBut = new System.Windows.Forms.Button();
            this.getReportBut = new System.Windows.Forms.Button();
            this.entityList = new System.Windows.Forms.ComboBox();
            this.updateBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 44);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(807, 394);
            this.dataGrid.TabIndex = 0;
            // 
            // addProductBut
            // 
            this.addProductBut.Location = new System.Drawing.Point(498, 12);
            this.addProductBut.Name = "addProductBut";
            this.addProductBut.Size = new System.Drawing.Size(115, 26);
            this.addProductBut.TabIndex = 1;
            this.addProductBut.Text = "Добавить изделие";
            this.addProductBut.UseVisualStyleBackColor = true;
            this.addProductBut.Click += new System.EventHandler(this.AddProductBut_Click);
            // 
            // addOrderBut
            // 
            this.addOrderBut.Location = new System.Drawing.Point(619, 12);
            this.addOrderBut.Name = "addOrderBut";
            this.addOrderBut.Size = new System.Drawing.Size(104, 26);
            this.addOrderBut.TabIndex = 2;
            this.addOrderBut.Text = "Добавить заказ";
            this.addOrderBut.UseVisualStyleBackColor = true;
            this.addOrderBut.Click += new System.EventHandler(this.AddOrderBut_Click);
            // 
            // getReportBut
            // 
            this.getReportBut.Location = new System.Drawing.Point(729, 12);
            this.getReportBut.Name = "getReportBut";
            this.getReportBut.Size = new System.Drawing.Size(89, 26);
            this.getReportBut.TabIndex = 3;
            this.getReportBut.Text = "Отчёт";
            this.getReportBut.UseVisualStyleBackColor = true;
            this.getReportBut.Click += new System.EventHandler(this.GetReportBut_Click);
            // 
            // entityList
            // 
            this.entityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entityList.FormattingEnabled = true;
            this.entityList.Items.AddRange(new object[] {
            "Компании",
            "Поставщики",
            "Изделия",
            "Продажи"});
            this.entityList.Location = new System.Drawing.Point(12, 12);
            this.entityList.Name = "entityList";
            this.entityList.Size = new System.Drawing.Size(180, 24);
            this.entityList.TabIndex = 4;
            this.entityList.SelectedIndexChanged += new System.EventHandler(this.EntityList_IndexChanged);
            // 
            // updateBut
            // 
            this.updateBut.Location = new System.Drawing.Point(198, 10);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(65, 26);
            this.updateBut.TabIndex = 5;
            this.updateBut.Text = "Обновить";
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.updateBut);
            this.Controls.Add(this.entityList);
            this.Controls.Add(this.getReportBut);
            this.Controls.Add(this.addOrderBut);
            this.Controls.Add(this.addProductBut);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ювелир";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button addProductBut;
        private System.Windows.Forms.Button addOrderBut;
        private System.Windows.Forms.Button getReportBut;
        private System.Windows.Forms.ComboBox entityList;
        private System.Windows.Forms.Button updateBut;
    }
}

