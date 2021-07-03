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
using UnitOfWorkExample.UnitOfWork.Models;

namespace AnalitikaAnketa
{
    public partial class Form1 : Form
    {
        LogOn frm2;
        User user; 

        public Form1()
        {
            InitializeComponent();
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frm2 = new LogOn(user);
            frm2.ShowDialog();
            tbUser.Text = frm2.getUser().Username;
        }

    }
}
