namespace Kursach
{
    partial class drugs_subuse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drugs_subuse));
            this.Name_pills = new System.Windows.Forms.Label();
            this.indforusingResultBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.FirstItem = new System.Windows.Forms.ToolStripButton();
            this.PrevItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NextItem = new System.Windows.Forms.ToolStripButton();
            this.LastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveItemNavig = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OutSubTB = new System.Windows.Forms.Button();
            this.Enter_DisBut = new System.Windows.Forms.Button();
            this.Drug_nameTB = new System.Windows.Forms.TextBox();
            this.Dis_nameTB = new System.Windows.Forms.TextBox();
            this.NDrugTB = new System.Windows.Forms.TextBox();
            this.PharmGrTB = new System.Windows.Forms.TextBox();
            this.SubTB = new System.Windows.Forms.TextBox();
            this.ContrainTB = new System.Windows.Forms.TextBox();
            this.OverdoseTB = new System.Windows.Forms.TextBox();
            this.DoseTB = new System.Windows.Forms.TextBox();
            this.SideEffTB = new System.Windows.Forms.TextBox();
            this.InterTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PharmTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.indforusingResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.indforusingResultBindingNavigator)).BeginInit();
            this.indforusingResultBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indforusingResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_pills
            // 
            this.Name_pills.AutoSize = true;
            this.Name_pills.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_pills.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_pills.Location = new System.Drawing.Point(111, 39);
            this.Name_pills.Name = "Name_pills";
            this.Name_pills.Size = new System.Drawing.Size(284, 54);
            this.Name_pills.TabIndex = 5;
            this.Name_pills.Text = "Показания к применению";
            // 
            // indforusingResultBindingNavigator
            // 
            this.indforusingResultBindingNavigator.AddNewItem = null;
            this.indforusingResultBindingNavigator.CountItem = null;
            this.indforusingResultBindingNavigator.DeleteItem = null;
            this.indforusingResultBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstItem,
            this.PrevItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.NextItem,
            this.LastItem,
            this.bindingNavigatorSeparator2,
            this.SaveItemNavig});
            this.indforusingResultBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.indforusingResultBindingNavigator.MoveFirstItem = this.FirstItem;
            this.indforusingResultBindingNavigator.MoveLastItem = this.LastItem;
            this.indforusingResultBindingNavigator.MoveNextItem = this.NextItem;
            this.indforusingResultBindingNavigator.MovePreviousItem = this.PrevItem;
            this.indforusingResultBindingNavigator.Name = "indforusingResultBindingNavigator";
            this.indforusingResultBindingNavigator.PositionItem = null;
            this.indforusingResultBindingNavigator.Size = new System.Drawing.Size(902, 25);
            this.indforusingResultBindingNavigator.TabIndex = 7;
            this.indforusingResultBindingNavigator.Text = "bindingNavigator1";
            // 
            // FirstItem
            // 
            this.FirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstItem.Image = ((System.Drawing.Image)(resources.GetObject("FirstItem.Image")));
            this.FirstItem.Name = "FirstItem";
            this.FirstItem.RightToLeftAutoMirrorImage = true;
            this.FirstItem.Size = new System.Drawing.Size(23, 22);
            this.FirstItem.Text = "Переместить в начало";
            this.FirstItem.Click += new System.EventHandler(this.FirstItem_Click);
            // 
            // PrevItem
            // 
            this.PrevItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrevItem.Image = ((System.Drawing.Image)(resources.GetObject("PrevItem.Image")));
            this.PrevItem.Name = "PrevItem";
            this.PrevItem.RightToLeftAutoMirrorImage = true;
            this.PrevItem.Size = new System.Drawing.Size(23, 22);
            this.PrevItem.Text = "Переместить назад";
            this.PrevItem.Click += new System.EventHandler(this.PrevItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NextItem
            // 
            this.NextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextItem.Image = ((System.Drawing.Image)(resources.GetObject("NextItem.Image")));
            this.NextItem.Name = "NextItem";
            this.NextItem.RightToLeftAutoMirrorImage = true;
            this.NextItem.Size = new System.Drawing.Size(23, 22);
            this.NextItem.Text = "Переместить вперед";
            this.NextItem.Click += new System.EventHandler(this.NextItem_Click);
            // 
            // LastItem
            // 
            this.LastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastItem.Image = ((System.Drawing.Image)(resources.GetObject("LastItem.Image")));
            this.LastItem.Name = "LastItem";
            this.LastItem.RightToLeftAutoMirrorImage = true;
            this.LastItem.Size = new System.Drawing.Size(23, 22);
            this.LastItem.Text = "Переместить в конец";
            this.LastItem.Click += new System.EventHandler(this.LastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveItemNavig
            // 
            this.SaveItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("SaveItemNavig.Image")));
            this.SaveItemNavig.Name = "SaveItemNavig";
            this.SaveItemNavig.Size = new System.Drawing.Size(23, 22);
            this.SaveItemNavig.Text = "Save Data";
            this.SaveItemNavig.Click += new System.EventHandler(this.SaveItemNavig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Заболевание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название препарата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "NПрепарата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фармакологическая группа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Показания к применению:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Доза:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "Побочные действия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Передозировка:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 35);
            this.label9.TabIndex = 16;
            this.label9.Text = "Взаимодействие с другими препаратами:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 761);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 35);
            this.label10.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 35);
            this.label11.TabIndex = 18;
            this.label11.Text = "Противопоказания:";
            // 
            // OutSubTB
            // 
            this.OutSubTB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OutSubTB.Location = new System.Drawing.Point(654, 98);
            this.OutSubTB.Name = "OutSubTB";
            this.OutSubTB.Size = new System.Drawing.Size(236, 34);
            this.OutSubTB.TabIndex = 19;
            this.OutSubTB.Text = "Вывести показания";
            this.OutSubTB.UseVisualStyleBackColor = true;
            this.OutSubTB.Click += new System.EventHandler(this.OutSubTB_Click);
            // 
            // Enter_DisBut
            // 
            this.Enter_DisBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Enter_DisBut.Location = new System.Drawing.Point(654, 138);
            this.Enter_DisBut.Name = "Enter_DisBut";
            this.Enter_DisBut.Size = new System.Drawing.Size(236, 34);
            this.Enter_DisBut.TabIndex = 20;
            this.Enter_DisBut.Text = "Заболевания";
            this.Enter_DisBut.UseVisualStyleBackColor = true;
            this.Enter_DisBut.Click += new System.EventHandler(this.Enter_DisBut_Click);
            // 
            // Drug_nameTB
            // 
            this.Drug_nameTB.Enabled = false;
            this.Drug_nameTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Drug_nameTB.Location = new System.Drawing.Point(186, 175);
            this.Drug_nameTB.Multiline = true;
            this.Drug_nameTB.Name = "Drug_nameTB";
            this.Drug_nameTB.Size = new System.Drawing.Size(460, 29);
            this.Drug_nameTB.TabIndex = 21;
            // 
            // Dis_nameTB
            // 
            this.Dis_nameTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dis_nameTB.Location = new System.Drawing.Point(186, 140);
            this.Dis_nameTB.Multiline = true;
            this.Dis_nameTB.Name = "Dis_nameTB";
            this.Dis_nameTB.Size = new System.Drawing.Size(460, 29);
            this.Dis_nameTB.TabIndex = 22;
            // 
            // NDrugTB
            // 
            this.NDrugTB.Enabled = false;
            this.NDrugTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDrugTB.Location = new System.Drawing.Point(781, 175);
            this.NDrugTB.Multiline = true;
            this.NDrugTB.Name = "NDrugTB";
            this.NDrugTB.Size = new System.Drawing.Size(109, 29);
            this.NDrugTB.TabIndex = 23;
            // 
            // PharmGrTB
            // 
            this.PharmGrTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PharmGrTB.Location = new System.Drawing.Point(186, 210);
            this.PharmGrTB.Multiline = true;
            this.PharmGrTB.Name = "PharmGrTB";
            this.PharmGrTB.Size = new System.Drawing.Size(704, 29);
            this.PharmGrTB.TabIndex = 24;
            // 
            // SubTB
            // 
            this.SubTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubTB.Location = new System.Drawing.Point(186, 303);
            this.SubTB.Multiline = true;
            this.SubTB.Name = "SubTB";
            this.SubTB.Size = new System.Drawing.Size(704, 59);
            this.SubTB.TabIndex = 25;
            // 
            // ContrainTB
            // 
            this.ContrainTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContrainTB.Location = new System.Drawing.Point(186, 443);
            this.ContrainTB.Multiline = true;
            this.ContrainTB.Name = "ContrainTB";
            this.ContrainTB.Size = new System.Drawing.Size(704, 66);
            this.ContrainTB.TabIndex = 26;
            // 
            // OverdoseTB
            // 
            this.OverdoseTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OverdoseTB.Location = new System.Drawing.Point(186, 588);
            this.OverdoseTB.Multiline = true;
            this.OverdoseTB.Name = "OverdoseTB";
            this.OverdoseTB.Size = new System.Drawing.Size(705, 52);
            this.OverdoseTB.TabIndex = 27;
            // 
            // DoseTB
            // 
            this.DoseTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoseTB.Location = new System.Drawing.Point(55, 515);
            this.DoseTB.Multiline = true;
            this.DoseTB.Name = "DoseTB";
            this.DoseTB.Size = new System.Drawing.Size(835, 67);
            this.DoseTB.TabIndex = 28;
            // 
            // SideEffTB
            // 
            this.SideEffTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SideEffTB.Location = new System.Drawing.Point(186, 368);
            this.SideEffTB.Multiline = true;
            this.SideEffTB.Name = "SideEffTB";
            this.SideEffTB.Size = new System.Drawing.Size(705, 69);
            this.SideEffTB.TabIndex = 29;
            // 
            // InterTB
            // 
            this.InterTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InterTB.Location = new System.Drawing.Point(282, 646);
            this.InterTB.Multiline = true;
            this.InterTB.Name = "InterTB";
            this.InterTB.Size = new System.Drawing.Size(608, 83);
            this.InterTB.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 35);
            this.label12.TabIndex = 31;
            this.label12.Text = "Фармакология:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 35);
            this.label13.TabIndex = 32;
            // 
            // PharmTB
            // 
            this.PharmTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PharmTB.Location = new System.Drawing.Point(186, 245);
            this.PharmTB.Multiline = true;
            this.PharmTB.Name = "PharmTB";
            this.PharmTB.Size = new System.Drawing.Size(704, 52);
            this.PharmTB.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(9, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // drugs_subuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(902, 770);
            this.Controls.Add(this.PharmTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.InterTB);
            this.Controls.Add(this.SideEffTB);
            this.Controls.Add(this.DoseTB);
            this.Controls.Add(this.OverdoseTB);
            this.Controls.Add(this.ContrainTB);
            this.Controls.Add(this.SubTB);
            this.Controls.Add(this.PharmGrTB);
            this.Controls.Add(this.NDrugTB);
            this.Controls.Add(this.Dis_nameTB);
            this.Controls.Add(this.Drug_nameTB);
            this.Controls.Add(this.Enter_DisBut);
            this.Controls.Add(this.OutSubTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indforusingResultBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "drugs_subuse";
            this.Text = "Показания к применению";
            ((System.ComponentModel.ISupportInitialize)(this.indforusingResultBindingNavigator)).EndInit();
            this.indforusingResultBindingNavigator.ResumeLayout(false);
            this.indforusingResultBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indforusingResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.BindingNavigator indforusingResultBindingNavigator;
        private System.Windows.Forms.ToolStripButton FirstItem;
        private System.Windows.Forms.ToolStripButton PrevItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NextItem;
        private System.Windows.Forms.ToolStripButton LastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource indforusingResultBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button OutSubTB;
        private System.Windows.Forms.Button Enter_DisBut;
        private System.Windows.Forms.TextBox Drug_nameTB;
        private System.Windows.Forms.TextBox Dis_nameTB;
        private System.Windows.Forms.TextBox NDrugTB;
        private System.Windows.Forms.TextBox PharmGrTB;
        private System.Windows.Forms.TextBox SubTB;
        private System.Windows.Forms.TextBox ContrainTB;
        private System.Windows.Forms.TextBox OverdoseTB;
        private System.Windows.Forms.TextBox DoseTB;
        private System.Windows.Forms.TextBox SideEffTB;
        private System.Windows.Forms.TextBox InterTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PharmTB;
        private System.Windows.Forms.ToolStripButton SaveItemNavig;
    }
}