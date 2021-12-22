
namespace WindowsFormsFinanseSystem.UI
{
    partial class AddTransaction
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
            this.gbAddTransaction = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblCmb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIncome = new System.Windows.Forms.ComboBox();
            this.dudAddTrans = new System.Windows.Forms.DomainUpDown();
            this.cmbExpenes = new System.Windows.Forms.ComboBox();
            this.numUpd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAddTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddTransaction
            // 
            this.gbAddTransaction.Controls.Add(this.label7);
            this.gbAddTransaction.Controls.Add(this.label6);
            this.gbAddTransaction.Controls.Add(this.label5);
            this.gbAddTransaction.Controls.Add(this.button1);
            this.gbAddTransaction.Controls.Add(this.txtUser);
            this.gbAddTransaction.Controls.Add(this.cmbIncome);
            this.gbAddTransaction.Controls.Add(this.dudAddTrans);
            this.gbAddTransaction.Controls.Add(this.cmbExpenes);
            this.gbAddTransaction.Controls.Add(this.numUpd);
            this.gbAddTransaction.Controls.Add(this.label4);
            this.gbAddTransaction.Controls.Add(this.label3);
            this.gbAddTransaction.Controls.Add(this.txtComment);
            this.gbAddTransaction.Controls.Add(this.label2);
            this.gbAddTransaction.Controls.Add(this.label1);
            this.gbAddTransaction.Controls.Add(this.pictureBox1);
            this.gbAddTransaction.Location = new System.Drawing.Point(1, 4);
            this.gbAddTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAddTransaction.Name = "gbAddTransaction";
            this.gbAddTransaction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAddTransaction.Size = new System.Drawing.Size(783, 460);
            this.gbAddTransaction.TabIndex = 0;
            this.gbAddTransaction.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(332, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Выберите Категорию";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выберите тип транзакции";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(38, 409);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(13, 26);
            this.txtUser.TabIndex = 9;
            this.txtUser.Visible = false;
            // 
            // lblCmb
            // 
            this.lblCmb.AutoSize = true;
            this.lblCmb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCmb.Location = new System.Drawing.Point(33, 444);
            this.lblCmb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmb.Name = "lblCmb";
            this.lblCmb.Size = new System.Drawing.Size(145, 31);
            this.lblCmb.TabIndex = 13;
            this.lblCmb.Text = "Говноходы";
            this.lblCmb.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(332, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Расходы";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbIncome
            // 
            this.cmbIncome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbIncome.FormattingEnabled = true;
            this.cmbIncome.Items.AddRange(new object[] {
            "Зарплата",
            "Дивиденты",
            "Подработка",
            "Проценты"});
            this.cmbIncome.Location = new System.Drawing.Point(338, 108);
            this.cmbIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIncome.Name = "cmbIncome";
            this.cmbIncome.Size = new System.Drawing.Size(344, 39);
            this.cmbIncome.TabIndex = 11;
            this.cmbIncome.Text = "Доходы";
            this.cmbIncome.Visible = false;
            // 
            // dudAddTrans
            // 
            this.dudAddTrans.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dudAddTrans.Items.Add("Доходы");
            this.dudAddTrans.Items.Add("Расходы");
            this.dudAddTrans.Location = new System.Drawing.Point(8, 165);
            this.dudAddTrans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dudAddTrans.Name = "dudAddTrans";
            this.dudAddTrans.Size = new System.Drawing.Size(298, 38);
            this.dudAddTrans.TabIndex = 1;
            this.dudAddTrans.Text = "Доходы";
            this.dudAddTrans.SelectedItemChanged += new System.EventHandler(this.dudAddTrans_SelectedItemChanged);
            // 
            // cmbExpenes
            // 
            this.cmbExpenes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbExpenes.FormattingEnabled = true;
            this.cmbExpenes.Items.AddRange(new object[] {
            "Продукты",
            "Автомобиль",
            "Парикмахер",
            "Коммунальные услуги",
            "Маникюр/педикюр",
            "Массаж",
            "Медицина",
            "Одежда",
            "Дети",
            "Животные",
            "Путешествие",
            "Отдых",
            "Напитки",
            "Кафе",
            "Бассейн",
            "Спорт",
            "Кино",
            "др. рассходы"});
            this.cmbExpenes.Location = new System.Drawing.Point(338, 108);
            this.cmbExpenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbExpenes.Name = "cmbExpenes";
            this.cmbExpenes.Size = new System.Drawing.Size(344, 39);
            this.cmbExpenes.TabIndex = 10;
            this.cmbExpenes.Text = "Расходы";
            this.cmbExpenes.Visible = false;
            // 
            // numUpd
            // 
            this.numUpd.DecimalPlaces = 2;
            this.numUpd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpd.Location = new System.Drawing.Point(338, 197);
            this.numUpd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpd.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numUpd.Name = "numUpd";
            this.numUpd.Size = new System.Drawing.Size(344, 38);
            this.numUpd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(690, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Руб.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(332, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Комментарий";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComment.Location = new System.Drawing.Point(338, 277);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(415, 158);
            this.txtComment.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(332, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(332, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доходы";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.SandyBrown;
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(13, 474);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(195, 60);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(601, 474);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 60);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsFinanseSystem.Properties.Resources.блокнот70;
            this.pictureBox1.Location = new System.Drawing.Point(99, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(797, 558);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCmb);
            this.Controls.Add(this.gbAddTransaction);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(819, 614);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(819, 614);
            this.Name = "AddTransaction";
            this.Text = "Транзакция";
            this.gbAddTransaction.ResumeLayout(false);
            this.gbAddTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddTransaction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudAddTrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cmbIncome;
        private System.Windows.Forms.ComboBox cmbExpenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}