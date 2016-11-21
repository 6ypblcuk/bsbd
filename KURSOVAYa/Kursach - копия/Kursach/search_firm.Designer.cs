namespace Kursach
{
    partial class search_firm
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
            this.components = new System.ComponentModel.Container();
            this.Name_pills = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchFirmB = new System.Windows.Forms.Button();
            this.SearchFirmTB = new System.Windows.Forms.TextBox();
            this.IdFirmTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameFirmTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.SiteTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_firmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_pills
            // 
            this.Name_pills.AutoSize = true;
            this.Name_pills.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_pills.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_pills.Location = new System.Drawing.Point(117, 27);
            this.Name_pills.Name = "Name_pills";
            this.Name_pills.Size = new System.Drawing.Size(162, 54);
            this.Name_pills.TabIndex = 5;
            this.Name_pills.Text = "Поиск фирмы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchFirmB);
            this.groupBox1.Controls.Add(this.SearchFirmTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 77);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите название фирмы:";
            // 
            // SearchFirmB
            // 
            this.SearchFirmB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchFirmB.Location = new System.Drawing.Point(243, 41);
            this.SearchFirmB.Name = "SearchFirmB";
            this.SearchFirmB.Size = new System.Drawing.Size(92, 30);
            this.SearchFirmB.TabIndex = 1;
            this.SearchFirmB.Text = "Поиск";
            this.SearchFirmB.UseVisualStyleBackColor = true;
            this.SearchFirmB.Click += new System.EventHandler(this.SearchFirmB_Click);
            // 
            // SearchFirmTB
            // 
            this.SearchFirmTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFirmTB.Location = new System.Drawing.Point(6, 41);
            this.SearchFirmTB.Multiline = true;
            this.SearchFirmTB.Name = "SearchFirmTB";
            this.SearchFirmTB.Size = new System.Drawing.Size(231, 30);
            this.SearchFirmTB.TabIndex = 0;
            // 
            // IdFirmTB
            // 
            this.IdFirmTB.Enabled = false;
            this.IdFirmTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdFirmTB.Location = new System.Drawing.Point(126, 208);
            this.IdFirmTB.Multiline = true;
            this.IdFirmTB.Name = "IdFirmTB";
            this.IdFirmTB.Size = new System.Drawing.Size(227, 30);
            this.IdFirmTB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Шифр фирмы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Название фирмы:";
            // 
            // NameFirmTB
            // 
            this.NameFirmTB.Enabled = false;
            this.NameFirmTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFirmTB.Location = new System.Drawing.Point(126, 246);
            this.NameFirmTB.Multiline = true;
            this.NameFirmTB.Name = "NameFirmTB";
            this.NameFirmTB.Size = new System.Drawing.Size(227, 30);
            this.NameFirmTB.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 35);
            this.label5.TabIndex = 22;
            this.label5.Text = "Сайт:";
            // 
            // PhoneTB
            // 
            this.PhoneTB.Enabled = false;
            this.PhoneTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTB.Location = new System.Drawing.Point(80, 279);
            this.PhoneTB.Multiline = true;
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(273, 30);
            this.PhoneTB.TabIndex = 23;
            // 
            // AddressTB
            // 
            this.AddressTB.Enabled = false;
            this.AddressTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTB.Location = new System.Drawing.Point(80, 312);
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(274, 30);
            this.AddressTB.TabIndex = 24;
            // 
            // SiteTB
            // 
            this.SiteTB.Enabled = false;
            this.SiteTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteTB.Location = new System.Drawing.Point(80, 344);
            this.SiteTB.Multiline = true;
            this.SiteTB.Name = "SiteTB";
            this.SiteTB.Size = new System.Drawing.Size(274, 30);
            this.SiteTB.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // search_firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(370, 397);
            this.Controls.Add(this.SiteTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameFirmTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdFirmTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "search_firm";
            this.Text = "Поиск фирмы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_firmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchFirmB;
        private System.Windows.Forms.TextBox SearchFirmTB;
        private System.Windows.Forms.TextBox IdFirmTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameFirmTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox SiteTB;
        private System.Windows.Forms.BindingSource search_firmBindingSource;
    }
}