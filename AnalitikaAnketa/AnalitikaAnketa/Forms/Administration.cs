using System;
using System.Data.Entity;
using System.Windows.Forms;
using UnitOfWorkExample.UnitOfWork;

namespace AnalitikaAnketa.Forms
{
    public partial class Administration : Form
    {
        AddingUser AddNewUser;
        DatabaseContext context = new DatabaseContext();

        public Administration()
        {
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
            context.Users.Load();
            dataGridView1.DataSource = context.Users.Local.ToBindingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Izmene su uspesno sacuvane");
            }
        }
    }
}
