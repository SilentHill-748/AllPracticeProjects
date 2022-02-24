
namespace MatrixCalc
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BDeterminantL = new System.Windows.Forms.Label();
            this.CalcOperationB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OperationCB = new System.Windows.Forms.ComboBox();
            this.ADeterminantL = new System.Windows.Forms.Label();
            this.BMatrixSizeCB = new System.Windows.Forms.ComboBox();
            this.AMatrixSizeCB = new System.Windows.Forms.ComboBox();
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.BDeterminantB = new System.Windows.Forms.Button();
            this.BTransposeB = new System.Windows.Forms.Button();
            this.ADeterminantB = new System.Windows.Forms.Button();
            this.ATransposeB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BMatrixDGV = new System.Windows.Forms.DataGridView();
            this.AMatrixDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SizeCB = new System.Windows.Forms.ComboBox();
            this.ValuesDGV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MatrixCollectionL = new System.Windows.Forms.Label();
            this.MatrixSizeCB = new System.Windows.Forms.ComboBox();
            this.SortB = new System.Windows.Forms.Button();
            this.AddMatrixB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MatrixForSortDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CalcValuesB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMatrixDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMatrixDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValuesDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixForSortDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BDeterminantL);
            this.tabPage1.Controls.Add(this.CalcOperationB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.OperationCB);
            this.tabPage1.Controls.Add(this.ADeterminantL);
            this.tabPage1.Controls.Add(this.BMatrixSizeCB);
            this.tabPage1.Controls.Add(this.AMatrixSizeCB);
            this.tabPage1.Controls.Add(this.ResultDGV);
            this.tabPage1.Controls.Add(this.BDeterminantB);
            this.tabPage1.Controls.Add(this.BTransposeB);
            this.tabPage1.Controls.Add(this.ADeterminantB);
            this.tabPage1.Controls.Add(this.ATransposeB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BMatrixDGV);
            this.tabPage1.Controls.Add(this.AMatrixDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Операции над матрицами";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BDeterminantL
            // 
            this.BDeterminantL.AutoSize = true;
            this.BDeterminantL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDeterminantL.Location = new System.Drawing.Point(18, 445);
            this.BDeterminantL.Name = "BDeterminantL";
            this.BDeterminantL.Size = new System.Drawing.Size(133, 24);
            this.BDeterminantL.TabIndex = 24;
            this.BDeterminantL.Text = "BDeterminantL";
            // 
            // CalcOperationB
            // 
            this.CalcOperationB.Location = new System.Drawing.Point(417, 88);
            this.CalcOperationB.Name = "CalcOperationB";
            this.CalcOperationB.Size = new System.Drawing.Size(99, 30);
            this.CalcOperationB.TabIndex = 23;
            this.CalcOperationB.Text = "Рассчитать";
            this.CalcOperationB.UseVisualStyleBackColor = true;
            this.CalcOperationB.Click += new System.EventHandler(this.CalcOperationB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(413, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Операция";
            // 
            // OperationCB
            // 
            this.OperationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationCB.FormattingEnabled = true;
            this.OperationCB.Items.AddRange(new object[] {
            "A + B",
            "A - B",
            "A x B",
            "A x B - B x A"});
            this.OperationCB.Location = new System.Drawing.Point(417, 58);
            this.OperationCB.Name = "OperationCB";
            this.OperationCB.Size = new System.Drawing.Size(99, 24);
            this.OperationCB.TabIndex = 21;
            // 
            // ADeterminantL
            // 
            this.ADeterminantL.AutoSize = true;
            this.ADeterminantL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADeterminantL.Location = new System.Drawing.Point(18, 421);
            this.ADeterminantL.Name = "ADeterminantL";
            this.ADeterminantL.Size = new System.Drawing.Size(134, 24);
            this.ADeterminantL.TabIndex = 20;
            this.ADeterminantL.Text = "ADeterminantL";
            // 
            // BMatrixSizeCB
            // 
            this.BMatrixSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BMatrixSizeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMatrixSizeCB.FormattingEnabled = true;
            this.BMatrixSizeCB.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.BMatrixSizeCB.Location = new System.Drawing.Point(877, 269);
            this.BMatrixSizeCB.Name = "BMatrixSizeCB";
            this.BMatrixSizeCB.Size = new System.Drawing.Size(40, 24);
            this.BMatrixSizeCB.TabIndex = 19;
            this.BMatrixSizeCB.TextChanged += new System.EventHandler(this.BMatrixSizeCB_TextChanged);
            // 
            // AMatrixSizeCB
            // 
            this.AMatrixSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AMatrixSizeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AMatrixSizeCB.FormattingEnabled = true;
            this.AMatrixSizeCB.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.AMatrixSizeCB.Location = new System.Drawing.Point(101, 269);
            this.AMatrixSizeCB.Name = "AMatrixSizeCB";
            this.AMatrixSizeCB.Size = new System.Drawing.Size(40, 24);
            this.AMatrixSizeCB.TabIndex = 18;
            this.AMatrixSizeCB.TextChanged += new System.EventHandler(this.AMatrixSizeCB_TextChanged);
            // 
            // ResultDGV
            // 
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(304, 346);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.Size = new System.Drawing.Size(332, 241);
            this.ResultDGV.TabIndex = 17;
            // 
            // BDeterminantB
            // 
            this.BDeterminantB.Location = new System.Drawing.Point(797, 335);
            this.BDeterminantB.Name = "BDeterminantB";
            this.BDeterminantB.Size = new System.Drawing.Size(120, 30);
            this.BDeterminantB.TabIndex = 16;
            this.BDeterminantB.Text = "Определитель";
            this.BDeterminantB.UseVisualStyleBackColor = true;
            this.BDeterminantB.Click += new System.EventHandler(this.BDeterminantB_Click);
            // 
            // BTransposeB
            // 
            this.BTransposeB.Location = new System.Drawing.Point(797, 299);
            this.BTransposeB.Name = "BTransposeB";
            this.BTransposeB.Size = new System.Drawing.Size(120, 30);
            this.BTransposeB.TabIndex = 15;
            this.BTransposeB.Text = "Транспонирование";
            this.BTransposeB.UseVisualStyleBackColor = true;
            this.BTransposeB.Click += new System.EventHandler(this.BTransposeB_Click);
            // 
            // ADeterminantB
            // 
            this.ADeterminantB.Location = new System.Drawing.Point(21, 335);
            this.ADeterminantB.Name = "ADeterminantB";
            this.ADeterminantB.Size = new System.Drawing.Size(120, 30);
            this.ADeterminantB.TabIndex = 14;
            this.ADeterminantB.Text = "Определитель";
            this.ADeterminantB.UseVisualStyleBackColor = true;
            this.ADeterminantB.Click += new System.EventHandler(this.ADeterminantB_Click);
            // 
            // ATransposeB
            // 
            this.ATransposeB.Location = new System.Drawing.Point(22, 299);
            this.ATransposeB.Name = "ATransposeB";
            this.ATransposeB.Size = new System.Drawing.Size(120, 30);
            this.ATransposeB.TabIndex = 13;
            this.ATransposeB.Text = "Транспонирование";
            this.ATransposeB.UseVisualStyleBackColor = true;
            this.ATransposeB.Click += new System.EventHandler(this.ATransposeB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(413, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(793, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Размер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер";
            // 
            // BMatrixDGV
            // 
            this.BMatrixDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BMatrixDGV.Location = new System.Drawing.Point(585, 22);
            this.BMatrixDGV.Name = "BMatrixDGV";
            this.BMatrixDGV.Size = new System.Drawing.Size(332, 241);
            this.BMatrixDGV.TabIndex = 1;
            // 
            // AMatrixDGV
            // 
            this.AMatrixDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AMatrixDGV.Location = new System.Drawing.Point(21, 22);
            this.AMatrixDGV.Name = "AMatrixDGV";
            this.AMatrixDGV.Size = new System.Drawing.Size(332, 241);
            this.AMatrixDGV.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CalcValuesB);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ResultTB);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.SizeCB);
            this.tabPage2.Controls.Add(this.ValuesDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Решение системы линейных уравнений";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(413, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Введите значения при неизвестных и чему равны уравнения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Число уравнений";
            // 
            // SizeCB
            // 
            this.SizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeCB.FormattingEnabled = true;
            this.SizeCB.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.SizeCB.Location = new System.Drawing.Point(174, 21);
            this.SizeCB.Name = "SizeCB";
            this.SizeCB.Size = new System.Drawing.Size(42, 24);
            this.SizeCB.TabIndex = 1;
            this.SizeCB.TextChanged += new System.EventHandler(this.SizeCB_TextChanged);
            // 
            // ValuesDGV
            // 
            this.ValuesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ValuesDGV.Location = new System.Drawing.Point(10, 121);
            this.ValuesDGV.Name = "ValuesDGV";
            this.ValuesDGV.Size = new System.Drawing.Size(374, 271);
            this.ValuesDGV.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MatrixCollectionL);
            this.tabPage3.Controls.Add(this.MatrixSizeCB);
            this.tabPage3.Controls.Add(this.SortB);
            this.tabPage3.Controls.Add(this.AddMatrixB);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.MatrixForSortDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(933, 612);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Работа с массивом матриц";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MatrixCollectionL
            // 
            this.MatrixCollectionL.AutoSize = true;
            this.MatrixCollectionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixCollectionL.Location = new System.Drawing.Point(286, 7);
            this.MatrixCollectionL.Name = "MatrixCollectionL";
            this.MatrixCollectionL.Size = new System.Drawing.Size(154, 24);
            this.MatrixCollectionL.TabIndex = 20;
            this.MatrixCollectionL.Text = "Массив матриц:";
            // 
            // MatrixSizeCB
            // 
            this.MatrixSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatrixSizeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixSizeCB.FormattingEnabled = true;
            this.MatrixSizeCB.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.MatrixSizeCB.Location = new System.Drawing.Point(94, 58);
            this.MatrixSizeCB.Name = "MatrixSizeCB";
            this.MatrixSizeCB.Size = new System.Drawing.Size(40, 24);
            this.MatrixSizeCB.TabIndex = 19;
            this.MatrixSizeCB.TextChanged += new System.EventHandler(this.MatrixSizeCB_TextChanged);
            // 
            // SortB
            // 
            this.SortB.Location = new System.Drawing.Point(148, 6);
            this.SortB.Name = "SortB";
            this.SortB.Size = new System.Drawing.Size(132, 25);
            this.SortB.TabIndex = 5;
            this.SortB.Text = "Сортировать матрицы";
            this.SortB.UseVisualStyleBackColor = true;
            this.SortB.Click += new System.EventHandler(this.SortB_Click);
            // 
            // AddMatrixB
            // 
            this.AddMatrixB.Location = new System.Drawing.Point(10, 6);
            this.AddMatrixB.Name = "AddMatrixB";
            this.AddMatrixB.Size = new System.Drawing.Size(132, 25);
            this.AddMatrixB.TabIndex = 4;
            this.AddMatrixB.Text = "Добавить матрицу";
            this.AddMatrixB.UseVisualStyleBackColor = true;
            this.AddMatrixB.Click += new System.EventHandler(this.AddMatrixB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер:";
            // 
            // MatrixForSortDGV
            // 
            this.MatrixForSortDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixForSortDGV.Location = new System.Drawing.Point(10, 89);
            this.MatrixForSortDGV.Name = "MatrixForSortDGV";
            this.MatrixForSortDGV.Size = new System.Drawing.Size(483, 352);
            this.MatrixForSortDGV.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.справкаToolStripMenuItem.Text = "?";
            // 
            // ResultTB
            // 
            this.ResultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTB.Location = new System.Drawing.Point(459, 121);
            this.ResultTB.Multiline = true;
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(195, 271);
            this.ResultTB.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(367, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Последний столбец отвечает за значение уравнения!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(456, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Значения при неизвестных";
            // 
            // CalcValuesB
            // 
            this.CalcValuesB.Location = new System.Drawing.Point(222, 20);
            this.CalcValuesB.Name = "CalcValuesB";
            this.CalcValuesB.Size = new System.Drawing.Size(75, 25);
            this.CalcValuesB.TabIndex = 8;
            this.CalcValuesB.Text = "Рассчитать";
            this.CalcValuesB.UseVisualStyleBackColor = true;
            this.CalcValuesB.Click += new System.EventHandler(this.CalcValuesB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(958, 689);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Супер пупер калькулятор";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMatrixDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMatrixDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValuesDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixForSortDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView BMatrixDGV;
        private System.Windows.Forms.DataGridView AMatrixDGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.Button BDeterminantB;
        private System.Windows.Forms.Button BTransposeB;
        private System.Windows.Forms.Button ADeterminantB;
        private System.Windows.Forms.Button ATransposeB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SortB;
        private System.Windows.Forms.Button AddMatrixB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView MatrixForSortDGV;
        private System.Windows.Forms.ComboBox BMatrixSizeCB;
        private System.Windows.Forms.ComboBox AMatrixSizeCB;
        private System.Windows.Forms.ComboBox MatrixSizeCB;
        private System.Windows.Forms.Label ADeterminantL;
        private System.Windows.Forms.ComboBox OperationCB;
        private System.Windows.Forms.Button CalcOperationB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BDeterminantL;
        private System.Windows.Forms.Label MatrixCollectionL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SizeCB;
        private System.Windows.Forms.DataGridView ValuesDGV;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CalcValuesB;
        private System.Windows.Forms.Label label9;
    }
}

