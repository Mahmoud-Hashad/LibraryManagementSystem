namespace LibraryManagementSystem
{
    partial class EditBookDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookDialog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DeleteLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BookISNB = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ISNB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Title = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Author = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Department = new MetroFramework.Controls.MetroComboBox();
            this.Status = new MetroFramework.Controls.MetroComboBox();
            this.CancelBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UpdateBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LibraryDBCon = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // DeleteLable
            // 
            this.DeleteLable.AutoSize = true;
            this.DeleteLable.BackColor = System.Drawing.Color.Transparent;
            this.DeleteLable.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLable.ForeColor = System.Drawing.Color.White;
            this.DeleteLable.Location = new System.Drawing.Point(23, 30);
            this.DeleteLable.Name = "DeleteLable";
            this.DeleteLable.Size = new System.Drawing.Size(170, 25);
            this.DeleteLable.TabIndex = 1;
            this.DeleteLable.Text = "Edit Book Data:";
            // 
            // BookISNB
            // 
            this.BookISNB.AutoSize = true;
            this.BookISNB.BackColor = System.Drawing.Color.Transparent;
            this.BookISNB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookISNB.ForeColor = System.Drawing.Color.White;
            this.BookISNB.Location = new System.Drawing.Point(36, 74);
            this.BookISNB.Name = "BookISNB";
            this.BookISNB.Size = new System.Drawing.Size(48, 19);
            this.BookISNB.TabIndex = 2;
            this.BookISNB.Text = "ISNB:";
            // 
            // ISNB
            // 
            this.ISNB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ISNB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ISNB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ISNB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ISNB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ISNB.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.ISNB.ForeColor = System.Drawing.Color.White;
            this.ISNB.HintForeColor = System.Drawing.Color.White;
            this.ISNB.HintText = "";
            this.ISNB.isPassword = false;
            this.ISNB.LineFocusedColor = System.Drawing.Color.Magenta;
            this.ISNB.LineIdleColor = System.Drawing.Color.Gray;
            this.ISNB.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ISNB.LineThickness = 4;
            this.ISNB.Location = new System.Drawing.Point(137, 66);
            this.ISNB.Margin = new System.Windows.Forms.Padding(4);
            this.ISNB.MaxLength = 32767;
            this.ISNB.Name = "ISNB";
            this.ISNB.Size = new System.Drawing.Size(313, 36);
            this.ISNB.TabIndex = 0;
            this.ISNB.Text = "Book ISNB";
            this.ISNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ISNB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISNB_KeyPress);
            // 
            // Title
            // 
            this.Title.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Title.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Title.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.HintForeColor = System.Drawing.Color.White;
            this.Title.HintText = "";
            this.Title.isPassword = false;
            this.Title.LineFocusedColor = System.Drawing.Color.Magenta;
            this.Title.LineIdleColor = System.Drawing.Color.Gray;
            this.Title.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Title.LineThickness = 4;
            this.Title.Location = new System.Drawing.Point(137, 122);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.MaxLength = 32767;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(313, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Book ISNB";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(36, 130);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(44, 19);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Title:";
            // 
            // Author
            // 
            this.Author.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Author.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Author.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Author.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.Author.ForeColor = System.Drawing.Color.White;
            this.Author.HintForeColor = System.Drawing.Color.White;
            this.Author.HintText = "";
            this.Author.isPassword = false;
            this.Author.LineFocusedColor = System.Drawing.Color.Magenta;
            this.Author.LineIdleColor = System.Drawing.Color.Gray;
            this.Author.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Author.LineThickness = 4;
            this.Author.Location = new System.Drawing.Point(137, 178);
            this.Author.Margin = new System.Windows.Forms.Padding(4);
            this.Author.MaxLength = 32767;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(313, 36);
            this.Author.TabIndex = 2;
            this.Author.Text = "Book ISNB";
            this.Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 186);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 19);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Author:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(36, 242);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(96, 19);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Department:";
            // 
            // Price
            // 
            this.Price.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Price.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Price.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.Price.ForeColor = System.Drawing.Color.White;
            this.Price.HintForeColor = System.Drawing.Color.White;
            this.Price.HintText = "";
            this.Price.isPassword = false;
            this.Price.LineFocusedColor = System.Drawing.Color.Magenta;
            this.Price.LineIdleColor = System.Drawing.Color.Gray;
            this.Price.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Price.LineThickness = 4;
            this.Price.Location = new System.Drawing.Point(137, 290);
            this.Price.Margin = new System.Windows.Forms.Padding(4);
            this.Price.MaxLength = 32767;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(313, 36);
            this.Price.TabIndex = 4;
            this.Price.Text = "Book ISNB";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(36, 298);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(48, 19);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Price:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(36, 354);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 19);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Status:";
            // 
            // Department
            // 
            this.Department.FormattingEnabled = true;
            this.Department.ItemHeight = 23;
            this.Department.Location = new System.Drawing.Point(137, 238);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(313, 29);
            this.Department.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Department.TabIndex = 3;
            this.Department.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Department.UseSelectable = true;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.ItemHeight = 23;
            this.Status.Location = new System.Drawing.Point(137, 350);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(313, 29);
            this.Status.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Status.TabIndex = 5;
            this.Status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Status.UseSelectable = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.AllowToggling = false;
            this.CancelBtn.AnimationSpeed = 200;
            this.CancelBtn.AutoGenerateColors = false;
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelBtn.ButtonText = "Cancel";
            this.CancelBtn.ButtonTextMarginLeft = 0;
            this.CancelBtn.ColorContrastOnClick = 45;
            this.CancelBtn.ColorContrastOnHover = 45;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.CancelBtn.CustomizableEdges = borderEdges1;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.CancelBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CancelBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CancelBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.IconMarginLeft = 11;
            this.CancelBtn.IconPadding = 10;
            this.CancelBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.CancelBtn.IdleBorderRadius = 5;
            this.CancelBtn.IdleBorderThickness = 1;
            this.CancelBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.CancelBtn.IdleIconLeftImage = null;
            this.CancelBtn.IdleIconRightImage = null;
            this.CancelBtn.IndicateFocus = false;
            this.CancelBtn.Location = new System.Drawing.Point(282, 394);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(102)))));
            this.CancelBtn.onHoverState.BorderRadius = 5;
            this.CancelBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelBtn.onHoverState.BorderThickness = 0;
            this.CancelBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(102)))));
            this.CancelBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.onHoverState.IconLeftImage = null;
            this.CancelBtn.onHoverState.IconRightImage = null;
            this.CancelBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.CancelBtn.OnIdleState.BorderRadius = 5;
            this.CancelBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelBtn.OnIdleState.BorderThickness = 0;
            this.CancelBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.CancelBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.OnIdleState.IconLeftImage = null;
            this.CancelBtn.OnIdleState.IconRightImage = null;
            this.CancelBtn.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.CancelBtn.OnPressedState.BorderRadius = 5;
            this.CancelBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelBtn.OnPressedState.BorderThickness = 0;
            this.CancelBtn.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.CancelBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.OnPressedState.IconLeftImage = null;
            this.CancelBtn.OnPressedState.IconRightImage = null;
            this.CancelBtn.Size = new System.Drawing.Size(79, 33);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelBtn.TextMarginLeft = 0;
            this.CancelBtn.UseDefaultRadiusAndThickness = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AllowToggling = false;
            this.UpdateBtn.AnimationSpeed = 200;
            this.UpdateBtn.AutoGenerateColors = false;
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BackColor1 = System.Drawing.Color.MediumVioletRed;
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.ButtonText = "Update";
            this.UpdateBtn.ButtonTextMarginLeft = 0;
            this.UpdateBtn.ColorContrastOnClick = 45;
            this.UpdateBtn.ColorContrastOnHover = 45;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.UpdateBtn.CustomizableEdges = borderEdges2;
            this.UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.UpdateBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.IconMarginLeft = 11;
            this.UpdateBtn.IconPadding = 10;
            this.UpdateBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.IdleBorderColor = System.Drawing.Color.MediumVioletRed;
            this.UpdateBtn.IdleBorderRadius = 5;
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.UpdateBtn.IdleIconLeftImage = null;
            this.UpdateBtn.IdleIconRightImage = null;
            this.UpdateBtn.IndicateFocus = false;
            this.UpdateBtn.Location = new System.Drawing.Point(377, 394);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.onHoverState.BorderColor = System.Drawing.Color.Orchid;
            this.UpdateBtn.onHoverState.BorderRadius = 5;
            this.UpdateBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.onHoverState.BorderThickness = 0;
            this.UpdateBtn.onHoverState.FillColor = System.Drawing.Color.Orchid;
            this.UpdateBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.onHoverState.IconLeftImage = null;
            this.UpdateBtn.onHoverState.IconRightImage = null;
            this.UpdateBtn.OnIdleState.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.UpdateBtn.OnIdleState.BorderRadius = 5;
            this.UpdateBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnIdleState.BorderThickness = 0;
            this.UpdateBtn.OnIdleState.FillColor = System.Drawing.Color.MediumVioletRed;
            this.UpdateBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.OnIdleState.IconLeftImage = null;
            this.UpdateBtn.OnIdleState.IconRightImage = null;
            this.UpdateBtn.OnPressedState.BorderColor = System.Drawing.Color.DeepPink;
            this.UpdateBtn.OnPressedState.BorderRadius = 5;
            this.UpdateBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnPressedState.BorderThickness = 0;
            this.UpdateBtn.OnPressedState.FillColor = System.Drawing.Color.DeepPink;
            this.UpdateBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.OnPressedState.IconLeftImage = null;
            this.UpdateBtn.OnPressedState.IconRightImage = null;
            this.UpdateBtn.Size = new System.Drawing.Size(79, 33);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.TextMarginLeft = 0;
            this.UpdateBtn.UseDefaultRadiusAndThickness = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // LibraryDBCon
            // 
            this.LibraryDBCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase\\Libr" +
    "artDB.mdf;Integrated Security=True;Connect Timeout=30";
            this.LibraryDBCon.FireInfoMessageEventOnUserErrors = false;
            // 
            // EditBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 438);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ISNB);
            this.Controls.Add(this.BookISNB);
            this.Controls.Add(this.DeleteLable);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "EditBookDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "EditBookDialog";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.EditBookDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel DeleteLable;
        private Bunifu.Framework.UI.BunifuCustomLabel BookISNB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ISNB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Title;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Author;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Price;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private MetroFramework.Controls.MetroComboBox Department;
        private MetroFramework.Controls.MetroComboBox Status;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CancelBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateBtn;
        private System.Data.SqlClient.SqlConnection LibraryDBCon;
    }
}