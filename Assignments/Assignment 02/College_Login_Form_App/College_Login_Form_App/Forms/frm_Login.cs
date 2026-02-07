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



namespace College_Login_Form_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            FCon_Start();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = FCon;
            Cmd.CommandText = "Select Count (*) From Login_Details where Username = @UName And Password =@Pwd ";
            Cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = tb_UName.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Pass.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            if(Cnt > 0)
            {
                MessageBox.Show("Welcome", "Login Successuful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Class.UName = tb_UName.Text;
                     
                Frm_Students_Details obj = new Frm_Students_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                lb_Message.Text = "Invalid Username Or Password";
                lb_Message.ForeColor = Color.Red;
                lb_Message.BackColor = Color.Aqua;

                MessageBox.Show("Error", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            tb_UName.Clear();
            tb_Pass.Clear();
            tb_UName.Focus();
           
         }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            tb_UName.Focus();
        }

       }
    }

