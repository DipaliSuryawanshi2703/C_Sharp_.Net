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
            // TODO: This line of code loads data into the 'college_Management_SystemDataSet._Student_Details' table. You can move, or remove it, as needed.
           // this._Student_DetailsTableAdapter.Fill(this.college_Management_SystemDataSet._Student_Details);
            this._Student_DetailsTableAdapter.Fill(this.college_Management_SystemDataSet._Student_Details);
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Student_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }    
    }
}
