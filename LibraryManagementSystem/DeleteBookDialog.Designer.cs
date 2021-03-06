﻿namespace LibraryManagementSystem
{
    partial class DeleteBookDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBookDialog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DeleteLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BookISNB = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeleteBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CancelBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BookTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BookDepartment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LibraryDBCon = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // DeleteLable
            // 
            this.DeleteLable.AutoSize = true;
            this.DeleteLable.BackColor = System.Drawing.Color.Transparent;
            this.DeleteLable.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLable.ForeColor = System.Drawing.Color.White;
            this.DeleteLable.Location = new System.Drawing.Point(7, 20);
            this.DeleteLable.Name = "DeleteLable";
            this.DeleteLable.Size = new System.Drawing.Size(408, 25);
            this.DeleteLable.TabIndex = 0;
            this.DeleteLable.Text = "This Book Will Be Deleted Permanently";
            // 
            // BookISNB
            // 
            this.BookISNB.BackColor = System.Drawing.Color.Transparent;
            this.BookISNB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BookISNB.ForeColor = System.Drawing.Color.White;
            this.BookISNB.Location = new System.Drawing.Point(24, 65);
            this.BookISNB.Name = "BookISNB";
            this.BookISNB.Size = new System.Drawing.Size(476, 25);
            this.BookISNB.TabIndex = 1;
            this.BookISNB.Text = "Book ISNB:";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AllowToggling = false;
            this.DeleteBtn.AnimationSpeed = 200;
            this.DeleteBtn.AutoGenerateColors = false;
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BackColor1 = System.Drawing.Color.Red;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.ButtonTextMarginLeft = 0;
            this.DeleteBtn.ColorContrastOnClick = 45;
            this.DeleteBtn.ColorContrastOnHover = 45;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.DeleteBtn.CustomizableEdges = borderEdges1;
            this.DeleteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DeleteBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.DeleteBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.IconMarginLeft = 11;
            this.DeleteBtn.IconPadding = 10;
            this.DeleteBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DeleteBtn.IdleBorderRadius = 5;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.Red;
            this.DeleteBtn.IdleIconLeftImage = null;
            this.DeleteBtn.IdleIconRightImage = null;
            this.DeleteBtn.IndicateFocus = false;
            this.DeleteBtn.Location = new System.Drawing.Point(421, 142);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DeleteBtn.onHoverState.BorderRadius = 5;
            this.DeleteBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteBtn.onHoverState.BorderThickness = 0;
            this.DeleteBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DeleteBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.onHoverState.IconLeftImage = null;
            this.DeleteBtn.onHoverState.IconRightImage = null;
            this.DeleteBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DeleteBtn.OnIdleState.BorderRadius = 5;
            this.DeleteBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteBtn.OnIdleState.BorderThickness = 0;
            this.DeleteBtn.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.DeleteBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.OnIdleState.IconLeftImage = null;
            this.DeleteBtn.OnIdleState.IconRightImage = null;
            this.DeleteBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteBtn.OnPressedState.BorderRadius = 5;
            this.DeleteBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteBtn.OnPressedState.BorderThickness = 0;
            this.DeleteBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.OnPressedState.IconLeftImage = null;
            this.DeleteBtn.OnPressedState.IconRightImage = null;
            this.DeleteBtn.Size = new System.Drawing.Size(79, 33);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.TextMarginLeft = 0;
            this.DeleteBtn.UseDefaultRadiusAndThickness = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.CancelBtn.CustomizableEdges = borderEdges2;
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
            this.CancelBtn.Location = new System.Drawing.Point(326, 142);
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
            // BookTitle
            // 
            this.BookTitle.BackColor = System.Drawing.Color.Transparent;
            this.BookTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BookTitle.ForeColor = System.Drawing.Color.White;
            this.BookTitle.Location = new System.Drawing.Point(24, 90);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(476, 25);
            this.BookTitle.TabIndex = 8;
            this.BookTitle.Text = "Book ISNB:";
            // 
            // BookDepartment
            // 
            this.BookDepartment.BackColor = System.Drawing.Color.Transparent;
            this.BookDepartment.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BookDepartment.ForeColor = System.Drawing.Color.White;
            this.BookDepartment.Location = new System.Drawing.Point(24, 115);
            this.BookDepartment.Name = "BookDepartment";
            this.BookDepartment.Size = new System.Drawing.Size(476, 25);
            this.BookDepartment.TabIndex = 9;
            this.BookDepartment.Text = "Book ISNB:";
            // 
            // LibraryDBCon
            // 
            this.LibraryDBCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase\\Libr" +
    "artDB.mdf;Integrated Security=True;Connect Timeout=30";
            this.LibraryDBCon.FireInfoMessageEventOnUserErrors = false;
            // 
            // DeleteBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 186);
            this.Controls.Add(this.BookDepartment);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.BookISNB);
            this.Controls.Add(this.DeleteLable);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "DeleteBookDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Delete Book";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DeleteBookDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel DeleteLable;
        private Bunifu.Framework.UI.BunifuCustomLabel BookISNB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CancelBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel BookTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel BookDepartment;
        private System.Data.SqlClient.SqlConnection LibraryDBCon;
    }
}