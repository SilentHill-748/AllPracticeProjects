
namespace TableUI
{
    partial class OperationsForm
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
            this.AddRowB = new System.Windows.Forms.Button();
            this.EditRowB = new System.Windows.Forms.Button();
            this.RemoveRowB = new System.Windows.Forms.Button();
            this.SelectRowsB = new System.Windows.Forms.Button();
            this.FindEmptyValueB = new System.Windows.Forms.Button();
            this.AddRowGB = new System.Windows.Forms.GroupBox();
            this.RowNumForEditTB = new System.Windows.Forms.TextBox();
            this.TextEditStringTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PageNumTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StringNumTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RowNumForRemoveCB = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SelectColumnTB = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColumnNameTB = new System.Windows.Forms.TextBox();
            this.FindValueTextTB = new System.Windows.Forms.TextBox();
            this.FindValueB = new System.Windows.Forms.Button();
            this.FindMinValueB = new System.Windows.Forms.Button();
            this.SelectConditionTB = new System.Windows.Forms.TextBox();
            this.SelectValueTB = new System.Windows.Forms.TextBox();
            this.AddRowGB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRowB
            // 
            this.AddRowB.Location = new System.Drawing.Point(191, 84);
            this.AddRowB.Name = "AddRowB";
            this.AddRowB.Size = new System.Drawing.Size(99, 23);
            this.AddRowB.TabIndex = 0;
            this.AddRowB.Text = "Добавить";
            this.AddRowB.UseVisualStyleBackColor = true;
            this.AddRowB.Click += new System.EventHandler(this.AddRowB_Click);
            // 
            // EditRowB
            // 
            this.EditRowB.Location = new System.Drawing.Point(191, 109);
            this.EditRowB.Name = "EditRowB";
            this.EditRowB.Size = new System.Drawing.Size(99, 23);
            this.EditRowB.TabIndex = 1;
            this.EditRowB.Text = "Редактировать";
            this.EditRowB.UseVisualStyleBackColor = true;
            this.EditRowB.Click += new System.EventHandler(this.EditRowB_Click);
            // 
            // RemoveRowB
            // 
            this.RemoveRowB.Location = new System.Drawing.Point(212, 15);
            this.RemoveRowB.Name = "RemoveRowB";
            this.RemoveRowB.Size = new System.Drawing.Size(75, 23);
            this.RemoveRowB.TabIndex = 2;
            this.RemoveRowB.Text = "Удалить";
            this.RemoveRowB.UseVisualStyleBackColor = true;
            this.RemoveRowB.Click += new System.EventHandler(this.RemoveRowB_Click);
            // 
            // SelectRowsB
            // 
            this.SelectRowsB.Location = new System.Drawing.Point(210, 9);
            this.SelectRowsB.Name = "SelectRowsB";
            this.SelectRowsB.Size = new System.Drawing.Size(80, 23);
            this.SelectRowsB.TabIndex = 3;
            this.SelectRowsB.Text = "Выбрать";
            this.SelectRowsB.UseVisualStyleBackColor = true;
            this.SelectRowsB.Click += new System.EventHandler(this.SelectRowsB_Click);
            // 
            // FindEmptyValueB
            // 
            this.FindEmptyValueB.Location = new System.Drawing.Point(113, 97);
            this.FindEmptyValueB.Name = "FindEmptyValueB";
            this.FindEmptyValueB.Size = new System.Drawing.Size(174, 22);
            this.FindEmptyValueB.TabIndex = 4;
            this.FindEmptyValueB.Text = "Записи с пустыми значениями";
            this.FindEmptyValueB.UseVisualStyleBackColor = true;
            this.FindEmptyValueB.Click += new System.EventHandler(this.FindEmptyValueB_Click);
            // 
            // AddRowGB
            // 
            this.AddRowGB.Controls.Add(this.RowNumForEditTB);
            this.AddRowGB.Controls.Add(this.TextEditStringTB);
            this.AddRowGB.Controls.Add(this.label8);
            this.AddRowGB.Controls.Add(this.PageNumTB);
            this.AddRowGB.Controls.Add(this.label3);
            this.AddRowGB.Controls.Add(this.label2);
            this.AddRowGB.Controls.Add(this.label6);
            this.AddRowGB.Controls.Add(this.EditRowB);
            this.AddRowGB.Controls.Add(this.label1);
            this.AddRowGB.Controls.Add(this.AddRowB);
            this.AddRowGB.Controls.Add(this.StringNumTB);
            this.AddRowGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRowGB.Location = new System.Drawing.Point(12, 12);
            this.AddRowGB.Name = "AddRowGB";
            this.AddRowGB.Size = new System.Drawing.Size(296, 161);
            this.AddRowGB.TabIndex = 14;
            this.AddRowGB.TabStop = false;
            this.AddRowGB.Text = "Добавление/изменения";
            // 
            // RowNumForEditTB
            // 
            this.RowNumForEditTB.Location = new System.Drawing.Point(166, 38);
            this.RowNumForEditTB.Name = "RowNumForEditTB";
            this.RowNumForEditTB.Size = new System.Drawing.Size(29, 20);
            this.RowNumForEditTB.TabIndex = 24;
            // 
            // TextEditStringTB
            // 
            this.TextEditStringTB.Location = new System.Drawing.Point(6, 135);
            this.TextEditStringTB.Name = "TextEditStringTB";
            this.TextEditStringTB.Size = new System.Drawing.Size(284, 20);
            this.TextEditStringTB.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Номер записи для изменения";
            // 
            // PageNumTB
            // 
            this.PageNumTB.Location = new System.Drawing.Point(105, 70);
            this.PageNumTB.Name = "PageNumTB";
            this.PageNumTB.Size = new System.Drawing.Size(40, 20);
            this.PageNumTB.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Текст изменения строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Номер строки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введите те данные, которые хотите изменить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номер страницы";
            // 
            // StringNumTB
            // 
            this.StringNumTB.Location = new System.Drawing.Point(105, 91);
            this.StringNumTB.Name = "StringNumTB";
            this.StringNumTB.Size = new System.Drawing.Size(40, 20);
            this.StringNumTB.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.RowNumForRemoveCB);
            this.groupBox3.Controls.Add(this.RemoveRowB);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 45);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Номер записи для удаления";
            // 
            // RowNumForRemoveCB
            // 
            this.RowNumForRemoveCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RowNumForRemoveCB.FormattingEnabled = true;
            this.RowNumForRemoveCB.Location = new System.Drawing.Point(163, 16);
            this.RowNumForRemoveCB.Name = "RowNumForRemoveCB";
            this.RowNumForRemoveCB.Size = new System.Drawing.Size(43, 21);
            this.RowNumForRemoveCB.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SelectValueTB);
            this.groupBox4.Controls.Add(this.SelectConditionTB);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.SelectColumnTB);
            this.groupBox4.Controls.Add(this.SelectRowsB);
            this.groupBox4.Location = new System.Drawing.Point(319, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 76);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выборка данных";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Условие отбора";
            // 
            // SelectColumnTB
            // 
            this.SelectColumnTB.Location = new System.Drawing.Point(6, 38);
            this.SelectColumnTB.Name = "SelectColumnTB";
            this.SelectColumnTB.Size = new System.Drawing.Size(125, 20);
            this.SelectColumnTB.TabIndex = 25;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.ColumnNameTB);
            this.groupBox5.Controls.Add(this.FindEmptyValueB);
            this.groupBox5.Controls.Add(this.FindValueTextTB);
            this.groupBox5.Controls.Add(this.FindValueB);
            this.groupBox5.Controls.Add(this.FindMinValueB);
            this.groupBox5.Location = new System.Drawing.Point(319, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 128);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поиск";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Имя столбца";
            // 
            // ColumnNameTB
            // 
            this.ColumnNameTB.Location = new System.Drawing.Point(82, 45);
            this.ColumnNameTB.Name = "ColumnNameTB";
            this.ColumnNameTB.Size = new System.Drawing.Size(205, 20);
            this.ColumnNameTB.TabIndex = 19;
            // 
            // FindValueTextTB
            // 
            this.FindValueTextTB.Location = new System.Drawing.Point(82, 17);
            this.FindValueTextTB.Name = "FindValueTextTB";
            this.FindValueTextTB.Size = new System.Drawing.Size(116, 20);
            this.FindValueTextTB.TabIndex = 18;
            // 
            // FindValueB
            // 
            this.FindValueB.Location = new System.Drawing.Point(201, 15);
            this.FindValueB.Name = "FindValueB";
            this.FindValueB.Size = new System.Drawing.Size(86, 23);
            this.FindValueB.TabIndex = 6;
            this.FindValueB.Text = "По значению";
            this.FindValueB.UseVisualStyleBackColor = true;
            this.FindValueB.Click += new System.EventHandler(this.FindValueB_Click);
            // 
            // FindMinValueB
            // 
            this.FindMinValueB.Location = new System.Drawing.Point(113, 71);
            this.FindMinValueB.Name = "FindMinValueB";
            this.FindMinValueB.Size = new System.Drawing.Size(174, 22);
            this.FindMinValueB.TabIndex = 5;
            this.FindMinValueB.Text = "Мин. значение в столбце";
            this.FindMinValueB.UseVisualStyleBackColor = true;
            this.FindMinValueB.Click += new System.EventHandler(this.FindMinValueB_Click);
            // 
            // SelectConditionTB
            // 
            this.SelectConditionTB.Location = new System.Drawing.Point(137, 38);
            this.SelectConditionTB.Name = "SelectConditionTB";
            this.SelectConditionTB.Size = new System.Drawing.Size(28, 20);
            this.SelectConditionTB.TabIndex = 27;
            // 
            // SelectValueTB
            // 
            this.SelectValueTB.Location = new System.Drawing.Point(171, 38);
            this.SelectValueTB.Name = "SelectValueTB";
            this.SelectValueTB.Size = new System.Drawing.Size(119, 20);
            this.SelectValueTB.TabIndex = 28;
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 231);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AddRowGB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операции над таблицей.";
            this.AddRowGB.ResumeLayout(false);
            this.AddRowGB.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddRowB;
        private System.Windows.Forms.Button EditRowB;
        private System.Windows.Forms.Button RemoveRowB;
        private System.Windows.Forms.Button SelectRowsB;
        private System.Windows.Forms.Button FindEmptyValueB;
        private System.Windows.Forms.GroupBox AddRowGB;
        private System.Windows.Forms.TextBox TextEditStringTB;
        private System.Windows.Forms.TextBox PageNumTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StringNumTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox FindValueTextTB;
        private System.Windows.Forms.Button FindValueB;
        private System.Windows.Forms.Button FindMinValueB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RowNumForRemoveCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SelectColumnTB;
        private System.Windows.Forms.TextBox RowNumForEditTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColumnNameTB;
        private System.Windows.Forms.TextBox SelectValueTB;
        private System.Windows.Forms.TextBox SelectConditionTB;
    }
}