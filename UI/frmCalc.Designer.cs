
namespace WindowsFormsFinanseSystem.UI
{
    partial class frmCalc
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnInDegree = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(6, 25);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(312, 46);
            this.txtNum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtnum2.Location = new System.Drawing.Point(335, 25);
            this.txtnum2.Multiline = true;
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(312, 46);
            this.txtnum2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnRoot);
            this.groupBox1.Controls.Add(this.btnInDegree);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnMult);
            this.groupBox1.Controls.Add(this.btnSubstraction);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.txtnum2);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRoot.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoot.Location = new System.Drawing.Point(404, 239);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(177, 53);
            this.btnRoot.TabIndex = 7;
            this.btnRoot.Text = "Корень";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnInDegree
            // 
            this.btnInDegree.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInDegree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInDegree.Location = new System.Drawing.Point(73, 239);
            this.btnInDegree.Name = "btnInDegree";
            this.btnInDegree.Size = new System.Drawing.Size(177, 53);
            this.btnInDegree.TabIndex = 6;
            this.btnInDegree.Text = "В степень";
            this.btnInDegree.UseVisualStyleBackColor = false;
            this.btnInDegree.Click += new System.EventHandler(this.btnInDegree_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivision.Location = new System.Drawing.Point(404, 169);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(177, 53);
            this.btnDivision.TabIndex = 5;
            this.btnDivision.Text = "Разделить";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMult.Location = new System.Drawing.Point(73, 169);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(177, 53);
            this.btnMult.TabIndex = 4;
            this.btnMult.Text = "Умножить";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubstraction.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubstraction.Location = new System.Drawing.Point(404, 100);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(177, 53);
            this.btnSubstraction.TabIndex = 3;
            this.btnSubstraction.Text = "Вычесть";
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSum.Location = new System.Drawing.Point(73, 100);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(177, 53);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Сложить";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnswer.Location = new System.Drawing.Point(171, 392);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(498, 46);
            this.txtAnswer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ответ:";
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCalc";
            this.Text = "Калькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnInDegree;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
    }
}