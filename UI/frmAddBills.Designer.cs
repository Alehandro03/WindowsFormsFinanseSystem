
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbAddBillsBalance = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbAddBillsCurrency = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAddBillsName = new System.Windows.Forms.Label();
            this.pbAddBills = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddBillsOK = new System.Windows.Forms.Button();
            this.btnAddBillsCancel = new System.Windows.Forms.Button();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numBills = new System.Windows.Forms.NumericUpDown();
            this.gbAddBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBills)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddBills
            // 
            this.gbAddBills.Controls.Add(this.numBills);
            this.gbAddBills.Controls.Add(this.comboBox2);
            this.gbAddBills.Controls.Add(this.cmbUserName);
            this.gbAddBills.Controls.Add(this.button2);
            this.gbAddBills.Controls.Add(this.lbAddBillsBalance);
            this.gbAddBills.Controls.Add(this.txtName);
            this.gbAddBills.Controls.Add(this.lbAddBillsCurrency);
            this.gbAddBills.Controls.Add(this.lblUser);
            this.gbAddBills.Controls.Add(this.lblAddBillsName);
            this.gbAddBills.Controls.Add(this.pbAddBills);
            this.gbAddBills.Location = new System.Drawing.Point(3, 3);
            this.gbAddBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAddBills.Name = "gbAddBills";
            this.gbAddBills.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAddBills.Size = new System.Drawing.Size(543, 361);
            this.gbAddBills.TabIndex = 0;
            this.gbAddBills.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::WindowsFormsFinanseSystem.Properties.Resources.калькулятор;
            this.button2.Location = new System.Drawing.Point(443, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 52);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbAddBillsBalance
            // 
            this.lbAddBillsBalance.AutoSize = true;
            this.lbAddBillsBalance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddBillsBalance.Location = new System.Drawing.Point(129, 263);
            this.lbAddBillsBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddBillsBalance.Name = "lbAddBillsBalance";
            this.lbAddBillsBalance.Size = new System.Drawing.Size(202, 27);
            this.lbAddBillsBalance.TabIndex = 7;
            this.lbAddBillsBalance.Text = "Начальный баланс";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 51);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 35);
            this.txtName.TabIndex = 1;
            // 
            // lbAddBillsCurrency
            // 
            this.lbAddBillsCurrency.AutoSize = true;
            this.lbAddBillsCurrency.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddBillsCurrency.Location = new System.Drawing.Point(129, 169);
            this.lbAddBillsCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddBillsCurrency.Name = "lbAddBillsCurrency";
            this.lbAddBillsCurrency.Size = new System.Drawing.Size(86, 27);
            this.lbAddBillsCurrency.TabIndex = 5;
            this.lbAddBillsCurrency.Text = "Валюта";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(129, 92);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(153, 27);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Пользователь";
            // 
            // lblAddBillsName
            // 
            this.lblAddBillsName.AutoSize = true;
            this.lblAddBillsName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddBillsName.Location = new System.Drawing.Point(129, 15);
            this.lblAddBillsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBillsName.Name = "lblAddBillsName";
            this.lblAddBillsName.Size = new System.Drawing.Size(108, 27);
            this.lblAddBillsName.TabIndex = 2;
            this.lblAddBillsName.Text = "Название";
            // 
            // pbAddBills
            // 
            this.pbAddBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAddBills.Image = global::WindowsFormsFinanseSystem.Properties.Resources.кошелек_иконка70;
            this.pbAddBills.Location = new System.Drawing.Point(10, 33);
            this.pbAddBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAddBills.Name = "pbAddBills";
            this.pbAddBills.Size = new System.Drawing.Size(88, 86);
            this.pbAddBills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.btnAddBillsOK.Location = new System.Drawing.Point(27, 374);
            this.btnAddBillsOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBillsOK.Name = "btnAddBillsOK";
            this.btnAddBillsOK.Size = new System.Drawing.Size(154, 48);
            this.btnAddBillsOK.TabIndex = 11;
            this.btnAddBillsOK.Text = "ОК";
            this.btnAddBillsOK.UseVisualStyleBackColor = true;
            this.btnAddBillsOK.Click += new System.EventHandler(this.btnAddBillsOK_Click);
            // 
            // btnAddBillsCancel
            // 
            this.btnAddBillsCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBillsCancel.Location = new System.Drawing.Point(369, 374);
            this.btnAddBillsCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBillsCancel.Name = "btnAddBillsCancel";
            this.btnAddBillsCancel.Size = new System.Drawing.Size(154, 48);
            this.btnAddBillsCancel.TabIndex = 12;
            this.btnAddBillsCancel.Text = "Отмена";
            this.btnAddBillsCancel.UseVisualStyleBackColor = true;
            this.btnAddBillsCancel.Click += new System.EventHandler(this.btnAddBillsCancel_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(135, 123);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(370, 35);
            this.cmbUserName.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Рубли",
            "Евро"});
            this.comboBox2.Location = new System.Drawing.Point(134, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(370, 35);
            this.comboBox2.TabIndex = 14;
            // 
            // numBills
            // 
            this.numBills.DecimalPlaces = 2;
            this.numBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBills.Location = new System.Drawing.Point(134, 293);
            this.numBills.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numBills.Name = "numBills";
            this.numBills.Size = new System.Drawing.Size(311, 33);
            this.numBills.TabIndex = 15;
            // 
            // frmAddBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 449);
            this.Controls.Add(this.btnAddBillsOK);
            this.Controls.Add(this.btnAddBillsCancel);
            this.Controls.Add(this.gbAddBills);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 505);
            this.Name = "frmAddBills";
            this.Text = "Счет";
            this.gbAddBills.ResumeLayout(false);
            this.gbAddBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddBills;
        private System.Windows.Forms.PictureBox pbAddBills;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblAddBillsName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbAddBillsCurrency;
        private System.Windows.Forms.Label lbAddBillsBalance;
        private System.Windows.Forms.Button btnAddBillsOK;
        private System.Windows.Forms.Button btnAddBillsCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numBills;
    }
}