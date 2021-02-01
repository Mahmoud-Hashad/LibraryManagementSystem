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
    public partial class AddMemberDialog : MetroFramework.Forms.MetroForm
    {
        public AddMemberDialog()
        {
            InitializeComponent();
        }

        SqlCommand sqlcom = new SqlCommand();

        private void AddMemberDialog_Load(object sender, EventArgs e)
        {
            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            FillPrivilage();
        }

     
        private void FillPrivilage()
        {
            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = "SELECT RoleId, Role FROM Roles";

                SqlDataAdapter da = new SqlDataAdapter(sqlcom);

                DataSet ds = new DataSet();
                da.Fill(ds, "Roles");
                PrivilageCB.DisplayMember = "Role";
                PrivilageCB.ValueMember = "RoleId";
                PrivilageCB.DataSource = ds.Tables["Roles"];

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");

            }
        }

        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                try
                {

                    if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                    //Create Connection With DataBase
                    sqlcom.Connection = LibraryDBCon;
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.CommandText = $"INSERT INTO Members (MemberId, Name, Email, Phone, Privilage) Values ('{MemberIdTB.Text}', '{MemberNameTB.Text}', '{MemberEmailTB.Text}', {MemberPhoneTB.Text}, {PrivilageCB.SelectedValue})";

                    sqlcom.ExecuteNonQuery();

                    if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();

                    Close();
                    DialogResult = DialogResult.OK;
                } catch
                {
                    MessageBox.Show("Something Went Wrong, Please Try Again");
                }
            }
            
        }

        private bool ValidData()
        {
            if (MemberNameTB.Text.Trim() == "") MemberNameTB.LineIdleColor = Color.Red; else MemberNameTB.LineIdleColor = Color.Gray;
            if (MemberIdTB.Text.Trim() == "") MemberIdTB.LineIdleColor = Color.Red; else MemberIdTB.LineIdleColor = Color.Gray;
            if (MemberEmailTB.Text.Trim() == "") MemberEmailTB.LineIdleColor = Color.Red; else MemberEmailTB.LineIdleColor = Color.Gray;
            if (MemberPhoneTB.Text.Trim() == "") MemberPhoneTB.LineIdleColor = Color.Red; else MemberPhoneTB.LineIdleColor = Color.Gray;
            if (MemberNameTB.Text.Trim() == "" || MemberIdTB.Text.Trim() == "" || MemberEmailTB.Text.Trim() == "" || MemberPhoneTB.Text.Trim() == "") return false;


            MemberIdTB.Text = MemberIdTB.Text.Trim();
            MemberNameTB.Text = MemberNameTB.Text.Trim();
            MemberEmailTB.Text = MemberEmailTB.Text.Trim();
            MemberPhoneTB.Text = MemberPhoneTB.Text.Trim();

            return true;
        }

       
    }
}
