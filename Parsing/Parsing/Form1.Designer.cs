
namespace Parsing
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
            this.label1 = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.GetStatsBut = new System.Windows.Forms.Button();
            this.CountryLab = new System.Windows.Forms.Label();
            this.ContinentLab = new System.Windows.Forms.Label();
            this.TimezoneLab = new System.Windows.Forms.Label();
            this.CityLab = new System.Windows.Forms.Label();
            this.MapWebB = new System.Windows.Forms.WebBrowser();
            this.LatitudeLab = new System.Windows.Forms.Label();
            this.LongitudeLab = new System.Windows.Forms.Label();
            this.ShowMapBut = new System.Windows.Forms.Button();
            this.HideMapBut = new System.Windows.Forms.Button();
            this.RegionLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введи IP";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(63, 5);
            this.IPTextBox.MaxLength = 15;
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(100, 20);
            this.IPTextBox.TabIndex = 1;
            this.IPTextBox.TextChanged += new System.EventHandler(this.IPTextBox_TextChanged);
            // 
            // GetStatsBut
            // 
            this.GetStatsBut.Enabled = false;
            this.GetStatsBut.Location = new System.Drawing.Point(169, 2);
            this.GetStatsBut.Name = "GetStatsBut";
            this.GetStatsBut.Size = new System.Drawing.Size(75, 24);
            this.GetStatsBut.TabIndex = 2;
            this.GetStatsBut.Text = "Get Stats";
            this.GetStatsBut.UseVisualStyleBackColor = true;
            this.GetStatsBut.Click += new System.EventHandler(this.GetStatsBut_Click);
            // 
            // CountryLab
            // 
            this.CountryLab.AutoSize = true;
            this.CountryLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLab.Location = new System.Drawing.Point(64, 42);
            this.CountryLab.Name = "CountryLab";
            this.CountryLab.Size = new System.Drawing.Size(64, 17);
            this.CountryLab.TabIndex = 0;
            this.CountryLab.Text = "Страна: ";
            // 
            // ContinentLab
            // 
            this.ContinentLab.AutoSize = true;
            this.ContinentLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinentLab.Location = new System.Drawing.Point(41, 76);
            this.ContinentLab.Name = "ContinentLab";
            this.ContinentLab.Size = new System.Drawing.Size(83, 17);
            this.ContinentLab.TabIndex = 0;
            this.ContinentLab.Text = "Континент:";
            // 
            // TimezoneLab
            // 
            this.TimezoneLab.AutoSize = true;
            this.TimezoneLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimezoneLab.Location = new System.Drawing.Point(11, 59);
            this.TimezoneLab.Name = "TimezoneLab";
            this.TimezoneLab.Size = new System.Drawing.Size(117, 17);
            this.TimezoneLab.TabIndex = 0;
            this.TimezoneLab.Text = "Местное время: ";
            // 
            // CityLab
            // 
            this.CityLab.AutoSize = true;
            this.CityLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLab.Location = new System.Drawing.Point(72, 110);
            this.CityLab.Name = "CityLab";
            this.CityLab.Size = new System.Drawing.Size(56, 17);
            this.CityLab.TabIndex = 0;
            this.CityLab.Text = "Город: ";
            // 
            // MapWebB
            // 
            this.MapWebB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapWebB.Location = new System.Drawing.Point(250, 32);
            this.MapWebB.MinimumSize = new System.Drawing.Size(20, 20);
            this.MapWebB.Name = "MapWebB";
            this.MapWebB.Size = new System.Drawing.Size(598, 455);
            this.MapWebB.TabIndex = 0;
            this.MapWebB.Visible = false;
            // 
            // LatitudeLab
            // 
            this.LatitudeLab.AutoSize = true;
            this.LatitudeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LatitudeLab.Location = new System.Drawing.Point(62, 127);
            this.LatitudeLab.Name = "LatitudeLab";
            this.LatitudeLab.Size = new System.Drawing.Size(66, 17);
            this.LatitudeLab.TabIndex = 0;
            this.LatitudeLab.Text = "Широта: ";
            // 
            // LongitudeLab
            // 
            this.LongitudeLab.AutoSize = true;
            this.LongitudeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LongitudeLab.Location = new System.Drawing.Point(57, 144);
            this.LongitudeLab.Name = "LongitudeLab";
            this.LongitudeLab.Size = new System.Drawing.Size(67, 17);
            this.LongitudeLab.TabIndex = 0;
            this.LongitudeLab.Text = "Долгота:";
            // 
            // ShowMapBut
            // 
            this.ShowMapBut.Enabled = false;
            this.ShowMapBut.Location = new System.Drawing.Point(250, 2);
            this.ShowMapBut.Name = "ShowMapBut";
            this.ShowMapBut.Size = new System.Drawing.Size(148, 24);
            this.ShowMapBut.TabIndex = 3;
            this.ShowMapBut.Text = "Показать на карте";
            this.ShowMapBut.UseVisualStyleBackColor = true;
            this.ShowMapBut.Click += new System.EventHandler(this.ShowMapBut_Click);
            // 
            // HideMapBut
            // 
            this.HideMapBut.Location = new System.Drawing.Point(404, 2);
            this.HideMapBut.Name = "HideMapBut";
            this.HideMapBut.Size = new System.Drawing.Size(97, 24);
            this.HideMapBut.TabIndex = 4;
            this.HideMapBut.Text = "Скрыть карту";
            this.HideMapBut.UseVisualStyleBackColor = true;
            this.HideMapBut.Click += new System.EventHandler(this.HideMapBut_Click);
            // 
            // RegionLab
            // 
            this.RegionLab.AutoSize = true;
            this.RegionLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionLab.Location = new System.Drawing.Point(66, 93);
            this.RegionLab.Name = "RegionLab";
            this.RegionLab.Size = new System.Drawing.Size(62, 17);
            this.RegionLab.TabIndex = 5;
            this.RegionLab.Text = "Регион: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ширина окна: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegionLab);
            this.Controls.Add(this.HideMapBut);
            this.Controls.Add(this.ShowMapBut);
            this.Controls.Add(this.LongitudeLab);
            this.Controls.Add(this.LatitudeLab);
            this.Controls.Add(this.MapWebB);
            this.Controls.Add(this.CityLab);
            this.Controls.Add(this.TimezoneLab);
            this.Controls.Add(this.ContinentLab);
            this.Controls.Add(this.CountryLab);
            this.Controls.Add(this.GetStatsBut);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пробить по IP";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button GetStatsBut;
        private System.Windows.Forms.Label CountryLab;
        private System.Windows.Forms.Label ContinentLab;
        private System.Windows.Forms.Label TimezoneLab;
        private System.Windows.Forms.Label CityLab;
        private System.Windows.Forms.WebBrowser MapWebB;
        private System.Windows.Forms.Label LatitudeLab;
        private System.Windows.Forms.Label LongitudeLab;
        private System.Windows.Forms.Button ShowMapBut;
        private System.Windows.Forms.Button HideMapBut;
        private System.Windows.Forms.Label RegionLab;
        private System.Windows.Forms.Label label2;
    }
}

