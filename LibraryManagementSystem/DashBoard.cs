using MetroFramework.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
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
    public partial class DashBoard : MetroForm
    {
        public DashBoard()
        {
            InitializeComponent();
        }



        SqlCommand sqlcom = new SqlCommand();
        String VisitsId;
        String VisitMemberId;

        // Dash Board Load Event
        private void DashBoard_Load(object sender, EventArgs e)
        {
            LibraryDBCon.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;


            // Set The Name And The State Of The User To the Form
            UserNameL.Text = LoginForm.UserName;

            // Fill books Tab
            FillBooksTable();

            FillVisitsTable();

            FillMembersTable();

            FillBooksStatusComBox();
            FillBooksDepartmentComBox();
            FillMemberPrivilageComBox();

            BookSearchType.SelectedIndex = 1;
            MemberSearchType.SelectedIndex = 1;


            BooksTab.BringToFront();

            PDFSaveDialog.Filter = "PDF Files|*.pdf";
           
        }


        #region Books Tab Functions
        // fill the Books Data Grid View 
        void FillBooksTable()
        {
            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = "SELECT Books.BookId, Books.ISNB, Books.Title As 'Book Title', Books.Author, Departments.DepName AS 'Department', Books.Price, Status.Status FROM Books INNER JOIN Departments ON Books.Department = Departments.DepId INNER JOIN Status ON Books.Status = Status.StatusId";



                // Get The Data From DataBase Base And Set It Into DataGridView(Books Table)
                SqlDataAdapter DA = new SqlDataAdapter(sqlcom);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                BooksTable.ReadOnly = true;
                BooksTable.Columns.Clear();
                BooksTable.DataSource = DT;


                // Add Edit And Delete Buttons At the End Of The Table
                BooksTable.Columns.Add("Edit", "Edit");
                BooksTable.Columns.Add("Delete.", "Delete");

                // Hide Book Id Collums
                BooksTable.Columns[0].Visible = false;

                // Set The width Of Some Columns

                BooksTable.Columns[2].Width = 250;  // Book Title
                BooksTable.Columns[7].Width = 50;   // Edit Btn
                BooksTable.Columns[8].Width = 60;   // Delete Btn

                // Close Database
                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        // Set Image At Books Table
        private void Booksgrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 7
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.file.Width;
                var h = Properties.Resources.file.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.file, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            else if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void FillBooksDepartmentComBox()
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
                // Add general Option At Top
                DataTable dt = new DataTable("Departments");
                dt.Columns.Add(new DataColumn("DepId", typeof(int)));
                dt.Columns.Add(new DataColumn("DepName", typeof(string)));

                DataRow dr = dt.NewRow();
                dr["DepId"] = 0;
                dr["DepName"] = "All Departments";
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);

                da.Fill(ds, "Departments");
                BookDepComBox.DisplayMember = "DepName";
                BookDepComBox.ValueMember = "DepId";
                BookDepComBox.DataSource = ds.Tables["Departments"];

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void FillBooksStatusComBox()
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
                // Add general Option At Top
                DataTable dt = new DataTable("Status");
                dt.Columns.Add(new DataColumn("StatusId", typeof(int)));
                dt.Columns.Add(new DataColumn("Status", typeof(string)));

                DataRow dr = dt.NewRow();
                dr["StatusId"] = 0;
                dr["Status"] = "All Status";
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);

                da.Fill(ds, "Status");
                BookStatusComBox.DisplayMember = "Status";
                BookStatusComBox.ValueMember = "StatusId";
                BookStatusComBox.DataSource = ds.Tables["Status"];

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void BoocksTable_BtnsClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if ((e.ColumnIndex == 7 || e.ColumnIndex == 8) &&
                e.RowIndex >= 0)
            {

                switch (e.ColumnIndex)
                {
                    case 7:
                        // EditBook($"{senderGrid.Rows[e.RowIndex].Cells[0].Value}")
                        EditBook($"{senderGrid.Rows[e.RowIndex].Cells[0].Value}");
                        break;
                    case 8:
                        DeleteBook($"{senderGrid.Rows[e.RowIndex].Cells[0].Value}");

                        break;
                }
            }
        }

        private void EditBook(string BookId)
        {
            EditBookDialog dialog = new EditBookDialog(BookId);
            if (dialog.ShowDialog() == DialogResult.OK)
                FillBooksTable();
        }

        private void DeleteBook(string BookId)
        {
            DeleteBookDialog confirmMessage = new DeleteBookDialog(BookId);

            if (confirmMessage.ShowDialog() == DialogResult.OK)
                FillBooksTable();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBookDialog dialog = new AddBookDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FillBooksTable();
            }
        }

        private void BookSearch(object sender, EventArgs e)
        {
            string SearchColumn = BookSearchType.SelectedItem.ToString().Split(' ')[1];
            string SearchWord = BookSearchTB.Text.Trim();
            string SearchDep = (BookDepComBox.SelectedValue.ToString() == "0") ? "" : $" AND (Books.Department = {BookDepComBox.SelectedValue.ToString()})";
            string SearchStatus = ((BookStatusComBox.SelectedValue.ToString() == "0") ? "" : $" AND (Books.Status = {BookStatusComBox.SelectedValue.ToString()})");


            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();


                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"SELECT Books.BookId, Books.ISNB, Books.Title AS 'Book Title', Books.Author, Departments.DepName AS 'Department', Books.Price, Status.Status FROM Books INNER JOIN Departments ON Books.Department = Departments.DepId INNER JOIN Status ON Books.Status = Status.StatusId WHERE(Books.{SearchColumn} LIKE '%{SearchWord}%'){SearchDep}{SearchStatus}";

                // Get The Data From DataBase Base And Set It Into DataGridView(Books Table)
                SqlDataAdapter DA = new SqlDataAdapter(sqlcom);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                BooksTable.ReadOnly = true;
                BooksTable.Columns.Clear();
                BooksTable.DataSource = DT;


                // Add Edit And Delete Buttons At the End Of The Table
                BooksTable.Columns.Add("Edit", "Edit");
                BooksTable.Columns.Add("Delete.", "Delete");

                // Hide Book Id Collums
                BooksTable.Columns[0].Visible = false;

                // Set The width Of Some Columns

                BooksTable.Columns[2].Width = 250;  // Book Title
                BooksTable.Columns[7].Width = 50;   // Edit Btn
                BooksTable.Columns[8].Width = 60;   // Delete Btn

                // Colse Database
                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }

        }
        #endregion

        #region Visits Tab Functions
        private void FillVisitsTable()
        {
            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = "SELECT Visits.VisitId, Members.Name AS 'Member Name', Visits.CheckIn AS 'Check-In Time',  Visits.CheckOut As 'Check-Out Time', CONVERT(varchar, Visits.Date, 111) AS 'Day Date'  FROM Visits INNER JOIN Members ON Visits.MemberId = Members.MemberId";



                // Get The Data From DataBase Base And Set It Into DataGridView(Books Table)
                SqlDataAdapter DA = new SqlDataAdapter(sqlcom);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                VisitsTable.ReadOnly = true;
                VisitsTable.Columns.Clear();
                VisitsTable.DataSource = DT;

                VisitsTable.Columns[0].Visible = false;
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void VisitMemberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;


            if (e.KeyChar == 13)
            {
                try
                {
                    if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                    // Create Connection With DataBase
                    sqlcom.Connection = LibraryDBCon;
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.CommandText = $"SELECT Name FROM Members WHERE MemberId = {VisitsMemberIdTB.Text}";
                    SqlDataReader Data = sqlcom.ExecuteReader();


                    // If Memeber Id Found
                    if (Data.Read())
                    {
                        VisitMemberId = VisitsMemberIdTB.Text;
                        VisitsMemberName.Text = Data[0].ToString();
                        VisitsMemberName.Visible = true;
                        sqlcom.CommandText = $"SELECT VisitId, CheckOut FROM Visits WHERE MemberId = {VisitsMemberIdTB.Text}";
                        Data.Close();

                        Data = sqlcom.ExecuteReader();
                        while (Data.Read())
                        {
                            VisitsId = Data[0].ToString();

                            if (Data[1].ToString() == "00:00:00")
                            {
                                VisitsCheckOutBtn.BringToFront();
                                VisitsCheckOutBtn.Visible = true;
                                break;
                            }

                        }
                        if (VisitsCheckOutBtn.Visible == false)
                        {
                            VisitsCheckInBtn.BringToFront();
                            VisitsCheckInBtn.Visible = true;
                        }
                    }
                    else
                    {
                        VisitsMemberName.Visible = false;
                        VisitsCheckOutBtn.Visible = false;
                        VisitsCheckInBtn.Visible = false;
                    }

                    if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
                    Data.Close();
                } catch
                {
                    MessageBox.Show("Something Went Wrong, Please Try Again");
                }
            }

        }

        private void VisitsCheckOutBtn_Click(object sender, EventArgs e)
        {

            DateTime currentTime = DateTime.Now;
            string CheckOutTime = $"{currentTime.Hour.ToString(): D2} : {currentTime.Minute.ToString(): D2} : {currentTime.Second.ToString(): D2}";

            try
            {
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"UPDATE Visits SET CheckOut = '{CheckOutTime}'  WHERE VisitId = {VisitsId}";
                sqlcom.ExecuteNonQuery();

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();

                FillVisitsTable();
                VisitsMemberName.Visible = false;
                VisitsCheckOutBtn.Visible = false;
                VisitsCheckInBtn.Visible = false;
                VisitsMemberIdTB.Reset();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }

        }

        private void VisitsCheckInBtn_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string CheckInTime = $"{currentTime.Hour.ToString(): D2}:{currentTime.Minute.ToString(): D2}:{currentTime.Second.ToString(): D2}";
            string CheckInDay = $"{currentTime.Year.ToString()}/{currentTime.Month.ToString(): D2}/{currentTime.Day.ToString(): D2}";

            try
            {
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"INSERT INTO Visits (MemberId, Date ,CheckIn, CheckOut) VALUES({VisitMemberId}, '{CheckInDay}', '{CheckInTime}', '00:00:00')";
                sqlcom.ExecuteNonQuery();

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();

                FillVisitsTable();
                VisitsMemberName.Visible = false;
                VisitsCheckOutBtn.Visible = false;
                VisitsCheckInBtn.Visible = false;
                VisitsMemberIdTB.Reset();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }
        #endregion

        #region Member Tab Functions
        // fill the Members Data Grid View 
        void FillMembersTable(bool old = false)
        {

            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();

                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = "SELECT Members.MemberId, Members.Name, Members.Email, Members.Phone, Roles.Role AS 'Privilage' FROM Members INNER JOIN Roles ON Members.Privilage = Roles.RoleId";


                // Get The Data From DataBase Base And Set It Into DataGridView(Books Table)
                SqlDataAdapter DA = new SqlDataAdapter(sqlcom);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                MembersTable.ReadOnly = true;
                MembersTable.Columns.Clear();
                MembersTable.DataSource = DT;


                // Add Edit And Delete Buttons At the End Of The Table
                MembersTable.Columns.Add("Edit", "Edit");
                MembersTable.Columns.Add("Delete.", "Delete");


                // Set The width Of Some Columns

                MembersTable.Columns[5].Width = 50;   // Edit Btn
                MembersTable.Columns[6].Width = 60;   // Delete Btn

                // Colse Database
                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void MembersTable_BtnsClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == 5 || e.ColumnIndex == 6 &&
                e.RowIndex >= 0)
            {

                switch (e.ColumnIndex)
                {
                    case 5:

                        EditMember($"{senderGrid.Rows[e.RowIndex].Cells[0].Value}");
                        break;
                    case 6:
                        DeleteMember($"{senderGrid.Rows[e.RowIndex].Cells[0].Value}");

                        break;
                }
            }
        }

        private void DeleteMember(string memberId)
        {
            DeleteMemberDialog dialog = new DeleteMemberDialog(memberId);
            if (dialog.ShowDialog() == DialogResult.OK)
                FillMembersTable();
        }

        private void EditMember(string memberId)
        {
            EditMemberDialog dialog = new EditMemberDialog(memberId);
            if (dialog.ShowDialog() == DialogResult.OK)
                FillMembersTable();


        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            AddMemberDialog dialog = new AddMemberDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                FillMembersTable();
        }

        private void FillMemberPrivilageComBox()
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
                // Add general Option At Top
                DataTable dt = new DataTable("Roles");
                dt.Columns.Add(new DataColumn("RoleId", typeof(int)));
                dt.Columns.Add(new DataColumn("Role", typeof(string)));

                DataRow dr = dt.NewRow();
                dr["RoleId"] = 0;
                dr["Role"] = "All Privilages";
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);

                da.Fill(ds, "Roles");
                MemberPrivilageComBox.DisplayMember = "Role";
                MemberPrivilageComBox.ValueMember = "RoleId";
                MemberPrivilageComBox.DataSource = ds.Tables["Roles"];

                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }
        }

        private void MemberSearch(object sender, EventArgs e)
        {

            string SearchColumn = MemberSearchType.SelectedItem.ToString().Split(' ')[1];
            if (SearchColumn == "Id") SearchColumn = "MemberId";
            string SearchWord = MemberSearchWord.Text.Trim();
            string SearchPrivilage = ((MemberPrivilageComBox.SelectedValue.ToString() == "0") ? "" : $" AND (Members.Privilage = {MemberPrivilageComBox.SelectedValue.ToString()})");

            try
            {
                // Open DataBase
                if (LibraryDBCon.State == ConnectionState.Closed) LibraryDBCon.Open();


                // Create Connection With DataBase
                sqlcom.Connection = LibraryDBCon;
                sqlcom.CommandType = CommandType.Text;
                sqlcom.CommandText = $"SELECT Members.MemberId, Members.Name, Members.Email, Members.Phone, Roles.Role FROM Members INNER JOIN Roles ON Members.Privilage = Roles.RoleId WHERE(Members.{SearchColumn} LIKE '%{SearchWord}%'){SearchPrivilage}";

                // Get The Data From DataBase Base And Set It Into DataGridView(Books Table)
                SqlDataAdapter DA = new SqlDataAdapter(sqlcom);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                MembersTable.ReadOnly = true;
                MembersTable.Columns.Clear();
                MembersTable.DataSource = DT;


                // Add Edit And Delete Buttons At the End Of The Table
                MembersTable.Columns.Add("Edit", "Edit");
                MembersTable.Columns.Add("Delete.", "Delete");



                // Set The width Of Some Columns
                MembersTable.Columns[5].Width = 50;   // Edit Btn
                MembersTable.Columns[6].Width = 60;   // Delete Btn

                // Colse Database
                if (LibraryDBCon.State == ConnectionState.Open) LibraryDBCon.Close();
            } catch
            {
                MessageBox.Show("Something Went Wrong, Please Try Again");
            }

        }

        // Set Image At Members Table
        private void Membersgrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 7
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.file.Width;
                var h = Properties.Resources.file.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.file, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            else if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        #endregion
        // Side Line And Tab Animation Function
        private void ShowSideLine(object sender, EventArgs e)
        {
            // Convert Sender Object To Button of Bunifi Framework
            Bunifu.Framework.UI.BunifuFlatButton btn = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            #region Side Line Animation
            // If The Button That Run The Function Is Not The Current Active One
            if (SideLine.Location.Y != btn.Location.Y)
            {
                // SideLine.Location = new System.Drawing.Point(SideLine.Location.X, btn.Location.Y);
                // Make New Transition Element
                Transition HeightChange = new Transition(new TransitionType_EaseInEaseOut(300)),
                           ColorChange = new Transition(new TransitionType_EaseInEaseOut(500));
                // Add Description Of The Transition 
                HeightChange.add(SideLine, "Top", btn.Location.Y);
                ColorChange.add(btn, "BackColor", Color.Black);


                // Run Transition
                HeightChange.run();
                ColorChange.run();

            }
            #endregion

            #region Switch Tabs
            if (!btn.Active) {
                MetroFramework.Controls.MetroPanel panel = this.Controls.Find($"{btn.Text.Trim()}Tab", true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
                if (panel != null)
                    panel.BringToFront();

            }

            #endregion
        }

        private void LogoutBtn_Click(object sender, EventArgs e) 
        {
            this.DialogResult = DialogResult.OK;
        }


       
        private void PDFBtn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
            Bunifu.Framework.UI.BunifuCustomDataGrid PDF_dataTable = this.Controls.Find($"{btn.Name.Split('_')[1]}", true).FirstOrDefault() as Bunifu.Framework.UI.BunifuCustomDataGrid;

           if (PDFSaveDialog.ShowDialog() == DialogResult.OK)
            {
                //create a pdf document  
                PdfDocument pdf = new PdfDocument();
                //add a page  
                PdfPageBase page = pdf.Pages.Add();

                //create a table  
                PdfTable table = new PdfTable();

                //export datagridview to table  
                table.DataSource = PDF_dataTable.DataSource;

                //show header  
                table.Style.ShowHeader = true;

                //set cell padding  
                table.Style.CellPadding = 2;

                //set table layout  
                PdfTableLayoutFormat tableLayout = new PdfTableLayoutFormat();
                tableLayout.Break = PdfLayoutBreakType.FitElement;
                tableLayout.Layout = PdfLayoutType.Paginate;
                table.BeginRowLayout += new BeginRowLayoutEventHandler(table_BeginRowLayout);

                //draw table to pdf page  
                table.Draw(page, new RectangleF(10, 50, 500, 500), tableLayout);

                pdf.SaveToFile(PDFSaveDialog.FileName);
            }


        }
        //font and text alignment  
        private static void table_BeginRowLayout(object sender, BeginRowLayoutEventArgs args)
        {
            PdfCellStyle cellstyle = new PdfCellStyle();
            cellstyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            cellstyle.Font = new PdfTrueTypeFont(new Font("Roboto", 7f), true);
            args.CellStyle = cellstyle;
        }

            

  

    }
}
