
using System;
using System.Data.Entity;
using System.Windows.Forms;
using UnitOfWorkExample.UnitOfWork;
namespace AnalitikaAnketa.Forms {
    public partial class grupaTagova : Form
    {
            AddingUser AddNewUser;
            DatabaseContext context = new DatabaseContext();
        public grupaTagova()
        {
            InitializeComponent();
        }

        private void grupaTagova_Load(object sender, EventArgs e)
        {
            
            SetDataGrid();
        }
        private void SetDataGrid()
        {
            context.Tags.Load();
            dataGridView1.DataSource = context.Tags.Local.ToBindingList();
        }


    }
}
