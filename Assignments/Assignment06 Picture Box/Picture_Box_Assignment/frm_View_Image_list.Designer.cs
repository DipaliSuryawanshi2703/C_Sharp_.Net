
namespace Picture_Box_Assignment
{
    partial class frm_View_Image_list
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
            this.btn_Search_Image = new System.Windows.Forms.Button();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            this.pb_Add_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Image_List = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search_Image
            // 
            this.btn_Search_Image.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Search_Image.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Image.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Search_Image.Location = new System.Drawing.Point(292, 475);
            this.btn_Search_Image.Name = "btn_Search_Image";
            this.btn_Search_Image.Size = new System.Drawing.Size(198, 50);
            this.btn_Search_Image.TabIndex = 2;
            this.btn_Search_Image.Text = "Search Images";
            this.btn_Search_Image.UseVisualStyleBackColor = false;
            this.btn_Search_Image.Click += new System.EventHandler(this.btn_Search_Image_Click);
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Add_Image.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Add_Image.Location = new System.Drawing.Point(576, 475);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(225, 50);
            this.btn_Add_Image.TabIndex = 3;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = false;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.AllowUserToAddRows = false;
            this.dgv_Image_List.AllowUserToDeleteRows = false;
            this.dgv_Image_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(532, 144);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.ReadOnly = true;
            this.dgv_Image_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Image_List.Size = new System.Drawing.Size(448, 297);
            this.dgv_Image_List.TabIndex = 1;
            this.dgv_Image_List.SelectionChanged += new System.EventHandler(this.dgv_Image_List_SelectionChanged);
            // 
            // pb_Add_Image
            // 
            this.pb_Add_Image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_Add_Image.Location = new System.Drawing.Point(49, 144);
            this.pb_Add_Image.Name = "pb_Add_Image";
            this.pb_Add_Image.Size = new System.Drawing.Size(451, 297);
            this.pb_Add_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Add_Image.TabIndex = 26;
            this.pb_Add_Image.TabStop = false;
            // 
            // lbl_Image_List
            // 
            this.lbl_Image_List.AutoSize = true;
            this.lbl_Image_List.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_List.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image_List.Location = new System.Drawing.Point(743, 102);
            this.lbl_Image_List.Name = "lbl_Image_List";
            this.lbl_Image_List.Size = new System.Drawing.Size(92, 22);
            this.lbl_Image_List.TabIndex = 23;
            this.lbl_Image_List.Text = "Image List";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Image.Location = new System.Drawing.Point(181, 102);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(59, 22);
            this.lbl_Image.TabIndex = 24;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Uighur", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(392, 42);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(170, 56);
            this.lbl_Header.TabIndex = 25;
            this.lbl_Header.Text = "Show Image";
            // 
            // frm_View_Image_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 537);
            this.Controls.Add(this.btn_Search_Image);
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.pb_Add_Image);
            this.Controls.Add(this.lbl_Image_List);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Image_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Image_list";
            this.Load += new System.EventHandler(this.frm_View_Image_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search_Image;
        private System.Windows.Forms.Button btn_Add_Image;
        private System.Windows.Forms.DataGridView dgv_Image_List;
        private System.Windows.Forms.PictureBox pb_Add_Image;
        private System.Windows.Forms.Label lbl_Image_List;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Header;
    }
}