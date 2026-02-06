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
    public partial class Frm_Students_Details : Form
    {
        public Frm_Students_Details()
        {
            InitializeComponent();
        }
         SqlConnection FCon = new SqlConnection(@"Data Source = DESKTOP - SRGJOCB; Initial Catalog = College_Management_System; Integrated Security = True");
        void FCon_Start()
        {
            if (FCon.State != ConnectionState.Open)
            {
                FCon. Open();
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
            tb_RNo.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.ResetText();

        }
        private void lb_Welcome_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Student_List Obj = new Student_List();
            Obj.Show();
            this.Hide();
        }

        private void tb_RNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
