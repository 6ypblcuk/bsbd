namespace Kursach
{
    partial class disease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(disease));
            this.Name_pills = new System.Windows.Forms.Label();
            this.diseaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.datatableDisease = new System.Windows.Forms.DataGridView();
            this.CipDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddItemNavig = new System.Windows.Forms.ToolStripButton();
            this.DeleteItemNavig = new System.Windows.Forms.ToolStripButton();
            this.FirstItemNavig = new System.Windows.Forms.ToolStripButton();
            this.PrevItemNavig = new System.Windows.Forms.ToolStripButton();
            this.NextItemNavig = new System.Windows.Forms.ToolStripButton();
            this.LastItemNavig = new System.Windows.Forms.ToolStripButton();
            this.refreshBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingNavigator)).BeginInit();
            this.diseaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
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
            this.Name_pills.Size = new System.Drawing.Size(151, 54);
            this.Name_pills.TabIndex = 5;
            this.Name_pills.Text = "Заболевания";
            // 
            // diseaseBindingNavigator
            // 
            this.diseaseBindingNavigator.AddNewItem = this.AddItemNavig;
            this.diseaseBindingNavigator.CountItem = null;
            this.diseaseBindingNavigator.DeleteItem = this.DeleteItemNavig;
            this.diseaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstItemNavig,
            this.PrevItemNavig,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.NextItemNavig,
            this.LastItemNavig,
            this.bindingNavigatorSeparator2,
            this.AddItemNavig,
            this.DeleteItemNavig,
            this.refreshBindingNavigator});
            this.diseaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.diseaseBindingNavigator.MoveFirstItem = this.FirstItemNavig;
            this.diseaseBindingNavigator.MoveLastItem = this.LastItemNavig;
            this.diseaseBindingNavigator.MoveNextItem = this.NextItemNavig;
            this.diseaseBindingNavigator.MovePreviousItem = this.PrevItemNavig;
            this.diseaseBindingNavigator.Name = "diseaseBindingNavigator";
            this.diseaseBindingNavigator.PositionItem = null;
            this.diseaseBindingNavigator.Size = new System.Drawing.Size(714, 25);
            this.diseaseBindingNavigator.TabIndex = 7;
            this.diseaseBindingNavigator.Text = "diseaseBindingNavigator";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // datatableDisease
            // 
            this.datatableDisease.AllowUserToAddRows = false;
            this.datatableDisease.AllowUserToDeleteRows = false;
            this.datatableDisease.AutoGenerateColumns = false;
            this.datatableDisease.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datatableDisease.BackgroundColor = System.Drawing.Color.Snow;
            this.datatableDisease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datatableDisease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatableDisease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CipDis,
            this.InDis,
            this.TypeOfP});
            this.datatableDisease.DataSource = this.diseaseBindingSource;
            this.datatableDisease.Location = new System.Drawing.Point(9, 125);
            this.datatableDisease.Name = "datatableDisease";
            this.datatableDisease.Size = new System.Drawing.Size(693, 428);
            this.datatableDisease.TabIndex = 8;
            // 
            // CipDis
            // 
            this.CipDis.DataPropertyName = "id_dis";
            this.CipDis.HeaderText = "Шифр ";
            this.CipDis.Name = "CipDis";
            this.CipDis.Width = 140;
            // 
            // InDis
            // 
            this.InDis.DataPropertyName = "name_dis";
            this.InDis.HeaderText = "Название болезни";
            this.InDis.Name = "InDis";
            this.InDis.Width = 200;
            // 
            // TypeOfP
            // 
            this.TypeOfP.DataPropertyName = "drug_type";
            this.TypeOfP.HeaderText = "При заболевании";
            this.TypeOfP.Name = "TypeOfP";
            this.TypeOfP.Width = 305;
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
            // 
            // FirstItemNavig
            // 
            this.FirstItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("FirstItemNavig.Image")));
            this.FirstItemNavig.Name = "FirstItemNavig";
            this.FirstItemNavig.RightToLeftAutoMirrorImage = true;
            this.FirstItemNavig.Size = new System.Drawing.Size(23, 22);
            this.FirstItemNavig.Text = "Переместить в начало";
            this.FirstItemNavig.Click += new System.EventHandler(this.FirstItemNavig_Click);
            // 
            // PrevItemNavig
            // 
            this.PrevItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrevItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("PrevItemNavig.Image")));
            this.PrevItemNavig.Name = "PrevItemNavig";
            this.PrevItemNavig.RightToLeftAutoMirrorImage = true;
            this.PrevItemNavig.Size = new System.Drawing.Size(23, 22);
            this.PrevItemNavig.Text = "Переместить назад";
            this.PrevItemNavig.Click += new System.EventHandler(this.PrevItemNavig_Click);
            // 
            // NextItemNavig
            // 
            this.NextItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("NextItemNavig.Image")));
            this.NextItemNavig.Name = "NextItemNavig";
            this.NextItemNavig.RightToLeftAutoMirrorImage = true;
            this.NextItemNavig.Size = new System.Drawing.Size(23, 22);
            this.NextItemNavig.Text = "Переместить вперед";
            this.NextItemNavig.Click += new System.EventHandler(this.NextItemNavig_Click);
            // 
            // LastItemNavig
            // 
            this.LastItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("LastItemNavig.Image")));
            this.LastItemNavig.Name = "LastItemNavig";
            this.LastItemNavig.RightToLeftAutoMirrorImage = true;
            this.LastItemNavig.Size = new System.Drawing.Size(23, 22);
            this.LastItemNavig.Text = "Переместить в конец";
            this.LastItemNavig.Click += new System.EventHandler(this.LastItemNavig_Click);
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // disease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(714, 565);
            this.Controls.Add(this.datatableDisease);
            this.Controls.Add(this.diseaseBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "disease";
            this.Text = "Таблица заболеваний";
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingNavigator)).EndInit();
            this.diseaseBindingNavigator.ResumeLayout(false);
            this.diseaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.BindingNavigator diseaseBindingNavigator;
        private System.Windows.Forms.ToolStripButton AddItemNavig;
        private System.Windows.Forms.ToolStripButton DeleteItemNavig;
        private System.Windows.Forms.ToolStripButton FirstItemNavig;
        private System.Windows.Forms.ToolStripButton PrevItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NextItemNavig;
        private System.Windows.Forms.ToolStripButton LastItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource diseaseBindingSource;
        private System.Windows.Forms.DataGridView datatableDisease;
        private System.Windows.Forms.DataGridViewTextBoxColumn CipDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn InDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfP;
        private System.Windows.Forms.ToolStripButton refreshBindingNavigator;
    }
}