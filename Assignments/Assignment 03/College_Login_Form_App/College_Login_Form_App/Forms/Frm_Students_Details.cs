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
using College_Login_Form_App.Forms;

namespace College_Login_Form_App
{
    public partial class Frm_Students_Details : Form
    {
        public Frm_Students_Details()
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
            if(FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }
        void Clear_All_Controls()
        {
            tb_RNo.Text = Convert.ToString(RNo_Auto_Incr());
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.ResetText();

            tb_RNo.Focus();

        }
        int RNo_Auto_Incr()
        {
            int Cnt = 0;

            FCon_Start();
            SqlCommand Fsc = new SqlCommand();
           
            Fsc .Connection  = FCon;
            Fsc.CommandText = "select Count(*) from Student_Details";
            Cnt = Convert.ToInt32(Fsc.ExecuteScalar());
            Fsc.Dispose();
        if(Cnt > 0)
            {
                Fsc.Connection = FCon;
                Fsc.CommandText = "select Max (RollNo)from Student_Details";
                Cnt = Convert.ToInt32(Fsc.ExecuteScalar()) + 1 ;
            }
            else
            {
                Cnt = 1;
            }
            FCon_Stop();
            return Cnt;


        }
        private void Frm_Students_Details_Load(object sender, EventArgs e)
        {
            tb_RNo.Text = Convert.ToString(RNo_Auto_Incr());
            lb_UName.Text = "Welcome " + Shared_Class.UName;

        }
        private void btn_log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }
        
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_All_Controls();
        }

        private void Only_Letter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar) == (char)Keys.Space))
            {
                e.Handled = true;
            }
           
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
               {
                e.Handled = true;
               }
              

        }

        private void Student_List_Click(object sender, EventArgs e)
        {
            Student_List Obj = new Student_List();
            Obj.Show();
            this.Hide();
        }


        private void tb_RNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if (tb_RNo.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text !="" && dtp_DOB.Text != "" && cmb_Course.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = FCon;
                Cmd.CommandText = "Insert Into Student_Details (RollNo,Student_Name,Mobile_No,DOB,Course) Values (@RNo, @Nm , @MNo, @DOB, @Crs)";

                Cmd.Parameters.Add("RNo",SqlDbType.Int).Value = tb_RNo.Text;
                Cmd.Parameters.Add("Nm" ,SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MNo",SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("DOB",SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Crs",SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Seccessfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Clear_All_Controls();

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FCon_Stop();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {

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

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 