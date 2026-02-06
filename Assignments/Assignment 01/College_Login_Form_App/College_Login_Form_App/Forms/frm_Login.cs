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
         
        private void frm_Login_Load(object sender, EventArgs e)
        {



        }
            private void btn_Login_Click(object sender, EventArgs e)
        {
            if ((tb_UName.Text == "D" && tb_Pass.Text == "D") || (tb_UName.Text == "Dipali" && tb_Pass.Text == "27") )
            {
                MessageBox.Show("Welcome", "Login Successuful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_UName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

