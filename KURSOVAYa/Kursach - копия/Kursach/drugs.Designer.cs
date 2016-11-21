namespace Kursach
{
    partial class drugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drugs));
            this.Name_pills = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.InfGB = new System.Windows.Forms.GroupBox();
            this.firmslink = new System.Windows.Forms.LinkLabel();
            this.compositionlink = new System.Windows.Forms.LinkLabel();
            this.subuselink = new System.Windows.Forms.LinkLabel();
            this.NoteTB = new System.Windows.Forms.TextBox();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchB = new System.Windows.Forms.Button();
            this.NDrugTB = new System.Windows.Forms.TextBox();
            this.DrugNameTB = new System.Windows.Forms.TextBox();
            this.ActTB = new System.Windows.Forms.TextBox();
            this.ChemNameTB = new System.Windows.Forms.TextBox();
            this.PharmGrTB = new System.Windows.Forms.TextBox();
            this.SubUseTB = new System.Windows.Forms.TextBox();
            this.FormTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ExpDateTB = new System.Windows.Forms.TextBox();
            this.drugsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.FirstItem = new System.Windows.Forms.ToolStripButton();
            this.PrevItem = new System.Windows.Forms.ToolStripButton();
            this.NextItem = new System.Windows.Forms.ToolStripButton();
            this.LastItem = new System.Windows.Forms.ToolStripButton();
            this.AddItemNavig = new System.Windows.Forms.ToolStripButton();
            this.DeleteItemNavig = new System.Windows.Forms.ToolStripButton();
            this.SaveItemNavig = new System.Windows.Forms.ToolStripButton();
            this.refreshBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingNavigator)).BeginInit();
            this.drugsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_pills
            // 
            this.Name_pills.AutoSize = true;
            this.Name_pills.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_pills.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_pills.Location = new System.Drawing.Point(114, 54);
            this.Name_pills.Name = "Name_pills";
            this.Name_pills.Size = new System.Drawing.Size(143, 54);
            this.Name_pills.TabIndex = 1;
            this.Name_pills.Text = "Препараты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "NПрепарата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название препарата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Химическое название:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 35);
            this.label8.TabIndex = 9;
            this.label8.Text = "Применение вещества:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 35);
            this.label11.TabIndex = 12;
            // 
            // InfGB
            // 
            this.InfGB.Controls.Add(this.firmslink);
            this.InfGB.Controls.Add(this.compositionlink);
            this.InfGB.Controls.Add(this.subuselink);
            this.InfGB.Location = new System.Drawing.Point(11, 444);
            this.InfGB.Name = "InfGB";
            this.InfGB.Size = new System.Drawing.Size(782, 90);
            this.InfGB.TabIndex = 13;
            this.InfGB.TabStop = false;
            this.InfGB.Text = "Дополнительная информация о препарате";
            // 
            // firmslink
            // 
            this.firmslink.AutoSize = true;
            this.firmslink.Location = new System.Drawing.Point(543, 38);
            this.firmslink.Name = "firmslink";
            this.firmslink.Size = new System.Drawing.Size(214, 35);
            this.firmslink.TabIndex = 3;
            this.firmslink.TabStop = true;
            this.firmslink.Text = "Фирмы-поставщики препарата";
            this.firmslink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.firmslink_LinkClicked);
            // 
            // compositionlink
            // 
            this.compositionlink.AutoSize = true;
            this.compositionlink.Location = new System.Drawing.Point(259, 38);
            this.compositionlink.Name = "compositionlink";
            this.compositionlink.Size = new System.Drawing.Size(212, 35);
            this.compositionlink.TabIndex = 2;
            this.compositionlink.TabStop = true;
            this.compositionlink.Text = "Состав и лекарственная форма";
            this.compositionlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.compositionlink_LinkClicked);
            // 
            // subuselink
            // 
            this.subuselink.AutoSize = true;
            this.subuselink.Location = new System.Drawing.Point(22, 38);
            this.subuselink.Name = "subuselink";
            this.subuselink.Size = new System.Drawing.Size(174, 35);
            this.subuselink.TabIndex = 0;
            this.subuselink.TabStop = true;
            this.subuselink.Text = "Показания к применению";
            this.subuselink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.subuselink_LinkClicked);
            // 
            // NoteTB
            // 
            this.NoteTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "note", true));
            this.NoteTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTB.Location = new System.Drawing.Point(12, 549);
            this.NoteTB.Multiline = true;
            this.NoteTB.Name = "NoteTB";
            this.NoteTB.Size = new System.Drawing.Size(781, 57);
            this.NoteTB.TabIndex = 14;
            // 
            // SearchB
            // 
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchB.Location = new System.Drawing.Point(646, 164);
            this.SearchB.Name = "SearchB";
            this.SearchB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchB.Size = new System.Drawing.Size(147, 32);
            this.SearchB.TabIndex = 15;
            this.SearchB.Text = "Поиск по названию";
            this.SearchB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // NDrugTB
            // 
            this.NDrugTB.Enabled = false;
            this.NDrugTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDrugTB.Location = new System.Drawing.Point(123, 129);
            this.NDrugTB.Multiline = true;
            this.NDrugTB.Name = "NDrugTB";
            this.NDrugTB.Size = new System.Drawing.Size(70, 29);
            this.NDrugTB.TabIndex = 17;
            // 
            // DrugNameTB
            // 
            this.DrugNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "name_drug", true));
            this.DrugNameTB.Enabled = false;
            this.DrugNameTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrugNameTB.Location = new System.Drawing.Point(194, 164);
            this.DrugNameTB.Multiline = true;
            this.DrugNameTB.Name = "DrugNameTB";
            this.DrugNameTB.Size = new System.Drawing.Size(446, 32);
            this.DrugNameTB.TabIndex = 18;
            // 
            // ActTB
            // 
            this.ActTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "active_sub", true));
            this.ActTB.Enabled = false;
            this.ActTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActTB.Location = new System.Drawing.Point(194, 199);
            this.ActTB.Multiline = true;
            this.ActTB.Name = "ActTB";
            this.ActTB.Size = new System.Drawing.Size(599, 32);
            this.ActTB.TabIndex = 19;
            // 
            // ChemNameTB
            // 
            this.ChemNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "chem_name", true));
            this.ChemNameTB.Enabled = false;
            this.ChemNameTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChemNameTB.Location = new System.Drawing.Point(194, 234);
            this.ChemNameTB.Multiline = true;
            this.ChemNameTB.Name = "ChemNameTB";
            this.ChemNameTB.Size = new System.Drawing.Size(599, 32);
            this.ChemNameTB.TabIndex = 20;
            // 
            // PharmGrTB
            // 
            this.PharmGrTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "pharm_group", true));
            this.PharmGrTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PharmGrTB.Location = new System.Drawing.Point(194, 269);
            this.PharmGrTB.Multiline = true;
            this.PharmGrTB.Name = "PharmGrTB";
            this.PharmGrTB.Size = new System.Drawing.Size(599, 32);
            this.PharmGrTB.TabIndex = 21;
            // 
            // SubUseTB
            // 
            this.SubUseTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "sub_use", true));
            this.SubUseTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubUseTB.Location = new System.Drawing.Point(194, 307);
            this.SubUseTB.Multiline = true;
            this.SubUseTB.Name = "SubUseTB";
            this.SubUseTB.Size = new System.Drawing.Size(599, 93);
            this.SubUseTB.TabIndex = 22;
            // 
            // FormTB
            // 
            this.FormTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "form", true));
            this.FormTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormTB.Location = new System.Drawing.Point(194, 406);
            this.FormTB.Multiline = true;
            this.FormTB.Name = "FormTB";
            this.FormTB.Size = new System.Drawing.Size(599, 32);
            this.FormTB.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Действующее вещество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 35);
            this.label4.TabIndex = 27;
            this.label4.Text = "Фармакологическая группа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 35);
            this.label7.TabIndex = 29;
            this.label7.Text = "Форма выпуска:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 35);
            this.label9.TabIndex = 30;
            this.label9.Text = "Срок хранения:";
            // 
            // ExpDateTB
            // 
            this.ExpDateTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "exp_date", true));
            this.ExpDateTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpDateTB.Location = new System.Drawing.Point(347, 126);
            this.ExpDateTB.Multiline = true;
            this.ExpDateTB.Name = "ExpDateTB";
            this.ExpDateTB.Size = new System.Drawing.Size(446, 32);
            this.ExpDateTB.TabIndex = 31;
            // 
            // drugsBindingNavigator
            // 
            this.drugsBindingNavigator.AddNewItem = null;
            this.drugsBindingNavigator.CountItem = null;
            this.drugsBindingNavigator.DeleteItem = null;
            this.drugsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstItem,
            this.PrevItem,
            this.NextItem,
            this.LastItem,
            this.AddItemNavig,
            this.DeleteItemNavig,
            this.SaveItemNavig,
            this.refreshBindingNavigator});
            this.drugsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.drugsBindingNavigator.MoveFirstItem = null;
            this.drugsBindingNavigator.MoveLastItem = null;
            this.drugsBindingNavigator.MoveNextItem = null;
            this.drugsBindingNavigator.MovePreviousItem = null;
            this.drugsBindingNavigator.Name = "drugsBindingNavigator";
            this.drugsBindingNavigator.PositionItem = null;
            this.drugsBindingNavigator.Size = new System.Drawing.Size(805, 25);
            this.drugsBindingNavigator.TabIndex = 39;
            this.drugsBindingNavigator.Text = "bindingNavigator1";
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
            // AddItemNavig
            // 
            this.AddItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("AddItemNavig.Image")));
            this.AddItemNavig.Name = "AddItemNavig";
            this.AddItemNavig.RightToLeftAutoMirrorImage = true;
            this.AddItemNavig.Size = new System.Drawing.Size(23, 22);
            this.AddItemNavig.Text = "Добавить";
            this.AddItemNavig.Click += new System.EventHandler(this.AddItemNavig_Click);
            // 
            // DeleteItemNavig
            // 
            this.DeleteItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItemNavig.Image")));
            this.DeleteItemNavig.Name = "DeleteItemNavig";
            this.DeleteItemNavig.RightToLeftAutoMirrorImage = true;
            this.DeleteItemNavig.Size = new System.Drawing.Size(23, 22);
            this.DeleteItemNavig.Text = "Удалить";
            this.DeleteItemNavig.Click += new System.EventHandler(this.DeleteItemNavig_Click);
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
            // refreshBindingNavigator
            // 
            this.refreshBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBindingNavigator.Image = global::Kursach.Properties.Resources.refresh;
            this.refreshBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBindingNavigator.Name = "refreshBindingNavigator";
            this.refreshBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.refreshBindingNavigator.Text = "&Создать";
            this.refreshBindingNavigator.Click += new System.EventHandler(this.refreshBindingNavigator_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(9, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(805, 618);
            this.Controls.Add(this.drugsBindingNavigator);
            this.Controls.Add(this.ExpDateTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTB);
            this.Controls.Add(this.SubUseTB);
            this.Controls.Add(this.PharmGrTB);
            this.Controls.Add(this.ChemNameTB);
            this.Controls.Add(this.ActTB);
            this.Controls.Add(this.DrugNameTB);
            this.Controls.Add(this.NDrugTB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.NoteTB);
            this.Controls.Add(this.InfGB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "drugs";
            this.Text = "Препараты";
            this.InfGB.ResumeLayout(false);
            this.InfGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingNavigator)).EndInit();
            this.drugsBindingNavigator.ResumeLayout(false);
            this.drugsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox InfGB;
        private System.Windows.Forms.LinkLabel compositionlink;
        private System.Windows.Forms.LinkLabel subuselink;
        private System.Windows.Forms.TextBox NoteTB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.TextBox NDrugTB;
        private System.Windows.Forms.TextBox DrugNameTB;
        private System.Windows.Forms.TextBox ActTB;
        private System.Windows.Forms.TextBox ChemNameTB;
        private System.Windows.Forms.TextBox PharmGrTB;
        private System.Windows.Forms.TextBox SubUseTB;
        private System.Windows.Forms.TextBox FormTB;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private System.Windows.Forms.LinkLabel firmslink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ExpDateTB;
        private System.Windows.Forms.BindingNavigator drugsBindingNavigator;
        private System.Windows.Forms.ToolStripButton FirstItem;
        private System.Windows.Forms.ToolStripButton PrevItem;
        private System.Windows.Forms.ToolStripButton NextItem;
        private System.Windows.Forms.ToolStripButton LastItem;
        private System.Windows.Forms.ToolStripButton AddItemNavig;
        private System.Windows.Forms.ToolStripButton DeleteItemNavig;
        private System.Windows.Forms.ToolStripButton SaveItemNavig;
        private System.Windows.Forms.ToolStripButton refreshBindingNavigator;
    }
}