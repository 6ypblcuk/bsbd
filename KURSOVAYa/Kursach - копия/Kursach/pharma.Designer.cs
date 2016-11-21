namespace Kursach
{
    partial class pharma
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharma));
            this.pharm = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.change_info = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pharm
            // 
            this.pharm.Location = new System.Drawing.Point(57, 111);
            this.pharm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pharm.Name = "pharm";
            this.pharm.Size = new System.Drawing.Size(185, 41);
            this.pharm.TabIndex = 0;
            this.pharm.Text = "Препараты";
            this.pharm.UseVisualStyleBackColor = true;
            this.pharm.Click += new System.EventHandler(this.drugs_Click);
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(57, 162);
            this.orders.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(185, 41);
            this.orders.TabIndex = 1;
            this.orders.Text = "Заказы";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(57, 213);
            this.price.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(185, 41);
            this.price.TabIndex = 2;
            this.price.Text = "Прайс";
            this.price.UseVisualStyleBackColor = true;
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(151, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Домашняя Аптека \r\n";
            // 
            // change_info
            // 
            this.change_info.Location = new System.Drawing.Point(57, 266);
            this.change_info.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.change_info.Name = "change_info";
            this.change_info.Size = new System.Drawing.Size(185, 41);
            this.change_info.TabIndex = 6;
            this.change_info.Text = "Просмотр информации";
            this.change_info.UseVisualStyleBackColor = true;
            this.change_info.Click += new System.EventHandler(this.change_info_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(277, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 196);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 82);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pharma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(563, 349);
            this.Controls.Add(this.change_info);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.pharm);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "pharma";
            this.Text = "Аптека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pharm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pharm;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button change_info;
    }
}

