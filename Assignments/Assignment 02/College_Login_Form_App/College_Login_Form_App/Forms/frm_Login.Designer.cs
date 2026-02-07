
namespace College_Login_Form_App
{
    partial class frm_Login
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
            this.lb_Pass = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.tb_UName = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_Welcome.Location = new System.Drawing.Point(226, 22);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(306, 73);
            this.lb_Welcome.TabIndex = 4;
            this.lb_Welcome.Text = "Welcome";
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pass.Location = new System.Drawing.Point(149, 277);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(102, 24);
            this.lb_Pass.TabIndex = 6;
            this.lb_Pass.Text = "Password :";
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(149, 147);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(112, 24);
            this.lb_User.TabIndex = 5;
            this.lb_User.Text = "Username : ";
            // 
            // tb_UName
            // 
            this.tb_UName.Location = new System.Drawing.Point(351, 147);
            this.tb_UName.MaxLength = 20;
            this.tb_UName.Multiline = true;
            this.tb_UName.Name = "tb_UName";
            this.tb_UName.Size = new System.Drawing.Size(291, 30);
            this.tb_UName.TabIndex = 1;
            
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(351, 277);
            this.tb_Pass.MaxLength = 8;
            this.tb_Pass.Multiline = true;
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.PasswordChar = '*';
            this.tb_Pass.Size = new System.Drawing.Size(291, 30);
            this.tb_Pass.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(259, 406);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(109, 53);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_Message
            // 
            this.lb_Message.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.Location = new System.Drawing.Point(214, 375);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(197, 20);
            this.lb_Message.TabIndex = 7;
            this.lb_Message.Text = "Enter Valid Password &&Username";
          
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(749, 481);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_UName);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_Welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Login";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.TextBox tb_UName;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lb_Message;
    }
}

