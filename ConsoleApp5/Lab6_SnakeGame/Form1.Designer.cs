
namespace Lab6_SnakeGame
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
            this.Area = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.Population = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.nudPopulation = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulation)).BeginInit();
            this.SuspendLayout();
            // 
            // Area
            // 
            this.Area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Area.BackColor = System.Drawing.Color.Black;
            this.Area.Location = new System.Drawing.Point(323, -9);
            this.Area.Margin = new System.Windows.Forms.Padding(95, 0, 0, 0);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(896, 664);
            this.Area.TabIndex = 0;
            this.Area.TabStop = false;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 90);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(12, 119);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(9, 9);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(70, 13);
            this.ResolutionLabel.TabIndex = 4;
            this.ResolutionLabel.Text = "Расширение";
            // 
            // Population
            // 
            this.Population.AutoSize = true;
            this.Population.Location = new System.Drawing.Point(9, 48);
            this.Population.Name = "Population";
            this.Population.Size = new System.Drawing.Size(62, 13);
            this.Population.TabIndex = 7;
            this.Population.Text = "Популяция";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(12, 25);
            this.nudResolution.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(75, 20);
            this.nudResolution.TabIndex = 8;
            this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudPopulation
            // 
            this.nudPopulation.Location = new System.Drawing.Point(12, 64);
            this.nudPopulation.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPopulation.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPopulation.Name = "nudPopulation";
            this.nudPopulation.Size = new System.Drawing.Size(75, 20);
            this.nudPopulation.TabIndex = 9;
            this.nudPopulation.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1217, 652);
            this.Controls.Add(this.nudPopulation);
            this.Controls.Add(this.nudResolution);
            this.Controls.Add(this.Population);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.Area);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Area;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.Label Population;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.NumericUpDown nudPopulation;
        private System.Windows.Forms.Timer timer1;
    }
}

