namespace Kursach
{
    partial class add_disease
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_disTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drugsTB = new System.Windows.Forms.TextBox();
            this.add_dis = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.id_disTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добавить заболевание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название заболевания:";
            // 
            // name_disTB
            // 
            this.name_disTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_disTB.Location = new System.Drawing.Point(217, 151);
            this.name_disTB.Name = "name_disTB";
            this.name_disTB.Size = new System.Drawing.Size(259, 29);
            this.name_disTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Таблетки от заболевания:";
            // 
            // drugsTB
            // 
            this.drugsTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drugsTB.Location = new System.Drawing.Point(217, 188);
            this.drugsTB.Name = "drugsTB";
            this.drugsTB.Size = new System.Drawing.Size(259, 29);
            this.drugsTB.TabIndex = 10;
            // 
            // add_dis
            // 
            this.add_dis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_dis.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_dis.Location = new System.Drawing.Point(40, 221);
            this.add_dis.Name = "add_dis";
            this.add_dis.Size = new System.Drawing.Size(134, 35);
            this.add_dis.TabIndex = 11;
            this.add_dis.Text = "Добавить";
            this.add_dis.UseVisualStyleBackColor = true;
            this.add_dis.Click += new System.EventHandler(this.add_dis_Click);
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(342, 225);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 35);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "Шифр заболевания:";
            // 
            // id_disTB
            // 
            this.id_disTB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_disTB.Location = new System.Drawing.Point(217, 114);
            this.id_disTB.Name = "id_disTB";
            this.id_disTB.Size = new System.Drawing.Size(259, 29);
            this.id_disTB.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 82);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // add_disease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(510, 274);
            this.Controls.Add(this.id_disTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add_dis);
            this.Controls.Add(this.drugsTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_disTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "add_disease";
            this.Text = "Добавить заболевание";
            this.Load += new System.EventHandler(this.add_disease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_disTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drugsTB;
        private System.Windows.Forms.Button add_dis;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_disTB;
    }
}