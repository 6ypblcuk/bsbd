namespace Kursach
{
    partial class drug_composition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drug_composition));
            this.Name_pills = new System.Windows.Forms.Label();
            this.drugsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.compTB = new System.Windows.Forms.TextBox();
            this.SaveItemNavig = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingNavigator)).BeginInit();
            this.drugsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_pills
            // 
            this.Name_pills.AutoSize = true;
            this.Name_pills.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_pills.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_pills.Location = new System.Drawing.Point(114, 54);
            this.Name_pills.Name = "Name_pills";
            this.Name_pills.Size = new System.Drawing.Size(98, 54);
            this.Name_pills.TabIndex = 5;
            this.Name_pills.Text = "Состав";
            // 
            // drugsBindingNavigator
            // 
            this.drugsBindingNavigator.AddNewItem = null;
            this.drugsBindingNavigator.CountItem = null;
            this.drugsBindingNavigator.DeleteItem = null;
            this.drugsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveItemNavig});
            this.drugsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.drugsBindingNavigator.MoveFirstItem = null;
            this.drugsBindingNavigator.MoveLastItem = null;
            this.drugsBindingNavigator.MoveNextItem = null;
            this.drugsBindingNavigator.MovePreviousItem = null;
            this.drugsBindingNavigator.Name = "drugsBindingNavigator";
            this.drugsBindingNavigator.PositionItem = null;
            this.drugsBindingNavigator.Size = new System.Drawing.Size(615, 25);
            this.drugsBindingNavigator.TabIndex = 7;
            this.drugsBindingNavigator.Text = "bindingNavigator1";
            // 
            // compTB
            // 
            this.compTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compTB.Location = new System.Drawing.Point(9, 125);
            this.compTB.Multiline = true;
            this.compTB.Name = "compTB";
            this.compTB.Size = new System.Drawing.Size(594, 186);
            this.compTB.TabIndex = 8;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(9, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(615, 342);
            this.Controls.Add(this.compTB);
            this.Controls.Add(this.drugsBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "composition";
            this.Text = "Состав препарата";
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingNavigator)).EndInit();
            this.drugsBindingNavigator.ResumeLayout(false);
            this.drugsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.BindingNavigator drugsBindingNavigator;
        private System.Windows.Forms.ToolStripButton SaveItemNavig;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private System.Windows.Forms.TextBox compTB;
    }
}