using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFinanseSystem.BusinessLogic;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem
{
    public partial class frmFamilyMember : Form
    {
        //private string _family_name;
        

        IFamilyMember _ifem_member;
        private List<IFamilyMember> _fem;
        bool IsChangeFem = false;
        IUser _user;
        public IUser User => _user;

        public frmFamilyMember(IUser user,IFamilyMember fem = null)
        {
            InitializeComponent();
            _user = user;
            _fem = FamilyMemberService.GetFamilyMember();
            foreach (var item in _fem)
            { 
                cmbUser.Items.Add(item.Name); 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbUser.Text = txtFIO.Text;
            FamilyMemberService.AddFamilyMember(txtFIO.Text, cmbFemily.Text);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string str = cmbUser.Text;
            User.Name = cmbUser.Text;
            frmMain form = new frmMain(User,str);
            DialogResult = DialogResult.OK;
            form.Show();
            Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbUser.Items.Count; i++)
            {
                if (i == cmbUser.SelectedIndex)
                    cmbUser.Text = txtFIO.Text;
                FamilyMemberService.AddFamilyMember(cmbUser.Text, cmbFemily.Text);
                FamilyMemberService.RemoveFamilyMember(_fem[i]);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить транзакцию?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                for (int i = 0; i < cmbUser.Items.Count; i++)
                {
                    if (i == cmbUser.SelectedIndex)
                        FamilyMemberService.RemoveFamilyMember(_fem[i]);
                }
            if (cmbUser.SelectedIndex == 0)
            {
                cmbUser.Text = "";
            }
        }
    }
}
