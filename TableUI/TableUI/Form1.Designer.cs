
namespace TableUI
{
    partial class Form1
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.OperationMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SortMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ByNumberRowMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ByNumberPageMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ByNumberLineMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ByTextEditMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ByDateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TableRTB = new System.Windows.Forms.RichTextBox();
            this.ResultTableRTB = new System.Windows.Forms.RichTextBox();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationMenuStrip,
            this.SortMenuStrip,
            this.ClearMenuStrip,
            this.HelpMenuStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(837, 24);
            this.MenuStrip.TabIndex = 10;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // OperationMenuStrip
            // 
            this.OperationMenuStrip.Name = "OperationMenuStrip";
            this.OperationMenuStrip.Size = new System.Drawing.Size(152, 20);
            this.OperationMenuStrip.Text = "Операции над таблицей";
            this.OperationMenuStrip.Click += new System.EventHandler(this.OperationMenuStrip_Click);
            // 
            // SortMenuStrip
            // 
            this.SortMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ByNumberRowMI,
            this.ByNumberPageMI,
            this.ByNumberLineMI,
            this.ByTextEditMI,
            this.ByDateMenuItem});
            this.SortMenuStrip.Name = "SortMenuStrip";
            this.SortMenuStrip.Size = new System.Drawing.Size(85, 20);
            this.SortMenuStrip.Text = "Сортировка";
            // 
            // ByNumberRowMI
            // 
            this.ByNumberRowMI.Name = "ByNumberRowMI";
            this.ByNumberRowMI.Size = new System.Drawing.Size(192, 22);
            this.ByNumberRowMI.Text = "По номеру записи";
            this.ByNumberRowMI.Click += new System.EventHandler(this.ByNumberRowMI_Click);
            // 
            // ByNumberPageMI
            // 
            this.ByNumberPageMI.Name = "ByNumberPageMI";
            this.ByNumberPageMI.Size = new System.Drawing.Size(192, 22);
            this.ByNumberPageMI.Text = "По номеру страницы";
            this.ByNumberPageMI.Click += new System.EventHandler(this.ByNumberPageMI_Click);
            // 
            // ByNumberLineMI
            // 
            this.ByNumberLineMI.Name = "ByNumberLineMI";
            this.ByNumberLineMI.Size = new System.Drawing.Size(192, 22);
            this.ByNumberLineMI.Text = "По номеру строки";
            this.ByNumberLineMI.Click += new System.EventHandler(this.ByNumberLineMI_Click);
            // 
            // ByTextEditMI
            // 
            this.ByTextEditMI.Name = "ByTextEditMI";
            this.ByTextEditMI.Size = new System.Drawing.Size(192, 22);
            this.ByTextEditMI.Text = "По тексту изменения";
            this.ByTextEditMI.Click += new System.EventHandler(this.ByTextEditMI_Click);
            // 
            // ByDateMenuItem
            // 
            this.ByDateMenuItem.Name = "ByDateMenuItem";
            this.ByDateMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ByDateMenuItem.Text = "По дате изменения";
            this.ByDateMenuItem.Click += new System.EventHandler(this.ByDateMenuItem_Click);
            // 
            // ClearMenuStrip
            // 
            this.ClearMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearAllMenuItem});
            this.ClearMenuStrip.Name = "ClearMenuStrip";
            this.ClearMenuStrip.Size = new System.Drawing.Size(109, 20);
            this.ClearMenuStrip.Text = "Очистка данных";
            // 
            // ClearAllMenuItem
            // 
            this.ClearAllMenuItem.Name = "ClearAllMenuItem";
            this.ClearAllMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ClearAllMenuItem.Text = "Очистка всех данных";
            this.ClearAllMenuItem.Click += new System.EventHandler(this.ClearAllMenuItem_Click);
            // 
            // HelpMenuStrip
            // 
            this.HelpMenuStrip.Name = "HelpMenuStrip";
            this.HelpMenuStrip.Size = new System.Drawing.Size(65, 20);
            this.HelpMenuStrip.Text = "Справка";
            this.HelpMenuStrip.Click += new System.EventHandler(this.HelpMenuStrip_Click);
            // 
            // TableRTB
            // 
            this.TableRTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableRTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TableRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableRTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableRTB.Location = new System.Drawing.Point(0, 27);
            this.TableRTB.Name = "TableRTB";
            this.TableRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TableRTB.ShortcutsEnabled = false;
            this.TableRTB.Size = new System.Drawing.Size(837, 272);
            this.TableRTB.TabIndex = 1;
            this.TableRTB.Text = "";
            // 
            // ResultTableRTB
            // 
            this.ResultTableRTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTableRTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ResultTableRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTableRTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTableRTB.Location = new System.Drawing.Point(0, 305);
            this.ResultTableRTB.Name = "ResultTableRTB";
            this.ResultTableRTB.ReadOnly = true;
            this.ResultTableRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ResultTableRTB.ShortcutsEnabled = false;
            this.ResultTableRTB.Size = new System.Drawing.Size(837, 263);
            this.ResultTableRTB.TabIndex = 11;
            this.ResultTableRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(837, 575);
            this.Controls.Add(this.ResultTableRTB);
            this.Controls.Add(this.TableRTB);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OperationMenuStrip;
        private System.Windows.Forms.RichTextBox TableRTB;
        private System.Windows.Forms.ToolStripMenuItem SortMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ByNumberRowMI;
        private System.Windows.Forms.ToolStripMenuItem ByNumberPageMI;
        private System.Windows.Forms.ToolStripMenuItem ByNumberLineMI;
        private System.Windows.Forms.ToolStripMenuItem ByTextEditMI;
        private System.Windows.Forms.ToolStripMenuItem ByDateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearAllMenuItem;
        private System.Windows.Forms.RichTextBox ResultTableRTB;
    }
}

