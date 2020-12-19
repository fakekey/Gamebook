using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    public partial class DashBoard : Form
    {
        public DashBoard(string name, string quyen)
        {
            InitializeComponent();
            if (quyen != "Admin")
            {
                panel8.Visible = false;
            }
            lbName.Text = name;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            CheckClass.location = this.Location;
            CheckClass.size = this.Size;
            panel4_MouseMove(null, null);
            icoHome_Click(null, null);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragControl.mouseDown(this);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            DragControl.mouseMove(this);
            CheckClass.location = this.Location;
            CheckClass.size = this.Size;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            DragControl.mouseUp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Messagebox.Show("THÔNG BÁO", "Bạn có chắc muốn đăng xuất không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                CheckClass.location = this.Location;
                CheckClass.size = this.Size;
                if (fUsers != null)
                {
                    fUsers.ReSize();
                }
                if (fProducts != null)
                {
                    fProducts.ReSize();
                }
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CheckClass.location = this.Location;
                CheckClass.size = this.Size;
                if (fUsers != null)
                {
                    fUsers.ReSize();
                }
                if (fProducts != null)
                {
                    fProducts.ReSize();
                }
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool activeOne = false;
        bool activeTwo = false;
        bool activeThree = false;
        bool activeFour = false;

        private void clear()
        {
            if (activeOne == true)
            {
                if (userIsActive == false)
                {
                    if (icoUser.Radius == 14)
                    {
                        icoUser.rColor = Color.FromArgb(54, 57, 63);
                        icoUser.Radius = 48;
                        icoUser.Refresh();
                        active2.rColor = Color.Transparent;
                        active2.Refresh();
                    }
                }
            }
            else
            {
                if (homeIsActive == false)
                {
                    if (icoHome.Radius == 14)
                    {
                        icoHome.rColor = Color.FromArgb(54, 57, 63);
                        icoHome.Radius = 48;
                        icoHome.Refresh();
                        active1.rColor = Color.Transparent;
                        active1.Refresh();
                    }
                }
            }
            if (activeTwo == true)
            {
                if (homeIsActive == false)
                {
                    if (icoHome.Radius == 14)
                    {
                        icoHome.rColor = Color.FromArgb(54, 57, 63);
                        icoHome.Radius = 48;
                        icoHome.Refresh();
                        active1.rColor = Color.Transparent;
                        active1.Refresh();
                    }
                }
                if (productIsActive == false)
                {
                    if (icoProduct.Radius == 14)
                    {
                        icoProduct.rColor = Color.FromArgb(54, 57, 63);
                        icoProduct.Radius = 48;
                        icoProduct.Refresh();
                        active3.rColor = Color.Transparent;
                        active3.Refresh();
                    }
                }
            }
            else
            {
                if (userIsActive == false)
                {
                    if (icoUser.Radius == 14)
                    {
                        icoUser.rColor = Color.FromArgb(54, 57, 63);
                        icoUser.Radius = 48;
                        icoUser.Refresh();
                        active2.rColor = Color.Transparent;
                        active2.Refresh();
                    }
                }
            }
            if (activeThree == true)
            {
                if (userIsActive == false)
                {
                    if (icoUser.Radius == 14)
                    {
                        icoUser.rColor = Color.FromArgb(54, 57, 63);
                        icoUser.Radius = 48;
                        icoUser.Refresh();
                        active2.rColor = Color.Transparent;
                        active2.Refresh();
                    }
                }
                if (billIsActive == false)
                {
                    if (icoBill.Radius == 14)
                    {
                        icoBill.rColor = Color.FromArgb(54, 57, 63);
                        icoBill.Radius = 48;
                        icoBill.Refresh();
                        active4.rColor = Color.Transparent;
                        active4.Refresh();
                    }
                }

            }
            else
            {
                if (productIsActive == false)
                {
                    if (icoProduct.Radius == 14)
                    {
                        icoProduct.rColor = Color.FromArgb(54, 57, 63);
                        icoProduct.Radius = 48;
                        icoProduct.Refresh();
                        active3.rColor = Color.Transparent;
                        active3.Refresh();
                    }
                }
            }
            if (activeFour == true)
            {
                if (productIsActive == false)
                {
                    if (icoProduct.Radius == 14)
                    {
                        icoProduct.rColor = Color.FromArgb(54, 57, 63);
                        icoProduct.Radius = 48;
                        icoProduct.Refresh();
                        active3.rColor = Color.Transparent;
                        active3.Refresh();
                    }
                }
            }
            else
            {
                if (billIsActive == false)
                {
                    if (icoBill.Radius == 14)
                    {
                        icoBill.rColor = Color.FromArgb(54, 57, 63);
                        icoBill.Radius = 48;
                        icoBill.Refresh();
                        active4.rColor = Color.Transparent;
                        active4.Refresh();
                    }
                }
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = false;
            clear();
            if (labelBills != null && f4 != null)
            {
                labelBills.Close();
                f4.Close();
                labelBills = null;
                f4 = null;
                freeMemory();
            }
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeThree = activeFour = false;
            activeTwo = true;
            clear();
            if (icoUser.Radius == 48)
            {
                active2.rColor = Color.White;
                active2.Refresh();
                icoUser.rColor = Color.FromArgb(67, 181, 129);
                icoUser.Radius = 14;
                icoUser.Refresh();
            }
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            activeTwo = activeOne = activeFour = false;
            activeThree = true;
            clear();
            if (icoProduct.Radius == 48)
            {
                active3.rColor = Color.White;
                active3.Refresh();
                icoProduct.rColor = Color.FromArgb(67, 181, 129);
                icoProduct.Radius = 14;
                icoProduct.Refresh();
            }
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            activeTwo = activeOne = activeThree = false;
            activeFour = true;
            clear();
            if (icoBill.Radius == 48)
            {
                active4.rColor = Color.White;
                active4.Refresh();
                icoBill.rColor = Color.FromArgb(67, 181, 129);
                icoBill.Radius = 14;
                icoBill.Refresh();
            }
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            activeTwo = activeThree = activeFour = false;
            activeOne = true;
            clear();
            if (icoHome.Radius == 48)
            {
                active1.rColor = Color.White;
                active1.Refresh();
                icoHome.rColor = Color.FromArgb(114, 137, 218);
                icoHome.Radius = 14;
                icoHome.Refresh();
            }
        }

        bool homeIsActive = false;
        bool userIsActive = false;
        bool productIsActive = false;
        bool billIsActive = false;
        private void panel4_Click(object sender, EventArgs e)
        {
            userIsActive = productIsActive = billIsActive = false;
            homeIsActive = true;
            clear();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            homeIsActive = productIsActive = billIsActive = false;
            userIsActive = true;
            clear();
            if (isAdd != "Users")
            {
                fUsers = new Users();
                AddForm(fUsers);
            }
        }
        string isAdd = "";
        private void panel11_Click(object sender, EventArgs e)
        {
            homeIsActive = userIsActive = billIsActive = false;
            productIsActive = true;
            clear();
            fProducts = new Products();
            AddForm(fProducts);
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            userIsActive = productIsActive = homeIsActive = false;
            billIsActive = true;
            clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel4_Click(null, null);
        }

        private void icoHome_Click(object sender, EventArgs e)
        {
            panel4_Click(null, null);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel4_Click(null, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel8_Click(null, null);
        }

        private void icoUser_Click(object sender, EventArgs e)
        {
            panel8_Click(null, null);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel8_Click(null, null);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel11_Click(null, null);
        }

        private void icoProduct_Click(object sender, EventArgs e)
        {
            panel11_Click(null, null);
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel11_Click(null, null);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel14_Click(null, null);
        }

        private void icoBill_Click(object sender, EventArgs e)
        {
            panel14_Click(null, null);
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            panel14_Click(null, null);
        }

        private void panel7_MouseMove_1(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = false;
            clear();
            if (labelHome != null && f1 != null)
            {
                labelHome.Close();
                f1.Close();
                labelHome = null;
                f1 = null;
                freeMemory();
            }
        }

        private void panel20_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = false;
            clear();
        }

        private void panel23_MouseMove(object sender, MouseEventArgs e)
        {
            activeOne = activeTwo = activeThree = activeFour = false;
            clear();
            if (labelHome != null && f1 != null)
            {
                labelHome.Close();
                f1.Close();
                labelHome = null;
                f1 = null;
                freeMemory();
            }
            if (labelUsers != null && f2 != null)
            {
                labelUsers.Close();
                f2.Close();
                labelUsers = null;
                f2 = null;
                freeMemory();
            }
            if (labelProducts != null && f3 != null)
            {
                labelProducts.Close();
                f3.Close();
                labelProducts = null;
                f3 = null;
                freeMemory();
            }
            if (labelBills != null && f4 != null)
            {
                labelBills.Close();
                f4.Close();
                labelBills = null;
                f4 = null;
                freeMemory();
            }
        }
        private void AddForm(Form form)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            foreach (Form item in pnDisplay.Controls)
            {
                item.Dispose();
            }
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            pnDisplay.Controls.Add(form);
            form.Show();
            isAdd = form.Name;
        }
        private Users fUsers;
        private Products fProducts;

        private Form f1;
        private Form f2;
        private Form f3;
        private Form f4;
        private lbHome labelHome;
        private lbUsers labelUsers;
        private lbProducts labelProducts;
        private lbBills labelBills;
        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (labelUsers != null && f2 != null)
            {
                labelUsers.Close();
                labelUsers = null;
                f2.Close();
                f2 = null;
                freeMemory();
            }
            if (f1 == null)
            {
                f1 = new Form();
                f1.StartPosition = FormStartPosition.Manual;
                f1.FormBorderStyle = FormBorderStyle.None;
                f1.ShowInTaskbar = false;
                f1.BackColor = Color.Black;
                f1.Opacity = 0f;
                f1.Location = new Point(CheckClass.location.X, CheckClass.location.Y + 30);
                f1.AutoSize = false;
                f1.Size = new Size(196, 68);
                labelHome = new lbHome();
                f1.Show();
                labelHome.ShowInTaskbar = false;
                labelHome.AutoSize = false;
                labelHome.Owner = f1;
                labelHome.Location = new Point(CheckClass.location.X + 98, CheckClass.location.Y + 45);
                labelHome.Show();
            }
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            if (labelHome != null && f1 != null)
            {
                labelHome.Close();
                f1.Close();
                labelHome = null;
                f1 = null;
                freeMemory();
            }
            if (labelProducts != null && f3 != null)
            {
                labelProducts.Close();
                f3.Close();
                labelProducts = null;
                f3 = null;
                freeMemory();
            }
            if (f2 == null)
            {
                f2 = new Form();
                f2.StartPosition = FormStartPosition.Manual;
                f2.FormBorderStyle = FormBorderStyle.None;
                f2.ShowInTaskbar = false;
                f2.BackColor = Color.Black;
                f2.Opacity = 0f;
                f2.Location = new Point(CheckClass.location.X, CheckClass.location.Y + 100);
                f2.AutoSize = false;
                f2.Size = new Size(201, 68);
                labelUsers = new lbUsers();
                f2.Show();
                labelUsers.ShowInTaskbar = false;
                labelUsers.AutoSize = false;
                labelUsers.Owner = f2;
                labelUsers.Location = new Point(CheckClass.location.X + 98, CheckClass.location.Y + 114);
                labelUsers.Show();
            }
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            if (labelUsers != null && f2 != null)
            {
                labelUsers.Close();
                f2.Close();
                labelUsers = null;
                f2 = null;
                freeMemory();
            }
            if (labelBills != null && f4 != null)
            {
                labelBills.Close();
                f4.Close();
                labelBills = null;
                f4 = null;
                freeMemory();
            }
            if (f3 == null)
            {
                f3 = new Form();
                f3.StartPosition = FormStartPosition.Manual;
                f3.FormBorderStyle = FormBorderStyle.None;
                f3.ShowInTaskbar = false;
                f3.BackColor = Color.Black;
                f3.Opacity = 0f;
                f3.Location = new Point(CheckClass.location.X, CheckClass.location.Y + 168);
                f3.AutoSize = false;
                f3.Size = new Size(196, 68);
                labelProducts = new lbProducts();
                f3.Show();
                labelProducts.ShowInTaskbar = false;
                labelProducts.AutoSize = false;
                labelProducts.Owner = f3;
                labelProducts.Location = new Point(CheckClass.location.X + 98, CheckClass.location.Y + 182);
                labelProducts.Show();
            }
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            if (labelProducts != null && f3 != null)
            {
                labelProducts.Close();
                f3.Close();
                labelProducts = null;
                f3 = null;
                freeMemory();
            }
            if (f4 == null)
            {
                f4 = new Form();
                f4.StartPosition = FormStartPosition.Manual;
                f4.FormBorderStyle = FormBorderStyle.None;
                f4.ShowInTaskbar = false;
                f4.BackColor = Color.Black;
                f4.Opacity = 0f;
                f4.Location = new Point(CheckClass.location.X, CheckClass.location.Y + 236);
                f4.AutoSize = false;
                f4.Size = new Size(188, 68);
                labelBills = new lbBills();
                f4.Show();
                labelBills.ShowInTaskbar = false;
                labelBills.AutoSize = false;
                labelBills.Owner = f4;
                labelBills.Location = new Point(CheckClass.location.X + 98, CheckClass.location.Y + 250);
                labelBills.Show();
            }
        }
        private void freeMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
