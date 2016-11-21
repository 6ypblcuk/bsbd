namespace Kursach
{
    partial class order_drugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_drugs));
            this.Name_pills = new System.Windows.Forms.Label();
            this.order_firmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.order_firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteItemNavig = new System.Windows.Forms.ToolStripButton();
            this.FirstItemNavig = new System.Windows.Forms.ToolStripButton();
            this.PrevItemNavig = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NextItemNavig = new System.Windows.Forms.ToolStripButton();
            this.LastItemNavig = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.datatableOrder = new System.Windows.Forms.DataGridView();
            this.NOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderContentB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.order_firmBindingNavigator)).BeginInit();
            this.order_firmBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_firmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatableOrder)).BeginInit();
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
            this.Name_pills.Size = new System.Drawing.Size(94, 54);
            this.Name_pills.TabIndex = 5;
            this.Name_pills.Text = "Заказы";
            // 
            // order_firmBindingNavigator
            // 
            this.order_firmBindingNavigator.AddNewItem = null;
            this.order_firmBindingNavigator.BindingSource = this.order_firmBindingSource;
            this.order_firmBindingNavigator.CountItem = null;
            this.order_firmBindingNavigator.DeleteItem = this.DeleteItemNavig;
            this.order_firmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstItemNavig,
            this.PrevItemNavig,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.NextItemNavig,
            this.LastItemNavig,
            this.bindingNavigatorSeparator2,
            this.DeleteItemNavig,
            this.refreshBindingNavigator});
            this.order_firmBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_firmBindingNavigator.MoveFirstItem = this.FirstItemNavig;
            this.order_firmBindingNavigator.MoveLastItem = this.LastItemNavig;
            this.order_firmBindingNavigator.MoveNextItem = this.NextItemNavig;
            this.order_firmBindingNavigator.MovePreviousItem = this.PrevItemNavig;
            this.order_firmBindingNavigator.Name = "order_firmBindingNavigator";
            this.order_firmBindingNavigator.PositionItem = null;
            this.order_firmBindingNavigator.Size = new System.Drawing.Size(669, 25);
            this.order_firmBindingNavigator.TabIndex = 7;
            this.order_firmBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // datatableOrder
            // 
            this.datatableOrder.AllowUserToAddRows = false;
            this.datatableOrder.AllowUserToDeleteRows = false;
            this.datatableOrder.AutoGenerateColumns = false;
            this.datatableOrder.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.datatableOrder.ColumnHeadersHeight = 40;
            this.datatableOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOrder,
            this.card_number,
            this.date,
            this.TotalSumm,
            this.status});
            this.datatableOrder.DataSource = this.order_firmBindingSource;
            this.datatableOrder.Location = new System.Drawing.Point(9, 125);
            this.datatableOrder.Name = "datatableOrder";
            this.datatableOrder.Size = new System.Drawing.Size(650, 234);
            this.datatableOrder.TabIndex = 8;
            // 
            // NOrder
            // 
            this.NOrder.DataPropertyName = "id_order";
            this.NOrder.HeaderText = "NЗаказа";
            this.NOrder.Name = "NOrder";
            this.NOrder.ReadOnly = true;
            // 
            // card_number
            // 
            this.card_number.DataPropertyName = "card";
            this.card_number.HeaderText = "Номер карты";
            this.card_number.Name = "card_number";
            this.card_number.ReadOnly = true;
            this.card_number.Width = 145;
            // 
            // date
            // 
            this.date.DataPropertyName = "date_order";
            this.date.HeaderText = "Дата заказа";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 120;
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
            this.status.ReadOnly = true;
            // 
            // OrderContentB
            // 
            this.OrderContentB.Location = new System.Drawing.Point(9, 365);
            this.OrderContentB.Name = "OrderContentB";
            this.OrderContentB.Size = new System.Drawing.Size(233, 40);
            this.OrderContentB.TabIndex = 9;
            this.OrderContentB.Text = "Содержимое заказа";
            this.OrderContentB.UseVisualStyleBackColor = true;
            this.OrderContentB.Click += new System.EventHandler(this.OrderContentB_Click);
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
            // order_drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.OrderContentB);
            this.Controls.Add(this.datatableOrder);
            this.Controls.Add(this.order_firmBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "order_drugs";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.order_firmBindingNavigator)).EndInit();
            this.order_firmBindingNavigator.ResumeLayout(false);
            this.order_firmBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_firmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatableOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.BindingNavigator order_firmBindingNavigator;
        private System.Windows.Forms.ToolStripButton DeleteItemNavig;
        private System.Windows.Forms.ToolStripButton FirstItemNavig;
        private System.Windows.Forms.ToolStripButton PrevItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NextItemNavig;
        private System.Windows.Forms.ToolStripButton LastItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource order_firmBindingSource;
        private System.Windows.Forms.DataGridView datatableOrder;
        private System.Windows.Forms.Button OrderContentB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ToolStripButton refreshBindingNavigator;
    }
}