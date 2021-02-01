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
using Transitions;

namespace LibraryManagementSystem
{
    public partial class EditBookDialog : MetroFramework.Forms.MetroForm
    {
        public EditBookDialog()
        {
            InitializeComponent();
            
        }

        SqlCommand sqlcom = new SqlCommand();
        string BookId;
        public EditBookDialog(string BookId) : this() {
            this.BookId = BookId;
        }
        private void EditBookDialog_Load(object sender, EventArgs e)
        {
            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            FillDep();
            FillStatus();
            FillOldBookData(BookId);
        }

        private void FillOldBookData(string BookId)
        {
            try
            {
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"SELECT * FROM Books INNER JOIN Departments ON Books.Department = Departments.DepId WHERE (Books.BookId = {BookId})";

                SqlDataReader Data = sqlcom.ExecuteReader();
                Data.Read();

                ISNB.Text = Data[1].ToString();
                Title.Text = Data[2].ToString();
                Author.Text = Data[3].ToString();
                Department.SelectedValue = Data[4].ToString();
                Price.Text = Data[5].ToString();
                Status.SelectedValue = Data[6].ToString();




                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch (Exception Ex)
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
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
            }catch
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
            if(System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"([A-Za-z\+*/.`=]+)$"))
            {
                e.Handled = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                try
                {
                    if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();
                    
                    //Create Connection With DataBase
                    sqlcom.Connection = LibraryDBCon;
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.CommandText = $"UPDATE Books SET ISNB = '{ISNB.Text}', Title = '{Title.Text}', Author = '{Author.Text}', Department = {Department.SelectedValue}, Price = {Price.Text}, Status = {Status.SelectedValue} WHERE BookId={BookId}";

                    sqlcom.ExecuteNonQuery();

                    if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
                    Close();
                    this.DialogResult = DialogResult.OK;
                }catch
                {
                    MessageBox.Show("Something Went Wrong, Please Check Your Data And Try Again");
                }
            }
        }

        private bool ValidData()
        {
            if (Title.Text.Trim() == "") Title.LineIdleColor = Color.Red; else Title.LineIdleColor = Color.Gray;
            if (Price.Text.Trim() == "" || Convert.ToDecimal(Price.Text) >= 0) Price.LineIdleColor = Color.Red; else Price.LineIdleColor = Color.Gray;
            if (Title.Text.Trim() == "" || Price.Text.Trim() == "")
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
