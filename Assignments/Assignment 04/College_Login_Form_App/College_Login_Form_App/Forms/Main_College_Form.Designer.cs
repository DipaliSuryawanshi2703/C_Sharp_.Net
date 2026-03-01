
namespace College_Login_Form_App.Forms
{
    partial class Main_College_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_College_Form));
            this.btn_log_Out = new System.Windows.Forms.Button();
            this.studentDetailsMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Add_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_log_Out
            // 
            this.btn_log_Out.AutoSize = true;
            this.btn_log_Out.BackColor = System.Drawing.Color.Red;
            this.btn_log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_Out.Location = new System.Drawing.Point(817, 0);
            this.btn_log_Out.Name = "btn_log_Out";
            this.btn_log_Out.Size = new System.Drawing.Size(76, 30);
            this.btn_log_Out.TabIndex = 8;
            this.btn_log_Out.Text = "Log Out";
            this.btn_log_Out.UseVisualStyleBackColor = false;
            this.btn_log_Out.Click += new System.EventHandler(this.btn_log_Out_Click);
            // 
            // studentDetailsMenuToolStripMenuItem
            // 
            this.studentDetailsMenuToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.studentDetailsMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Add_Student,
            this.studentDetailsListToolStripMenuItem,
            this.searchStudentDetailsToolStripMenuItem,
            this.updateStudentDetailsToolStripMenuItem});
            this.studentDetailsMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDetailsMenuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.studentDetailsMenuToolStripMenuItem.MergeIndex = 1;
            this.studentDetailsMenuToolStripMenuItem.Name = "studentDetailsMenuToolStripMenuItem";
            this.studentDetailsMenuToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.studentDetailsMenuToolStripMenuItem.Text = "Student Details Menu";
            // 
            // tsm_Add_Student
            // 
            this.tsm_Add_Student.BackColor = System.Drawing.Color.Gainsboro;
            this.tsm_Add_Student.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_Add_Student.MergeIndex = 2;
            this.tsm_Add_Student.Name = "tsm_Add_Student";
            this.tsm_Add_Student.Size = new System.Drawing.Size(211, 22);
            this.tsm_Add_Student.Text = "Add Student Details";
            this.tsm_Add_Student.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsm_Add_Student.Click += new System.EventHandler(this.tsm_Add_Student_Click);
            // 
            // studentDetailsListToolStripMenuItem
            // 
            this.studentDetailsListToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.studentDetailsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDetailsListToolStripMenuItem.Name = "studentDetailsListToolStripMenuItem";
            this.studentDetailsListToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.studentDetailsListToolStripMenuItem.Text = "Student Details List";
            this.studentDetailsListToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.studentDetailsListToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsListToolStripMenuItem_Click);
            // 
            // searchStudentDetailsToolStripMenuItem
            // 
            this.searchStudentDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.searchStudentDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudentDetailsToolStripMenuItem.Name = "searchStudentDetailsToolStripMenuItem";
            this.searchStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.searchStudentDetailsToolStripMenuItem.Text = "Search Student Details";
            this.searchStudentDetailsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.searchStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentDetailsToolStripMenuItem_Click);
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            this.updateStudentDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.updateStudentDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            this.updateStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.updateStudentDetailsToolStripMenuItem.Text = "Update Student Details";
            this.updateStudentDetailsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.updateStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDetailsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main_College_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.btn_log_Out);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_College_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form ";
            this.Load += new System.EventHandler(this.Main_College_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_log_Out;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Add_Student;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}