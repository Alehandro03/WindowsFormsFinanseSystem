
namespace WindowsFormsFinanseSystem
{
    partial class OpenFileDialog
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
            this.gbFileOpen = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpenFileOpen = new System.Windows.Forms.Button();
            this.btnFileOpenCancell = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.gbFileOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFileOpen
            // 
            this.gbFileOpen.Controls.Add(this.btnOpenFileOpen);
            this.gbFileOpen.Controls.Add(this.textBox1);
            this.gbFileOpen.Location = new System.Drawing.Point(12, 12);
            this.gbFileOpen.Name = "gbFileOpen";
            this.gbFileOpen.Size = new System.Drawing.Size(375, 168);
            this.gbFileOpen.TabIndex = 0;
            this.gbFileOpen.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOpenFileOpen
            // 
            this.btnOpenFileOpen.Location = new System.Drawing.Point(289, 68);
            this.btnOpenFileOpen.Name = "btnOpenFileOpen";
            this.btnOpenFileOpen.Size = new System.Drawing.Size(62, 23);
            this.btnOpenFileOpen.TabIndex = 2;
            this.btnOpenFileOpen.Text = "Открыть";
            this.btnOpenFileOpen.UseVisualStyleBackColor = true;
            this.btnOpenFileOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFileOpenCancell
            // 
            this.btnFileOpenCancell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFileOpenCancell.Location = new System.Drawing.Point(256, 201);
            this.btnFileOpenCancell.Name = "btnFileOpenCancell";
            this.btnFileOpenCancell.Size = new System.Drawing.Size(75, 38);
            this.btnFileOpenCancell.TabIndex = 1;
            this.btnFileOpenCancell.Text = "Отмена";
            this.btnFileOpenCancell.UseVisualStyleBackColor = true;
            this.btnFileOpenCancell.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFileOpen.Location = new System.Drawing.Point(56, 201);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 38);
            this.btnFileOpen.TabIndex = 2;
            this.btnFileOpen.Text = "ОК";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // OpenFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 260);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.btnFileOpenCancell);
            this.Controls.Add(this.gbFileOpen);
            this.Name = "OpenFileDialog";
            this.Text = "Файл : Открыть";
            this.Load += new System.EventHandler(this.OpenFileDialog_Load);
            this.gbFileOpen.ResumeLayout(false);
            this.gbFileOpen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFileOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOpenFileOpen;
        private System.Windows.Forms.Button btnFileOpenCancell;
        private System.Windows.Forms.Button btnFileOpen;
    }
}