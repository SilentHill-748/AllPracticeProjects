
namespace Shop
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОтчетПоПродажамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОтчётПоПоставкамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОтчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.AllowUserToResizeColumns = false;
            this.productsGrid.AllowUserToResizeRows = false;
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Location = new System.Drawing.Point(12, 27);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersVisible = false;
            this.productsGrid.Size = new System.Drawing.Size(535, 347);
            this.productsGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетностьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетностьToolStripMenuItem
            // 
            this.отчетностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьОтчетПоПродажамToolStripMenuItem,
            this.показатьОтчётПоПоставкамToolStripMenuItem,
            this.сохранитьОтчетыToolStripMenuItem});
            this.отчетностьToolStripMenuItem.Name = "отчетностьToolStripMenuItem";
            this.отчетностьToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.отчетностьToolStripMenuItem.Text = "Отчетность";
            // 
            // показатьОтчетПоПродажамToolStripMenuItem
            // 
            this.показатьОтчетПоПродажамToolStripMenuItem.Name = "показатьОтчетПоПродажамToolStripMenuItem";
            this.показатьОтчетПоПродажамToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.показатьОтчетПоПродажамToolStripMenuItem.Text = "Показать отчёт по продажам";
            this.показатьОтчетПоПродажамToolStripMenuItem.Click += new System.EventHandler(this.показатьОтчетПоПродажамToolStripMenuItem_Click);
            // 
            // показатьОтчётПоПоставкамToolStripMenuItem
            // 
            this.показатьОтчётПоПоставкамToolStripMenuItem.Name = "показатьОтчётПоПоставкамToolStripMenuItem";
            this.показатьОтчётПоПоставкамToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.показатьОтчётПоПоставкамToolStripMenuItem.Text = "Показать отчёт по поставкам";
            this.показатьОтчётПоПоставкамToolStripMenuItem.Click += new System.EventHandler(this.показатьОтчётПоПоставкамToolStripMenuItem_Click);
            // 
            // сохранитьОтчетыToolStripMenuItem
            // 
            this.сохранитьОтчетыToolStripMenuItem.Name = "сохранитьОтчетыToolStripMenuItem";
            this.сохранитьОтчетыToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.сохранитьОтчетыToolStripMenuItem.Text = "Сохранить отчеты";
            this.сохранитьОтчетыToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОтчетыToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 386);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин ООО \"Пятёрочка\"";
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьОтчетПоПродажамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьОтчётПоПоставкамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОтчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
    }
}

