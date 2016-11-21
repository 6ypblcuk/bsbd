namespace Kursach
{
    partial class order_drugs_for_empl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_drugs_for_empl));
            this.order_firmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderContentB = new System.Windows.Forms.Button();
            this.datatableOrder = new System.Windows.Forms.DataGridView();
            this.NOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_pills = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FirstItemNavig = new System.Windows.Forms.ToolStripButton();
            this.PrevItemNavig = new System.Windows.Forms.ToolStripButton();
            this.NextItemNavig = new System.Windows.Forms.ToolStripButton();
            this.LastItemNavig = new System.Windows.Forms.ToolStripButton();
            this.SaveItemNavig = new System.Windows.Forms.ToolStripButton();
            this.refreshBindingNavigator = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.order_firmBindingNavigator)).BeginInit();
            this.order_firmBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // order_firmBindingNavigator
            // 
            this.order_firmBindingNavigator.AddNewItem = null;
            this.order_firmBindingNavigator.CountItem = null;
            this.order_firmBindingNavigator.DeleteItem = null;
            this.order_firmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstItemNavig,
            this.PrevItemNavig,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.NextItemNavig,
            this.LastItemNavig,
            this.bindingNavigatorSeparator2,
            this.SaveItemNavig,
            this.refreshBindingNavigator});
            this.order_firmBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_firmBindingNavigator.MoveFirstItem = this.FirstItemNavig;
            this.order_firmBindingNavigator.MoveLastItem = this.LastItemNavig;
            this.order_firmBindingNavigator.MoveNextItem = this.NextItemNavig;
            this.order_firmBindingNavigator.MovePreviousItem = this.PrevItemNavig;
            this.order_firmBindingNavigator.Name = "order_firmBindingNavigator";
            this.order_firmBindingNavigator.PositionItem = null;
            this.order_firmBindingNavigator.Size = new System.Drawing.Size(769, 25);
            this.order_firmBindingNavigator.TabIndex = 13;
            this.order_firmBindingNavigator.Text = "bindingNavigator1";
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
            // OrderContentB
            // 
            this.OrderContentB.Location = new System.Drawing.Point(9, 364);
            this.OrderContentB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderContentB.Name = "OrderContentB";
            this.OrderContentB.Size = new System.Drawing.Size(233, 40);
            this.OrderContentB.TabIndex = 17;
            this.OrderContentB.Text = "Содержимое заказа";
            this.OrderContentB.UseVisualStyleBackColor = true;
            this.OrderContentB.Click += new System.EventHandler(this.OrderContentB_Click);
            // 
            // datatableOrder
            // 
            this.datatableOrder.AllowUserToAddRows = false;
            this.datatableOrder.AllowUserToDeleteRows = false;
            this.datatableOrder.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.datatableOrder.ColumnHeadersHeight = 40;
            this.datatableOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOrder,
            this.ФИО,
            this.date,
            this.TotalSumm,
            this.status});
            this.datatableOrder.Location = new System.Drawing.Point(9, 126);
            this.datatableOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datatableOrder.Name = "datatableOrder";
            this.datatableOrder.Size = new System.Drawing.Size(748, 234);
            this.datatableOrder.TabIndex = 16;
            // 
            // NOrder
            // 
            this.NOrder.DataPropertyName = "id_order";
            this.NOrder.HeaderText = "NЗаказа";
            this.NOrder.Name = "NOrder";
            this.NOrder.ReadOnly = true;
            this.NOrder.Width = 80;
            // 
            // ФИО
            // 
            this.ФИО.DataPropertyName = "fullname";
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            this.ФИО.Width = 230;
            // 
            // date
            // 
            this.date.DataPropertyName = "date_order";
            this.date.HeaderText = "Дата заказа";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 140;
            // 
            // TotalSumm
            // 
            this.TotalSumm.DataPropertyName = "summ";
            this.TotalSumm.HeaderText = "Сумма заказа";
            this.TotalSumm.Name = "TotalSumm";
            this.TotalSumm.ReadOnly = true;
            this.TotalSumm.Width = 140;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.Width = 115;
            // 
            // Name_pills
            // 
            this.Name_pills.AutoSize = true;
            this.Name_pills.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_pills.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_pills.Location = new System.Drawing.Point(114, 54);
            this.Name_pills.Name = "Name_pills";
            this.Name_pills.Size = new System.Drawing.Size(94, 54);
            this.Name_pills.TabIndex = 14;
            this.Name_pills.Text = "Заказы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(9, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            // SaveItemNavig
            // 
            this.SaveItemNavig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveItemNavig.Image = ((System.Drawing.Image)(resources.GetObject("SaveItemNavig.Image")));
            this.SaveItemNavig.Name = "SaveItemNavig";
            this.SaveItemNavig.Size = new System.Drawing.Size(23, 22);
            this.SaveItemNavig.Text = "Сохранить";
            this.SaveItemNavig.Click += new System.EventHandler(this.order_contentBindingNavigatorSaveItem_Click);
            // 
            // refreshBindingNavigator
            // 
            this.refreshBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBindingNavigator.Image = global::Kursach.Properties.Resources.refresh;
            this.refreshBindingNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBindingNavigator.Name = "refreshBindingNavigator";
            this.refreshBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.refreshBindingNavigator.Text = "&Обновить";
            this.refreshBindingNavigator.Click += new System.EventHandler(this.refreshBindingNavigator_Click);
            // 
            // order_drugs_for_empl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(769, 439);
            this.Controls.Add(this.OrderContentB);
            this.Controls.Add(this.datatableOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Controls.Add(this.order_firmBindingNavigator);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "order_drugs_for_empl";
            this.Text = "Заказы пользователей";
            ((System.ComponentModel.ISupportInitialize)(this.order_firmBindingNavigator)).EndInit();
            this.order_firmBindingNavigator.ResumeLayout(false);
            this.order_firmBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator order_firmBindingNavigator;
        private System.Windows.Forms.ToolStripButton FirstItemNavig;
        private System.Windows.Forms.ToolStripButton PrevItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NextItemNavig;
        private System.Windows.Forms.ToolStripButton LastItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton SaveItemNavig;
        private System.Windows.Forms.Button OrderContentB;
        private System.Windows.Forms.DataGridView datatableOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ToolStripButton refreshBindingNavigator;
    }
}