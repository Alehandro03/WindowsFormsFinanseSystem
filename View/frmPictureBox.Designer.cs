
namespace WindowsFormsFinanseSystem
{
    partial class frmPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPictureBox6 = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbPictureBox2 = new System.Windows.Forms.RadioButton();
            this.rbPictureBox3 = new System.Windows.Forms.RadioButton();
            this.rbPictureBox4 = new System.Windows.Forms.RadioButton();
            this.rbPictureBox5 = new System.Windows.Forms.RadioButton();
            this.rbPictureBox1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPictureBox6);
            this.groupBox1.Controls.Add(this.rbPictureBox2);
            this.groupBox1.Controls.Add(this.rbPictureBox3);
            this.groupBox1.Controls.Add(this.rbPictureBox4);
            this.groupBox1.Controls.Add(this.rbPictureBox5);
            this.groupBox1.Controls.Add(this.rbPictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(260, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Выберите значок";
            // 
            // rbPictureBox6
            // 
            this.rbPictureBox6.AutoSize = true;
            this.rbPictureBox6.ImageIndex = 3;
            this.rbPictureBox6.ImageList = this.imageList1;
            this.rbPictureBox6.Location = new System.Drawing.Point(9, 158);
            this.rbPictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPictureBox6.Name = "rbPictureBox6";
            this.rbPictureBox6.Size = new System.Drawing.Size(51, 30);
            this.rbPictureBox6.TabIndex = 13;
            this.rbPictureBox6.TabStop = true;
            this.rbPictureBox6.UseVisualStyleBackColor = true;
            this.rbPictureBox6.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bank.png");
            this.imageList1.Images.SetKeyName(1, "CardMasterCard.png");
            this.imageList1.Images.SetKeyName(2, "CardVisa.png");
            this.imageList1.Images.SetKeyName(3, "Заначка.png");
            this.imageList1.Images.SetKeyName(4, "кошель30.png");
            this.imageList1.Images.SetKeyName(5, "кошелек женский30.png");
            // 
            // rbPictureBox2
            // 
            this.rbPictureBox2.AutoSize = true;
            this.rbPictureBox2.ImageIndex = 1;
            this.rbPictureBox2.ImageList = this.imageList1;
            this.rbPictureBox2.Location = new System.Drawing.Point(9, 71);
            this.rbPictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPictureBox2.Name = "rbPictureBox2";
            this.rbPictureBox2.Size = new System.Drawing.Size(51, 30);
            this.rbPictureBox2.TabIndex = 12;
            this.rbPictureBox2.TabStop = true;
            this.rbPictureBox2.UseVisualStyleBackColor = true;
            // 
            // rbPictureBox3
            // 
            this.rbPictureBox3.AutoSize = true;
            this.rbPictureBox3.ImageIndex = 2;
            this.rbPictureBox3.ImageList = this.imageList1;
            this.rbPictureBox3.Location = new System.Drawing.Point(9, 112);
            this.rbPictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPictureBox3.Name = "rbPictureBox3";
            this.rbPictureBox3.Size = new System.Drawing.Size(51, 30);
            this.rbPictureBox3.TabIndex = 11;
            this.rbPictureBox3.TabStop = true;
            this.rbPictureBox3.UseVisualStyleBackColor = true;
            this.rbPictureBox3.CheckedChanged += new System.EventHandler(this.rbPictureBox3_CheckedChanged);
            // 
            // rbPictureBox4
            // 
            this.rbPictureBox4.AutoSize = true;
            this.rbPictureBox4.ImageIndex = 4;
            this.rbPictureBox4.ImageList = this.imageList1;
            this.rbPictureBox4.Location = new System.Drawing.Point(9, 200);
            this.rbPictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPictureBox4.Name = "rbPictureBox4";
            this.rbPictureBox4.Size = new System.Drawing.Size(51, 30);
            this.rbPictureBox4.TabIndex = 10;
            this.rbPictureBox4.TabStop = true;
            this.rbPictureBox4.UseVisualStyleBackColor = true;
            // 
            // rbPictureBox5
            // 
            this.rbPictureBox5.AutoSize = true;
            this.rbPictureBox5.ImageIndex = 5;
            this.rbPictureBox5.ImageList = this.imageList1;
            this.rbPictureBox5.Location = new System.Drawing.Point(9, 237);
            this.rbPictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPictureBox5.Name = "rbPictureBox5";
            this.rbPictureBox5.Size = new System.Drawing.Size(51, 30);
            this.rbPictureBox5.TabIndex = 9;
            this.rbPictureBox5.TabStop = true;
            this.rbPictureBox5.UseVisualStyleBackColor = true;
            // 
            // rbPictureBox1
            // 
            this.rbPictureBox1.AutoSize = true;
            this.rbPictureBox1.ImageIndex = 0;
            this.rbPictureBox1.ImageList = this.imageList1;
            this.rbPictureBox1.Location = new System.Drawing.Point(9, 29);
            this.rbPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPictureBox1.Name = "rbPictureBox1";
            this.rbPictureBox1.Size = new System.Drawing.Size(51, 30);
            this.rbPictureBox1.TabIndex = 8;
            this.rbPictureBox1.TabStop = true;
            this.rbPictureBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 314);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(312, 418);
            this.MinimumSize = new System.Drawing.Size(312, 418);
            this.Name = "frmPictureBox";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbPictureBox2;
        private System.Windows.Forms.RadioButton rbPictureBox3;
        private System.Windows.Forms.RadioButton rbPictureBox4;
        private System.Windows.Forms.RadioButton rbPictureBox5;
        private System.Windows.Forms.RadioButton rbPictureBox1;
        private System.Windows.Forms.RadioButton rbPictureBox6;
    }
}