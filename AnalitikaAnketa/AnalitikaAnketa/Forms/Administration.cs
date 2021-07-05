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
            InitializeDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Izmene su uspesno sacuvane");
            }
        }
        private void InitializeDataGridView() 
        {
            dataGridView1.Columns[1].HeaderText = "Korisnicko ime";
            dataGridView1.Columns[3].HeaderText = "Ime";
            dataGridView1.Columns[4].HeaderText = "Administrator";
            dataGridView1.Columns[5].HeaderText = "E-mail";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[3].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
