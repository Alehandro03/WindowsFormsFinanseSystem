using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinanseSystem
{
    public partial class OpenFileDialog : Form
    {
        public string Filter { get; private set; }
        public string FileName { get; private set; }

        public OpenFileDialog()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (btnOpenFileOpen.Click == true)
            //    textBox1 = "Файл открыт";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Test files|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;
                string fileText = File.ReadAllText(filename);
                textBox1.Text = fileText;
                MessageBox.Show("Файл открыт!");
            }
        }

        private void gbFileOpen_Enter(object sender, EventArgs e)
        {

        }
    }
}
