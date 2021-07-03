using AnalitikaAnketa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalitikaAnketa.Forms
{
    public partial class LogOn : Form
    {
        User _user;
        public LogOn()
        {
            InitializeComponent();
        }

        public LogOn(User user)
        {
            _user = user;
            _user = new User();
            InitializeComponent();
        }

        public User getUser()
        {
            return _user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _user.Username = textBox1.Text;
            _user.Password = textBox2.Text;
            this.Dispose();
        }
    }
}
