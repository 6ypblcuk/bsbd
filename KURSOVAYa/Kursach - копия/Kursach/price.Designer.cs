namespace Kursach
{
    partial class price
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
            this.Name_firm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowPriceB = new System.Windows.Forms.Button();
            this.NameDrugGTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderB = new System.Windows.Forms.Button();
            this.DrugNameTB = new System.Windows.Forms.TextBox();
            this.NDrugTB = new System.Windows.Forms.TextBox();
            this.ExpDateTB = new System.Windows.Forms.TextBox();
            this.formTB = new System.Windows.Forms.TextBox();
            this.CardTB = new System.Windows.Forms.TextBox();
            this.CountsTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.PharmGrTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getprice = new System.Windows.Forms.Button();
            this.namefirmsCB = new System.Windows.Forms.ComboBox();
            this.default_cardB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_firm
            // 
            this.Name_firm.AutoSize = true;
            this.Name_firm.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_firm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_firm.Location = new System.Drawing.Point(117, 27);
            this.Name_firm.Name = "Name_firm";
            this.Name_firm.Size = new System.Drawing.Size(87, 54);
            this.Name_firm.TabIndex = 4;
            this.Name_firm.Text = "Прайс";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowPriceB);
            this.groupBox1.Controls.Add(this.NameDrugGTB);
            this.groupBox1.Location = new System.Drawing.Point(29, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите название препарата";
            // 
            // ShowPriceB
            // 
            this.ShowPriceB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShowPriceB.Location = new System.Drawing.Point(540, 31);
            this.ShowPriceB.Name = "ShowPriceB";
            this.ShowPriceB.Size = new System.Drawing.Size(126, 27);
            this.ShowPriceB.TabIndex = 1;
            this.ShowPriceB.Text = "Вывести прайс";
            this.ShowPriceB.UseVisualStyleBackColor = true;
            this.ShowPriceB.Click += new System.EventHandler(this.ShowPriceB_Click);
            // 
            // NameDrugGTB
            // 
            this.NameDrugGTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDrugGTB.Location = new System.Drawing.Point(6, 31);
            this.NameDrugGTB.Multiline = true;
            this.NameDrugGTB.Name = "NameDrugGTB";
            this.NameDrugGTB.Size = new System.Drawing.Size(513, 27);
            this.NameDrugGTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "NПрепарата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название препарата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фармакологическая группа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Срок хранения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Форма выпуска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Название фирмы:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 35);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер карты:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "Количество штук:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "Цена:";
            // 
            // OrderB
            // 
            this.OrderB.Enabled = false;
            this.OrderB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderB.Location = new System.Drawing.Point(558, 454);
            this.OrderB.Name = "OrderB";
            this.OrderB.Size = new System.Drawing.Size(143, 29);
            this.OrderB.TabIndex = 17;
            this.OrderB.Text = "Заказать";
            this.OrderB.UseVisualStyleBackColor = true;
            this.OrderB.Click += new System.EventHandler(this.OrderB_Click);
            // 
            // DrugNameTB
            // 
            this.DrugNameTB.Enabled = false;
            this.DrugNameTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrugNameTB.Location = new System.Drawing.Point(204, 210);
            this.DrugNameTB.Multiline = true;
            this.DrugNameTB.Name = "DrugNameTB";
            this.DrugNameTB.Size = new System.Drawing.Size(497, 29);
            this.DrugNameTB.TabIndex = 19;
            // 
            // NDrugTB
            // 
            this.NDrugTB.Enabled = false;
            this.NDrugTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDrugTB.Location = new System.Drawing.Point(204, 175);
            this.NDrugTB.Multiline = true;
            this.NDrugTB.Name = "NDrugTB";
            this.NDrugTB.Size = new System.Drawing.Size(178, 29);
            this.NDrugTB.TabIndex = 20;
            // 
            // ExpDateTB
            // 
            this.ExpDateTB.Enabled = false;
            this.ExpDateTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpDateTB.Location = new System.Drawing.Point(204, 280);
            this.ExpDateTB.Multiline = true;
            this.ExpDateTB.Name = "ExpDateTB";
            this.ExpDateTB.Size = new System.Drawing.Size(125, 29);
            this.ExpDateTB.TabIndex = 22;
            // 
            // formTB
            // 
            this.formTB.Enabled = false;
            this.formTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formTB.Location = new System.Drawing.Point(204, 315);
            this.formTB.Multiline = true;
            this.formTB.Name = "formTB";
            this.formTB.Size = new System.Drawing.Size(497, 29);
            this.formTB.TabIndex = 23;
            // 
            // CardTB
            // 
            this.CardTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardTB.Location = new System.Drawing.Point(156, 416);
            this.CardTB.Multiline = true;
            this.CardTB.Name = "CardTB";
            this.CardTB.Size = new System.Drawing.Size(226, 29);
            this.CardTB.TabIndex = 25;
            // 
            // CountsTB
            // 
            this.CountsTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountsTB.Location = new System.Drawing.Point(156, 454);
            this.CountsTB.Multiline = true;
            this.CountsTB.Name = "CountsTB";
            this.CountsTB.Size = new System.Drawing.Size(180, 29);
            this.CountsTB.TabIndex = 26;
            // 
            // PriceTB
            // 
            this.PriceTB.Enabled = false;
            this.PriceTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTB.Location = new System.Drawing.Point(457, 454);
            this.PriceTB.Multiline = true;
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(95, 29);
            this.PriceTB.TabIndex = 27;
            // 
            // PharmGrTB
            // 
            this.PharmGrTB.Enabled = false;
            this.PharmGrTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PharmGrTB.Location = new System.Drawing.Point(204, 245);
            this.PharmGrTB.Multiline = true;
            this.PharmGrTB.Name = "PharmGrTB";
            this.PharmGrTB.Size = new System.Drawing.Size(497, 29);
            this.PharmGrTB.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 87);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // getprice
            // 
            this.getprice.Enabled = false;
            this.getprice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.getprice.Location = new System.Drawing.Point(558, 416);
            this.getprice.Name = "getprice";
            this.getprice.Size = new System.Drawing.Size(143, 29);
            this.getprice.TabIndex = 2;
            this.getprice.Text = "Рассчитать цену";
            this.getprice.UseVisualStyleBackColor = true;
            this.getprice.Click += new System.EventHandler(this.getprice_Click);
            // 
            // namefirmsCB
            // 
            this.namefirmsCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.namefirmsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namefirmsCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namefirmsCB.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namefirmsCB.FormattingEnabled = true;
            this.namefirmsCB.Location = new System.Drawing.Point(153, 373);
            this.namefirmsCB.Name = "namefirmsCB";
            this.namefirmsCB.Size = new System.Drawing.Size(229, 37);
            this.namefirmsCB.TabIndex = 31;
            // 
            // default_cardB
            // 
            this.default_cardB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.default_cardB.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.default_cardB.Location = new System.Drawing.Point(388, 416);
            this.default_cardB.Name = "default_cardB";
            this.default_cardB.Size = new System.Drawing.Size(164, 29);
            this.default_cardB.TabIndex = 32;
            this.default_cardB.Text = "Использовать дефолтную карту";
            this.default_cardB.UseVisualStyleBackColor = true;
            this.default_cardB.Click += new System.EventHandler(this.default_cardB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(501, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение";
            this.groupBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(6, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавление в прайс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(6, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменение прайса";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(739, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.default_cardB);
            this.Controls.Add(this.namefirmsCB);
            this.Controls.Add(this.getprice);
            this.Controls.Add(this.PharmGrTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.CountsTB);
            this.Controls.Add(this.CardTB);
            this.Controls.Add(this.formTB);
            this.Controls.Add(this.ExpDateTB);
            this.Controls.Add(this.NDrugTB);
            this.Controls.Add(this.DrugNameTB);
            this.Controls.Add(this.OrderB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_firm);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "price";
            this.Text = "Прайс";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_firm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ShowPriceB;
        private System.Windows.Forms.TextBox NameDrugGTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button OrderB;
        private System.Windows.Forms.TextBox DrugNameTB;
        private System.Windows.Forms.TextBox NDrugTB;
        private System.Windows.Forms.TextBox ExpDateTB;
        private System.Windows.Forms.TextBox formTB;
        private System.Windows.Forms.TextBox CardTB;
        private System.Windows.Forms.TextBox CountsTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox PharmGrTB;
        private System.Windows.Forms.Button getprice;
        private System.Windows.Forms.ComboBox namefirmsCB;
        private System.Windows.Forms.Button default_cardB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}