namespace PizzaProjectSprint2 {
    partial class Form_SignIn {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.txtb_username = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.txtb_usernameconfirm = new System.Windows.Forms.TextBox();
            this.txtb_passwordconfirm = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_usernameconfirm = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_passwordconfirm = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(178, 125);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(178, 154);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(118, 23);
            this.btn_signup.TabIndex = 1;
            this.btn_signup.Text = "Sign up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // txtb_username
            // 
            this.txtb_username.Location = new System.Drawing.Point(178, 44);
            this.txtb_username.Name = "txtb_username";
            this.txtb_username.Size = new System.Drawing.Size(118, 20);
            this.txtb_username.TabIndex = 2;
            // 
            // txtb_password
            // 
            this.txtb_password.Location = new System.Drawing.Point(178, 96);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(118, 20);
            this.txtb_password.TabIndex = 3;
            this.txtb_password.UseSystemPasswordChar = true;
            // 
            // txtb_usernameconfirm
            // 
            this.txtb_usernameconfirm.Location = new System.Drawing.Point(178, 70);
            this.txtb_usernameconfirm.Name = "txtb_usernameconfirm";
            this.txtb_usernameconfirm.Size = new System.Drawing.Size(118, 20);
            this.txtb_usernameconfirm.TabIndex = 4;
            this.txtb_usernameconfirm.Visible = false;
            // 
            // txtb_passwordconfirm
            // 
            this.txtb_passwordconfirm.Location = new System.Drawing.Point(178, 122);
            this.txtb_passwordconfirm.Name = "txtb_passwordconfirm";
            this.txtb_passwordconfirm.Size = new System.Drawing.Size(118, 20);
            this.txtb_passwordconfirm.TabIndex = 5;
            this.txtb_passwordconfirm.UseSystemPasswordChar = true;
            this.txtb_passwordconfirm.Visible = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(93, 45);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 15);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_usernameconfirm
            // 
            this.lbl_usernameconfirm.AutoSize = true;
            this.lbl_usernameconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameconfirm.Location = new System.Drawing.Point(39, 71);
            this.lbl_usernameconfirm.Name = "lbl_usernameconfirm";
            this.lbl_usernameconfirm.Size = new System.Drawing.Size(131, 15);
            this.lbl_usernameconfirm.TabIndex = 7;
            this.lbl_usernameconfirm.Text = "Confirm Username:";
            this.lbl_usernameconfirm.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(97, 97);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(73, 15);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_passwordconfirm
            // 
            this.lbl_passwordconfirm.AutoSize = true;
            this.lbl_passwordconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordconfirm.Location = new System.Drawing.Point(43, 123);
            this.lbl_passwordconfirm.Name = "lbl_passwordconfirm";
            this.lbl_passwordconfirm.Size = new System.Drawing.Size(127, 15);
            this.lbl_passwordconfirm.TabIndex = 9;
            this.lbl_passwordconfirm.Text = "Confirm Password:";
            this.lbl_passwordconfirm.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error.Location = new System.Drawing.Point(146, 180);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(191, 13);
            this.lbl_error.TabIndex = 11;
            this.lbl_error.Text = "Incorrect Username or Password";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_error.Visible = false;
            // 
            // Form_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 213);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_passwordconfirm);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_usernameconfirm);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txtb_passwordconfirm);
            this.Controls.Add(this.txtb_usernameconfirm);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_username);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SignIn";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox txtb_username;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.TextBox txtb_usernameconfirm;
        private System.Windows.Forms.TextBox txtb_passwordconfirm;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_usernameconfirm;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_passwordconfirm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_error;
    }
}

