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
    public partial class EditMemberDialog : MetroFramework.Forms.MetroForm
    {
        public EditMemberDialog()
        {
            InitializeComponent();
        }
        public EditMemberDialog(String MemberId):this()
        {
            this.GMemberId = MemberId;
        }

       

        String GMemberId = "101012"; 

        private void EditMemberDialog_Load(object sender, EventArgs e)
        {
            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            FillPrivilage();
            FillOldMemberData("0");
        }

        SqlCommand sqlcom = new SqlCommand();

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
                MemberPrivilageTB.DisplayMember = "Role";
                MemberPrivilageTB.ValueMember = "RoleId";
                MemberPrivilageTB.DataSource = ds.Tables["Roles"];

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void FillOldMemberData(string BookId)
        {
            try
            {
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"SELECT * FROM Members WHERE Members.MemberId = {GMemberId}";

                SqlDataReader Data = sqlcom.ExecuteReader();
                Data.Read();

                MemberIdTB.Text = Data[0].ToString();
                MemberNameTB.Text = Data[1].ToString();
                MemberEmailTB.Text = Data[2].ToString();
                MemberPhoneTB.Text = Data[3].ToString();
                MemberPrivilageTB.SelectedValue = Data[4].ToString();

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
                Data.Close();
            } catch(Exception ex)
            {
                 MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void NumberOnlyField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(ValidData()) { 
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();
                try
                {
                    //Create Connection With DataBase
                    sqlcom.Connection = LibraryDBCon;
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.CommandText = $"UPDATE Members SET MemberId = {MemberIdTB.Text}, Name = '{MemberNameTB.Text}', Email = '{MemberEmailTB.Text}', Phone = '{MemberPhoneTB.Text}', Privilage = {MemberPrivilageTB.SelectedValue} WHERE MemberId = {GMemberId}";
                    sqlcom.ExecuteNonQuery();
                } catch (Exception Ex)
                {
                    MessageBox.Show("Something Went Wrong, Please Check Your Data And Try Again");
                }
                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
                Close();
                this.DialogResult = DialogResult.OK;
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
