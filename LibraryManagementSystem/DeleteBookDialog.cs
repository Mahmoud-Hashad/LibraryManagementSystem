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
    public partial class DeleteBookDialog : MetroFramework.Forms.MetroForm
    {
        public DeleteBookDialog()
        {
            InitializeComponent();
        }
        string BookId;

        public DeleteBookDialog(string BookId) : this()
        {
            
            this.BookId = BookId;
        }

        private void DeleteBookDialog_Load(object sender, EventArgs e)
        {
            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            GetBookInfo(BookId);
        }

        SqlCommand  sqlcom = new SqlCommand();

        void GetBookInfo(string bookId)
        {
            if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

            // Create Connection With DataBase
            sqlcom.Connection = LibraryDBCon;
            sqlcom.CommandType = CommandType.Text;
            sqlcom.CommandText = $"SELECT Books.ISNB, Books.Title, Departments.DepName FROM Books INNER JOIN Departments ON Books.Department = Departments.DepId WHERE (Books.BookId = {bookId})";

            SqlDataReader Data = sqlcom.ExecuteReader();
            Data.Read();

            BookISNB.Text = $"Book ISNB: {Data[0]}";
            BookTitle.Text = $"Book Title: {Data[1]}";
            BookDepartment.Text = $"Book Department: {Data[2]}";



            if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();

            Data.Close();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                //Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"DELETE FROM Books WHERE BookId={BookId}";

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
