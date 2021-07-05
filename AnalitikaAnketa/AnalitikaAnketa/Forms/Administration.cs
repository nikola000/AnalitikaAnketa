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
using UnitOfWorkExample.Services.Dto;
using UnitOfWorkExample.UnitOfWork;

namespace AnalitikaAnketa.Forms
{
    public partial class Administration : Form
    {
        AddingUser AddNewUser;
        private readonly IUserService _userService;
        public Administration()
        {
            InitializeComponent();
        }
        public Administration(IUserService userService)
        {
            this._userService = userService;
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            SetDataGrid();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser = new AddingUser();
            AddNewUser.ShowDialog();
            SetDataGrid();
        }


        private void SetDataGrid()
        {
            dataGridView1.DataSource = _userService.GetUsersDataGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
