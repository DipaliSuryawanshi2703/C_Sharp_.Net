using College_Login_Form_App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Login_Form_App
{
    public partial class Student_List : Form
    {
        public Student_List()
        {
            InitializeComponent();
        }
        private void Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'college_Management_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.college_Management_SystemDataSet.Student_Details);
            // TODO: This line of code loads data into the 'college_Management_SystemDataSet._Student_Details' table. You can move, or remove it, as needed.
            // this._Student_DetailsTableAdapter.Fill(this.college_Management_SystemDataSet._Student_Details);


            lb_UName.Text = "Welcome "+ Shared_Class.UName;
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();

        }      

        private void btn_Add_Student(object sender, EventArgs e)
        {
            Frm_Students_Details Obj = new Frm_Students_Details();
            Obj.Show();
            this.Hide();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();
            Obj.Show();
            this.Hide();
        }
    }
}
