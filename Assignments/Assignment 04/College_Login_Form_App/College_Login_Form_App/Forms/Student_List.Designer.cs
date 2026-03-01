
namespace College_Login_Form_App
{
    partial class Student_List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_List));
            this.lb_List = new System.Windows.Forms.Label();
            this.dgv_Student_list = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.college_Management_SystemDataSet = new College_Login_Form_App.College_Management_SystemDataSet();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_UName = new System.Windows.Forms.Label();
            this.student_DetailsTableAdapter = new College_Login_Form_App.College_Management_SystemDataSetTableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.college_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_List
            // 
            this.lb_List.AutoSize = true;
            this.lb_List.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_List.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_List.Location = new System.Drawing.Point(219, 9);
            this.lb_List.Name = "lb_List";
            this.lb_List.Size = new System.Drawing.Size(384, 73);
            this.lb_List.TabIndex = 4;
            this.lb_List.Text = "Student List";
            // 
            // dgv_Student_list
            // 
            this.dgv_Student_list.AllowUserToAddRows = false;
            this.dgv_Student_list.AllowUserToDeleteRows = false;
            this.dgv_Student_list.AutoGenerateColumns = false;
            this.dgv_Student_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Student_list.ColumnHeadersHeight = 30;
            this.dgv_Student_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_Student_list.DataSource = this.studentDetailsBindingSource1;
            this.dgv_Student_list.Location = new System.Drawing.Point(12, 102);
            this.dgv_Student_list.Name = "dgv_Student_list";
            this.dgv_Student_list.ReadOnly = true;
            this.dgv_Student_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv_Student_list.Size = new System.Drawing.Size(869, 417);
            this.dgv_Student_list.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RollNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "RollNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Student_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mobile_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mobile_No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn4.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn5.HeaderText = "Course";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.college_Management_SystemDataSet;
            // 
            // college_Management_SystemDataSet
            // 
            this.college_Management_SystemDataSet.DataSetName = "College_Management_SystemDataSet";
            this.college_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_UName
            // 
            this.lb_UName.AutoSize = true;
            this.lb_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_UName.Location = new System.Drawing.Point(9, 9);
            this.lb_UName.Name = "lb_UName";
            this.lb_UName.Size = new System.Drawing.Size(87, 16);
            this.lb_UName.TabIndex = 9;
            this.lb_UName.Text = "Logged User";
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(893, 531);
            this.Controls.Add(this.lb_UName);
            this.Controls.Add(this.dgv_Student_list);
            this.Controls.Add(this.lb_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.college_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_List;
        private System.Windows.Forms.DataGridView dgv_Student_list;
      
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lb_UName;
        private College_Management_SystemDataSet college_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private College_Management_SystemDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}