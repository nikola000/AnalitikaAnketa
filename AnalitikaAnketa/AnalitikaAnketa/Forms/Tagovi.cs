
using System;
using System.Data.Entity;
using System.Windows.Forms;
using UnitOfWorkExample.UnitOfWork;
namespace AnalitikaAnketa.Forms {
    public partial class Tagovi : Form
    {
            AddingUser AddNewUser;
            DatabaseContext context = new DatabaseContext();
        public Tagovi()
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
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Izmene su uspesno sacuvane");
            }
        }
    }
}
