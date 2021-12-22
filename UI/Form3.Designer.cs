
namespace WindowsFormsFinanseSystem
{
    partial class frmAdd
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblUserComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.btnUserOK = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbUser.Controls.Add(this.richTextBox1);
            this.gbUser.Controls.Add(this.lblUserComment);
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Controls.Add(this.txtName);
            this.gbUser.Controls.Add(this.lblImage);
            this.gbUser.Controls.Add(this.picboxImage);
            this.gbUser.Location = new System.Drawing.Point(2, 1);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(320, 209);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(99, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 69);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // lblUserComment
            // 
            this.lblUserComment.AutoSize = true;
            this.lblUserComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserComment.Location = new System.Drawing.Point(96, 88);
            this.lblUserComment.Name = "lblUserComment";
            this.lblUserComment.Size = new System.Drawing.Size(98, 17);
            this.lblUserComment.TabIndex = 14;
            this.lblUserComment.Text = "Комментарий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Имя";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(99, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 24);
            this.txtName.TabIndex = 12;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImage.Location = new System.Drawing.Point(20, 69);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(56, 17);
            this.lblImage.TabIndex = 11;
            this.lblImage.Text = "Значок";
            // 
            // picboxImage
            // 
            this.picboxImage.Image = global::WindowsFormsFinanseSystem.Properties.Resources.рыжая70;
            this.picboxImage.Location = new System.Drawing.Point(6, 11);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(84, 55);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImage.TabIndex = 10;
            this.picboxImage.TabStop = false;
            // 
            // btnUserOK
            // 
            this.btnUserOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserOK.Location = new System.Drawing.Point(2, 216);
            this.btnUserOK.Name = "btnUserOK";
            this.btnUserOK.Size = new System.Drawing.Size(94, 33);
            this.btnUserOK.TabIndex = 1;
            this.btnUserOK.Text = "OK";
            this.btnUserOK.UseVisualStyleBackColor = true;
            this.btnUserOK.Click += new System.EventHandler(this.btnUserOK_Click);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserCancel.Location = new System.Drawing.Point(228, 216);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(94, 33);
            this.btnUserCancel.TabIndex = 2;
            this.btnUserCancel.Text = "Отмена";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 260);
            this.Controls.Add(this.btnUserCancel);
            this.Controls.Add(this.btnUserOK);
            this.Controls.Add(this.gbUser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(342, 299);
            this.Name = "frmAdd";
            this.Text = "Пользователь";
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblUserComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Button btnUserOK;
        private System.Windows.Forms.Button btnUserCancel;
    }
}