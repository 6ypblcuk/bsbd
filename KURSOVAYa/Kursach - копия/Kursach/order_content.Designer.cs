namespace Kursach
{
    partial class order_content
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_content));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Name_drug = new System.Windows.Forms.Label();
            this.order_contentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.FirstItemNavig = new System.Windows.Forms.ToolStripButton();
            this.PrevItemNavig = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NextItemNavig = new System.Windows.Forms.ToolStripButton();
            this.LastItemNavig = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.datatableOrderContent = new System.Windows.Forms.DataGridView();
            this.NDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderFirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.order_contentBindingNavigator)).BeginInit();
            this.order_contentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableOrderContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_drug
            // 
            this.Name_drug.AutoSize = true;
            this.Name_drug.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_drug.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_drug.Location = new System.Drawing.Point(114, 54);
            this.Name_drug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_drug.Name = "Name_drug";
            this.Name_drug.Size = new System.Drawing.Size(218, 54);
            this.Name_drug.TabIndex = 5;
            this.Name_drug.Text = "Содержимое заказа";
            // 
            // order_contentBindingNavigator
            // 
            this.order_contentBindingNavigator.AddNewItem = null;
            this.order_contentBindingNavigator.CountItem = null;
            this.order_contentBindingNavigator.DeleteItem = null;
            this.order_contentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstItemNavig,
            this.PrevItemNavig,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.NextItemNavig,
            this.LastItemNavig,
            this.bindingNavigatorSeparator2,
            this.refreshBindingNavigator});
            this.order_contentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_contentBindingNavigator.MoveFirstItem = this.FirstItemNavig;
            this.order_contentBindingNavigator.MoveLastItem = this.LastItemNavig;
            this.order_contentBindingNavigator.MoveNextItem = this.NextItemNavig;
            this.order_contentBindingNavigator.MovePreviousItem = this.PrevItemNavig;
            this.order_contentBindingNavigator.Name = "order_contentBindingNavigator";
            this.order_contentBindingNavigator.PositionItem = null;
            this.order_contentBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.order_contentBindingNavigator.TabIndex = 7;
            this.order_contentBindingNavigator.Text = "bindingNavigator1";
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
            this.LastItemNavig.Click += new System.EventHandler(this.LastItem_Click);
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
            // datatableOrderContent
            // 
            this.datatableOrderContent.AllowUserToAddRows = false;
            this.datatableOrderContent.AllowUserToDeleteRows = false;
            this.datatableOrderContent.AutoGenerateColumns = false;
            this.datatableOrderContent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datatableOrderContent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datatableOrderContent.ColumnHeadersHeight = 40;
            this.datatableOrderContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NDr,
            this.NumberOr,
            this.Summ,
            this.OrderFirm,
            this.Drug});
            this.datatableOrderContent.DataSource = this.order_contentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datatableOrderContent.DefaultCellStyle = dataGridViewCellStyle2;
            this.datatableOrderContent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datatableOrderContent.Location = new System.Drawing.Point(9, 144);
            this.datatableOrderContent.Name = "datatableOrderContent";
            this.datatableOrderContent.Size = new System.Drawing.Size(840, 314);
            this.datatableOrderContent.TabIndex = 8;
            // 
            // NDr
            // 
            this.NDr.DataPropertyName = "id_drug";
            this.NDr.HeaderText = "NПрепарата";
            this.NDr.Name = "NDr";
            // 
            // NumberOr
            // 
            this.NumberOr.DataPropertyName = "counts";
            this.NumberOr.HeaderText = "Количество";
            this.NumberOr.Name = "NumberOr";
            this.NumberOr.Width = 115;
            // 
            // Summ
            // 
            this.Summ.DataPropertyName = "summ";
            this.Summ.HeaderText = "К оплате";
            this.Summ.Name = "Summ";
            this.Summ.Width = 140;
            // 
            // OrderFirm
            // 
            this.OrderFirm.DataPropertyName = "name_firm";
            this.OrderFirm.HeaderText = "Фирма";
            this.OrderFirm.Name = "OrderFirm";
            this.OrderFirm.Width = 170;
            // 
            // Drug
            // 
            this.Drug.DataPropertyName = "name_drug";
            this.Drug.HeaderText = "Препарат";
            this.Drug.Name = "Drug";
            this.Drug.Width = 270;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(9, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 94);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // order_content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(856, 472);
            this.Controls.Add(this.datatableOrderContent);
            this.Controls.Add(this.order_contentBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_drug);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "order_content";
            this.Text = "Содержимое заказа";
            ((System.ComponentModel.ISupportInitialize)(this.order_contentBindingNavigator)).EndInit();
            this.order_contentBindingNavigator.ResumeLayout(false);
            this.order_contentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatableOrderContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_drug;
        private System.Windows.Forms.BindingNavigator order_contentBindingNavigator;
        private System.Windows.Forms.ToolStripButton FirstItemNavig;
        private System.Windows.Forms.ToolStripButton PrevItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NextItemNavig;
        private System.Windows.Forms.ToolStripButton LastItemNavig;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource order_contentBindingSource;
        private System.Windows.Forms.DataGridView datatableOrderContent;
        private System.Windows.Forms.ToolStripButton refreshBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drug;
    }
}