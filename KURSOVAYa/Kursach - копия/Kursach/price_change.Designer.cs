namespace Kursach
{
    partial class price_change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(price_change));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name_firm = new System.Windows.Forms.Label();
            this.drugsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.FirstItem = new System.Windows.Forms.ToolStripButton();
            this.PrevItem = new System.Windows.Forms.ToolStripButton();
            this.NextItem = new System.Windows.Forms.ToolStripButton();
            this.LastItem = new System.Windows.Forms.ToolStripButton();
            this.SaveItemNavig = new System.Windows.Forms.ToolStripButton();
            this.refreshBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameDrugTB = new System.Windows.Forms.TextBox();
            this.NameFirmTB = new System.Windows.Forms.TextBox();
            this.CountsTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingNavigator)).BeginInit();
            this.drugsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(13, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 93);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Name_firm
            // 
            this.Name_firm.AutoSize = true;
            this.Name_firm.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_firm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_firm.Location = new System.Drawing.Point(125, 69);
            this.Name_firm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_firm.Name = "Name_firm";
            this.Name_firm.Size = new System.Drawing.Size(274, 54);
            this.Name_firm.TabIndex = 6;
            this.Name_firm.Text = "Пополнение препаратов";
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
            this.SaveItemNavig,
            this.refreshBindingNavigator});
            this.drugsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.drugsBindingNavigator.MoveFirstItem = null;
            this.drugsBindingNavigator.MoveLastItem = null;
            this.drugsBindingNavigator.MoveNextItem = null;
            this.drugsBindingNavigator.MovePreviousItem = null;
            this.drugsBindingNavigator.Name = "drugsBindingNavigator";
            this.drugsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.drugsBindingNavigator.PositionItem = null;
            this.drugsBindingNavigator.Size = new System.Drawing.Size(472, 25);
            this.drugsBindingNavigator.TabIndex = 40;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Название препарата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Название фирмы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Количество:";
            // 
            // NameDrugTB
            // 
            this.NameDrugTB.Enabled = false;
            this.NameDrugTB.Location = new System.Drawing.Point(194, 153);
            this.NameDrugTB.Multiline = true;
            this.NameDrugTB.Name = "NameDrugTB";
            this.NameDrugTB.Size = new System.Drawing.Size(214, 34);
            this.NameDrugTB.TabIndex = 44;
            // 
            // NameFirmTB
            // 
            this.NameFirmTB.Enabled = false;
            this.NameFirmTB.Location = new System.Drawing.Point(194, 193);
            this.NameFirmTB.Multiline = true;
            this.NameFirmTB.Name = "NameFirmTB";
            this.NameFirmTB.Size = new System.Drawing.Size(214, 34);
            this.NameFirmTB.TabIndex = 45;
            // 
            // CountsTB
            // 
            this.CountsTB.Location = new System.Drawing.Point(194, 233);
            this.CountsTB.Multiline = true;
            this.CountsTB.Name = "CountsTB";
            this.CountsTB.Size = new System.Drawing.Size(214, 34);
            this.CountsTB.TabIndex = 46;
            // 
            // price_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(472, 302);
            this.Controls.Add(this.CountsTB);
            this.Controls.Add(this.NameFirmTB);
            this.Controls.Add(this.NameDrugTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drugsBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_firm);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "price_change";
            this.Text = "Изменение прайса";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingNavigator)).EndInit();
            this.drugsBindingNavigator.ResumeLayout(false);
            this.drugsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_firm;
        private System.Windows.Forms.BindingNavigator drugsBindingNavigator;
        private System.Windows.Forms.ToolStripButton FirstItem;
        private System.Windows.Forms.ToolStripButton PrevItem;
        private System.Windows.Forms.ToolStripButton NextItem;
        private System.Windows.Forms.ToolStripButton LastItem;
        private System.Windows.Forms.ToolStripButton SaveItemNavig;
        private System.Windows.Forms.ToolStripButton refreshBindingNavigator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameDrugTB;
        private System.Windows.Forms.TextBox NameFirmTB;
        private System.Windows.Forms.TextBox CountsTB;
    }
}