
namespace PracticeTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.currentTimerLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.stopLabel = new System.Windows.Forms.Label();
            this.globalTimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            // 
            // currentTimerLabel
            // 
            this.currentTimerLabel.AutoSize = true;
            this.currentTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTimerLabel.Location = new System.Drawing.Point(85, 47);
            this.currentTimerLabel.Name = "currentTimerLabel";
            this.currentTimerLabel.Size = new System.Drawing.Size(133, 36);
            this.currentTimerLabel.TabIndex = 0;
            this.currentTimerLabel.Text = "00:00:00";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(306, 26);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Таймер практики на 03.05.21";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLabel.Location = new System.Drawing.Point(34, 155);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(72, 26);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Старт";
            this.startLabel.Click += new System.EventHandler(this.Label_Click);
            this.startLabel.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.startLabel.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // stopLabel
            // 
            this.stopLabel.AutoSize = true;
            this.stopLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopLabel.Location = new System.Drawing.Point(213, 155);
            this.stopLabel.Name = "stopLabel";
            this.stopLabel.Size = new System.Drawing.Size(62, 26);
            this.stopLabel.TabIndex = 4;
            this.stopLabel.Text = "Стоп";
            // 
            // globalTimerLabel
            // 
            this.globalTimerLabel.AutoSize = true;
            this.globalTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalTimerLabel.Location = new System.Drawing.Point(85, 83);
            this.globalTimerLabel.Name = "globalTimerLabel";
            this.globalTimerLabel.Size = new System.Drawing.Size(133, 36);
            this.globalTimerLabel.TabIndex = 6;
            this.globalTimerLabel.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(326, 197);
            this.Controls.Add(this.globalTimerLabel);
            this.Controls.Add(this.stopLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.currentTimerLabel);
            this.Name = "Form1";
            this.Text = "Таймер практики C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label currentTimerLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label stopLabel;
        private System.Windows.Forms.Label globalTimerLabel;
    }
}

