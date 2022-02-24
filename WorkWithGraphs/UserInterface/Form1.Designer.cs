
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
            this.MainGraph = new System.Windows.Forms.DataGridView();
            this.SizeGraphCB = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OperationsOnGraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.CrossingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiameterMainGraphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberOfVertexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberOfEdgesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgesOfVertexesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsOnSubgraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.FindAllTheCorrectGraphsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindCountIsolatedGraphsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindSubgraphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondaryGraph = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.SizeSecondaryGraphCB = new System.Windows.Forms.ComboBox();
            this.CreateMainGraphB = new System.Windows.Forms.Button();
            this.CreateSecondaryGraphB = new System.Windows.Forms.Button();
            this.MainGraphStatsL = new System.Windows.Forms.Label();
            this.SecondaryGraphStatsL = new System.Windows.Forms.Label();
            this.InfoLabelA = new System.Windows.Forms.Label();
            this.InfoLabelB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainGraph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGraph
            // 
            this.MainGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGraph.Location = new System.Drawing.Point(54, 109);
            this.MainGraph.Name = "MainGraph";
            this.MainGraph.Size = new System.Drawing.Size(322, 298);
            this.MainGraph.TabIndex = 0;
            this.MainGraph.Visible = false;
            // 
            // SizeGraphCB
            // 
            this.SizeGraphCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeGraphCB.FormattingEnabled = true;
            this.SizeGraphCB.Items.AddRange(new object[] {
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
            this.SizeGraphCB.Location = new System.Drawing.Point(208, 81);
            this.SizeGraphCB.Name = "SizeGraphCB";
            this.SizeGraphCB.Size = new System.Drawing.Size(43, 21);
            this.SizeGraphCB.TabIndex = 1;
            this.SizeGraphCB.SelectedIndexChanged += new System.EventHandler(this.SizeGraphCB_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationsOnGraphs,
            this.OperationsOnSubgraphs,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OperationsOnGraphs
            // 
            this.OperationsOnGraphs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrossingMenuItem,
            this.UnionMenuItem,
            this.DiameterMainGraphMenuItem,
            this.NumberOfVertexMenuItem,
            this.NumberOfEdgesMenuItem,
            this.EdgesOfVertexesMenuItem});
            this.OperationsOnGraphs.Enabled = false;
            this.OperationsOnGraphs.Name = "OperationsOnGraphs";
            this.OperationsOnGraphs.Size = new System.Drawing.Size(130, 20);
            this.OperationsOnGraphs.Text = "Операции с графом";
            // 
            // CrossingMenuItem
            // 
            this.CrossingMenuItem.Name = "CrossingMenuItem";
            this.CrossingMenuItem.Size = new System.Drawing.Size(234, 22);
            this.CrossingMenuItem.Text = "Пересечение (А ⋂ В)";
            this.CrossingMenuItem.Click += new System.EventHandler(this.CrossingMenuItem_Click);
            // 
            // UnionMenuItem
            // 
            this.UnionMenuItem.Name = "UnionMenuItem";
            this.UnionMenuItem.Size = new System.Drawing.Size(234, 22);
            this.UnionMenuItem.Text = "Объединение (А ∪ В)";
            this.UnionMenuItem.Click += new System.EventHandler(this.UnionMenuItem_Click);
            // 
            // DiameterMainGraphMenuItem
            // 
            this.DiameterMainGraphMenuItem.Name = "DiameterMainGraphMenuItem";
            this.DiameterMainGraphMenuItem.Size = new System.Drawing.Size(234, 22);
            this.DiameterMainGraphMenuItem.Text = "Диаметр графа";
            this.DiameterMainGraphMenuItem.Click += new System.EventHandler(this.DiameterMainGraphMenuItem_Click);
            // 
            // NumberOfVertexMenuItem
            // 
            this.NumberOfVertexMenuItem.Name = "NumberOfVertexMenuItem";
            this.NumberOfVertexMenuItem.Size = new System.Drawing.Size(234, 22);
            this.NumberOfVertexMenuItem.Text = "Число вершин";
            this.NumberOfVertexMenuItem.Click += new System.EventHandler(this.NumberOfVertexMenuItem_Click);
            // 
            // NumberOfEdgesMenuItem
            // 
            this.NumberOfEdgesMenuItem.Name = "NumberOfEdgesMenuItem";
            this.NumberOfEdgesMenuItem.Size = new System.Drawing.Size(234, 22);
            this.NumberOfEdgesMenuItem.Text = "Общее число рёбер графа";
            this.NumberOfEdgesMenuItem.Click += new System.EventHandler(this.NumberOfEdgesMenuItem_Click);
            // 
            // EdgesOfVertexesMenuItem
            // 
            this.EdgesOfVertexesMenuItem.Name = "EdgesOfVertexesMenuItem";
            this.EdgesOfVertexesMenuItem.Size = new System.Drawing.Size(234, 22);
            this.EdgesOfVertexesMenuItem.Text = "Число рёбер из всех вершин";
            this.EdgesOfVertexesMenuItem.Click += new System.EventHandler(this.EdgesOfVertexesMenuItem_Click);
            // 
            // OperationsOnSubgraphs
            // 
            this.OperationsOnSubgraphs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindAllTheCorrectGraphsMenuItem,
            this.FindCountIsolatedGraphsMenuItem,
            this.FindSubgraphMenuItem});
            this.OperationsOnSubgraphs.Enabled = false;
            this.OperationsOnSubgraphs.Name = "OperationsOnSubgraphs";
            this.OperationsOnSubgraphs.Size = new System.Drawing.Size(156, 20);
            this.OperationsOnSubgraphs.Text = "Операции с подграфами";
            // 
            // FindAllTheCorrectGraphsMenuItem
            // 
            this.FindAllTheCorrectGraphsMenuItem.Name = "FindAllTheCorrectGraphsMenuItem";
            this.FindAllTheCorrectGraphsMenuItem.Size = new System.Drawing.Size(280, 22);
            this.FindAllTheCorrectGraphsMenuItem.Text = "Найти все правильные графы";
            this.FindAllTheCorrectGraphsMenuItem.Click += new System.EventHandler(this.FindAllTheCorrectGraphsMenuItem_Click);
            // 
            // FindCountIsolatedGraphsMenuItem
            // 
            this.FindCountIsolatedGraphsMenuItem.Name = "FindCountIsolatedGraphsMenuItem";
            this.FindCountIsolatedGraphsMenuItem.Size = new System.Drawing.Size(280, 22);
            this.FindCountIsolatedGraphsMenuItem.Text = "Найти число изолированных графов";
            this.FindCountIsolatedGraphsMenuItem.Click += new System.EventHandler(this.FindCountIsolatedGraphsMenuItem_Click);
            // 
            // FindSubgraphMenuItem
            // 
            this.FindSubgraphMenuItem.Name = "FindSubgraphMenuItem";
            this.FindSubgraphMenuItem.Size = new System.Drawing.Size(280, 22);
            this.FindSubgraphMenuItem.Text = "Найти дополнение графа до полного";
            this.FindSubgraphMenuItem.Click += new System.EventHandler(this.FindSubgraphMenuItem_Click);
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(65, 20);
            this.Help.Text = "Справка";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Граф А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите размер матрицы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(409, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Граф В";
            // 
            // SecondaryGraph
            // 
            this.SecondaryGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondaryGraph.Location = new System.Drawing.Point(455, 109);
            this.SecondaryGraph.Name = "SecondaryGraph";
            this.SecondaryGraph.Size = new System.Drawing.Size(318, 298);
            this.SecondaryGraph.TabIndex = 6;
            this.SecondaryGraph.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(409, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Укажите размер матрицы";
            // 
            // SizeSecondaryGraphCB
            // 
            this.SizeSecondaryGraphCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeSecondaryGraphCB.FormattingEnabled = true;
            this.SizeSecondaryGraphCB.Items.AddRange(new object[] {
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
            this.SizeSecondaryGraphCB.Location = new System.Drawing.Point(593, 79);
            this.SizeSecondaryGraphCB.Name = "SizeSecondaryGraphCB";
            this.SizeSecondaryGraphCB.Size = new System.Drawing.Size(43, 21);
            this.SizeSecondaryGraphCB.TabIndex = 8;
            this.SizeSecondaryGraphCB.SelectedIndexChanged += new System.EventHandler(this.SizeSecondaryGraphCB_SelectedIndexChanged);
            // 
            // CreateMainGraphB
            // 
            this.CreateMainGraphB.Location = new System.Drawing.Point(257, 80);
            this.CreateMainGraphB.Name = "CreateMainGraphB";
            this.CreateMainGraphB.Size = new System.Drawing.Size(88, 23);
            this.CreateMainGraphB.TabIndex = 9;
            this.CreateMainGraphB.Text = "Создать граф";
            this.CreateMainGraphB.UseVisualStyleBackColor = true;
            this.CreateMainGraphB.Click += new System.EventHandler(this.CreateMainGraphB_Click);
            // 
            // CreateSecondaryGraphB
            // 
            this.CreateSecondaryGraphB.Location = new System.Drawing.Point(642, 78);
            this.CreateSecondaryGraphB.Name = "CreateSecondaryGraphB";
            this.CreateSecondaryGraphB.Size = new System.Drawing.Size(88, 23);
            this.CreateSecondaryGraphB.TabIndex = 10;
            this.CreateSecondaryGraphB.Text = "Создать граф";
            this.CreateSecondaryGraphB.UseVisualStyleBackColor = true;
            this.CreateSecondaryGraphB.Click += new System.EventHandler(this.CreateSecondaryGraphB_Click);
            // 
            // MainGraphStatsL
            // 
            this.MainGraphStatsL.AutoSize = true;
            this.MainGraphStatsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainGraphStatsL.Location = new System.Drawing.Point(12, 109);
            this.MainGraphStatsL.Name = "MainGraphStatsL";
            this.MainGraphStatsL.Size = new System.Drawing.Size(46, 17);
            this.MainGraphStatsL.TabIndex = 11;
            this.MainGraphStatsL.Text = "label5";
            // 
            // SecondaryGraphStatsL
            // 
            this.SecondaryGraphStatsL.AutoSize = true;
            this.SecondaryGraphStatsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondaryGraphStatsL.Location = new System.Drawing.Point(409, 109);
            this.SecondaryGraphStatsL.Name = "SecondaryGraphStatsL";
            this.SecondaryGraphStatsL.Size = new System.Drawing.Size(46, 17);
            this.SecondaryGraphStatsL.TabIndex = 12;
            this.SecondaryGraphStatsL.Text = "label6";
            // 
            // InfoLabelA
            // 
            this.InfoLabelA.AutoSize = true;
            this.InfoLabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabelA.Location = new System.Drawing.Point(20, 51);
            this.InfoLabelA.Name = "InfoLabelA";
            this.InfoLabelA.Size = new System.Drawing.Size(75, 17);
            this.InfoLabelA.TabIndex = 13;
            this.InfoLabelA.Text = "infoLabelA";
            // 
            // InfoLabelB
            // 
            this.InfoLabelB.AutoSize = true;
            this.InfoLabelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabelB.Location = new System.Drawing.Point(409, 51);
            this.InfoLabelB.Name = "InfoLabelB";
            this.InfoLabelB.Size = new System.Drawing.Size(75, 17);
            this.InfoLabelB.TabIndex = 14;
            this.InfoLabelB.Text = "infoLabelB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 422);
            this.Controls.Add(this.InfoLabelB);
            this.Controls.Add(this.InfoLabelA);
            this.Controls.Add(this.SecondaryGraphStatsL);
            this.Controls.Add(this.MainGraphStatsL);
            this.Controls.Add(this.CreateSecondaryGraphB);
            this.Controls.Add(this.CreateMainGraphB);
            this.Controls.Add(this.SizeSecondaryGraphCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecondaryGraph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeGraphCB);
            this.Controls.Add(this.MainGraph);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с графами";
            ((System.ComponentModel.ISupportInitialize)(this.MainGraph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGraph;
        private System.Windows.Forms.ComboBox SizeGraphCB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OperationsOnGraphs;
        private System.Windows.Forms.ToolStripMenuItem CrossingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiameterMainGraphMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NumberOfVertexMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NumberOfEdgesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdgesOfVertexesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationsOnSubgraphs;
        private System.Windows.Forms.ToolStripMenuItem FindAllTheCorrectGraphsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindCountIsolatedGraphsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindSubgraphMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView SecondaryGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SizeSecondaryGraphCB;
        private System.Windows.Forms.Button CreateMainGraphB;
        private System.Windows.Forms.Button CreateSecondaryGraphB;
        private System.Windows.Forms.Label MainGraphStatsL;
        private System.Windows.Forms.Label SecondaryGraphStatsL;
        private System.Windows.Forms.Label InfoLabelA;
        private System.Windows.Forms.Label InfoLabelB;
    }
}

