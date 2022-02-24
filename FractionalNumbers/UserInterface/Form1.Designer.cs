
namespace UserInterface
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
            this.OperationComboBox = new System.Windows.Forms.ComboBox();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResultOfExponentiationLabel = new System.Windows.Forms.Label();
            this.ResultDegreeNumber = new System.Windows.Forms.Button();
            this.DegreeTextBox = new System.Windows.Forms.TextBox();
            this.ExponentiationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ResultOfReductionLabel = new System.Windows.Forms.Label();
            this.ReductionButton = new System.Windows.Forms.Button();
            this.ReductionNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.AvgResultLabel = new System.Windows.Forms.Label();
            this.SumResultLabel = new System.Windows.Forms.Label();
            this.ArrayNumsTextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.GetSumButton = new System.Windows.Forms.Button();
            this.GetAvgButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationComboBox
            // 
            this.OperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationComboBox.FormattingEnabled = true;
            this.OperationComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.OperationComboBox.Location = new System.Drawing.Point(150, 41);
            this.OperationComboBox.Name = "OperationComboBox";
            this.OperationComboBox.Size = new System.Drawing.Size(46, 32);
            this.OperationComboBox.TabIndex = 1;
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNumberTextBox.Location = new System.Drawing.Point(202, 41);
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(125, 32);
            this.SecondNumberTextBox.TabIndex = 2;
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNumberTextBox.Location = new System.Drawing.Point(19, 41);
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(125, 32);
            this.FirstNumberTextBox.TabIndex = 0;
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(19, 85);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(125, 33);
            this.ResultButton.TabIndex = 5;
            this.ResultButton.Text = "Рассчитать";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите числа и операцию.";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(14, 160);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(130, 26);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Результат: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 374);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ResultButton);
            this.tabPage1.Controls.Add(this.OperationComboBox);
            this.tabPage1.Controls.Add(this.SecondNumberTextBox);
            this.tabPage1.Controls.Add(this.ResultLabel);
            this.tabPage1.Controls.Add(this.FirstNumberTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(512, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Операции над дробями";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResultOfExponentiationLabel);
            this.tabPage2.Controls.Add(this.ResultDegreeNumber);
            this.tabPage2.Controls.Add(this.DegreeTextBox);
            this.tabPage2.Controls.Add(this.ExponentiationTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(512, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Возведение дроби в степень";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResultOfExponentiationLabel
            // 
            this.ResultOfExponentiationLabel.AutoSize = true;
            this.ResultOfExponentiationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultOfExponentiationLabel.Location = new System.Drawing.Point(15, 171);
            this.ResultOfExponentiationLabel.Name = "ResultOfExponentiationLabel";
            this.ResultOfExponentiationLabel.Size = new System.Drawing.Size(130, 26);
            this.ResultOfExponentiationLabel.TabIndex = 10;
            this.ResultOfExponentiationLabel.Text = "Результат: ";
            // 
            // ResultDegreeNumber
            // 
            this.ResultDegreeNumber.Location = new System.Drawing.Point(11, 107);
            this.ResultDegreeNumber.Name = "ResultDegreeNumber";
            this.ResultDegreeNumber.Size = new System.Drawing.Size(125, 33);
            this.ResultDegreeNumber.TabIndex = 9;
            this.ResultDegreeNumber.Text = "Возвести";
            this.ResultDegreeNumber.UseVisualStyleBackColor = true;
            this.ResultDegreeNumber.Click += new System.EventHandler(this.ResultDegreeNumber_Click);
            // 
            // DegreeTextBox
            // 
            this.DegreeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DegreeTextBox.Location = new System.Drawing.Point(142, 69);
            this.DegreeTextBox.Name = "DegreeTextBox";
            this.DegreeTextBox.Size = new System.Drawing.Size(51, 32);
            this.DegreeTextBox.TabIndex = 8;
            // 
            // ExponentiationTextBox
            // 
            this.ExponentiationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExponentiationTextBox.Location = new System.Drawing.Point(11, 69);
            this.ExponentiationTextBox.Name = "ExponentiationTextBox";
            this.ExponentiationTextBox.Size = new System.Drawing.Size(125, 32);
            this.ExponentiationTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Укажите число и степень.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ResultOfReductionLabel);
            this.tabPage3.Controls.Add(this.ReductionButton);
            this.tabPage3.Controls.Add(this.ReductionNumberTextBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(512, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сокращение дробей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ResultOfReductionLabel
            // 
            this.ResultOfReductionLabel.AutoSize = true;
            this.ResultOfReductionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultOfReductionLabel.Location = new System.Drawing.Point(6, 145);
            this.ResultOfReductionLabel.Name = "ResultOfReductionLabel";
            this.ResultOfReductionLabel.Size = new System.Drawing.Size(124, 26);
            this.ResultOfReductionLabel.TabIndex = 11;
            this.ResultOfReductionLabel.Text = "Результат:";
            // 
            // ReductionButton
            // 
            this.ReductionButton.Location = new System.Drawing.Point(142, 74);
            this.ReductionButton.Name = "ReductionButton";
            this.ReductionButton.Size = new System.Drawing.Size(125, 33);
            this.ReductionButton.TabIndex = 10;
            this.ReductionButton.Text = "Сократить";
            this.ReductionButton.UseVisualStyleBackColor = true;
            this.ReductionButton.Click += new System.EventHandler(this.ReductionButton_Click);
            // 
            // ReductionNumberTextBox
            // 
            this.ReductionNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReductionNumberTextBox.Location = new System.Drawing.Point(11, 75);
            this.ReductionNumberTextBox.Name = "ReductionNumberTextBox";
            this.ReductionNumberTextBox.Size = new System.Drawing.Size(125, 32);
            this.ReductionNumberTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Укажите число.";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AvgResultLabel);
            this.tabPage4.Controls.Add(this.SumResultLabel);
            this.tabPage4.Controls.Add(this.ArrayNumsTextBox);
            this.tabPage4.Controls.Add(this.SortButton);
            this.tabPage4.Controls.Add(this.GetSumButton);
            this.tabPage4.Controls.Add(this.GetAvgButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(512, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Работа с массивом";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AvgResultLabel
            // 
            this.AvgResultLabel.AutoSize = true;
            this.AvgResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgResultLabel.Location = new System.Drawing.Point(108, 135);
            this.AvgResultLabel.Name = "AvgResultLabel";
            this.AvgResultLabel.Size = new System.Drawing.Size(203, 24);
            this.AvgResultLabel.TabIndex = 5;
            this.AvgResultLabel.Text = "Среднее элементов: ";
            // 
            // SumResultLabel
            // 
            this.SumResultLabel.AutoSize = true;
            this.SumResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumResultLabel.Location = new System.Drawing.Point(108, 93);
            this.SumResultLabel.Name = "SumResultLabel";
            this.SumResultLabel.Size = new System.Drawing.Size(181, 24);
            this.SumResultLabel.TabIndex = 4;
            this.SumResultLabel.Text = "Сумма элементов: ";
            // 
            // ArrayNumsTextBox
            // 
            this.ArrayNumsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayNumsTextBox.Location = new System.Drawing.Point(6, 49);
            this.ArrayNumsTextBox.Multiline = true;
            this.ArrayNumsTextBox.Name = "ArrayNumsTextBox";
            this.ArrayNumsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayNumsTextBox.Size = new System.Drawing.Size(88, 293);
            this.ArrayNumsTextBox.TabIndex = 3;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(6, 6);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(137, 37);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Отсортировать массив";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // GetSumButton
            // 
            this.GetSumButton.Location = new System.Drawing.Point(149, 6);
            this.GetSumButton.Name = "GetSumButton";
            this.GetSumButton.Size = new System.Drawing.Size(88, 37);
            this.GetSumButton.TabIndex = 1;
            this.GetSumButton.Text = "Найти сумму элементов";
            this.GetSumButton.UseVisualStyleBackColor = true;
            this.GetSumButton.Click += new System.EventHandler(this.GetSumButton_Click);
            // 
            // GetAvgButton
            // 
            this.GetAvgButton.Location = new System.Drawing.Point(243, 6);
            this.GetAvgButton.Name = "GetAvgButton";
            this.GetAvgButton.Size = new System.Drawing.Size(160, 37);
            this.GetAvgButton.TabIndex = 0;
            this.GetAvgButton.Text = "Найти среднее арифметическое элементов";
            this.GetAvgButton.UseVisualStyleBackColor = true;
            this.GetAvgButton.Click += new System.EventHandler(this.GetAvgButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(12, 12);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(129, 26);
            this.CleanButton.TabIndex = 8;
            this.CleanButton.Text = "Очистить результаты";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(147, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(78, 26);
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "Справка";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(540, 435);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox OperationComboBox;
        private System.Windows.Forms.TextBox SecondNumberTextBox;
        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ResultOfExponentiationLabel;
        private System.Windows.Forms.Button ResultDegreeNumber;
        private System.Windows.Forms.TextBox DegreeTextBox;
        private System.Windows.Forms.TextBox ExponentiationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label ResultOfReductionLabel;
        private System.Windows.Forms.Button ReductionButton;
        private System.Windows.Forms.TextBox ReductionNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox ArrayNumsTextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button GetSumButton;
        private System.Windows.Forms.Button GetAvgButton;
        private System.Windows.Forms.Label AvgResultLabel;
        private System.Windows.Forms.Label SumResultLabel;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button HelpButton;
    }
}

