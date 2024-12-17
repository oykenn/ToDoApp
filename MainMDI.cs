using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class MainMDI : Form
    {
        private FormUserMgt formUserMgt;
        private FormBookMgt formBookMgt;
        private StudentDashboard studentDashboard;
        private LibrarianDashboard librarianDashboard;
        private RentalsTable rentalsTable;
        public MainMDI()
        {
            InitializeComponent();
        }

        private void librarianHome()
        {
            if (librarianDashboard == null)
            {
                librarianDashboard = new LibrarianDashboard();
                librarianDashboard.MdiParent = this;
                librarianDashboard.FormClosed += LibrarianDashboard_FormClosed;
                librarianDashboard.Show();
            }
        }
        private void MainMDI_Load(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.MdiParent = this;
            formLogin.SuccessLoginEvent += FormLogin_SuccessLoginEvent;
            formLogin.Show();
        }

        private void FormLogin_SuccessLoginEvent(object? sender, events.LoginEventArgs e)
        {
            this.toolStripStatusLabelName.Text = e.theUser.fullName;
            if (e.theUser.role == "Student")
            {
                this.menuStripMain.Visible = false;
                MessageBox.Show("You have login as Student.", "Welcome Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (studentDashboard == null)
                {
                    studentDashboard = new StudentDashboard();
                    studentDashboard.MdiParent = this;
                    studentDashboard.FormClosed += StudentDashboard_FormClosed; ;
                    studentDashboard.Show();
                }
            }
            else if (e.theUser.role == "Librarian")
            {
                this.menuStripMain.Visible = true;
                this.rentalsToolStripMenuItemRentals.Visible = true;
                this.usersToolStripMenuItemUsers.Visible = false;
                this.booksToolStripMenuItem.Visible = false;
                this.studentDashMenuItem.Visible = false;

                //MessageBox.Show("You have login as Librarian.", "Welcome Librarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (librarianDashboard == null)
                //{
                //    librarianDashboard = new LibrarianDashboard();
                //    librarianDashboard.MdiParent = this;
                //    librarianDashboard.FormClosed += LibrarianDashboard_FormClosed;
                //    librarianDashboard.Show();
                //}
                librarianHome();
            }
            else
            {
                this.menuStripMain.Visible = true;
            }
        }

        private void LibrarianDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            librarianDashboard = null;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usersToolStripMenuItemFiles_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            if (formUserMgt == null)
            {
                formUserMgt = new FormUserMgt();
                formUserMgt.MdiParent = this;
                formUserMgt.FormClosed += FormUserMgt_FormClosed;
                formUserMgt.Show();
            }
        }

        private void FormUserMgt_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formUserMgt = null;
        }

        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formBookMgt == null)
            {
                formBookMgt = new FormBookMgt();
                formBookMgt.MdiParent = this;
                formBookMgt.FormClosed += FormBookMgt_FormClosed; ;
                formBookMgt.Show();
            }
        }

        private void StudentDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            studentDashboard = null;
        }

        private void FormBookMgt_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formBookMgt = null;
        }

        private void studentDashMenuItem_Click(object sender, EventArgs e)
        {
            //if (studentDashboard == null)
            //{
            //    studentDashboard = new StudentDashboard();
            //    studentDashboard.MdiParent = this;
            //    studentDashboard.FormClosed += StudentDashboard_FormClosed1;
            //    studentDashboard.Show();
            //}

        }

        private void StudentDashboard_FormClosed1(object? sender, FormClosedEventArgs e)
        {
            //studentDashboard = null;
        }

        private void rentalsToolStripMenuItemRentals_Click(object sender, EventArgs e)
        {
            if (rentalsTable == null)
            {
                rentalsTable = new RentalsTable();
                rentalsTable.MdiParent = this;
                //rentalsTable.FormClosed += FormUserMgt_FormClosed;
                rentalsTable.FormClosed += RentalsTable_FormClosed;
                rentalsTable.Show();
            }
        }

        private void RentalsTable_FormClosed(object? sender, FormClosedEventArgs e)
        {
            rentalsTable = null;
        }

        private void homeToolStripMenuItemLibDash_Click(object sender, EventArgs e)
        {
            librarianHome();
        }
    }
}
