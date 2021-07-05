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
using UnitOfWorkExample.Services;
using UnitOfWorkExample.Services.Dto;

namespace AnalitikaAnketa.Forms
{
    public partial class LogOn : Form
    {
        private readonly IUserService _userService;
        UserDto _user;

        public LogOn()
        {
            InitializeComponent();
        }

        public LogOn(UserDto user, IUserService userService)
        {
            this._user = user;
            this._userService = userService;
            
            InitializeComponent();
        }

        public UserDto getUser()
        {
            return _user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LogIn();
            }
        }

        private void LogIn()
        {
            _user = _userService.CheckUser(tbUser.Text, tbPassword.Text);
            if (_user == null)
            {
                MessageBox.Show("Unet je pogresan username ili password", "Neuspelo logovanje", MessageBoxButtons.OK);
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
