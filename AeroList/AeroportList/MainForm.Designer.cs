
namespace AeroportList
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
            this.aerolinesGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБроньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСписокБронированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоБронированиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.aerolinesGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aerolinesGrid
            // 
            this.aerolinesGrid.AllowUserToAddRows = false;
            this.aerolinesGrid.AllowUserToDeleteRows = false;
            this.aerolinesGrid.AllowUserToResizeColumns = false;
            this.aerolinesGrid.AllowUserToResizeRows = false;
            this.aerolinesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.aerolinesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aerolinesGrid.Location = new System.Drawing.Point(12, 27);
            this.aerolinesGrid.Name = "aerolinesGrid";
            this.aerolinesGrid.RowHeadersVisible = false;
            this.aerolinesGrid.Size = new System.Drawing.Size(798, 243);
            this.aerolinesGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьБроньToolStripMenuItem,
            this.показатьСписокБронированияToolStripMenuItem,
            this.отчетПоБронированиюToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьБроньToolStripMenuItem
            // 
            this.добавитьБроньToolStripMenuItem.Name = "добавитьБроньToolStripMenuItem";
            this.добавитьБроньToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.добавитьБроньToolStripMenuItem.Text = "Добавить бронь";
            this.добавитьБроньToolStripMenuItem.Click += new System.EventHandler(this.добавитьБроньToolStripMenuItem_Click);
            // 
            // показатьСписокБронированияToolStripMenuItem
            // 
            this.показатьСписокБронированияToolStripMenuItem.Name = "показатьСписокБронированияToolStripMenuItem";
            this.показатьСписокБронированияToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.показатьСписокБронированияToolStripMenuItem.Text = "Показать список бронирования";
            this.показатьСписокБронированияToolStripMenuItem.Click += new System.EventHandler(this.показатьСписокБронированияToolStripMenuItem_Click);
            // 
            // отчетПоБронированиюToolStripMenuItem
            // 
            this.отчетПоБронированиюToolStripMenuItem.Name = "отчетПоБронированиюToolStripMenuItem";
            this.отчетПоБронированиюToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.отчетПоБронированиюToolStripMenuItem.Text = "Отчет по бронированию";
            this.отчетПоБронированиюToolStripMenuItem.Click += new System.EventHandler(this.отчетПоБронированиюToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(821, 282);
            this.Controls.Add(this.aerolinesGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО МэйнЛайнс";
            ((System.ComponentModel.ISupportInitialize)(this.aerolinesGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aerolinesGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБроньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьСписокБронированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоБронированиюToolStripMenuItem;
    }
}

