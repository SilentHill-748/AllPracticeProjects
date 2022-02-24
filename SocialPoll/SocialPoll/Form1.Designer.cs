namespace SocialPoll
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.counterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fourthquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fifthquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixthquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialPollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_for_AppDataSet = new SocialPoll.DataBase_for_AppDataSet();
            this.social_PollTableAdapter = new SocialPoll.DataBase_for_AppDataSetTableAdapters.Social_PollTableAdapter();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.AddTenRecordsButton = new System.Windows.Forms.Button();
            this.RemoveLastRecordButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialPollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_for_AppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counterDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.firstquestionDataGridViewTextBoxColumn,
            this.secondquestionDataGridViewTextBoxColumn,
            this.thirdquestionDataGridViewTextBoxColumn,
            this.fourthquestionDataGridViewTextBoxColumn,
            this.fifthquestionDataGridViewTextBoxColumn,
            this.sixthquestionDataGridViewTextBoxColumn,
            this.source1DataGridViewTextBoxColumn,
            this.source2DataGridViewTextBoxColumn,
            this.source3DataGridViewTextBoxColumn,
            this.source4DataGridViewTextBoxColumn,
            this.source5DataGridViewTextBoxColumn,
            this.source6DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.socialPollBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1544, 589);
            this.dataGridView1.TabIndex = 0;
            // 
            // counterDataGridViewTextBoxColumn
            // 
            this.counterDataGridViewTextBoxColumn.DataPropertyName = "Counter";
            this.counterDataGridViewTextBoxColumn.HeaderText = "Counter";
            this.counterDataGridViewTextBoxColumn.Name = "counterDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // firstquestionDataGridViewTextBoxColumn
            // 
            this.firstquestionDataGridViewTextBoxColumn.DataPropertyName = "First_question";
            this.firstquestionDataGridViewTextBoxColumn.HeaderText = "First_question";
            this.firstquestionDataGridViewTextBoxColumn.Name = "firstquestionDataGridViewTextBoxColumn";
            // 
            // secondquestionDataGridViewTextBoxColumn
            // 
            this.secondquestionDataGridViewTextBoxColumn.DataPropertyName = "Second_question";
            this.secondquestionDataGridViewTextBoxColumn.HeaderText = "Second_question";
            this.secondquestionDataGridViewTextBoxColumn.Name = "secondquestionDataGridViewTextBoxColumn";
            // 
            // thirdquestionDataGridViewTextBoxColumn
            // 
            this.thirdquestionDataGridViewTextBoxColumn.DataPropertyName = "Third_question";
            this.thirdquestionDataGridViewTextBoxColumn.HeaderText = "Third_question";
            this.thirdquestionDataGridViewTextBoxColumn.Name = "thirdquestionDataGridViewTextBoxColumn";
            // 
            // fourthquestionDataGridViewTextBoxColumn
            // 
            this.fourthquestionDataGridViewTextBoxColumn.DataPropertyName = "Fourth_question";
            this.fourthquestionDataGridViewTextBoxColumn.HeaderText = "Fourth_question";
            this.fourthquestionDataGridViewTextBoxColumn.Name = "fourthquestionDataGridViewTextBoxColumn";
            // 
            // fifthquestionDataGridViewTextBoxColumn
            // 
            this.fifthquestionDataGridViewTextBoxColumn.DataPropertyName = "Fifth_question";
            this.fifthquestionDataGridViewTextBoxColumn.HeaderText = "Fifth_question";
            this.fifthquestionDataGridViewTextBoxColumn.Name = "fifthquestionDataGridViewTextBoxColumn";
            // 
            // sixthquestionDataGridViewTextBoxColumn
            // 
            this.sixthquestionDataGridViewTextBoxColumn.DataPropertyName = "Sixth_question";
            this.sixthquestionDataGridViewTextBoxColumn.HeaderText = "Sixth_question";
            this.sixthquestionDataGridViewTextBoxColumn.Name = "sixthquestionDataGridViewTextBoxColumn";
            // 
            // source1DataGridViewTextBoxColumn
            // 
            this.source1DataGridViewTextBoxColumn.DataPropertyName = "Source_1";
            this.source1DataGridViewTextBoxColumn.HeaderText = "Source_1";
            this.source1DataGridViewTextBoxColumn.Name = "source1DataGridViewTextBoxColumn";
            // 
            // source2DataGridViewTextBoxColumn
            // 
            this.source2DataGridViewTextBoxColumn.DataPropertyName = "Source_2";
            this.source2DataGridViewTextBoxColumn.HeaderText = "Source_2";
            this.source2DataGridViewTextBoxColumn.Name = "source2DataGridViewTextBoxColumn";
            // 
            // source3DataGridViewTextBoxColumn
            // 
            this.source3DataGridViewTextBoxColumn.DataPropertyName = "Source_3";
            this.source3DataGridViewTextBoxColumn.HeaderText = "Source_3";
            this.source3DataGridViewTextBoxColumn.Name = "source3DataGridViewTextBoxColumn";
            // 
            // source4DataGridViewTextBoxColumn
            // 
            this.source4DataGridViewTextBoxColumn.DataPropertyName = "Source_4";
            this.source4DataGridViewTextBoxColumn.HeaderText = "Source_4";
            this.source4DataGridViewTextBoxColumn.Name = "source4DataGridViewTextBoxColumn";
            // 
            // source5DataGridViewTextBoxColumn
            // 
            this.source5DataGridViewTextBoxColumn.DataPropertyName = "Source_5";
            this.source5DataGridViewTextBoxColumn.HeaderText = "Source_5";
            this.source5DataGridViewTextBoxColumn.Name = "source5DataGridViewTextBoxColumn";
            // 
            // source6DataGridViewTextBoxColumn
            // 
            this.source6DataGridViewTextBoxColumn.DataPropertyName = "Source_6";
            this.source6DataGridViewTextBoxColumn.HeaderText = "Source_6";
            this.source6DataGridViewTextBoxColumn.Name = "source6DataGridViewTextBoxColumn";
            // 
            // socialPollBindingSource
            // 
            this.socialPollBindingSource.DataMember = "Social_Poll";
            this.socialPollBindingSource.DataSource = this.dataBase_for_AppDataSet;
            // 
            // dataBase_for_AppDataSet
            // 
            this.dataBase_for_AppDataSet.DataSetName = "DataBase_for_AppDataSet";
            this.dataBase_for_AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // social_PollTableAdapter
            // 
            this.social_PollTableAdapter.ClearBeforeFill = true;
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(12, 607);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(128, 40);
            this.AddRecordButton.TabIndex = 1;
            this.AddRecordButton.Text = "Добавить 1 запись";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // AddTenRecordsButton
            // 
            this.AddTenRecordsButton.Location = new System.Drawing.Point(12, 653);
            this.AddTenRecordsButton.Name = "AddTenRecordsButton";
            this.AddTenRecordsButton.Size = new System.Drawing.Size(128, 40);
            this.AddTenRecordsButton.TabIndex = 2;
            this.AddTenRecordsButton.Text = "Добавить 10 записей";
            this.AddTenRecordsButton.UseVisualStyleBackColor = true;
            this.AddTenRecordsButton.Click += new System.EventHandler(this.AddTenRecordsButton_Click);
            // 
            // RemoveLastRecordButton
            // 
            this.RemoveLastRecordButton.Location = new System.Drawing.Point(185, 607);
            this.RemoveLastRecordButton.Name = "RemoveLastRecordButton";
            this.RemoveLastRecordButton.Size = new System.Drawing.Size(128, 40);
            this.RemoveLastRecordButton.TabIndex = 3;
            this.RemoveLastRecordButton.Text = "Удалить последнюю запись";
            this.RemoveLastRecordButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(447, 664);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Укажите с какого ID начинать вставлять записи.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.RemoveLastRecordButton);
            this.Controls.Add(this.AddTenRecordsButton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Работа с базой данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialPollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_for_AppDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBase_for_AppDataSet dataBase_for_AppDataSet;
        private System.Windows.Forms.BindingSource socialPollBindingSource;
        private DataBase_for_AppDataSetTableAdapters.Social_PollTableAdapter social_PollTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fourthquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fifthquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixthquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn source1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn source2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn source3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn source4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn source5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn source6DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button AddTenRecordsButton;
        private System.Windows.Forms.Button RemoveLastRecordButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}

