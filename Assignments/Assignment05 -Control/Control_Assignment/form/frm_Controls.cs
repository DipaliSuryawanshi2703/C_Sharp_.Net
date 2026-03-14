using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Assignment.form
{
    public partial class frm_Controls : Form
    {
        public frm_Controls()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool flag = false;
           
            if(tb_Name.Text != "")
            {
                Result = "The Employee " + tb_Name.Text + " is from Depatment ";

                if (cmb_Department.Text != "")
                {
                    Result += cmb_Department.Text + " Is ";

                    if (rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " Employee.He Preffered ";
                    }
                    else if (rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " Employee. She Prefered ";
                    }
                    else
                    {
                        MessageBox.Show("Select Gender");
                        flag = true;
                    }
                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + " Shift.";
                    }
                    else if (rb_Afternoon.Checked == true)
                    {
                        Result += rb_Afternoon.Text + " Shift.";
                    }
                    else if (rb_Night.Checked== true)
                    {
                        Result += rb_Night.Text + " Shift.";
                    }

                    else
                    {
                        MessageBox.Show("Select Shift");
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Select Department");
                    flag = true;
                }

            }
            else
            {
                MessageBox.Show("Select Employee Name");
                flag = true;
            }
            if(flag == false)
            {
                tb_Output.Text = Result;
            }
           
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            cmb_Department.SelectedIndex = -1;
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            rb_Morning.Checked = false;
            rb_Afternoon.Checked = false;
            rb_Night.Checked = false;
            tb_Output.Clear();
        }
    }
}
