using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinanseSystem
{
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private Image _image_my_form;
        public Image ImageMyForm { get; set; }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Image RefreshImage()
        {
            //ImageList il = new ImageList();

            if (rbPictureBox1.Checked == true)
            //pbAddBills.Image = imageList1.Images[0];
            {
                 ImageMyForm = imageList1.Images[0];
                return ImageMyForm;
            }
            if (rbPictureBox2.Checked == true)
            {
                ImageMyForm = imageList1.Images[1];
                return ImageMyForm;
            }
            if (rbPictureBox3.Checked == true)
            {
                ImageMyForm = imageList1.Images[2];
                return ImageMyForm;
            }
            if (rbPictureBox6.Checked == true)
            {
                ImageMyForm = imageList1.Images[3];
                return ImageMyForm;
            }
            if (rbPictureBox5.Checked == true)
            {
                ImageMyForm = imageList1.Images[4];
                return ImageMyForm;
            }
            if (rbPictureBox4.Checked == true)
            {
                ImageMyForm = imageList1.Images[5];
                return ImageMyForm;
            }
            return imageList1.Images[1];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshImage();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
