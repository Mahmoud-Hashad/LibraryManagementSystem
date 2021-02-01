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
    public partial class AddBookDialog : MetroFramework.Forms.MetroForm
    {
        SqlCommand sqlcom = new SqlCommand();

        public AddBookDialog()
        {
            InitializeComponent();
        }

        private void AddBookDialog_Load(object sender, EventArgs e)
        {
            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            FillDep();
            FillStatus();
        }
        private void FillDep()
        {
            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = "SELECT DepId, DepName FROM Departments";


                SqlDataAdapter da = new SqlDataAdapter(sqlcom);

                DataSet ds = new DataSet();
                da.Fill(ds, "Department");
                Department.DisplayMember = "DepName";
                Department.ValueMember = "DepID";
                Department.DataSource = ds.Tables["Department"];

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }
        private void FillStatus()
        {
            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = "SELECT StatusId, Status FROM Status";


                SqlDataAdapter da = new SqlDataAdapter(sqlcom);

                DataSet ds = new DataSet();
                da.Fill(ds, "Status");
                Status.DisplayMember = "Status";
                Status.ValueMember = "StatusId";
                Status.DataSource = ds.Tables["Status"];

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Bunifu.Framework.UI.BunifuMaterialTextbox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ISNB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"([A-Za-z\+*/.`=]+)$"))
            {
                e.Handled = true;
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                try
                {
                    if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                    //Create Connection With DataBase
                    sqlcom.Connection = LibraryDBCon;
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.CommandText = $"INSERT INTO Books (ISNB, Title, Author, Department, Price, Status) Values ('{ISNB.Text}', '{Title.Text}', '{Author.Text}', {Department.SelectedValue}, {Price.Text}, {Status.SelectedValue})";

                    sqlcom.ExecuteNonQuery();

                    if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Something Went Wrong, Please Try Again");
                }
            }
            
        }

        private bool ValidData()
        {
            if (Title.Text.Trim() == "") Title.LineIdleColor = Color.Red; else Title.LineIdleColor = Color.Gray;
            if (Price.Text.Trim() == "" || Convert.ToDecimal(Price.Text) < 0) Price.LineIdleColor = Color.Red; else Price.LineIdleColor = Color.Gray;
            if(Title.Text.Trim() == "" || Price.Text.Trim() == "")
                return false;

            if (ISNB.Text.Trim() == "") ISNB.Text = "Not Set";
            if (Author.Text.Trim() == "") Author.Text = "Not Set";
            ISNB.Text = ISNB.Text.Trim();
            Title.Text = Title.Text.Trim();
            Author.Text = Author.Text.Trim();
            Price.Text = Price.Text.Trim();

            return true;
        }
    }
}
