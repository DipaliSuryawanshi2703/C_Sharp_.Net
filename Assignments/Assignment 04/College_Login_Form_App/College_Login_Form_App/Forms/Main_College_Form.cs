using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Login_Form_App.Forms
{
    public partial class Main_College_Form : Form
    {
        public Main_College_Form()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void tsm_Add_Student_Click(object sender, EventArgs e)
        {
            Frm_Students_Details Obj = new Frm_Students_Details();
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void studentDetailsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_List Obj = new  Student_List();
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void searchStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void btn_log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Log Out ????", "logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void Main_College_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
