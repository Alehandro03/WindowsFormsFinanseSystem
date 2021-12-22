
namespace WindowsFormsFinanseSystem.UI
{
    partial class frmRegisration
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
            this.btnRegistrMain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtFIORegistr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrOK = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsersRegistr = new System.Windows.Forms.TextBox();
            this.txtPasswordRegistr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrMain
            // 
            this.btnRegistrMain.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRegistrMain.BackgroundImage = global::WindowsFormsFinanseSystem.Properties.Resources.градиент;
            this.btnRegistrMain.Enabled = false;
            this.btnRegistrMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistrMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrMain.Location = new System.Drawing.Point(-4, 0);
            this.btnRegistrMain.Name = "btnRegistrMain";
            this.btnRegistrMain.Size = new System.Drawing.Size(547, 136);
            this.btnRegistrMain.TabIndex = 1;
            this.btnRegistrMain.Text = "Регистрация";
            this.btnRegistrMain.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WindowsFormsFinanseSystem.Properties.Resources.градиент;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.txtFIORegistr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRegistrOK);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtUsersRegistr);
            this.groupBox1.Controls.Add(this.txtPasswordRegistr);
            this.groupBox1.Controls.Add(this.btnRegistrMain);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.MaximumSize = new System.Drawing.Size(543, 477);
            this.groupBox1.MinimumSize = new System.Drawing.Size(543, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(543, 477);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Snow;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Пользователи70;
            this.pictureBox3.Location = new System.Drawing.Point(13, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // txtFIORegistr
            // 
            this.txtFIORegistr.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFIORegistr.Location = new System.Drawing.Point(65, 301);
            this.txtFIORegistr.Multiline = true;
            this.txtFIORegistr.Name = "txtFIORegistr";
            this.txtFIORegistr.Size = new System.Drawing.Size(386, 43);
            this.txtFIORegistr.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введите ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(61, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Введите Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Введите Пароль";
            // 
            // btnRegistrOK
            // 
            this.btnRegistrOK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegistrOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistrOK.Location = new System.Drawing.Point(105, 358);
            this.btnRegistrOK.Name = "btnRegistrOK";
            this.btnRegistrOK.Size = new System.Drawing.Size(295, 56);
            this.btnRegistrOK.TabIndex = 18;
            this.btnRegistrOK.Text = "ОК";
            this.btnRegistrOK.UseVisualStyleBackColor = false;
            this.btnRegistrOK.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Snow;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsFinanseSystem.Properties.Resources.пользователь_с_замком;
            this.pictureBox2.Location = new System.Drawing.Point(13, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsFinanseSystem.Properties.Resources.группа;
            this.pictureBox1.Location = new System.Drawing.Point(13, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsersRegistr
            // 
            this.txtUsersRegistr.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsersRegistr.Location = new System.Drawing.Point(65, 163);
            this.txtUsersRegistr.Multiline = true;
            this.txtUsersRegistr.Name = "txtUsersRegistr";
            this.txtUsersRegistr.Size = new System.Drawing.Size(387, 43);
            this.txtUsersRegistr.TabIndex = 14;
            // 
            // txtPasswordRegistr
            // 
            this.txtPasswordRegistr.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPasswordRegistr.Location = new System.Drawing.Point(65, 228);
            this.txtPasswordRegistr.Multiline = true;
            this.txtPasswordRegistr.Name = "txtPasswordRegistr";
            this.txtPasswordRegistr.Size = new System.Drawing.Size(386, 43);
            this.txtPasswordRegistr.TabIndex = 13;
            // 
            // frmRegisration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 418);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 468);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 448);
            this.Name = "frmRegisration";
            this.Text = "Регистрация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrOK;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsersRegistr;
        private System.Windows.Forms.TextBox txtPasswordRegistr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtFIORegistr;
    }
}