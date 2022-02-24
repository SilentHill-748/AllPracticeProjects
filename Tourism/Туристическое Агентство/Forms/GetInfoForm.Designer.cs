
namespace Tourism.Forms
{
    partial class GetInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetInfoForm));
            this.moveNextBut = new System.Windows.Forms.Button();
            this.moveBackBut = new System.Windows.Forms.Button();
            this.okBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotelPrice = new System.Windows.Forms.TextBox();
            this.hotel = new System.Windows.Forms.TextBox();
            this.dateOfShipment = new System.Windows.Forms.TextBox();
            this.finalRoute = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.beginRoute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.purchaseDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveNextBut
            // 
            this.moveNextBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveNextBut.Location = new System.Drawing.Point(148, 292);
            this.moveNextBut.Name = "moveNextBut";
            this.moveNextBut.Size = new System.Drawing.Size(69, 30);
            this.moveNextBut.TabIndex = 13;
            this.moveNextBut.Text = ">>";
            this.moveNextBut.UseVisualStyleBackColor = true;
            this.moveNextBut.Click += new System.EventHandler(this.MoveNext_CLick);
            // 
            // moveBackBut
            // 
            this.moveBackBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveBackBut.Location = new System.Drawing.Point(73, 292);
            this.moveBackBut.Name = "moveBackBut";
            this.moveBackBut.Size = new System.Drawing.Size(69, 30);
            this.moveBackBut.TabIndex = 12;
            this.moveBackBut.Text = "<<";
            this.moveBackBut.UseVisualStyleBackColor = true;
            this.moveBackBut.Click += new System.EventHandler(this.MoveBack_Click);
            // 
            // okBut
            // 
            this.okBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBut.Location = new System.Drawing.Point(346, 292);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(112, 30);
            this.okBut.TabIndex = 11;
            this.okBut.Text = "Ok";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okBut);
            this.groupBox1.Controls.Add(this.moveNextBut);
            this.groupBox1.Controls.Add(this.hotelPrice);
            this.groupBox1.Controls.Add(this.moveBackBut);
            this.groupBox1.Controls.Add(this.hotel);
            this.groupBox1.Controls.Add(this.dateOfShipment);
            this.groupBox1.Controls.Add(this.finalRoute);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.beginRoute);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fullName);
            this.groupBox1.Controls.Add(this.purchaseDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 339);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инфо";
            // 
            // hotelPrice
            // 
            this.hotelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelPrice.Location = new System.Drawing.Point(177, 247);
            this.hotelPrice.Name = "hotelPrice";
            this.hotelPrice.ReadOnly = true;
            this.hotelPrice.Size = new System.Drawing.Size(333, 26);
            this.hotelPrice.TabIndex = 16;
            // 
            // hotel
            // 
            this.hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotel.Location = new System.Drawing.Point(177, 215);
            this.hotel.Name = "hotel";
            this.hotel.ReadOnly = true;
            this.hotel.Size = new System.Drawing.Size(333, 26);
            this.hotel.TabIndex = 15;
            // 
            // dateOfShipment
            // 
            this.dateOfShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfShipment.Location = new System.Drawing.Point(177, 183);
            this.dateOfShipment.Name = "dateOfShipment";
            this.dateOfShipment.ReadOnly = true;
            this.dateOfShipment.Size = new System.Drawing.Size(333, 26);
            this.dateOfShipment.TabIndex = 14;
            // 
            // finalRoute
            // 
            this.finalRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalRoute.Location = new System.Drawing.Point(177, 151);
            this.finalRoute.Name = "finalRoute";
            this.finalRoute.ReadOnly = true;
            this.finalRoute.Size = new System.Drawing.Size(333, 26);
            this.finalRoute.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(100, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Цена: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(90, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Отель: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата отправки: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Конечный пункт: ";
            // 
            // beginRoute
            // 
            this.beginRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginRoute.Location = new System.Drawing.Point(177, 119);
            this.beginRoute.Name = "beginRoute";
            this.beginRoute.ReadOnly = true;
            this.beginRoute.Size = new System.Drawing.Size(333, 26);
            this.beginRoute.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Начальный пункт: ";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(177, 87);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Size = new System.Drawing.Size(333, 26);
            this.phone.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон: ";
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(177, 55);
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Size = new System.Drawing.Size(333, 26);
            this.fullName.TabIndex = 6;
            // 
            // purchaseDate
            // 
            this.purchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseDate.Location = new System.Drawing.Point(177, 23);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.ReadOnly = true;
            this.purchaseDate.Size = new System.Drawing.Size(333, 26);
            this.purchaseDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата покупки: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Полное имя: ";
            // 
            // GetInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveNextBut;
        private System.Windows.Forms.Button moveBackBut;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox beginRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox purchaseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hotelPrice;
        private System.Windows.Forms.TextBox hotel;
        private System.Windows.Forms.TextBox dateOfShipment;
        private System.Windows.Forms.TextBox finalRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}