
namespace ExamProject
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.NumI = new System.Windows.Forms.Button();
            this.NumV = new System.Windows.Forms.Button();
            this.NumX = new System.Windows.Forms.Button();
            this.NumC = new System.Windows.Forms.Button();
            this.NumD = new System.Windows.Forms.Button();
            this.NumM = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultBut = new System.Windows.Forms.Button();
            this.Operations = new System.Windows.Forms.ComboBox();
            this.Clean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CleanSortArgs = new System.Windows.Forms.Button();
            this.SortIntResult = new System.Windows.Forms.TextBox();
            this.SortBut = new System.Windows.Forms.Button();
            this.SortRomeResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CleanFindArgs = new System.Windows.Forms.Button();
            this.ResultFindedIntNums = new System.Windows.Forms.TextBox();
            this.ResultFindedRomeNums = new System.Windows.Forms.TextBox();
            this.FindExists = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputIntNumbers = new System.Windows.Forms.TextBox();
            this.InputRomeNumbers = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(6, 19);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.Size = new System.Drawing.Size(239, 24);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // NumI
            // 
            this.NumI.Location = new System.Drawing.Point(6, 85);
            this.NumI.Name = "NumI";
            this.NumI.Size = new System.Drawing.Size(29, 23);
            this.NumI.TabIndex = 1;
            this.NumI.Text = "I";
            this.NumI.UseVisualStyleBackColor = true;
            this.NumI.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // NumV
            // 
            this.NumV.Location = new System.Drawing.Point(41, 85);
            this.NumV.Name = "NumV";
            this.NumV.Size = new System.Drawing.Size(29, 23);
            this.NumV.TabIndex = 2;
            this.NumV.Text = "V";
            this.NumV.UseVisualStyleBackColor = true;
            this.NumV.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // NumX
            // 
            this.NumX.Location = new System.Drawing.Point(76, 85);
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(29, 23);
            this.NumX.TabIndex = 3;
            this.NumX.Text = "X";
            this.NumX.UseVisualStyleBackColor = true;
            this.NumX.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // NumC
            // 
            this.NumC.Location = new System.Drawing.Point(146, 85);
            this.NumC.Name = "NumC";
            this.NumC.Size = new System.Drawing.Size(29, 23);
            this.NumC.TabIndex = 4;
            this.NumC.Text = "C";
            this.NumC.UseVisualStyleBackColor = true;
            this.NumC.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // NumD
            // 
            this.NumD.Location = new System.Drawing.Point(181, 85);
            this.NumD.Name = "NumD";
            this.NumD.Size = new System.Drawing.Size(29, 23);
            this.NumD.TabIndex = 5;
            this.NumD.Text = "D";
            this.NumD.UseVisualStyleBackColor = true;
            this.NumD.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // NumM
            // 
            this.NumM.Location = new System.Drawing.Point(216, 85);
            this.NumM.Name = "NumM";
            this.NumM.Size = new System.Drawing.Size(29, 23);
            this.NumM.TabIndex = 6;
            this.NumM.Text = "M";
            this.NumM.UseVisualStyleBackColor = true;
            this.NumM.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(6, 49);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(239, 24);
            this.ResultTextBox.TabIndex = 12;
            // 
            // ResultBut
            // 
            this.ResultBut.Enabled = false;
            this.ResultBut.Location = new System.Drawing.Point(6, 114);
            this.ResultBut.Name = "ResultBut";
            this.ResultBut.Size = new System.Drawing.Size(85, 23);
            this.ResultBut.TabIndex = 19;
            this.ResultBut.Text = "Результат";
            this.ResultBut.UseVisualStyleBackColor = true;
            this.ResultBut.Click += new System.EventHandler(this.ResultBut_Click);
            // 
            // Operations
            // 
            this.Operations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operations.FormattingEnabled = true;
            this.Operations.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            ">",
            "<",
            ">=",
            "<=",
            "==",
            "!="});
            this.Operations.Location = new System.Drawing.Point(193, 115);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(52, 21);
            this.Operations.TabIndex = 20;
            this.Operations.SelectedIndexChanged += new System.EventHandler(this.Operations_SelectedIndexChanged);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(97, 114);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(90, 23);
            this.Clean.TabIndex = 21;
            this.Clean.Text = "Очистка";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumL);
            this.groupBox1.Controls.Add(this.ResultTextBox);
            this.groupBox1.Controls.Add(this.InputTextBox);
            this.groupBox1.Controls.Add(this.Clean);
            this.groupBox1.Controls.Add(this.NumD);
            this.groupBox1.Controls.Add(this.NumC);
            this.groupBox1.Controls.Add(this.Operations);
            this.groupBox1.Controls.Add(this.NumM);
            this.groupBox1.Controls.Add(this.NumI);
            this.groupBox1.Controls.Add(this.NumX);
            this.groupBox1.Controls.Add(this.ResultBut);
            this.groupBox1.Controls.Add(this.NumV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 147);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Калькулятор";
            // 
            // NumL
            // 
            this.NumL.Location = new System.Drawing.Point(111, 85);
            this.NumL.Name = "NumL";
            this.NumL.Size = new System.Drawing.Size(29, 23);
            this.NumL.TabIndex = 22;
            this.NumL.Text = "L";
            this.NumL.UseVisualStyleBackColor = true;
            this.NumL.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CleanSortArgs);
            this.groupBox2.Controls.Add(this.SortIntResult);
            this.groupBox2.Controls.Add(this.SortBut);
            this.groupBox2.Controls.Add(this.SortRomeResult);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.InputArray);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 147);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // CleanSortArgs
            // 
            this.CleanSortArgs.Location = new System.Drawing.Point(215, 61);
            this.CleanSortArgs.Name = "CleanSortArgs";
            this.CleanSortArgs.Size = new System.Drawing.Size(53, 23);
            this.CleanSortArgs.TabIndex = 6;
            this.CleanSortArgs.Text = "Чистка";
            this.CleanSortArgs.UseVisualStyleBackColor = true;
            this.CleanSortArgs.Click += new System.EventHandler(this.CleanSortArgs_Click);
            // 
            // SortIntResult
            // 
            this.SortIntResult.Location = new System.Drawing.Point(9, 114);
            this.SortIntResult.Name = "SortIntResult";
            this.SortIntResult.ReadOnly = true;
            this.SortIntResult.Size = new System.Drawing.Size(259, 20);
            this.SortIntResult.TabIndex = 5;
            // 
            // SortBut
            // 
            this.SortBut.Location = new System.Drawing.Point(121, 61);
            this.SortBut.Name = "SortBut";
            this.SortBut.Size = new System.Drawing.Size(88, 23);
            this.SortBut.TabIndex = 4;
            this.SortBut.Text = "Сортировать";
            this.SortBut.UseVisualStyleBackColor = true;
            this.SortBut.Click += new System.EventHandler(this.SortBut_Click);
            // 
            // SortRomeResult
            // 
            this.SortRomeResult.Location = new System.Drawing.Point(9, 90);
            this.SortRomeResult.Name = "SortRomeResult";
            this.SortRomeResult.ReadOnly = true;
            this.SortRomeResult.Size = new System.Drawing.Size(259, 20);
            this.SortRomeResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результат";
            // 
            // InputArray
            // 
            this.InputArray.Location = new System.Drawing.Point(9, 35);
            this.InputArray.Name = "InputArray";
            this.InputArray.Size = new System.Drawing.Size(259, 20);
            this.InputArray.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите массив римских чисел через пробел";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CleanFindArgs);
            this.groupBox3.Controls.Add(this.ResultFindedIntNums);
            this.groupBox3.Controls.Add(this.ResultFindedRomeNums);
            this.groupBox3.Controls.Add(this.FindExists);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.InputIntNumbers);
            this.groupBox3.Controls.Add(this.InputRomeNumbers);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 170);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // CleanFindArgs
            // 
            this.CleanFindArgs.Location = new System.Drawing.Point(396, 65);
            this.CleanFindArgs.Name = "CleanFindArgs";
            this.CleanFindArgs.Size = new System.Drawing.Size(68, 23);
            this.CleanFindArgs.TabIndex = 10;
            this.CleanFindArgs.Text = "Чистка";
            this.CleanFindArgs.UseVisualStyleBackColor = true;
            this.CleanFindArgs.Click += new System.EventHandler(this.CleanFindArgs_Click);
            // 
            // ResultFindedIntNums
            // 
            this.ResultFindedIntNums.Location = new System.Drawing.Point(6, 144);
            this.ResultFindedIntNums.Name = "ResultFindedIntNums";
            this.ResultFindedIntNums.ReadOnly = true;
            this.ResultFindedIntNums.Size = new System.Drawing.Size(384, 20);
            this.ResultFindedIntNums.TabIndex = 9;
            // 
            // ResultFindedRomeNums
            // 
            this.ResultFindedRomeNums.Location = new System.Drawing.Point(6, 118);
            this.ResultFindedRomeNums.Name = "ResultFindedRomeNums";
            this.ResultFindedRomeNums.ReadOnly = true;
            this.ResultFindedRomeNums.Size = new System.Drawing.Size(384, 20);
            this.ResultFindedRomeNums.TabIndex = 8;
            // 
            // FindExists
            // 
            this.FindExists.Location = new System.Drawing.Point(396, 41);
            this.FindExists.Name = "FindExists";
            this.FindExists.Size = new System.Drawing.Size(136, 23);
            this.FindExists.TabIndex = 5;
            this.FindExists.Text = "Найти совпадения.";
            this.FindExists.UseVisualStyleBackColor = true;
            this.FindExists.Click += new System.EventHandler(this.FindExists_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите массив римских чисел. Ниже введите массив десятичных чисел.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат: ";
            // 
            // InputIntNumbers
            // 
            this.InputIntNumbers.Location = new System.Drawing.Point(6, 68);
            this.InputIntNumbers.Name = "InputIntNumbers";
            this.InputIntNumbers.Size = new System.Drawing.Size(384, 20);
            this.InputIntNumbers.TabIndex = 5;
            // 
            // InputRomeNumbers
            // 
            this.InputRomeNumbers.Location = new System.Drawing.Point(6, 42);
            this.InputRomeNumbers.Name = "InputRomeNumbers";
            this.InputRomeNumbers.Size = new System.Drawing.Size(384, 20);
            this.InputRomeNumbers.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 345);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор римских чисел";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button NumI;
        private System.Windows.Forms.Button NumV;
        private System.Windows.Forms.Button NumX;
        private System.Windows.Forms.Button NumC;
        private System.Windows.Forms.Button NumD;
        private System.Windows.Forms.Button NumM;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ResultBut;
        private System.Windows.Forms.ComboBox Operations;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NumL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortBut;
        private System.Windows.Forms.TextBox SortRomeResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ResultFindedRomeNums;
        private System.Windows.Forms.Button FindExists;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputIntNumbers;
        private System.Windows.Forms.TextBox InputRomeNumbers;
        private System.Windows.Forms.TextBox ResultFindedIntNums;
        private System.Windows.Forms.TextBox SortIntResult;
        private System.Windows.Forms.Button CleanSortArgs;
        private System.Windows.Forms.Button CleanFindArgs;
    }
}

