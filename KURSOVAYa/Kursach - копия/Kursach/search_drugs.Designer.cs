namespace Kursach
{
    partial class search_drugs
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
            this.SearchDrugB = new System.Windows.Forms.Button();
            this.SearchDrTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameDrugTB = new System.Windows.Forms.TextBox();
            this.NDrugTB = new System.Windows.Forms.TextBox();
            this.PharmGrTB = new System.Windows.Forms.TextBox();
            this.FormDrTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_drugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_pills
            // 
            this.Name_pills.AutoSize = true;
            this.Name_pills.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_pills.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_pills.Location = new System.Drawing.Point(117, 27);
            this.Name_pills.Name = "Name_pills";
            this.Name_pills.Size = new System.Drawing.Size(203, 54);
            this.Name_pills.TabIndex = 5;
            this.Name_pills.Text = "Поиск препарата";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchDrugB);
            this.groupBox1.Controls.Add(this.SearchDrTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите название препарата";
            // 
            // SearchDrugB
            // 
            this.SearchDrugB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchDrugB.Location = new System.Drawing.Point(243, 41);
            this.SearchDrugB.Name = "SearchDrugB";
            this.SearchDrugB.Size = new System.Drawing.Size(92, 30);
            this.SearchDrugB.TabIndex = 1;
            this.SearchDrugB.Text = "Поиск";
            this.SearchDrugB.UseVisualStyleBackColor = true;
            this.SearchDrugB.Click += new System.EventHandler(this.SearchDrugB_Click);
            // 
            // SearchDrTB
            // 
            this.SearchDrTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchDrTB.Location = new System.Drawing.Point(6, 41);
            this.SearchDrTB.Multiline = true;
            this.SearchDrTB.Name = "SearchDrTB";
            this.SearchDrTB.Size = new System.Drawing.Size(231, 30);
            this.SearchDrTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "NПрепарата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название препарата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип препарата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Форма выпуска:";
            // 
            // NameDrugTB
            // 
            this.NameDrugTB.Enabled = false;
            this.NameDrugTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDrugTB.Location = new System.Drawing.Point(153, 244);
            this.NameDrugTB.Multiline = true;
            this.NameDrugTB.Name = "NameDrugTB";
            this.NameDrugTB.Size = new System.Drawing.Size(200, 30);
            this.NameDrugTB.TabIndex = 14;
            // 
            // NDrugTB
            // 
            this.NDrugTB.Enabled = false;
            this.NDrugTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDrugTB.Location = new System.Drawing.Point(111, 208);
            this.NDrugTB.Multiline = true;
            this.NDrugTB.Name = "NDrugTB";
            this.NDrugTB.Size = new System.Drawing.Size(90, 30);
            this.NDrugTB.TabIndex = 15;
            // 
            // PharmGrTB
            // 
            this.PharmGrTB.Enabled = false;
            this.PharmGrTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PharmGrTB.Location = new System.Drawing.Point(125, 279);
            this.PharmGrTB.Multiline = true;
            this.PharmGrTB.Name = "PharmGrTB";
            this.PharmGrTB.Size = new System.Drawing.Size(228, 30);
            this.PharmGrTB.TabIndex = 16;
            // 
            // FormDrTB
            // 
            this.FormDrTB.Enabled = false;
            this.FormDrTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormDrTB.Location = new System.Drawing.Point(126, 312);
            this.FormDrTB.Multiline = true;
            this.FormDrTB.Name = "FormDrTB";
            this.FormDrTB.Size = new System.Drawing.Size(227, 30);
            this.FormDrTB.TabIndex = 17;
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
            // search_drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(364, 395);
            this.Controls.Add(this.FormDrTB);
            this.Controls.Add(this.PharmGrTB);
            this.Controls.Add(this.NDrugTB);
            this.Controls.Add(this.NameDrugTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "search_drugs";
            this.Text = "Поиск препарата";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_drugsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchDrugB;
        private System.Windows.Forms.TextBox SearchDrTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameDrugTB;
        private System.Windows.Forms.TextBox NDrugTB;
        private System.Windows.Forms.TextBox PharmGrTB;
        private System.Windows.Forms.TextBox FormDrTB;
        private System.Windows.Forms.BindingSource search_drugsBindingSource;
    }
}