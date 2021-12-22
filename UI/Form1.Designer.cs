
namespace WindowsFormsFinanseSystem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutTheProg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutProgDev = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNull = new System.Windows.Forms.Button();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCurrencies = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.rtbTotalSum = new System.Windows.Forms.RichTextBox();
            this.rtbDebtsSum = new System.Windows.Forms.RichTextBox();
            this.rtbSumOverallBalance = new System.Windows.Forms.RichTextBox();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.rtbDebts = new System.Windows.Forms.RichTextBox();
            this.rtbOverallBalance = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeneralExit = new System.Windows.Forms.Button();
            this.gbGeneralChoice = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbAddUser = new System.Windows.Forms.ComboBox();
            this.cnbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpeedTrans = new System.Windows.Forms.Button();
            this.numSum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbCaledary = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.gbButton.SuspendLayout();
            this.gbGeneralChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbCaledary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.menuAboutTheProg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1538, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSave,
            this.tsmExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(270, 34);
            this.tsmSave.Text = "Сохранить";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(270, 34);
            this.tsmExit.Text = "Выход";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // menuAboutTheProg
            // 
            this.menuAboutTheProg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAboutProgDev});
            this.menuAboutTheProg.Name = "menuAboutTheProg";
            this.menuAboutTheProg.Size = new System.Drawing.Size(141, 29);
            this.menuAboutTheProg.Text = "О программе";
            // 
            // menuAboutProgDev
            // 
            this.menuAboutProgDev.Name = "menuAboutProgDev";
            this.menuAboutProgDev.Size = new System.Drawing.Size(270, 34);
            this.menuAboutProgDev.Text = "Разработчики";
            this.menuAboutProgDev.Click += new System.EventHandler(this.menuAboutProgDev_Click);
            // 
            // btnNull
            // 
            this.btnNull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNull.Enabled = false;
            this.btnNull.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNull.Location = new System.Drawing.Point(1152, 42);
            this.btnNull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(386, 157);
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
            this.gbButton.Location = new System.Drawing.Point(0, 42);
            this.gbButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbButton.Name = "gbButton";
            this.gbButton.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbButton.Size = new System.Drawing.Size(1169, 157);
            this.gbButton.TabIndex = 34;
            this.gbButton.TabStop = false;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransaction.Image = global::WindowsFormsFinanseSystem.Properties.Resources.блокнот70;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransaction.Location = new System.Drawing.Point(138, 17);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(142, 131);
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
            this.btnGeneral.Location = new System.Drawing.Point(0, 17);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(142, 131);
            this.btnGeneral.TabIndex = 4;
            this.btnGeneral.Text = "Общее";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneral.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Торговый_счет1;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(987, 17);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(174, 131);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Рассчет Кредита";
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
            this.btnReports.Location = new System.Drawing.Point(276, 17);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(142, 131);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Отчеты";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategories.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Категории70;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategories.Location = new System.Drawing.Point(848, 17);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(142, 131);
            this.btnCategories.TabIndex = 10;
            this.btnCategories.Text = "Категории";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsers.Image = global::WindowsFormsFinanseSystem.Properties.Resources.Пользователи70;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(692, 17);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(160, 131);
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
            this.btnCurrencies.Location = new System.Drawing.Point(414, 17);
            this.btnCurrencies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.Size = new System.Drawing.Size(144, 131);
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
            this.btnBills.Location = new System.Drawing.Point(554, 17);
            this.btnBills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(142, 131);
            this.btnBills.TabIndex = 8;
            this.btnBills.Text = "Счета";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpty.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEmpty.Enabled = false;
            this.btnEmpty.Location = new System.Drawing.Point(1170, 58);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(368, 131);
            this.btnEmpty.TabIndex = 35;
            this.btnEmpty.UseVisualStyleBackColor = false;
            // 
            // rtbTotalSum
            // 
            this.rtbTotalSum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTotalSum.Location = new System.Drawing.Point(210, 652);
            this.rtbTotalSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbTotalSum.Name = "rtbTotalSum";
            this.rtbTotalSum.ReadOnly = true;
            this.rtbTotalSum.Size = new System.Drawing.Size(259, 46);
            this.rtbTotalSum.TabIndex = 42;
            this.rtbTotalSum.Text = "";
            // 
            // rtbDebtsSum
            // 
            this.rtbDebtsSum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbDebtsSum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDebtsSum.Location = new System.Drawing.Point(210, 611);
            this.rtbDebtsSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDebtsSum.Name = "rtbDebtsSum";
            this.rtbDebtsSum.ReadOnly = true;
            this.rtbDebtsSum.Size = new System.Drawing.Size(259, 46);
            this.rtbDebtsSum.TabIndex = 41;
            this.rtbDebtsSum.Text = "";
            // 
            // rtbSumOverallBalance
            // 
            this.rtbSumOverallBalance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSumOverallBalance.Location = new System.Drawing.Point(210, 568);
            this.rtbSumOverallBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbSumOverallBalance.Name = "rtbSumOverallBalance";
            this.rtbSumOverallBalance.ReadOnly = true;
            this.rtbSumOverallBalance.Size = new System.Drawing.Size(259, 46);
            this.rtbSumOverallBalance.TabIndex = 40;
            this.rtbSumOverallBalance.Text = "";
            // 
            // rtbTotal
            // 
            this.rtbTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTotal.Location = new System.Drawing.Point(0, 652);
            this.rtbTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.ReadOnly = true;
            this.rtbTotal.Size = new System.Drawing.Size(212, 46);
            this.rtbTotal.TabIndex = 39;
            this.rtbTotal.Text = "⚖️ Итого";
            // 
            // rtbDebts
            // 
            this.rtbDebts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbDebts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDebts.Location = new System.Drawing.Point(0, 611);
            this.rtbDebts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDebts.Name = "rtbDebts";
            this.rtbDebts.ReadOnly = true;
            this.rtbDebts.Size = new System.Drawing.Size(212, 46);
            this.rtbDebts.TabIndex = 38;
            this.rtbDebts.Text = "👛 Долги(Всего)";
            // 
            // rtbOverallBalance
            // 
            this.rtbOverallBalance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbOverallBalance.Location = new System.Drawing.Point(0, 568);
            this.rtbOverallBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbOverallBalance.Name = "rtbOverallBalance";
            this.rtbOverallBalance.ReadOnly = true;
            this.rtbOverallBalance.Size = new System.Drawing.Size(212, 46);
            this.rtbOverallBalance.TabIndex = 37;
            this.rtbOverallBalance.Text = " 💵 Общий баланс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Выберите пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(831, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 31);
            this.label2.TabIndex = 50;
            this.label2.Text = "Добавить сумму";
            // 
            // btnGeneralExit
            // 
            this.btnGeneralExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGeneralExit.Location = new System.Drawing.Point(1580, 708);
            this.btnGeneralExit.Name = "btnGeneralExit";
            this.btnGeneralExit.Size = new System.Drawing.Size(140, 55);
            this.btnGeneralExit.TabIndex = 52;
            this.btnGeneralExit.Text = "Выход";
            this.btnGeneralExit.UseVisualStyleBackColor = true;
            // 
            // gbGeneralChoice
            // 
            this.gbGeneralChoice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbGeneralChoice.Controls.Add(this.cmbType);
            this.gbGeneralChoice.Controls.Add(this.cmbAddUser);
            this.gbGeneralChoice.Controls.Add(this.cnbCategory);
            this.gbGeneralChoice.Controls.Add(this.label5);
            this.gbGeneralChoice.Controls.Add(this.label4);
            this.gbGeneralChoice.Controls.Add(this.label1);
            this.gbGeneralChoice.Location = new System.Drawing.Point(478, 208);
            this.gbGeneralChoice.Name = "gbGeneralChoice";
            this.gbGeneralChoice.Size = new System.Drawing.Size(1000, 100);
            this.gbGeneralChoice.TabIndex = 54;
            this.gbGeneralChoice.TabStop = false;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Доходы",
            "Расходы"});
            this.cmbType.Location = new System.Drawing.Point(6, 48);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(313, 35);
            this.cmbType.TabIndex = 51;
            // 
            // cmbAddUser
            // 
            this.cmbAddUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAddUser.FormattingEnabled = true;
            this.cmbAddUser.Location = new System.Drawing.Point(325, 48);
            this.cmbAddUser.Name = "cmbAddUser";
            this.cmbAddUser.Size = new System.Drawing.Size(313, 35);
            this.cmbAddUser.TabIndex = 50;
            // 
            // cnbCategory
            // 
            this.cnbCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cnbCategory.FormattingEnabled = true;
            this.cnbCategory.Items.AddRange(new object[] {
            "Зарплата",
            "Дивиденты",
            "Подработка",
            "Проценты",
            "Продукты",
            "Услуги",
            "ЖКХ",
            "Медицина",
            "Одежда",
            "Дети",
            "Питомец",
            "Автомобиль",
            "Отдых",
            "Др. вид трат",
            "Др. вид доходов"});
            this.cnbCategory.Location = new System.Drawing.Point(660, 48);
            this.cnbCategory.Name = "cnbCategory";
            this.cnbCategory.Size = new System.Drawing.Size(313, 35);
            this.cnbCategory.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(686, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Выберите категорию";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 46;
            this.label4.Text = "Выберите группу";
            // 
            // btnSpeedTrans
            // 
            this.btnSpeedTrans.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSpeedTrans.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpeedTrans.Location = new System.Drawing.Point(1176, 556);
            this.btnSpeedTrans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpeedTrans.Name = "btnSpeedTrans";
            this.btnSpeedTrans.Size = new System.Drawing.Size(302, 89);
            this.btnSpeedTrans.TabIndex = 59;
            this.btnSpeedTrans.Text = "Добавить";
            this.btnSpeedTrans.UseVisualStyleBackColor = false;
            this.btnSpeedTrans.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numSum
            // 
            this.numSum.DecimalPlaces = 2;
            this.numSum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSum.Location = new System.Drawing.Point(1047, 330);
            this.numSum.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numSum.Name = "numSum";
            this.numSum.Size = new System.Drawing.Size(431, 38);
            this.numSum.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(743, 445);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 31);
            this.label3.TabIndex = 62;
            this.label3.Text = "Добавить комментарий";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComment.Location = new System.Drawing.Point(1046, 389);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(432, 133);
            this.txtComment.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsFinanseSystem.Properties.Resources.деньга_маленькая;
            this.pictureBox1.Location = new System.Drawing.Point(747, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox3.Image = global::WindowsFormsFinanseSystem.Properties.Resources.зеленая_галочка;
            this.pictureBox3.Location = new System.Drawing.Point(1193, 568);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // gbCaledary
            // 
            this.gbCaledary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCaledary.BackgroundImage = global::WindowsFormsFinanseSystem.Properties.Resources.зима_фон1001;
            this.gbCaledary.Controls.Add(this.monthCalendar1);
            this.gbCaledary.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCaledary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbCaledary.Location = new System.Drawing.Point(0, 208);
            this.gbCaledary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCaledary.Name = "gbCaledary";
            this.gbCaledary.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCaledary.Size = new System.Drawing.Size(471, 351);
            this.gbCaledary.TabIndex = 36;
            this.gbCaledary.TabStop = false;
            this.gbCaledary.Text = "                   Календарь 📅";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.Location = new System.Drawing.Point(108, 48);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1538, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSum);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSpeedTrans);
            this.Controls.Add(this.gbGeneralChoice);
            this.Controls.Add(this.btnGeneralExit);
            this.Controls.Add(this.label2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1560, 770);
            this.MinimumSize = new System.Drawing.Size(1560, 770);
            this.Name = "frmMain";
            this.Text = "Главная форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbButton.ResumeLayout(false);
            this.gbGeneralChoice.ResumeLayout(false);
            this.gbGeneralChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbCaledary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeneralExit;
        private System.Windows.Forms.GroupBox gbGeneralChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSpeedTrans;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbAddUser;
        private System.Windows.Forms.ComboBox cnbCategory;
        private System.Windows.Forms.NumericUpDown numSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

