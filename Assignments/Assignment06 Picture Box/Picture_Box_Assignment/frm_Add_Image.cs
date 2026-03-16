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

namespace Picture_Box_Assignment
{
    public partial class frm_Add_Image : Form
    {
        public frm_Add_Image()
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
            if(PCon.State != ConnectionState.Closed)
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

       

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
        private void frm_Add_Image_Load(object sender, EventArgs e)
        {
            tb_Image_ID.Focus();
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Img = new OpenFileDialog();

            Img.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";

            if(Img.ShowDialog() == DialogResult.OK)
            {
                pb_Add_Image.Image =new  Bitmap(Img.FileName);
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            PCon_Open();
            if(tb_Image_ID.Text != "" && tb_Image_Description.Text !="" && pb_Add_Image.Image != null)
            {
                SqlCommand cmd = new SqlCommand("Insert Into Tb_ImageDetails Values(@Id , @ImgDetails, @Image) ", PCon);

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = tb_Image_ID.Text;
                cmd.Parameters.Add("@ImgDetails", SqlDbType.NVarChar).Value = tb_Image_Description.Text;

                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Add_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully");
                Clear_Control();

            }
            else
            {
                MessageBox.Show("First Fill All Fields");

            }
            PCon_Close();

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Search_Image_Click(object sender, EventArgs e)
        {
            frm_Search_Image obj = new frm_Search_Image();
            obj.Show();
            this.Hide();

        }

        private void btn_Show_Images_Click(object sender, EventArgs e)
        {
            frm_View_Image_list obj = new frm_View_Image_list();
            obj.Show();
            this.Hide();
        }

        private void btn_Browse_MouseHover(object sender, EventArgs e)
        {
            btn_Browse.BackColor = Color.Red;
        }

        private void btn_Browse_MouseLeave(object sender, EventArgs e)
        {
            btn_Browse.BackColor = Color.Teal;
        }
    }
}