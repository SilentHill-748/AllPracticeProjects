
namespace ExamApp
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
            this.UserTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.EditValuesTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchValueTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchMinimumButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.ColumnsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectValueTextBox = new System.Windows.Forms.TextBox();
            this.SelectColumnNames = new System.Windows.Forms.ComboBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectCondition = new System.Windows.Forms.ComboBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.RowNumTextBox = new System.Windows.Forms.TextBox();
            this.EditRowNumTextBox = new System.Windows.Forms.TextBox();
            this.SearchColumnsNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTable
            // 
            this.UserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable.Location = new System.Drawing.Point(18, 303);
            this.UserTable.Name = "UserTable";
            this.UserTable.Size = new System.Drawing.Size(686, 322);
            this.UserTable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InsertButton);
            this.groupBox1.Controls.Add(this.AddTextBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить запись";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EditRowNumTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EditButton);
            this.groupBox2.Controls.Add(this.EditValuesTextBox);
            this.groupBox2.Location = new System.Drawing.Point(21, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменить запись";
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(6, 19);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(320, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(6, 45);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // EditValuesTextBox
            // 
            this.EditValuesTextBox.Location = new System.Drawing.Point(6, 45);
            this.EditValuesTextBox.Name = "EditValuesTextBox";
            this.EditValuesTextBox.Size = new System.Drawing.Size(320, 20);
            this.EditValuesTextBox.TabIndex = 2;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(251, 19);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RowNumTextBox);
            this.groupBox3.Controls.Add(this.DeleteAllButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.Location = new System.Drawing.Point(21, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 51);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление записей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(153, 19);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Location = new System.Drawing.Point(234, 19);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(92, 23);
            this.DeleteAllButton.TabIndex = 5;
            this.DeleteAllButton.Text = "Удалить все";
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SearchColumnsNameComboBox);
            this.groupBox4.Controls.Add(this.SearchMinimumButton);
            this.groupBox4.Controls.Add(this.SearchButton);
            this.groupBox4.Controls.Add(this.SearchValueTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(367, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 83);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Значение поля";
            // 
            // SearchValueTextBox
            // 
            this.SearchValueTextBox.Location = new System.Drawing.Point(94, 23);
            this.SearchValueTextBox.Name = "SearchValueTextBox";
            this.SearchValueTextBox.Size = new System.Drawing.Size(232, 20);
            this.SearchValueTextBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(251, 49);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchMinimumButton
            // 
            this.SearchMinimumButton.Location = new System.Drawing.Point(145, 49);
            this.SearchMinimumButton.Name = "SearchMinimumButton";
            this.SearchMinimumButton.Size = new System.Drawing.Size(100, 23);
            this.SearchMinimumButton.TabIndex = 7;
            this.SearchMinimumButton.Text = "Найти минимум";
            this.SearchMinimumButton.UseVisualStyleBackColor = true;
            this.SearchMinimumButton.Click += new System.EventHandler(this.SearchMinimumButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.ColumnsComboBox);
            this.groupBox5.Controls.Add(this.SortButton);
            this.groupBox5.Location = new System.Drawing.Point(367, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 51);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сортировка";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(238, 20);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(88, 23);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ColumnsComboBox
            // 
            this.ColumnsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnsComboBox.FormattingEnabled = true;
            this.ColumnsComboBox.Items.AddRange(new object[] {
            "Номер",
            "Имя",
            "Фамилия",
            "Отчество",
            "Дата рождения",
            "Адрес"});
            this.ColumnsComboBox.Location = new System.Drawing.Point(99, 21);
            this.ColumnsComboBox.Name = "ColumnsComboBox";
            this.ColumnsComboBox.Size = new System.Drawing.Size(133, 21);
            this.ColumnsComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название поля";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SelectCondition);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.SelectButton);
            this.groupBox6.Controls.Add(this.SelectColumnNames);
            this.groupBox6.Controls.Add(this.SelectValueTextBox);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(367, 187);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 110);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Выборка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Значение поля";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Название поля";
            // 
            // SelectValueTextBox
            // 
            this.SelectValueTextBox.Location = new System.Drawing.Point(99, 51);
            this.SelectValueTextBox.Name = "SelectValueTextBox";
            this.SelectValueTextBox.Size = new System.Drawing.Size(227, 20);
            this.SelectValueTextBox.TabIndex = 10;
            // 
            // SelectColumnNames
            // 
            this.SelectColumnNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectColumnNames.FormattingEnabled = true;
            this.SelectColumnNames.Items.AddRange(new object[] {
            "Номер",
            "Имя",
            "Фамилия",
            "Отчество",
            "Дата рождения",
            "Адрес"});
            this.SelectColumnNames.Location = new System.Drawing.Point(99, 23);
            this.SelectColumnNames.Name = "SelectColumnNames";
            this.SelectColumnNames.Size = new System.Drawing.Size(139, 21);
            this.SelectColumnNames.TabIndex = 9;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(244, 21);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(82, 23);
            this.SelectButton.TabIndex = 8;
            this.SelectButton.Text = "Выбрать";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Условие";
            // 
            // SelectCondition
            // 
            this.SelectCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCondition.FormattingEnabled = true;
            this.SelectCondition.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.SelectCondition.Location = new System.Drawing.Point(99, 77);
            this.SelectCondition.Name = "SelectCondition";
            this.SelectCondition.Size = new System.Drawing.Size(38, 21);
            this.SelectCondition.TabIndex = 12;
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(12, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 23);
            this.HelpButton.TabIndex = 10;
            this.HelpButton.Text = "Справка";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // RowNumTextBox
            // 
            this.RowNumTextBox.Location = new System.Drawing.Point(53, 22);
            this.RowNumTextBox.Name = "RowNumTextBox";
            this.RowNumTextBox.Size = new System.Drawing.Size(52, 20);
            this.RowNumTextBox.TabIndex = 2;
            // 
            // EditRowNumTextBox
            // 
            this.EditRowNumTextBox.Location = new System.Drawing.Point(53, 21);
            this.EditRowNumTextBox.Name = "EditRowNumTextBox";
            this.EditRowNumTextBox.Size = new System.Drawing.Size(52, 20);
            this.EditRowNumTextBox.TabIndex = 6;
            // 
            // SearchColumnsNameComboBox
            // 
            this.SearchColumnsNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchColumnsNameComboBox.FormattingEnabled = true;
            this.SearchColumnsNameComboBox.Items.AddRange(new object[] {
            "Номер",
            "Имя",
            "Фамилия",
            "Отчество",
            "Дата рождения",
            "Адрес"});
            this.SearchColumnsNameComboBox.Location = new System.Drawing.Point(6, 49);
            this.SearchColumnsNameComboBox.Name = "SearchColumnsNameComboBox";
            this.SearchColumnsNameComboBox.Size = new System.Drawing.Size(133, 21);
            this.SearchColumnsNameComboBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(716, 637);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserTable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Таблица";
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox EditValuesTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteAllButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SearchMinimumButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ColumnsComboBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox SelectCondition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ComboBox SelectColumnNames;
        private System.Windows.Forms.TextBox SelectValueTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.TextBox EditRowNumTextBox;
        private System.Windows.Forms.TextBox RowNumTextBox;
        private System.Windows.Forms.ComboBox SearchColumnsNameComboBox;
    }
}

