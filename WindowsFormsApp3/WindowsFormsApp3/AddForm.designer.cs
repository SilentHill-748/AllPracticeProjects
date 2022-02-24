
namespace WindowsFormsApp1
{
    partial class AddForm
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
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbдата = new System.Windows.Forms.TextBox();
            this.tbадрес = new System.Windows.Forms.TextBox();
            this.tbотчество = new System.Windows.Forms.TextBox();
            this.tbфамилия = new System.Windows.Forms.TextBox();
            this.tbимя = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(102, 39);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(193, 20);
            this.tbid.TabIndex = 0;
            // 
            // tbдата
            // 
            this.tbдата.Location = new System.Drawing.Point(102, 206);
            this.tbдата.Name = "tbдата";
            this.tbдата.Size = new System.Drawing.Size(193, 20);
            this.tbдата.TabIndex = 1;
            // 
            // tbадрес
            // 
            this.tbадрес.Location = new System.Drawing.Point(102, 252);
            this.tbадрес.Name = "tbадрес";
            this.tbадрес.Size = new System.Drawing.Size(193, 20);
            this.tbадрес.TabIndex = 2;
            this.tbадрес.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbотчество
            // 
            this.tbотчество.Location = new System.Drawing.Point(102, 167);
            this.tbотчество.Name = "tbотчество";
            this.tbотчество.Size = new System.Drawing.Size(193, 20);
            this.tbотчество.TabIndex = 3;
            this.tbотчество.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbфамилия
            // 
            this.tbфамилия.Location = new System.Drawing.Point(102, 121);
            this.tbфамилия.Name = "tbфамилия";
            this.tbфамилия.Size = new System.Drawing.Size(193, 20);
            this.tbфамилия.TabIndex = 4;
            // 
            // tbимя
            // 
            this.tbимя.Location = new System.Drawing.Point(102, 79);
            this.tbимя.Name = "tbимя";
            this.tbимя.Size = new System.Drawing.Size(193, 20);
            this.tbимя.TabIndex = 5;
            this.tbимя.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "дата рождения";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "адрес";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBtn.Location = new System.Drawing.Point(15, 339);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 31);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseBtn.Location = new System.Drawing.Point(184, 339);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(111, 31);
            this.CloseBtn.TabIndex = 13;
            this.CloseBtn.Text = "закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 404);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbимя);
            this.Controls.Add(this.tbфамилия);
            this.Controls.Add(this.tbотчество);
            this.Controls.Add(this.tbадрес);
            this.Controls.Add(this.tbдата);
            this.Controls.Add(this.tbid);
            this.Name = "AddForm";
            this.Text = "форма добавления записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbдата;
        private System.Windows.Forms.TextBox tbадрес;
        private System.Windows.Forms.TextBox tbотчество;
        private System.Windows.Forms.TextBox tbфамилия;
        private System.Windows.Forms.TextBox tbимя;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}