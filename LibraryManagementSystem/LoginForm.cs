using MaterialSkin.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Security.Cryptography;

namespace LibraryManagementSystem
{
    public partial class LoginForm : MetroForm
    {
        

        static public string UserName;
       
        public LoginForm()
        {
            InitializeComponent();

            
        }


        SqlCommand sqlcom = new SqlCommand();
        private void LoginForm_Load(object sender, EventArgs e)
        {

            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        }



        private string GenerateHash(string value)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(value);
            data = System.Security.Cryptography.MD5.Create().ComputeHash(data);
            return Convert.ToBase64String(data);
        }


        private void UserLogin(object sender, EventArgs e)
        {
            var hashedPass = GenerateHash(PasswordTB.Text);


            //MessageBox.Show(LibraryDBCon.ServerVersion);
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();
          
                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"SELECT FullName FROM Librarians WHERE UserName = '{UserNameTB.Text}' AND PassHash = '{hashedPass}'";

                SqlDataReader DR = sqlcom.ExecuteReader();


                if (DR.Read())
                {
                    // Set The Id To Static To Be Avilabile To The Other Forms
                    UserName = DR[0].ToString();

                    DashBoard Admin = new DashBoard();
                    this.Hide();
                    // Reset User Name And Password Field
                    UserNameTB.ResetText();
                    PasswordTB.ResetText();

                    if (Admin.ShowDialog() == DialogResult.OK)
                        this.Show();
                    else
                        this.Close();




                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Worng Name or Password.", "Error Message", 100);
                }

                // Close Data Reader
                DR.Close();

                // Close DataBase Connection 
                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            

        }
    }
}
