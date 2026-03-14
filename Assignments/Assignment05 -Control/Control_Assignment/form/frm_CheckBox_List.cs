using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Assignment
{
    public partial class frm_CheckBox_List : Form
    {
        public frm_CheckBox_List()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool flag = false, Lflag = false;

            if (tb_Name.Text != "")
            {
                Result = "The Employee " + tb_Name.Text + " is from Department ";
                lb_NameErr.Visible = false;
            }
            else
            {
                lb_NameErr.Visible = true;
                flag = true;
            }
            if (cmb_Department.Text != "")
            {
                Result += cmb_Department.Text + " is a";
                lb_DeptErr.Visible = false;
            }
            else
            {
                lb_DeptErr.Visible = true;
                flag = true;
            }
            if (rb_Male.Checked == true)
            {
                Result += " Male Employ " + "He prefered ";
                lb_GenderErr.Visible = false;
            }
            else if (rb_Female.Checked == true)
            {
                Result += " Female Employ " + "She Prefered ";
                lb_GenderErr.Visible = false;
            }
            else
            {
                lb_GenderErr.Visible = true;
                flag = true;
            }
            if (rb_Morning.Checked == true)
            {
                Result += rb_Morning.Text + " Shift." + " Employee knows Laguages Are ";
                lb_ShiftErr.Visible = false;
            }
            else if (rb_Afternoon.Checked == true)
            {
                Result += rb_Afternoon.Text + " Shift." + " Employee knows Laguages Are ";
                lb_ShiftErr.Visible = false;

            }
            else if (rb_Night.Checked == true)
            {
                Result += rb_Night.Text + " Shift." + " Employee knows Laguages Are ";
                lb_ShiftErr.Visible = false;
            }
            else
            {
                lb_ShiftErr.Visible = true;
                flag = true;
            }

            if (cb_Marathi.Checked == true)
            {
                lb_LangErr.Visible = false;
                Lflag = true;
                if(cb_Hindi.Checked == true || cb_English.Checked == true)
                {
                    Result += " " + cb_Marathi.Text + ",";
                }
                else
                {
                    Result +=  " " + cb_Marathi.Text + ".";
                }
            }
            if (cb_Hindi.Checked == true)
            {
               
                lb_LangErr.Visible = false;
                Lflag = true;
                if(cb_English.Checked == true)
                {
                    Result += " " + cb_Hindi.Text + ",";
                }
                else
                {
                    Result += " " + cb_Hindi.Text + ".";
                }
                
            }
            if (cb_English.Checked == true)
            {
                Result += " " + cb_English.Text + ".";
                lb_LangErr.Visible = false;
                Lflag = true;
            }

            if (Lflag == false)
            {
                lb_LangErr.Visible = true;

            }
             int Cnt = clb_Hobbies.CheckedItems.Count;
            if (Cnt > 0)
            {
                lb_HobErr.Visible = false;
                Result += " And Has Hobbies As ";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (Cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] += " ,";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + " .";
                            break;

                        }
                        Cnt--;
                    }
                }
            }
            else
            {
                lb_HobErr.Text = "Select Atleast 1 Hobby";
               lb_HobErr.Visible = true;
                flag = true;
            }
            ///////////////////////////////////////////
            if(flag == false && Lflag ==true)
            {
                lb_Result.Text = Result;
               
            }
            else
            {
                lb_Result.Text = "";

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
            lb_Result.Text = "";
            cb_English.Checked = false;
            cb_Hindi.Checked = false;
            cb_Marathi.Checked = false;

           for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            lb_Result.Visible = false;
        }
    }
    }

