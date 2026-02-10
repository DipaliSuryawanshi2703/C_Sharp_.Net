using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace College_Login_Form_App.Forms
{
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }
        SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-SRGJOCB;Initial Catalog=College_Management_System;Integrated Security=True");
        void FCon_Start()
        {
            if (FCon.State != ConnectionState.Open)
            {
                FCon.Open();
            }
        }
        void FCon_Stop()
        {
            if (FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }
        void Clear_All_Controls()
        {
            tb_RNo.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.ResetText();

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = FCon;
            Cmd.CommandText = "Select * From Student_Details where RollNo = @RNo";
            Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RNo.Text;

            SqlDataReader DR = Cmd.ExecuteReader();
            if(DR.Read())
            {
                tb_Name.Text = DR.GetString(DR.GetOrdinal("Student_Name"));
                tb_Mob_No.Text = (DR["Mobile_No"].ToString());
                   dtp_DOB.Text = (DR["DOB"].ToString());
                cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));
                tb_RNo.Enabled = false;

            }
            else
            {
                MessageBox.Show("Error", "Invalid Roll Number .....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_All_Controls();
            }
            
            FCon_Stop();
        }
        private void Add_student_Click(object sender, EventArgs e)
        {
            Frm_Students_Details Obj = new Frm_Students_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_All_Controls();
            tb_RNo.Enabled = true;
            tb_RNo.Focus();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            Student_List Obj = new Student_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            lb_UName.Text = "Welcome" + Shared_Class.UName;
        }
    }
}
