
namespace WindowsFormsFinanseSystem
{
    partial class frmBills
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbBills = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBillsCash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddBills = new System.Windows.Forms.Button();
            this.btnChangeBills = new System.Windows.Forms.Button();
            this.btnDeleteBills = new System.Windows.Forms.Button();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBills
            // 
            this.gbBills.Controls.Add(this.dgvBills);
            this.gbBills.Controls.Add(this.pictureBox3);
            this.gbBills.Controls.Add(this.pictureBox2);
            this.gbBills.Controls.Add(this.btnBillsCash);
            this.gbBills.Controls.Add(this.pictureBox1);
            this.gbBills.Location = new System.Drawing.Point(3, 3);
            this.gbBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBills.Name = "gbBills";
            this.gbBills.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBills.Size = new System.Drawing.Size(741, 671);
            this.gbBills.TabIndex = 0;
            this.gbBills.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Заначка;
            this.pictureBox3.Location = new System.Drawing.Point(33, 172);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 53);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsFinanseSystem.Properties.Resources.кошелек_женский30;
            this.pictureBox2.Location = new System.Drawing.Point(33, 122);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 53);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnBillsCash
            // 
            this.btnBillsCash.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBillsCash.Enabled = false;
            this.btnBillsCash.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBillsCash.Location = new System.Drawing.Point(33, 14);
            this.btnBillsCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBillsCash.Name = "btnBillsCash";
            this.btnBillsCash.Size = new System.Drawing.Size(741, 48);
            this.btnBillsCash.TabIndex = 1;
            this.btnBillsCash.Text = "Наличные";
            this.btnBillsCash.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBillsCash.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsFinanseSystem.Properties.Resources.кошель30;
            this.pictureBox1.Location = new System.Drawing.Point(33, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 53);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddBills
            // 
            this.btnAddBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBills.Location = new System.Drawing.Point(753, 72);
            this.btnAddBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBills.Name = "btnAddBills";
            this.btnAddBills.Size = new System.Drawing.Size(160, 58);
            this.btnAddBills.TabIndex = 1;
            this.btnAddBills.Text = "Добавить";
            this.btnAddBills.UseVisualStyleBackColor = true;
            this.btnAddBills.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeBills
            // 
            this.btnChangeBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeBills.Location = new System.Drawing.Point(753, 158);
            this.btnChangeBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeBills.Name = "btnChangeBills";
            this.btnChangeBills.Size = new System.Drawing.Size(160, 58);
            this.btnChangeBills.TabIndex = 2;
            this.btnChangeBills.Text = "Изменить";
            this.btnChangeBills.UseVisualStyleBackColor = true;
            this.btnChangeBills.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteBills
            // 
            this.btnDeleteBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteBills.Location = new System.Drawing.Point(753, 240);
            this.btnDeleteBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteBills.Name = "btnDeleteBills";
            this.btnDeleteBills.Size = new System.Drawing.Size(160, 58);
            this.btnDeleteBills.TabIndex = 3;
            this.btnDeleteBills.Text = "Удалить";
            this.btnDeleteBills.UseVisualStyleBackColor = true;
            this.btnDeleteBills.Click += new System.EventHandler(this.btnDeleteBills_Click);
            // 
            // dgvBills
            // 
            this.dgvBills.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm,
            this.clmUserName,
            this.Bills});
            this.dgvBills.Location = new System.Drawing.Point(98, 72);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.RowHeadersWidth = 62;
            this.dgvBills.RowTemplate.Height = 28;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(626, 493);
            this.dgvBills.TabIndex = 6;
            // 
            // clm
            // 
            this.clm.DataPropertyName = "Name";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clm.DefaultCellStyle = dataGridViewCellStyle4;
            this.clm.FillWeight = 150F;
            this.clm.HeaderText = "Name";
            this.clm.MinimumWidth = 8;
            this.clm.Name = "clm";
            this.clm.Width = 150;
            // 
            // clmUserName
            // 
            this.clmUserName.DataPropertyName = "UserName";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clmUserName.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmUserName.FillWeight = 150F;
            this.clmUserName.HeaderText = "Пользователь";
            this.clmUserName.MinimumWidth = 8;
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.Width = 150;
            // 
            // Bills
            // 
            this.Bills.DataPropertyName = "Balance";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Bills.DefaultCellStyle = dataGridViewCellStyle6;
            this.Bills.FillWeight = 150F;
            this.Bills.HeaderText = "Баланс";
            this.Bills.MinimumWidth = 8;
            this.Bills.Name = "Bills";
            this.Bills.Width = 150;
            // 
            // frmBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 663);
            this.Controls.Add(this.btnDeleteBills);
            this.Controls.Add(this.btnChangeBills);
            this.Controls.Add(this.btnAddBills);
            this.Controls.Add(this.gbBills);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(940, 719);
            this.MinimumSize = new System.Drawing.Size(940, 718);
            this.Name = "frmBills";
            this.Text = "Счета";
            this.gbBills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBills;
        private System.Windows.Forms.Button btnBillsCash;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddBills;
        private System.Windows.Forms.Button btnChangeBills;
        private System.Windows.Forms.Button btnDeleteBills;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bills;
    }
}