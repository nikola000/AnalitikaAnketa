using AnalitikaAnketa.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitOfWorkExample.Services;
using UnitOfWorkExample.UnitOfWork.Models;

namespace AnalitikaAnketa
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        LogOn frm2;
        Administration frmAdmin;
        User user; 

        public Form1(IUserService userService)
        {
            this._userService = userService;
            InitializeComponent();
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            //MessageBox.Show(sender.ToString());
            
            if (e.ClickedItem.Name == toolStripMenuItem1.Name) { 
                if (user != null)
                {   
                    MessageBox.Show("Vec ste ulogovani");
                }
                else
                {
                    frm2 = new LogOn(user, _userService);
                    frm2.ShowDialog();
                    user = frm2.getUser();
                    tbUser.Text = user.Name;
                    if (user.IsAdministrator==true)
                    {
                        tsmiAdministrator.Visible = true;
                    }
                }
            }
            if (e.ClickedItem.Name == tsmiAdministrator.Name) {
                frmAdmin = new Administration(_userService);
                frmAdmin.ShowDialog();
            }
        }

    }
}
