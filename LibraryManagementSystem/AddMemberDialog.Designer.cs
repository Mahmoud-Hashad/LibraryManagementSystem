namespace LibraryManagementSystem
{
    partial class AddMemberDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemberDialog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MemberPhoneTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MemberEmailTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MemberNameTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MemberIdTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BookISNB = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeleteLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CancelBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddMemberBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PrivilageCB = new MetroFramework.Controls.MetroComboBox();
            this.LibraryDBCon = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // MemberPhoneTB
            // 
            this.MemberPhoneTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MemberPhoneTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MemberPhoneTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.MemberPhoneTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MemberPhoneTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberPhoneTB.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.MemberPhoneTB.ForeColor = System.Drawing.Color.White;
            this.MemberPhoneTB.HintForeColor = System.Drawing.Color.White;
            this.MemberPhoneTB.HintText = "Phone";
            this.MemberPhoneTB.isPassword = false;
            this.MemberPhoneTB.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.MemberPhoneTB.LineIdleColor = System.Drawing.Color.Gray;
            this.MemberPhoneTB.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.MemberPhoneTB.LineThickness = 4;
            this.MemberPhoneTB.Location = new System.Drawing.Point(137, 235);
            this.MemberPhoneTB.Margin = new System.Windows.Forms.Padding(4);
            this.MemberPhoneTB.MaxLength = 32767;
            this.MemberPhoneTB.Name = "MemberPhoneTB";
            this.MemberPhoneTB.Size = new System.Drawing.Size(281, 36);
            this.MemberPhoneTB.TabIndex = 3;
            this.MemberPhoneTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MemberPhoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(36, 243);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(58, 19);
            this.bunifuCustomLabel4.TabIndex = 41;
            this.bunifuCustomLabel4.Text = "Phone:";
            // 
            // MemberEmailTB
            // 
            this.MemberEmailTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MemberEmailTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MemberEmailTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.MemberEmailTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MemberEmailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberEmailTB.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.MemberEmailTB.ForeColor = System.Drawing.Color.White;
            this.MemberEmailTB.HintForeColor = System.Drawing.Color.White;
            this.MemberEmailTB.HintText = "Email";
            this.MemberEmailTB.isPassword = false;
            this.MemberEmailTB.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.MemberEmailTB.LineIdleColor = System.Drawing.Color.Gray;
            this.MemberEmailTB.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.MemberEmailTB.LineThickness = 4;
            this.MemberEmailTB.Location = new System.Drawing.Point(137, 178);
            this.MemberEmailTB.Margin = new System.Windows.Forms.Padding(4);
            this.MemberEmailTB.MaxLength = 32767;
            this.MemberEmailTB.Name = "MemberEmailTB";
            this.MemberEmailTB.Size = new System.Drawing.Size(281, 36);
            this.MemberEmailTB.TabIndex = 2;
            this.MemberEmailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 186);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(53, 19);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Email:";
            // 
            // MemberNameTB
            // 
            this.MemberNameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MemberNameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MemberNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.MemberNameTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MemberNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberNameTB.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.MemberNameTB.ForeColor = System.Drawing.Color.White;
            this.MemberNameTB.HintForeColor = System.Drawing.Color.White;
            this.MemberNameTB.HintText = "Name";
            this.MemberNameTB.isPassword = false;
            this.MemberNameTB.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.MemberNameTB.LineIdleColor = System.Drawing.Color.Gray;
            this.MemberNameTB.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.MemberNameTB.LineThickness = 4;
            this.MemberNameTB.Location = new System.Drawing.Point(137, 122);
            this.MemberNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.MemberNameTB.MaxLength = 32767;
            this.MemberNameTB.Name = "MemberNameTB";
            this.MemberNameTB.Size = new System.Drawing.Size(281, 36);
            this.MemberNameTB.TabIndex = 1;
            this.MemberNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(36, 130);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 19);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Name:";
            // 
            // MemberIdTB
            // 
            this.MemberIdTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MemberIdTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MemberIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.MemberIdTB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MemberIdTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberIdTB.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.MemberIdTB.ForeColor = System.Drawing.Color.White;
            this.MemberIdTB.HintForeColor = System.Drawing.Color.White;
            this.MemberIdTB.HintText = "ID";
            this.MemberIdTB.isPassword = false;
            this.MemberIdTB.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.MemberIdTB.LineIdleColor = System.Drawing.Color.Gray;
            this.MemberIdTB.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.MemberIdTB.LineThickness = 4;
            this.MemberIdTB.Location = new System.Drawing.Point(137, 66);
            this.MemberIdTB.Margin = new System.Windows.Forms.Padding(4);
            this.MemberIdTB.MaxLength = 32767;
            this.MemberIdTB.Name = "MemberIdTB";
            this.MemberIdTB.Size = new System.Drawing.Size(281, 36);
            this.MemberIdTB.TabIndex = 0;
            this.MemberIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MemberIdTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly_KeyPress);
            // 
            // BookISNB
            // 
            this.BookISNB.AutoSize = true;
            this.BookISNB.BackColor = System.Drawing.Color.Transparent;
            this.BookISNB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookISNB.ForeColor = System.Drawing.Color.White;
            this.BookISNB.Location = new System.Drawing.Point(36, 74);
            this.BookISNB.Name = "BookISNB";
            this.BookISNB.Size = new System.Drawing.Size(28, 19);
            this.BookISNB.TabIndex = 34;
            this.BookISNB.Text = "ID:";
            // 
            // DeleteLable
            // 
            this.DeleteLable.AutoSize = true;
            this.DeleteLable.BackColor = System.Drawing.Color.Transparent;
            this.DeleteLable.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLable.ForeColor = System.Drawing.Color.White;
            this.DeleteLable.Location = new System.Drawing.Point(23, 30);
            this.DeleteLable.Name = "DeleteLable";
            this.DeleteLable.Size = new System.Drawing.Size(200, 25);
            this.DeleteLable.TabIndex = 33;
            this.DeleteLable.Text = "Add New Member:";
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
            this.CancelBtn.Location = new System.Drawing.Point(234, 345);
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
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelBtn.TextMarginLeft = 0;
            this.CancelBtn.UseDefaultRadiusAndThickness = true;
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.AllowToggling = false;
            this.AddMemberBtn.AnimationSpeed = 200;
            this.AddMemberBtn.AutoGenerateColors = false;
            this.AddMemberBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddMemberBtn.BackColor1 = System.Drawing.Color.LimeGreen;
            this.AddMemberBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddMemberBtn.BackgroundImage")));
            this.AddMemberBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMemberBtn.ButtonText = "Add Member";
            this.AddMemberBtn.ButtonTextMarginLeft = 0;
            this.AddMemberBtn.ColorContrastOnClick = 45;
            this.AddMemberBtn.ColorContrastOnHover = 45;
            this.AddMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.AddMemberBtn.CustomizableEdges = borderEdges2;
            this.AddMemberBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddMemberBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.AddMemberBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddMemberBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddMemberBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.AddMemberBtn.ForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.AddMemberBtn.IconMarginLeft = 11;
            this.AddMemberBtn.IconPadding = 10;
            this.AddMemberBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.AddMemberBtn.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.AddMemberBtn.IdleBorderRadius = 5;
            this.AddMemberBtn.IdleBorderThickness = 1;
            this.AddMemberBtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.AddMemberBtn.IdleIconLeftImage = null;
            this.AddMemberBtn.IdleIconRightImage = null;
            this.AddMemberBtn.IndicateFocus = false;
            this.AddMemberBtn.Location = new System.Drawing.Point(321, 345);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.onHoverState.BorderColor = System.Drawing.Color.Chartreuse;
            this.AddMemberBtn.onHoverState.BorderRadius = 5;
            this.AddMemberBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMemberBtn.onHoverState.BorderThickness = 0;
            this.AddMemberBtn.onHoverState.FillColor = System.Drawing.Color.Chartreuse;
            this.AddMemberBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.onHoverState.IconLeftImage = null;
            this.AddMemberBtn.onHoverState.IconRightImage = null;
            this.AddMemberBtn.OnIdleState.BorderColor = System.Drawing.Color.LimeGreen;
            this.AddMemberBtn.OnIdleState.BorderRadius = 5;
            this.AddMemberBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMemberBtn.OnIdleState.BorderThickness = 0;
            this.AddMemberBtn.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.AddMemberBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.OnIdleState.IconLeftImage = null;
            this.AddMemberBtn.OnIdleState.IconRightImage = null;
            this.AddMemberBtn.OnPressedState.BorderColor = System.Drawing.Color.Lime;
            this.AddMemberBtn.OnPressedState.BorderRadius = 5;
            this.AddMemberBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMemberBtn.OnPressedState.BorderThickness = 0;
            this.AddMemberBtn.OnPressedState.FillColor = System.Drawing.Color.Lime;
            this.AddMemberBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.OnPressedState.IconLeftImage = null;
            this.AddMemberBtn.OnPressedState.IconRightImage = null;
            this.AddMemberBtn.Size = new System.Drawing.Size(97, 33);
            this.AddMemberBtn.TabIndex = 5;
            this.AddMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddMemberBtn.TextMarginLeft = 0;
            this.AddMemberBtn.UseDefaultRadiusAndThickness = true;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(36, 299);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(70, 19);
            this.bunifuCustomLabel5.TabIndex = 43;
            this.bunifuCustomLabel5.Text = "Privilage";
            // 
            // PrivilageCB
            // 
            this.PrivilageCB.FormattingEnabled = true;
            this.PrivilageCB.ItemHeight = 23;
            this.PrivilageCB.Location = new System.Drawing.Point(137, 295);
            this.PrivilageCB.Name = "PrivilageCB";
            this.PrivilageCB.Size = new System.Drawing.Size(281, 29);
            this.PrivilageCB.Style = MetroFramework.MetroColorStyle.Green;
            this.PrivilageCB.TabIndex = 4;
            this.PrivilageCB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PrivilageCB.UseSelectable = true;
            // 
            // LibraryDBCon
            // 
            this.LibraryDBCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase\\Libr" +
    "artDB.mdf;Integrated Security=True;Connect Timeout=30";
            this.LibraryDBCon.FireInfoMessageEventOnUserErrors = false;
            // 
            // AddMemberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 390);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddMemberBtn);
            this.Controls.Add(this.PrivilageCB);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.MemberPhoneTB);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.MemberEmailTB);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.MemberNameTB);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.MemberIdTB);
            this.Controls.Add(this.BookISNB);
            this.Controls.Add(this.DeleteLable);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AddMemberDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "AddMemberDialog";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddMemberDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CancelBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddMemberBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MemberPhoneTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MemberEmailTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MemberNameTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MemberIdTB;
        private Bunifu.Framework.UI.BunifuCustomLabel BookISNB;
        private Bunifu.Framework.UI.BunifuCustomLabel DeleteLable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private MetroFramework.Controls.MetroComboBox PrivilageCB;
        private System.Data.SqlClient.SqlConnection LibraryDBCon;
    }
}