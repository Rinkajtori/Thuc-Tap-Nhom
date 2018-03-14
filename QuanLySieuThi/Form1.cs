using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class Form1 : Form
    {
        int checkAccept = 0;
        public Form1()
        {
            InitializeComponent();
            
            if (checkAccept != 1)
            {
                setDafaultMenu();
            }
            
            //statusLabel.Text = "Hello";
            
        }

        private void setDafaultMenu()
        {
            statusLabel.Text = "Xin chào, ban đang truy cập với tư cách khách";
            quảnLýTruyCậpToolStripMenuItem.Enabled = false;
            quảnLýDữLiệuToolStripMenuItem.Enabled = false;
            chỉnhSửaThôngTinToolStripMenuItem.Enabled = false;
            nhàCungCấpToolStripMenuItem.Enabled = false;
            kháchHàngToolStripMenuItem.Enabled = false;
            phòngBanToolStripMenuItem.Enabled = false;
            nhânViênToolStripMenuItem.Enabled = false;

            hóaĐơnToolStripMenuItem.Enabled = false;
            nhạpHàngToolStripMenuItem.Enabled = false;
            xuấtHàngToolStripMenuItem.Enabled = false;

            đăngXuấtToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
        }
        
        
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            checkAccept = Login.checkAceccpt;
            if (checkAccept == 1 || checkAccept == 2)
            {
                đăngXuấtToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;

                nhàCungCấpToolStripMenuItem.Enabled = true;
                kháchHàngToolStripMenuItem.Enabled = true;
                phòngBanToolStripMenuItem.Enabled = true;
                nhânViênToolStripMenuItem.Enabled = true;
            }

            if (checkAccept == 1)
            {
                statusLabel.Text = "Xin chào " + Login.userName + ", bạn đang truy cập với tư cách nhà quản trị";
                quảnLýTruyCậpToolStripMenuItem.Enabled = true;
                quảnLýDữLiệuToolStripMenuItem.Enabled = true;
                chỉnhSửaThôngTinToolStripMenuItem.Enabled = true;
                
            }
            else
            {
                if (checkAccept == 2)
                {
                    statusLabel.Text = "Xin chào " + Login.userName + ", bạn đang truy cập với tư cách nhân viên";
                    quảnLýTruyCậpToolStripMenuItem.Enabled = false;
                    quảnLýDữLiệuToolStripMenuItem.Enabled = false;
                    chỉnhSửaThôngTinToolStripMenuItem.Enabled = false;                    
                }
            }
            
        }



        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }

        private void nhómMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuayHang produceLine = new QuayHang();
            produceLine.Show();
        }
        

        private void quảnLýTruyCậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                checkAccept = 0;
                setDafaultMenu();
            }
            else
            {

            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
