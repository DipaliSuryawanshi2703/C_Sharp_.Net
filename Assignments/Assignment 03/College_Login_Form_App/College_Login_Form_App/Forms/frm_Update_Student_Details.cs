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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
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

            tb_RNo.Focus();
        }
        void Enable_True()
        {
            tb_RNo.Enabled = false;
            tb_Mob_No.Enabled = true;
            tb_Name.Enabled = true;
            cmb_Course.Enabled = true;
            
        }
        void Enable_False()
        {
            tb_RNo.Enabled = true;
            tb_Mob_No.Enabled = false;
            tb_Name.Enabled = false;
            cmb_Course.Enabled = false;

        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_All_Controls();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            Student_List Obj = new Student_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if (tb_RNo.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_DOB.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = FCon;
               
                Cmd.CommandText = "Update Student_Details Set Student_Name = @Nm,Mobile_No = @MNo , DOB = @DOB , Course = @Crs Where RollNo = @RNo ";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RNo.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Crs", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Details Updated Seccessfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_All_Controls();
                //Enable_False();
               

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FCon_Stop();
         }

        private void btn_log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }

        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            tb_RNo.Focus();
            lb_UName.Text = "welcome " + Shared_Class.UName;
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            Frm_Students_Details Obj = new Frm_Students_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = FCon;
            Cmd.CommandText = "Select * From Student_Details where RollNo = @RNo";
            Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RNo.Text;

            SqlDataReader DR = Cmd.ExecuteReader();
            if (DR.Read())
            {
                tb_Name.Text = DR.GetString(DR.GetOrdinal("Student_Name"));
                tb_Mob_No.Text = (DR["Mobile_No"].ToString());
                dtp_DOB.Text = (DR["DOB"].ToString());
                cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));
                Enable_True();

            }
            else
            {
                MessageBox.Show("Error", "Invalid Roll Number .....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_All_Controls();
            }

            FCon_Stop();
        }
    }
}
