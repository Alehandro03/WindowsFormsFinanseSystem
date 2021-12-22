
namespace WindowsFormsFinanseSystem
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutTheProg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutProgDev = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNull = new System.Windows.Forms.Button();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.rtbTotalSum = new System.Windows.Forms.RichTextBox();
            this.rtbDebtsSum = new System.Windows.Forms.RichTextBox();
            this.rtbSumOverallBalance = new System.Windows.Forms.RichTextBox();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.rtbDebts = new System.Windows.Forms.RichTextBox();
            this.rtbOverallBalance = new System.Windows.Forms.RichTextBox();
            this.dgvTablGeneral = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFemalyMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCaledary = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCurrencies = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablGeneral)).BeginInit();
            this.gbCaledary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.menuAboutTheProg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmDownload,
            this.tsmSave,
            this.tsmExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(185, 22);
            this.tsmOpen.Text = "Открыть";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmDownload
            // 
            this.tsmDownload.Name = "tsmDownload";
            this.tsmDownload.Size = new System.Drawing.Size(185, 22);
            this.tsmDownload.Text = "Загрузить из облака";
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(185, 22);
            this.tsmSave.Text = "Сохранить";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(185, 22);
            this.tsmExit.Text = "Выход";
            // 
            // menuAboutTheProg
            // 
            this.menuAboutTheProg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAboutProgDev});
            this.menuAboutTheProg.Name = "menuAboutTheProg";
            this.menuAboutTheProg.Size = new System.Drawing.Size(94, 20);
            this.menuAboutTheProg.Text = "О программе";
            // 
            // menuAboutProgDev
            // 
            this.menuAboutProgDev.Name = "menuAboutProgDev";
            this.menuAboutProgDev.Size = new System.Drawing.Size(151, 22);
            this.menuAboutProgDev.Text = "Разработчики";
            // 
            // btnNull
            // 
            this.btnNull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNull.Enabled = false;
            this.btnNull.Location = new System.Drawing.Point(748, 27);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(456, 102);
            this.btnNull.TabIndex = 33;
            this.btnNull.UseVisualStyleBackColor = false;
            // 
            // gbButton
            // 
            this.gbButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbButton.Controls.Add(this.btnTransaction);
            this.gbButton.Controls.Add(this.btnGeneral);
            this.gbButton.Controls.Add(this.btnSettings);
            this.gbButton.Controls.Add(this.btnReports);
            this.gbButton.Controls.Add(this.btnCategories);
            this.gbButton.Controls.Add(this.btnUsers);
            this.gbButton.Controls.Add(this.btnCurrencies);
            this.gbButton.Controls.Add(this.btnBills);
            this.gbButton.Location = new System.Drawing.Point(0, 27);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(753, 102);
            this.gbButton.TabIndex = 34;
            this.gbButton.TabStop = false;
            this.gbButton.Enter += new System.EventHandler(this.gbButton_Enter);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpty.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEmpty.Enabled = false;
            this.btnEmpty.Location = new System.Drawing.Point(759, 38);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(402, 85);
            this.btnEmpty.TabIndex = 35;
            this.btnEmpty.UseVisualStyleBackColor = false;
            // 
            // rtbTotalSum
            // 
            this.rtbTotalSum.Location = new System.Drawing.Point(140, 424);
            this.rtbTotalSum.Name = "rtbTotalSum";
            this.rtbTotalSum.Size = new System.Drawing.Size(174, 31);
            this.rtbTotalSum.TabIndex = 42;
            this.rtbTotalSum.Text = "";
            // 
            // rtbDebtsSum
            // 
            this.rtbDebtsSum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbDebtsSum.Location = new System.Drawing.Point(140, 397);
            this.rtbDebtsSum.Name = "rtbDebtsSum";
            this.rtbDebtsSum.Size = new System.Drawing.Size(174, 31);
            this.rtbDebtsSum.TabIndex = 41;
            this.rtbDebtsSum.Text = "";
            this.rtbDebtsSum.TextChanged += new System.EventHandler(this.rtbDebtsSum_TextChanged);
            // 
            // rtbSumOverallBalance
            // 
            this.rtbSumOverallBalance.Location = new System.Drawing.Point(140, 369);
            this.rtbSumOverallBalance.Name = "rtbSumOverallBalance";
            this.rtbSumOverallBalance.Size = new System.Drawing.Size(174, 31);
            this.rtbSumOverallBalance.TabIndex = 40;
            this.rtbSumOverallBalance.Text = "";
            // 
            // rtbTotal
            // 
            this.rtbTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTotal.Location = new System.Drawing.Point(0, 424);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.Size = new System.Drawing.Size(143, 31);
            this.rtbTotal.TabIndex = 39;
            this.rtbTotal.Text = "⚖️ Итого";
            // 
            // rtbDebts
            // 
            this.rtbDebts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbDebts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDebts.Location = new System.Drawing.Point(0, 397);
            this.rtbDebts.Name = "rtbDebts";
            this.rtbDebts.Size = new System.Drawing.Size(143, 31);
            this.rtbDebts.TabIndex = 38;
            this.rtbDebts.Text = "👛 Долги(Всего)";
            this.rtbDebts.TextChanged += new System.EventHandler(this.rtbDebts_TextChanged);
            // 
            // rtbOverallBalance
            // 
            this.rtbOverallBalance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbOverallBalance.Location = new System.Drawing.Point(0, 369);
            this.rtbOverallBalance.Name = "rtbOverallBalance";
            this.rtbOverallBalance.Size = new System.Drawing.Size(143, 31);
            this.rtbOverallBalance.TabIndex = 37;
            this.rtbOverallBalance.Text = " 💵 Общий баланс";
            // 
            // dgvTablGeneral
            // 
            this.dgvTablGeneral.AllowUserToAddRows = false;
            this.dgvTablGeneral.AllowUserToDeleteRows = false;
            this.dgvTablGeneral.AllowUserToResizeColumns = false;
            this.dgvTablGeneral.AllowUserToResizeRows = false;
            this.dgvTablGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablGeneral.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTablGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colSum,
            this.colCategory,
            this.colFemalyMem,
            this.colComment});
            this.dgvTablGeneral.GridColor = System.Drawing.SystemColors.Info;
            this.dgvTablGeneral.Location = new System.Drawing.Point(320, 135);
            this.dgvTablGeneral.Name = "dgvTablGeneral";
            this.dgvTablGeneral.ReadOnly = true;
            this.dgvTablGeneral.RowHeadersVisible = false;
            this.dgvTablGeneral.RowHeadersWidth = 62;
            this.dgvTablGeneral.RowTemplate.Height = 28;
            this.dgvTablGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablGeneral.Size = new System.Drawing.Size(829, 372);
            this.dgvTablGeneral.TabIndex = 43;
            // 
            // colDate
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDate.HeaderText = "Дата";
            this.colDate.MaxInputLength = 10;
            this.colDate.MinimumWidth = 8;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colSum
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.colSum.DefaultCellStyle = dataGridViewCellStyle14;
            this.colSum.HeaderText = "Сумма";
            this.colSum.MinimumWidth = 8;
            this.colSum.Name = "colSum";
            this.colSum.ReadOnly = true;
            this.colSum.Width = 150;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Категория";
            this.colCategory.MinimumWidth = 8;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 150;
            // 
            // colFemalyMem
            // 
            this.colFemalyMem.HeaderText = "Член Семьи";
            this.colFemalyMem.MinimumWidth = 8;
            this.colFemalyMem.Name = "colFemalyMem";
            this.colFemalyMem.ReadOnly = true;
            this.colFemalyMem.Width = 150;
            // 
            // colComment
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colComment.DefaultCellStyle = dataGridViewCellStyle15;
            this.colComment.HeaderText = "Комментарий";
            this.colComment.MinimumWidth = 8;
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            this.colComment.Width = 150;
            // 
            // gbCaledary
            // 
            this.gbCaledary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCaledary.BackgroundImage = global::WindowsFormsFinanseSystem.Properties.Resources.фон_календарь;
            this.gbCaledary.Controls.Add(this.monthCalendar1);
            this.gbCaledary.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCaledary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbCaledary.Location = new System.Drawing.Point(0, 135);
            this.gbCaledary.Name = "gbCaledary";
            this.gbCaledary.Size = new System.Drawing.Size(314, 228);
            this.gbCaledary.TabIndex = 36;
            this.gbCaledary.TabStop = false;
            this.gbCaledary.Text = "                   Календарь 📅";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.Location = new System.Drawing.Point(72, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransaction.Image = global::WindowsFormsFinanseSystem.Properties.Resources.блокнот70;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransaction.Location = new System.Drawing.Point(92, 11);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(95, 85);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "Транзакция";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Обзор70;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeneral.Location = new System.Drawing.Point(0, 11);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(95, 85);
            this.btnGeneral.TabIndex = 4;
            this.btnGeneral.Text = "Общее";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneral.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Настройки70;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(658, 11);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(95, 85);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnReports.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReports.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Отчеты70;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.Location = new System.Drawing.Point(184, 11);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(95, 85);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Отчеты";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategories.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Категории70;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategories.Location = new System.Drawing.Point(565, 11);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(95, 85);
            this.btnCategories.TabIndex = 10;
            this.btnCategories.Text = "Категории";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsers.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Пользователи70;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(461, 11);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(107, 85);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCurrencies.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurrencies.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Валюты70;
            this.btnCurrencies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCurrencies.Location = new System.Drawing.Point(276, 11);
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.Size = new System.Drawing.Size(96, 85);
            this.btnCurrencies.TabIndex = 7;
            this.btnCurrencies.Text = "Валюты";
            this.btnCurrencies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCurrencies.UseVisualStyleBackColor = false;
            this.btnCurrencies.Click += new System.EventHandler(this.btnCurrencies_Click);
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBills.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Счета70;
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBills.Location = new System.Drawing.Point(369, 11);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(95, 85);
            this.btnBills.TabIndex = 8;
            this.btnBills.Text = "Счета";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 551);
            this.Controls.Add(this.dgvTablGeneral);
            this.Controls.Add(this.rtbTotalSum);
            this.Controls.Add(this.rtbDebtsSum);
            this.Controls.Add(this.rtbSumOverallBalance);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.rtbDebts);
            this.Controls.Add(this.rtbOverallBalance);
            this.Controls.Add(this.gbCaledary);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablGeneral)).EndInit();
            this.gbCaledary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmDownload;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem menuAboutTheProg;
        private System.Windows.Forms.ToolStripMenuItem menuAboutProgDev;
        private System.Windows.Forms.Button btnNull;
        private System.Windows.Forms.Button btnCurrencies;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.GroupBox gbCaledary;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox rtbTotalSum;
        private System.Windows.Forms.RichTextBox rtbDebtsSum;
        private System.Windows.Forms.RichTextBox rtbSumOverallBalance;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.RichTextBox rtbDebts;
        private System.Windows.Forms.RichTextBox rtbOverallBalance;
        private System.Windows.Forms.DataGridView dgvTablGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFemalyMem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
    }
}

