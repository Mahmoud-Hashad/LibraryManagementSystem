using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DeleteMemberDialog : MetroFramework.Forms.MetroForm
    {
        public DeleteMemberDialog()
        {
            InitializeComponent();
            
        }
        string GMemberId = "101013";
        public DeleteMemberDialog(string MemberId): this()
        {
            GMemberId = MemberId;
            
        }
        private void DeleteMemberDialog_Load(object sender, EventArgs e)
        {
            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            GetMemberInfo();
        }

        SqlCommand sqlcom = new SqlCommand();

        private void GetMemberInfo()
        {
            try
            {
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"SELECT MemberId, Name, Email FROM Members WHERE MemberId = {GMemberId}";

                SqlDataReader Data = sqlcom.ExecuteReader();
                Data.Read();

                MemberId.Text = $"Member ID: {Data[0]}";
                MemeberName.Text = $"Member Name: {Data[1]}";
                MemberEmail.Text = $"Member Email: {Data[2]}";

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();

                Data.Close();
            } catch
            {
                 MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                //Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"DELETE FROM Members WHERE MemberId={GMemberId}";

                sqlcom.ExecuteNonQuery();

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
                Close();
                this.DialogResult = DialogResult.OK;
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }

        }

       
    }
}
