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
    public partial class frm_View_Image_list : Form
    {
        public frm_View_Image_list()
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
        private void btn_Search_Image_Click(object sender, EventArgs e)
        {
            frm_Search_Image Obj = new frm_Search_Image();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_Image_Click(object sender, EventArgs e)
        {
            frm_Add_Image obj = new frm_Add_Image();
            obj.Show();
            this.Hide();
        }

       void Bind_Grid(string Query, DataGridView DGV)
        {
            PCon_Open();
            DGV.DataSource = "";

            SqlDataAdapter DA = new SqlDataAdapter(Query, PCon);

            DataTable DT = new DataTable();

            DA.Fill(DT);
            DGV.DataSource = DT;
            PCon_Close();
        }

        void View_Image(string Query, PictureBox pb)
        {
            PCon_Open();

            SqlDataAdapter Da = new SqlDataAdapter(Query,PCon);
            DataSet Ds = new DataSet();

            Da.Fill(Ds);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream MS = new MemoryStream((byte[])Ds.Tables[0].Rows[0]["Image"]);
                pb.Image = new Bitmap(MS);
            }
            else
            {
                MessageBox.Show("Invalid Image ID!!!");
            }

            PCon_Close();
        }

      

        private void frm_View_Image_list_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select Id ,description from Tb_ImageDetails", dgv_Image_List);
        }

        private void dgv_Image_List_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectRowCount = dgv_Image_List.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(selectRowCount == 1)
            {
                int index = dgv_Image_List.SelectedCells[0].RowIndex;
                int ID = Convert.ToInt32(dgv_Image_List.Rows[index].Cells[0].Value);

                View_Image("Select Image from Tb_ImageDetails where Id = " + ID + "", pb_Add_Image);
            }
        }
    }
}
