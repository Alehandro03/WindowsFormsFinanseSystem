
namespace WindowsFormsFinanseSystem.UI
{
    partial class frmCredits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvCredits = new System.Windows.Forms.DataGridView();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPercents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoanBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numPercent = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numSum = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(760, 561);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(204, 78);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Рассчитать";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvCredits
            // 
            this.dgvCredits.AllowUserToAddRows = false;
            this.dgvCredits.AllowUserToDeleteRows = false;
            this.dgvCredits.AllowUserToResizeColumns = false;
            this.dgvCredits.AllowUserToResizeRows = false;
            this.dgvCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCredits.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMonth,
            this.clmPayment,
            this.clmPercents,
            this.clmLoanBalance});
            this.dgvCredits.Location = new System.Drawing.Point(17, 100);
            this.dgvCredits.Name = "dgvCredits";
            this.dgvCredits.RowHeadersVisible = false;
            this.dgvCredits.RowHeadersWidth = 62;
            this.dgvCredits.RowTemplate.Height = 28;
            this.dgvCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCredits.Size = new System.Drawing.Size(1169, 454);
            this.dgvCredits.TabIndex = 4;
            // 
            // clmMonth
            // 
            this.clmMonth.DataPropertyName = "Month";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.NullValue = null;
            this.clmMonth.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmMonth.HeaderText = "Месяц";
            this.clmMonth.MinimumWidth = 8;
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.Width = 150;
            // 
            // clmPayment
            // 
            this.clmPayment.DataPropertyName = "Pay";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.clmPayment.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmPayment.FillWeight = 150F;
            this.clmPayment.HeaderText = "Платеж";
            this.clmPayment.MinimumWidth = 8;
            this.clmPayment.Name = "clmPayment";
            this.clmPayment.Width = 200;
            // 
            // clmPercents
            // 
            this.clmPercents.DataPropertyName = "Percents";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.clmPercents.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmPercents.FillWeight = 150F;
            this.clmPercents.HeaderText = "Проценты";
            this.clmPercents.MinimumWidth = 8;
            this.clmPercents.Name = "clmPercents";
            this.clmPercents.Width = 200;
            // 
            // clmLoanBalance
            // 
            this.clmLoanBalance.DataPropertyName = "Last";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.clmLoanBalance.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmLoanBalance.FillWeight = 150F;
            this.clmLoanBalance.HeaderText = "Остаток по кредиту";
            this.clmLoanBalance.MinimumWidth = 8;
            this.clmLoanBalance.Name = "clmLoanBalance";
            this.clmLoanBalance.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма кредита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(888, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Колличество месяцев";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(476, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Процентная ставка";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numPercent);
            this.groupBox1.Controls.Add(this.numMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.numSum);
            this.groupBox1.Controls.Add(this.dgvCredits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 645);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(982, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 78);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numPercent
            // 
            this.numPercent.DecimalPlaces = 1;
            this.numPercent.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPercent.Location = new System.Drawing.Point(421, 56);
            this.numPercent.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPercent.Name = "numPercent";
            this.numPercent.Size = new System.Drawing.Size(338, 38);
            this.numPercent.TabIndex = 10;
            // 
            // numMonth
            // 
            this.numMonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMonth.Location = new System.Drawing.Point(867, 56);
            this.numMonth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(313, 38);
            this.numMonth.TabIndex = 11;
            // 
            // numSum
            // 
            this.numSum.DecimalPlaces = 2;
            this.numSum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSum.Location = new System.Drawing.Point(11, 56);
            this.numSum.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numSum.Name = "numSum";
            this.numSum.Size = new System.Drawing.Size(319, 38);
            this.numSum.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(36, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 78);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 663);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCredits";
            this.Text = "frmCredits";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSum;
        private System.Windows.Forms.NumericUpDown numPercent;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPercents;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoanBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
    }
}