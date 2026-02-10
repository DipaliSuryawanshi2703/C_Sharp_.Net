
namespace College_Login_Form_App.Forms
{
    partial class frm_Search_Student_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search_Student_Details));
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lb_UName = new System.Windows.Forms.Label();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_log_Out = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_RNo = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lb_Course = new System.Windows.Forms.Label();
            this.lb_DOB = new System.Windows.Forms.Label();
            this.lb_Mobile_No = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Roll_No = new System.Windows.Forms.Label();
            this.lb_Search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(696, 453);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(154, 49);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update Student";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Search.Location = new System.Drawing.Point(713, 139);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(74, 28);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lb_UName
            // 
            this.lb_UName.AutoSize = true;
            this.lb_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_UName.Location = new System.Drawing.Point(9, 10);
            this.lb_UName.Name = "lb_UName";
            this.lb_UName.Size = new System.Drawing.Size(87, 16);
            this.lb_UName.TabIndex = 50;
            this.lb_UName.Text = "Logged User";
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.LightCoral;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.Location = new System.Drawing.Point(251, 453);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(130, 49);
            this.btn_List.TabIndex = 5;
            this.btn_List.Text = "Student List";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_log_Out
            // 
            this.btn_log_Out.AutoSize = true;
            this.btn_log_Out.BackColor = System.Drawing.Color.Red;
            this.btn_log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_Out.Location = new System.Drawing.Point(817, 10);
            this.btn_log_Out.Name = "btn_log_Out";
            this.btn_log_Out.Size = new System.Drawing.Size(76, 30);
            this.btn_log_Out.TabIndex = 7;
            this.btn_log_Out.Text = "Log Out";
            this.btn_log_Out.UseVisualStyleBackColor = false;
            this.btn_log_Out.Click += new System.EventHandler(this.btn_log_Out_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(416, 321);
            this.dtp_DOB.MaxDate = new System.DateTime(2009, 6, 15, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1995, 6, 15, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(291, 31);
            this.dtp_DOB.TabIndex = 38;
            this.dtp_DOB.Value = new System.DateTime(2000, 6, 15, 0, 0, 0, 0);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Enabled = false;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmb_Course.Location = new System.Drawing.Point(416, 375);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(291, 33);
            this.cmb_Course.TabIndex = 39;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Enabled = false;
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(416, 257);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Multiline = true;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(291, 38);
            this.tb_Mob_No.TabIndex = 37;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(416, 199);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(291, 38);
            this.tb_Name.TabIndex = 36;
            // 
            // tb_RNo
            // 
            this.tb_RNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RNo.Location = new System.Drawing.Point(416, 139);
            this.tb_RNo.MaxLength = 20;
            this.tb_RNo.Multiline = true;
            this.tb_RNo.Name = "tb_RNo";
            this.tb_RNo.Size = new System.Drawing.Size(291, 38);
            this.tb_RNo.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(39, 453);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(144, 49);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(456, 453);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 49);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Add Student Details";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Add_student_Click);
            // 
            // lb_Course
            // 
            this.lb_Course.AutoSize = true;
            this.lb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Course.Location = new System.Drawing.Point(183, 378);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(93, 25);
            this.lb_Course.TabIndex = 48;
            this.lb_Course.Text = "Course :";
            // 
            // lb_DOB
            // 
            this.lb_DOB.AutoSize = true;
            this.lb_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DOB.Location = new System.Drawing.Point(183, 321);
            this.lb_DOB.Name = "lb_DOB";
            this.lb_DOB.Size = new System.Drawing.Size(81, 25);
            this.lb_DOB.TabIndex = 47;
            this.lb_DOB.Text = "D.O.B :";
            // 
            // lb_Mobile_No
            // 
            this.lb_Mobile_No.AutoSize = true;
            this.lb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mobile_No.Location = new System.Drawing.Point(183, 257);
            this.lb_Mobile_No.Name = "lb_Mobile_No";
            this.lb_Mobile_No.Size = new System.Drawing.Size(121, 25);
            this.lb_Mobile_No.TabIndex = 46;
            this.lb_Mobile_No.Text = "Mobile No :";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(183, 199);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(160, 25);
            this.lb_Name.TabIndex = 45;
            this.lb_Name.Text = "Student Name :";
            // 
            // lb_Roll_No
            // 
            this.lb_Roll_No.AutoSize = true;
            this.lb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Roll_No.Location = new System.Drawing.Point(183, 142);
            this.lb_Roll_No.Name = "lb_Roll_No";
            this.lb_Roll_No.Size = new System.Drawing.Size(100, 25);
            this.lb_Roll_No.TabIndex = 44;
            this.lb_Roll_No.Text = "Roll No : ";
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.Color.Maroon;
            this.lb_Search.Location = new System.Drawing.Point(100, 26);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(711, 73);
            this.lb_Search.TabIndex = 43;
            this.lb_Search.Text = "Search Student Details";
            // 
            // frm_Search_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(893, 537);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
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
            this.Controls.Add(this.lb_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search student Details";
            this.Load += new System.EventHandler(this.frm_Search_Student_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lb_UName;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_log_Out;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_RNo;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lb_Course;
        private System.Windows.Forms.Label lb_DOB;
        private System.Windows.Forms.Label lb_Mobile_No;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Roll_No;
        private System.Windows.Forms.Label lb_Search;
    }
}