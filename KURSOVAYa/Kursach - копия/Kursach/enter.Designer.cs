namespace Kursach
{
    partial class enter
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
            this.Name_pills = new System.Windows.Forms.Label();
            this.enterB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.registB = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_pills
            // 
            this.Name_pills.AutoSize = true;
            this.Name_pills.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_pills.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_pills.Location = new System.Drawing.Point(123, 43);
            this.Name_pills.Name = "Name_pills";
            this.Name_pills.Size = new System.Drawing.Size(214, 54);
            this.Name_pills.TabIndex = 5;
            this.Name_pills.Text = "Домашняя Аптека";
            // 
            // enterB
            // 
            this.enterB.Location = new System.Drawing.Point(92, 267);
            this.enterB.Name = "enterB";
            this.enterB.Size = new System.Drawing.Size(178, 37);
            this.enterB.TabIndex = 7;
            this.enterB.Text = "Вход";
            this.enterB.UseVisualStyleBackColor = true;
            this.enterB.Click += new System.EventHandler(this.enterB_Click);
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(92, 353);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(178, 36);
            this.exitB.TabIndex = 8;
            this.exitB.Text = "Выход";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите пароль:";
            // 
            // passTB
            // 
            this.passTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTB.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTB.Location = new System.Drawing.Point(92, 228);
            this.passTB.Multiline = true;
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(178, 33);
            this.passTB.TabIndex = 1;
            // 
            // registB
            // 
            this.registB.Location = new System.Drawing.Point(92, 310);
            this.registB.Name = "registB";
            this.registB.Size = new System.Drawing.Size(178, 37);
            this.registB.TabIndex = 13;
            this.registB.Text = "Регистрация";
            this.registB.UseVisualStyleBackColor = true;
            this.registB.Click += new System.EventHandler(this.registB_Click);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTB.Location = new System.Drawing.Point(92, 148);
            this.emailTB.Multiline = true;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(178, 33);
            this.emailTB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 107);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(386, 432);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.enterB);
            this.Controls.Add(this.Name_pills);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "enter";
            this.Text = "Вход ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.enter_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_pills;
        private System.Windows.Forms.Button enterB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button registB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailTB;
    }
}