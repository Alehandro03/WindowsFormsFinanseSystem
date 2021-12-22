
namespace WindowsFormsFinanseSystem.UI
{
    partial class frmAuthorization
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
            this.gbAuthorization = new System.Windows.Forms.GroupBox();
            this.btnAuthRegisr = new System.Windows.Forms.Button();
            this.btnAuthOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsersAuth = new System.Windows.Forms.TextBox();
            this.txtPasswordAuth = new System.Windows.Forms.TextBox();
            this.btnAuthorization = new System.Windows.Forms.Button();
            this.gbAuthorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAuthorization
            // 
            this.gbAuthorization.BackgroundImage = global::WindowsFormsFinanseSystem.Properties.Resources.градиент;
            this.gbAuthorization.Controls.Add(this.btnAuthRegisr);
            this.gbAuthorization.Controls.Add(this.btnAuthOK);
            this.gbAuthorization.Controls.Add(this.label4);
            this.gbAuthorization.Controls.Add(this.label3);
            this.gbAuthorization.Controls.Add(this.pictureBox2);
            this.gbAuthorization.Controls.Add(this.pictureBox1);
            this.gbAuthorization.Controls.Add(this.txtUsersAuth);
            this.gbAuthorization.Controls.Add(this.txtPasswordAuth);
            this.gbAuthorization.Controls.Add(this.btnAuthorization);
            this.gbAuthorization.Location = new System.Drawing.Point(-1, 1);
            this.gbAuthorization.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAuthorization.Name = "gbAuthorization";
            this.gbAuthorization.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAuthorization.Size = new System.Drawing.Size(549, 392);
            this.gbAuthorization.TabIndex = 0;
            this.gbAuthorization.TabStop = false;
            // 
            // btnAuthRegisr
            // 
            this.btnAuthRegisr.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAuthRegisr.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuthRegisr.Location = new System.Drawing.Point(301, 316);
            this.btnAuthRegisr.Name = "btnAuthRegisr";
            this.btnAuthRegisr.Size = new System.Drawing.Size(209, 56);
            this.btnAuthRegisr.TabIndex = 28;
            this.btnAuthRegisr.Text = "Зарегистрироваться";
            this.btnAuthRegisr.UseVisualStyleBackColor = false;
            this.btnAuthRegisr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthOK
            // 
            this.btnAuthOK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAuthOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuthOK.Location = new System.Drawing.Point(34, 316);
            this.btnAuthOK.Name = "btnAuthOK";
            this.btnAuthOK.Size = new System.Drawing.Size(209, 56);
            this.btnAuthOK.TabIndex = 27;
            this.btnAuthOK.Text = "ОК";
            this.btnAuthOK.UseVisualStyleBackColor = false;
            this.btnAuthOK.Click += new System.EventHandler(this.btnAuthOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Введите Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Введите Пароль";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Snow;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsFinanseSystem.Properties.Resources.пользователь_с_замком;
            this.pictureBox2.Location = new System.Drawing.Point(34, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsFinanseSystem.Properties.Resources.группа;
            this.pictureBox1.Location = new System.Drawing.Point(34, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsersAuth
            // 
            this.txtUsersAuth.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsersAuth.Location = new System.Drawing.Point(86, 148);
            this.txtUsersAuth.Multiline = true;
            this.txtUsersAuth.Name = "txtUsersAuth";
            this.txtUsersAuth.Size = new System.Drawing.Size(387, 43);
            this.txtUsersAuth.TabIndex = 22;
            // 
            // txtPasswordAuth
            // 
            this.txtPasswordAuth.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPasswordAuth.Location = new System.Drawing.Point(87, 213);
            this.txtPasswordAuth.Multiline = true;
            this.txtPasswordAuth.Name = "txtPasswordAuth";
            this.txtPasswordAuth.Size = new System.Drawing.Size(386, 43);
            this.txtPasswordAuth.TabIndex = 21;
            // 
            // btnAuthorization
            // 
            this.btnAuthorization.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAuthorization.BackgroundImage = global::WindowsFormsFinanseSystem.Properties.Resources.градиент;
            this.btnAuthorization.Enabled = false;
            this.btnAuthorization.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuthorization.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAuthorization.Location = new System.Drawing.Point(0, 0);
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.Size = new System.Drawing.Size(549, 116);
            this.btnAuthorization.TabIndex = 2;
            this.btnAuthorization.Text = "Авторизация";
            this.btnAuthorization.UseVisualStyleBackColor = false;
            // 
            // frmAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 397);
            this.Controls.Add(this.gbAuthorization);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(563, 436);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(563, 436);
            this.Name = "frmAuthorization";
            this.Text = "Авторизация";
            this.gbAuthorization.ResumeLayout(false);
            this.gbAuthorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAuthorization;
        private System.Windows.Forms.Button btnAuthorization;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsersAuth;
        private System.Windows.Forms.TextBox txtPasswordAuth;
        private System.Windows.Forms.Button btnAuthRegisr;
        private System.Windows.Forms.Button btnAuthOK;
    }
}