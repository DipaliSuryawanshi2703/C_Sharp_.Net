
namespace College_Login_Form_App
{
    partial class Frm_Students_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.lb_Roll_No = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Mobile_No = new System.Windows.Forms.Label();
            this.lb_DOB = new System.Windows.Forms.Label();
            this.lb_Course = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_RNo = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_log_Out = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.lb_UName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.ForeColor = System.Drawing.Color.Maroon;
            this.lb_Welcome.Location = new System.Drawing.Point(229, 9);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(306, 73);
            this.lb_Welcome.TabIndex = 9;
            this.lb_Welcome.Text = "Welcome";
            // 
            // lb_Roll_No
            // 
            this.lb_Roll_No.AutoSize = true;
            this.lb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Roll_No.Location = new System.Drawing.Point(155, 122);
            this.lb_Roll_No.Name = "lb_Roll_No";
            this.lb_Roll_No.Size = new System.Drawing.Size(72, 20);
            this.lb_Roll_No.TabIndex = 10;
            this.lb_Roll_No.Text = "Roll No : ";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(155, 174);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(120, 20);
            this.lb_Name.TabIndex = 11;
            this.lb_Name.Text = "Student Name :";
            // 
            // lb_Mobile_No
            // 
            this.lb_Mobile_No.AutoSize = true;
            this.lb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mobile_No.Location = new System.Drawing.Point(155, 230);
            this.lb_Mobile_No.Name = "lb_Mobile_No";
            this.lb_Mobile_No.Size = new System.Drawing.Size(87, 20);
            this.lb_Mobile_No.TabIndex = 12;
            this.lb_Mobile_No.Text = "Mobile No :";
            // 
            // lb_DOB
            // 
            this.lb_DOB.AutoSize = true;
            this.lb_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DOB.Location = new System.Drawing.Point(155, 281);
            this.lb_DOB.Name = "lb_DOB";
            this.lb_DOB.Size = new System.Drawing.Size(60, 20);
            this.lb_DOB.TabIndex = 13;
            this.lb_DOB.Text = "D.O.B :";
            // 
            // lb_Course
            // 
            this.lb_Course.AutoSize = true;
            this.lb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Course.Location = new System.Drawing.Point(155, 338);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(68, 20);
            this.lb_Course.TabIndex = 14;
            this.lb_Course.Text = "Course :";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(611, 423);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(118, 41);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(75, 423);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(113, 41);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_RNo
            // 
            this.tb_RNo.Enabled = false;
            this.tb_RNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RNo.Location = new System.Drawing.Point(354, 119);
            this.tb_RNo.MaxLength = 20;
            this.tb_RNo.Multiline = true;
            this.tb_RNo.Name = "tb_RNo";
            this.tb_RNo.Size = new System.Drawing.Size(291, 25);
            this.tb_RNo.TabIndex = 1;
            this.tb_RNo.TextChanged += new System.EventHandler(this.tb_RNo_TextChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(354, 174);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(291, 25);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Letter);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(354, 230);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Multiline = true;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(291, 25);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "Bcs",
            "Bcom",
            "Bsc",
            "BA",
            "BCA",
            "Msc",
            "MBA",
            "M.tech"});
            this.cmb_Course.Location = new System.Drawing.Point(354, 335);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(291, 28);
            this.cmb_Course.TabIndex = 5;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(354, 281);
            this.dtp_DOB.MaxDate = new System.DateTime(2009, 6, 15, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1995, 6, 15, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(288, 26);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.Value = new System.DateTime(2000, 6, 15, 0, 0, 0, 0);
            // 
            // btn_log_Out
            // 
            this.btn_log_Out.AutoSize = true;
            this.btn_log_Out.BackColor = System.Drawing.Color.Red;
            this.btn_log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_Out.Location = new System.Drawing.Point(723, 9);
            this.btn_log_Out.Name = "btn_log_Out";
            this.btn_log_Out.Size = new System.Drawing.Size(76, 30);
            this.btn_log_Out.TabIndex = 8;
            this.btn_log_Out.Text = "Log Out";
            this.btn_log_Out.UseVisualStyleBackColor = false;
            this.btn_log_Out.Click += new System.EventHandler(this.btn_log_Out_Click);
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.LightCoral;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.Location = new System.Drawing.Point(339, 423);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(113, 41);
            this.btn_List.TabIndex = 15;
            this.btn_List.Text = "Student List";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.Student_List_Click);
            // 
            // lb_UName
            // 
            this.lb_UName.AutoSize = true;
            this.lb_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_UName.Location = new System.Drawing.Point(12, 17);
            this.lb_UName.Name = "lb_UName";
            this.lb_UName.Size = new System.Drawing.Size(87, 16);
            this.lb_UName.TabIndex = 16;
            this.lb_UName.Text = "Logged User";
            // 
            // Frm_Students_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.lb_UName);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.btn_log_Out);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_RNo);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lb_Course);
            this.Controls.Add(this.lb_DOB);
            this.Controls.Add(this.lb_Mobile_No);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_Roll_No);
            this.Controls.Add(this.lb_Welcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Students_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Frm_Students_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label lb_Roll_No;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Mobile_No;
        private System.Windows.Forms.Label lb_DOB;
        private System.Windows.Forms.Label lb_Course;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_RNo;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button btn_log_Out;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Label lb_UName;
    }
}