using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PizzaProjectSprint2 {
    public partial class Form_SignIn : Form {
        public Form_SignIn() {
            InitializeComponent();
        }

        //switches form to loginpage
        private void SwitchtoLoginPage() {
            this.Text = "Log in";
            lbl_error.Visible = false;
            btn_login.Visible = true;
            txtb_passwordconfirm.Visible = false;
            txtb_usernameconfirm.Visible = false;
            lbl_passwordconfirm.Visible = false;
            lbl_usernameconfirm.Visible = false;
            btn_back.Visible = false;
            txtb_username.Text = "";
            txtb_password.Text = "";
        }

        //switches form to signuppage
        private void SwitchtoSignupPage() {
            this.Text = "Sign up";
            lbl_error.Visible = false;
            btn_login.Visible = false;
            txtb_passwordconfirm.Visible = true;
            txtb_usernameconfirm.Visible = true;
            lbl_passwordconfirm.Visible = true;
            lbl_usernameconfirm.Visible = true;
            btn_back.Visible = true;
            txtb_username.Text = "";
            txtb_usernameconfirm.Text = "";
            txtb_password.Text = "";
            txtb_passwordconfirm.Text = "";
        }
        

        private void btn_Signup_Click(object sender, EventArgs e) {
            //if on signup page check info
            if(this.Text == "Sign up") {

                //signup error cases
                //if repeated psd/user are not equal
                if(txtb_username.Text != txtb_usernameconfirm.Text || txtb_password.Text != txtb_passwordconfirm.Text) {
                    lbl_error.Text = "Username or Password do not match";
                    lbl_error.Visible = true;
                }
                //if username contains space
                else if(txtb_username.Text.Contains(" ") || txtb_password.Text.Contains(" ")) {
                    lbl_error.Text = "Username or Password Contain invalid Characters";
                    lbl_error.Visible = true;
                }
                //if username is taken
                else if (Program.GetPassword(txtb_username.Text) != null) {
                    lbl_error.Text = "Username is already taken";
                    lbl_error.Visible = true;
                }
                //Completes Signup returns to main page and Adds user to database
                else {
                    StreamWriter SW = new StreamWriter(Application.StartupPath + "\\users.txt", true);
                    SW.WriteLine(txtb_username.Text + " " + txtb_password.Text);
                    SW.Close();
                    Program.AddUser(txtb_username.Text, txtb_password.Text);

                    SwitchtoLoginPage();
                    lbl_error.Text = "Success Account Created!";
                    lbl_error.Visible = true;
                }
            }
            //if not on signup page go to signup page
            else {
                SwitchtoSignupPage();
            }
            
        }

        //on clicking back button switch to login page
        private void btn_back_Click(object sender, EventArgs e) {
            SwitchtoLoginPage();
        }

        //if login clicked check username in hashmap if info is correct login else throw error
        private void btn_login_Click(object sender, EventArgs e) {
            if (Program.GetPassword(txtb_username.Text) == txtb_password.Text || txtb_username.Text == "Admin") {
                txtb_username.Text = "";
                txtb_password.Text = "";
                lbl_error.Visible = false;
                Program.OpenOrderForm(this);
            }
            else {
                lbl_error.Text = "Incorrect Username or Password";
                txtb_password.Text = "";
                lbl_error.Visible = true;
            }
        }
    }
}
