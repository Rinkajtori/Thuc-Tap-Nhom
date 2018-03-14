using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static int checkAceccpt = 0;
        public static string userName = "";
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }


    

        private void staffRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userText.Text.Length != 0 && passText.Text.Length != 0)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userText.Text.Length != 0 && passText.Text.Length != 0)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        private void userText_TextChanged(object sender, EventArgs e)
        {
            
            if (userText.Text.Length != 0 && passText.Text.Length != 0)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        private void passText_TextChanged(object sender, EventArgs e)
        {
            
            if (userText.Text.Length != 0 && passText.Text.Length != 0)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        private Boolean checkAccess()
        {
            string query = "SELECT COUNT(*) FROM dbo.Users WHERE (userName = @ID AND passWord = @pass)";
            string queryCheck = "SELECT phanQuyen FROM dbo.Users WHERE (userName = @ID AND passWord = @pass)";
            string queryGetPass="SELECT passWord FROM dbo.Users WHERE (userName = @ID AND passWord = @pass)";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@ID", userText.Text));
                command.Parameters.Add(new SqlParameter("@pass", passText.Text));
                int check = (int)command.ExecuteScalar();
                if (check == 1)
                {
                    SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                    commandCheck.Parameters.Add(new SqlParameter("@ID", userText.Text));
                    commandCheck.Parameters.Add(new SqlParameter("@pass", passText.Text));
                    checkAceccpt = (int)commandCheck.ExecuteScalar();
                    if ((checkAceccpt == 1 && adminRadioButton.Checked == true) || (checkAceccpt == 2 && staffRadioButton.Checked == true))
                    {   
                        SqlCommand commandGetPass = new SqlCommand(queryGetPass, connection);
                        commandGetPass.Parameters.Add(new SqlParameter("@ID", userText.Text));
                        commandGetPass.Parameters.Add(new SqlParameter("@pass", passText.Text));
                        string tempPass = commandGetPass.ExecuteScalar().ToString();
                        //MessageBox.Show(" " + String.Compare(tempPass, passText.Text));
                        if (String.Compare(tempPass, passText.Text)==0)
                        {
                            return true;
                        }
                        else
                        {                            
                            return false;
                           
                        }
                    }
                    else
                    {
                        return false;
                    }

                    
                }                             
                return false;                
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (checkAccess())
            {
                userName = userText.Text;
                MessageBox.Show("Đăng nhập thành công !!");
                this.Close();
            }
            else
            {
                statusLabel.Text = "Tên đăng nhập hoặc mật khẩu sai !!";
                passText.Text = "";
                checkAceccpt = 0;
            }
        }

        private void checkHiddenPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHiddenPass.Checked)
            {
                passText.UseSystemPasswordChar = false;
            }
            else
            {
                passText.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
