namespace LibraryApp
{
    partial class MainMDI
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelName = new ToolStripStatusLabel();
            menuStripMain = new MenuStrip();
            usersToolStripMenuItemFiles = new ToolStripMenuItem();
            usersToolStripMenuItemUsers = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            studentDashMenuItem = new ToolStripMenuItem();
            rentalsToolStripMenuItemRentals = new ToolStripMenuItem();
            homeToolStripMenuItemLibDash = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelName });
            statusStrip1.Location = new Point(0, 796);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 23, 0);
            statusStrip1.Size = new Size(1684, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabelName
            // 
            toolStripStatusLabelName.Name = "toolStripStatusLabelName";
            toolStripStatusLabelName.Size = new Size(0, 12);
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItemFiles });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new Padding(10, 3, 0, 3);
            menuStripMain.Size = new Size(1684, 44);
            menuStripMain.TabIndex = 3;
            menuStripMain.Text = "menuStrip1";
            menuStripMain.Visible = false;
            menuStripMain.ItemClicked += menuStripMain_ItemClicked;
            // 
            // usersToolStripMenuItemFiles
            // 
            usersToolStripMenuItemFiles.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItemUsers, booksToolStripMenuItem, studentDashMenuItem, rentalsToolStripMenuItemRentals, homeToolStripMenuItemLibDash });
            usersToolStripMenuItemFiles.Name = "usersToolStripMenuItemFiles";
            usersToolStripMenuItemFiles.Size = new Size(81, 38);
            usersToolStripMenuItemFiles.Text = "Files";
            usersToolStripMenuItemFiles.Click += usersToolStripMenuItemFiles_Click;
            // 
            // usersToolStripMenuItemUsers
            // 
            usersToolStripMenuItemUsers.Name = "usersToolStripMenuItemUsers";
            usersToolStripMenuItemUsers.Size = new Size(359, 44);
            usersToolStripMenuItemUsers.Text = "Users";
            usersToolStripMenuItemUsers.Click += usersToolStripMenuItemUsers_Click;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(359, 44);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // studentDashMenuItem
            // 
            studentDashMenuItem.Name = "studentDashMenuItem";
            studentDashMenuItem.Size = new Size(359, 44);
            studentDashMenuItem.Text = "Student Dashboard";
            studentDashMenuItem.Visible = false;
            studentDashMenuItem.Click += studentDashMenuItem_Click;
            // 
            // rentalsToolStripMenuItemRentals
            // 
            rentalsToolStripMenuItemRentals.Name = "rentalsToolStripMenuItemRentals";
            rentalsToolStripMenuItemRentals.Size = new Size(359, 44);
            rentalsToolStripMenuItemRentals.Text = "Rentals";
            rentalsToolStripMenuItemRentals.Click += rentalsToolStripMenuItemRentals_Click;
            // 
            // homeToolStripMenuItemLibDash
            // 
            homeToolStripMenuItemLibDash.Name = "homeToolStripMenuItemLibDash";
            homeToolStripMenuItemLibDash.Size = new Size(359, 44);
            homeToolStripMenuItemLibDash.Text = "Home";
            homeToolStripMenuItemLibDash.Click += homeToolStripMenuItemLibDash_Click;
            // 
            // MainMDI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 818);
            Controls.Add(statusStrip1);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Margin = new Padding(5);
            Name = "MainMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STI Library System";
            WindowState = FormWindowState.Maximized;
            Load += MainMDI_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelName;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem usersToolStripMenuItemFiles;
        private ToolStripMenuItem usersToolStripMenuItemUsers;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem studentDashMenuItem;
        private ToolStripMenuItem rentalsToolStripMenuItemRentals;
        private ToolStripMenuItem homeToolStripMenuItemLibDash;
    }
}