
namespace WindowsFormsFinanseSystem
{
    partial class frmAddBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBills));
            this.gbAddBills = new System.Windows.Forms.GroupBox();
            this.lblImageBills = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbAddBillsComment = new System.Windows.Forms.RichTextBox();
            this.lbAddBillsComment = new System.Windows.Forms.Label();
            this.lbAddBillsBalance = new System.Windows.Forms.Label();
            this.dudCurrency = new System.Windows.Forms.DomainUpDown();
            this.txtbNameAddBills = new System.Windows.Forms.TextBox();
            this.lbAddBillsCurrency = new System.Windows.Forms.Label();
            this.dudAddBillsGroup = new System.Windows.Forms.DomainUpDown();
            this.lblAddBillsgroup = new System.Windows.Forms.Label();
            this.lblAddBillsName = new System.Windows.Forms.Label();
            this.pbAddBills = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddBillsOK = new System.Windows.Forms.Button();
            this.btnAddBillsCancel = new System.Windows.Forms.Button();
            this.numupdAddBills = new System.Windows.Forms.NumericUpDown();
            this.gbAddBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdAddBills)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddBills
            // 
            this.gbAddBills.Controls.Add(this.numupdAddBills);
            this.gbAddBills.Controls.Add(this.lblImageBills);
            this.gbAddBills.Controls.Add(this.button2);
            this.gbAddBills.Controls.Add(this.rtbAddBillsComment);
            this.gbAddBills.Controls.Add(this.lbAddBillsComment);
            this.gbAddBills.Controls.Add(this.lbAddBillsBalance);
            this.gbAddBills.Controls.Add(this.dudCurrency);
            this.gbAddBills.Controls.Add(this.txtbNameAddBills);
            this.gbAddBills.Controls.Add(this.lbAddBillsCurrency);
            this.gbAddBills.Controls.Add(this.dudAddBillsGroup);
            this.gbAddBills.Controls.Add(this.lblAddBillsgroup);
            this.gbAddBills.Controls.Add(this.lblAddBillsName);
            this.gbAddBills.Controls.Add(this.pbAddBills);
            this.gbAddBills.Location = new System.Drawing.Point(2, 2);
            this.gbAddBills.Name = "gbAddBills";
            this.gbAddBills.Size = new System.Drawing.Size(362, 351);
            this.gbAddBills.TabIndex = 0;
            this.gbAddBills.TabStop = false;
            this.gbAddBills.Enter += new System.EventHandler(this.gbAddBills_Enter);
            // 
            // lblImageBills
            // 
            this.lblImageBills.AutoSize = true;
            this.lblImageBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImageBills.Location = new System.Drawing.Point(11, 83);
            this.lblImageBills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageBills.Name = "lblImageBills";
            this.lblImageBills.Size = new System.Drawing.Size(52, 17);
            this.lblImageBills.TabIndex = 13;
            this.lblImageBills.Text = "Значок";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::WindowsFormsFinanseSystem.Properties.Resources.калькулятор;
            this.button2.Location = new System.Drawing.Point(297, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 34);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbAddBillsComment
            // 
            this.rtbAddBillsComment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAddBillsComment.Location = new System.Drawing.Point(14, 241);
            this.rtbAddBillsComment.Name = "rtbAddBillsComment";
            this.rtbAddBillsComment.Size = new System.Drawing.Size(324, 96);
            this.rtbAddBillsComment.TabIndex = 10;
            this.rtbAddBillsComment.Text = "";
            // 
            // lbAddBillsComment
            // 
            this.lbAddBillsComment.AutoSize = true;
            this.lbAddBillsComment.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddBillsComment.Location = new System.Drawing.Point(10, 218);
            this.lbAddBillsComment.Name = "lbAddBillsComment";
            this.lbAddBillsComment.Size = new System.Drawing.Size(107, 20);
            this.lbAddBillsComment.TabIndex = 9;
            this.lbAddBillsComment.Text = "Комментарий";
            // 
            // lbAddBillsBalance
            // 
            this.lbAddBillsBalance.AutoSize = true;
            this.lbAddBillsBalance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddBillsBalance.Location = new System.Drawing.Point(86, 160);
            this.lbAddBillsBalance.Name = "lbAddBillsBalance";
            this.lbAddBillsBalance.Size = new System.Drawing.Size(143, 20);
            this.lbAddBillsBalance.TabIndex = 7;
            this.lbAddBillsBalance.Text = "Начальный баланс";
            // 
            // dudCurrency
            // 
            this.dudCurrency.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dudCurrency.Items.Add("Рубли");
            this.dudCurrency.Items.Add("Евро");
            this.dudCurrency.Items.Add("Доллар");
            this.dudCurrency.Location = new System.Drawing.Point(90, 133);
            this.dudCurrency.Name = "dudCurrency";
            this.dudCurrency.Size = new System.Drawing.Size(248, 24);
            this.dudCurrency.TabIndex = 6;
            this.dudCurrency.Text = "Рубли";
            this.dudCurrency.SelectedItemChanged += new System.EventHandler(this.dudCurrency_SelectedItemChanged);
            // 
            // txtbNameAddBills
            // 
            this.txtbNameAddBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbNameAddBills.Location = new System.Drawing.Point(90, 33);
            this.txtbNameAddBills.Multiline = true;
            this.txtbNameAddBills.Name = "txtbNameAddBills";
            this.txtbNameAddBills.Size = new System.Drawing.Size(248, 24);
            this.txtbNameAddBills.TabIndex = 1;
            // 
            // lbAddBillsCurrency
            // 
            this.lbAddBillsCurrency.AutoSize = true;
            this.lbAddBillsCurrency.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddBillsCurrency.Location = new System.Drawing.Point(86, 110);
            this.lbAddBillsCurrency.Name = "lbAddBillsCurrency";
            this.lbAddBillsCurrency.Size = new System.Drawing.Size(60, 20);
            this.lbAddBillsCurrency.TabIndex = 5;
            this.lbAddBillsCurrency.Text = "Валюта";
            this.lbAddBillsCurrency.Click += new System.EventHandler(this.lbAddBillsCurrency_Click);
            // 
            // dudAddBillsGroup
            // 
            this.dudAddBillsGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dudAddBillsGroup.Items.Add("Наличные");
            this.dudAddBillsGroup.Items.Add("Карты");
            this.dudAddBillsGroup.Items.Add("Банк");
            this.dudAddBillsGroup.Location = new System.Drawing.Point(90, 83);
            this.dudAddBillsGroup.Name = "dudAddBillsGroup";
            this.dudAddBillsGroup.Size = new System.Drawing.Size(248, 24);
            this.dudAddBillsGroup.TabIndex = 4;
            this.dudAddBillsGroup.Text = "Наличные";
            this.dudAddBillsGroup.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // lblAddBillsgroup
            // 
            this.lblAddBillsgroup.AutoSize = true;
            this.lblAddBillsgroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddBillsgroup.Location = new System.Drawing.Point(86, 60);
            this.lblAddBillsgroup.Name = "lblAddBillsgroup";
            this.lblAddBillsgroup.Size = new System.Drawing.Size(58, 20);
            this.lblAddBillsgroup.TabIndex = 3;
            this.lblAddBillsgroup.Text = "Группа";
            // 
            // lblAddBillsName
            // 
            this.lblAddBillsName.AutoSize = true;
            this.lblAddBillsName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddBillsName.Location = new System.Drawing.Point(86, 10);
            this.lblAddBillsName.Name = "lblAddBillsName";
            this.lblAddBillsName.Size = new System.Drawing.Size(77, 20);
            this.lblAddBillsName.TabIndex = 2;
            this.lblAddBillsName.Text = "Название";
            this.lblAddBillsName.Click += new System.EventHandler(this.lblAddBills_Click);
            // 
            // pbAddBills
            // 
            this.pbAddBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAddBills.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Счета70;
            this.pbAddBills.Location = new System.Drawing.Point(6, 10);
            this.pbAddBills.Name = "pbAddBills";
            this.pbAddBills.Size = new System.Drawing.Size(74, 74);
            this.pbAddBills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAddBills.TabIndex = 0;
            this.pbAddBills.TabStop = false;
            this.pbAddBills.UseWaitCursor = true;
            this.pbAddBills.Click += new System.EventHandler(this.pbAddBills_Click);
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
            // btnAddBillsOK
            // 
            this.btnAddBillsOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBillsOK.Location = new System.Drawing.Point(16, 359);
            this.btnAddBillsOK.Name = "btnAddBillsOK";
            this.btnAddBillsOK.Size = new System.Drawing.Size(103, 31);
            this.btnAddBillsOK.TabIndex = 11;
            this.btnAddBillsOK.Text = "ОК";
            this.btnAddBillsOK.UseVisualStyleBackColor = true;
            this.btnAddBillsOK.Click += new System.EventHandler(this.btnAddBillsOK_Click);
            // 
            // btnAddBillsCancel
            // 
            this.btnAddBillsCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBillsCancel.Location = new System.Drawing.Point(237, 359);
            this.btnAddBillsCancel.Name = "btnAddBillsCancel";
            this.btnAddBillsCancel.Size = new System.Drawing.Size(103, 31);
            this.btnAddBillsCancel.TabIndex = 12;
            this.btnAddBillsCancel.Text = "Отмена";
            this.btnAddBillsCancel.UseVisualStyleBackColor = true;
            this.btnAddBillsCancel.Click += new System.EventHandler(this.btnAddBillsCancel_Click);
            // 
            // numupdAddBills
            // 
            this.numupdAddBills.DecimalPlaces = 2;
            this.numupdAddBills.Location = new System.Drawing.Point(90, 195);
            this.numupdAddBills.Name = "numupdAddBills";
            this.numupdAddBills.Size = new System.Drawing.Size(201, 20);
            this.numupdAddBills.TabIndex = 14;
            // 
            // frmAddBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 401);
            this.Controls.Add(this.btnAddBillsOK);
            this.Controls.Add(this.btnAddBillsCancel);
            this.Controls.Add(this.gbAddBills);
            this.Name = "frmAddBills";
            this.Text = "Счет";
            this.Load += new System.EventHandler(this.frmAddBills_Load);
            this.gbAddBills.ResumeLayout(false);
            this.gbAddBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdAddBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddBills;
        private System.Windows.Forms.PictureBox pbAddBills;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblAddBillsName;
        private System.Windows.Forms.TextBox txtbNameAddBills;
        private System.Windows.Forms.Label lblAddBillsgroup;
        private System.Windows.Forms.DomainUpDown dudAddBillsGroup;
        private System.Windows.Forms.DomainUpDown dudCurrency;
        private System.Windows.Forms.Label lbAddBillsCurrency;
        private System.Windows.Forms.Label lbAddBillsBalance;
        private System.Windows.Forms.RichTextBox rtbAddBillsComment;
        private System.Windows.Forms.Label lbAddBillsComment;
        private System.Windows.Forms.Button btnAddBillsOK;
        private System.Windows.Forms.Button btnAddBillsCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblImageBills;
        private System.Windows.Forms.NumericUpDown numupdAddBills;
    }
}