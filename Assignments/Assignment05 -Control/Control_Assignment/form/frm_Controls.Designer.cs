
namespace Control_Assignment.form
{
    partial class frm_Controls
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
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Shift = new System.Windows.Forms.Label();
            this.lb_Depatment = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Afternoon = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.lb_Employ_Details = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.lb_Output = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Shift_Time.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "R&D",
            "Analytical",
            "QC",
            "QA"});
            this.cmb_Department.Location = new System.Drawing.Point(217, 156);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(346, 32);
            this.cmb_Department.TabIndex = 27;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(217, 87);
            this.tb_Name.MaxLength = 70;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(346, 29);
            this.tb_Name.TabIndex = 20;
            // 
            // lb_Shift
            // 
            this.lb_Shift.AutoSize = true;
            this.lb_Shift.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Shift.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_Shift.Location = new System.Drawing.Point(52, 301);
            this.lb_Shift.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Shift.Name = "lb_Shift";
            this.lb_Shift.Size = new System.Drawing.Size(103, 24);
            this.lb_Shift.TabIndex = 24;
            this.lb_Shift.Text = "Shift Time";
            // 
            // lb_Depatment
            // 
            this.lb_Depatment.AutoSize = true;
            this.lb_Depatment.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Depatment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_Depatment.Location = new System.Drawing.Point(52, 159);
            this.lb_Depatment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Depatment.Name = "lb_Depatment";
            this.lb_Depatment.Size = new System.Drawing.Size(108, 24);
            this.lb_Depatment.TabIndex = 23;
            this.lb_Depatment.Text = "Department";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_Gender.Location = new System.Drawing.Point(52, 222);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(69, 24);
            this.lb_Gender.TabIndex = 22;
            this.lb_Gender.Text = "Gender";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_Name.Location = new System.Drawing.Point(52, 87);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(147, 24);
            this.lb_Name.TabIndex = 21;
            this.lb_Name.Text = "Employee Name";
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb_Shift_Time.Controls.Add(this.rb_Night);
            this.gb_Shift_Time.Controls.Add(this.rb_Afternoon);
            this.gb_Shift_Time.Controls.Add(this.rb_Morning);
            this.gb_Shift_Time.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Shift_Time.Location = new System.Drawing.Point(217, 301);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(346, 67);
            this.gb_Shift_Time.TabIndex = 26;
            this.gb_Shift_Time.TabStop = false;
            this.gb_Shift_Time.Text = "Shift Time";
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Location = new System.Drawing.Point(274, 24);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(63, 22);
            this.rb_Night.TabIndex = 14;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Afternoon
            // 
            this.rb_Afternoon.AutoSize = true;
            this.rb_Afternoon.Location = new System.Drawing.Point(134, 24);
            this.rb_Afternoon.Name = "rb_Afternoon";
            this.rb_Afternoon.Size = new System.Drawing.Size(92, 22);
            this.rb_Afternoon.TabIndex = 13;
            this.rb_Afternoon.TabStop = true;
            this.rb_Afternoon.Text = "Afternoon";
            this.rb_Afternoon.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Location = new System.Drawing.Point(31, 24);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(83, 22);
            this.rb_Morning.TabIndex = 12;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(217, 222);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(346, 64);
            this.gb_Gender.TabIndex = 25;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(234, 24);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(72, 22);
            this.rb_Female.TabIndex = 12;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(45, 24);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(58, 22);
            this.rb_Male.TabIndex = 11;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // lb_Employ_Details
            // 
            this.lb_Employ_Details.AutoSize = true;
            this.lb_Employ_Details.BackColor = System.Drawing.Color.MistyRose;
            this.lb_Employ_Details.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Employ_Details.ForeColor = System.Drawing.Color.Teal;
            this.lb_Employ_Details.Location = new System.Drawing.Point(310, 14);
            this.lb_Employ_Details.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Employ_Details.Name = "lb_Employ_Details";
            this.lb_Employ_Details.Size = new System.Drawing.Size(362, 50);
            this.lb_Employ_Details.TabIndex = 19;
            this.lb_Employ_Details.Text = "Employee Details";
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(120, 480);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(879, 29);
            this.tb_Output.TabIndex = 32;
            // 
            // lb_Output
            // 
            this.lb_Output.AutoSize = true;
            this.lb_Output.BackColor = System.Drawing.Color.LightBlue;
            this.lb_Output.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Output.ForeColor = System.Drawing.Color.Maroon;
            this.lb_Output.Location = new System.Drawing.Point(22, 483);
            this.lb_Output.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Output.Name = "lb_Output";
            this.lb_Output.Size = new System.Drawing.Size(67, 24);
            this.lb_Output.TabIndex = 31;
            this.lb_Output.Text = "Output";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(664, 405);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 48);
            this.btn_Save.TabIndex = 30;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(150, 405);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(135, 48);
            this.btn_Refresh.TabIndex = 29;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1002, 539);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.lb_Output);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Shift);
            this.Controls.Add(this.lb_Depatment);
            this.Controls.Add(this.lb_Gender);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.lb_Employ_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Controls";
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Shift;
        private System.Windows.Forms.Label lb_Depatment;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Afternoon;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label lb_Employ_Details;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Label lb_Output;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
    }
}