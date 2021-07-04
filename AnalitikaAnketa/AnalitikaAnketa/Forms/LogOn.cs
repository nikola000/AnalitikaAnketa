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
        User _user;

        public LogOn()
        {
            InitializeComponent();
        }

        public LogOn(User user, IUserService userService)
        {
            this._userService = userService;
            _user = user;
            _user = new User();
            InitializeComponent();
        }

        public User getUser()
        {
            return _user;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UserDto user = await _userService.CheckUser(tbUser.Text, tbPassword.Text);
            if (user==null)
            {
                MessageBox.Show("Unet je pogresan username ili password","Neuspelo logovanje",MessageBoxButtons.OK);
            }
            else
            {
                _user.Name = user.Name;
                _user.IsAdministrator = user.IsAdministrator;
                this.Dispose();
            }
        }
    }
}
