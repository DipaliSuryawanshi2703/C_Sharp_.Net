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
using System.IO;

namespace Picture_Box_Assignment
{
    public partial class frm_Search_Image : Form
    {
        public frm_Search_Image()
        {
            InitializeComponent();
        }
        SqlConnection PCon = new SqlConnection(@"Data Source=.;Initial Catalog=Picture_Box_db;Integrated Security=True");

        void PCon_Open()
        {
            if (PCon.State != ConnectionState.Open)
            {
                PCon.Open();
            }
        }

        void PCon_Close()
        {
            if (PCon.State != ConnectionState.Closed)
            {
                PCon.Close();
            }
        }
        void Clear_Control()
        {
            tb_Image_ID.Clear();
            tb_Image_Description.Clear();
            pb_Add_Image.Image = null;
        }

        private void Only_numeric(object sender, KeyPressEventArgs e)
        {
                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
                {
                    e.Handled = true;
                }
            }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_Image_ID.Text != "")
            {
                PCon_Open();
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = PCon;

                Cmd.CommandText = " Select * from Tb_ImageDetails where Id = @ID";

                Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Image_ID.Text;

                SqlDataAdapter DA = new SqlDataAdapter("select * From Tb_ImageDetails where Id = " + tb_Image_ID.Text + " " , PCon);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Image_Description.Text = Dr.GetString(Dr.GetOrdinal("description"));
                    MemoryStream  ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                    pb_Add_Image.Image = new Bitmap(ms);

                }
                else
                {
                    MessageBox.Show("Inavalid ID");
                    Clear_Control();
                }

                PCon_Close();

            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Add_Image_Click(object sender, EventArgs e)
        {
            frm_Add_Image Obj = new frm_Add_Image();
            Obj.Show();
            this.Hide();
        }

        private void btn_Show_Images_Click(object sender, EventArgs e)
        {
            frm_View_Image_list Obj = new frm_View_Image_list();
            Obj.Show();
            this.Hide();
        }
    }
    }

