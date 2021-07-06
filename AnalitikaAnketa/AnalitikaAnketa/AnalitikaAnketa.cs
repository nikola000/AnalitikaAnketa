using AnalitikaAnketa.Forms;
using System.Windows.Forms;
using UnitOfWorkExample.Services;
using UnitOfWorkExample.UnitOfWork.Models;

namespace AnalitikaAnketa
{
    public partial class AnalitikaAnketa : Form
    {
        private readonly IUserService _userService;
        LogOn frm2;
        User user;
        import frm3;
        Administration frmAdmin;
        GroupOfTags frmGroup;
        public AnalitikaAnketa(IUserService userService)
        {
            this._userService = userService;
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == toolStripMenuItem1.Name)
            {
                if (user != null)
                {
                    MessageBox.Show("Vec ste ulogovani");
                }
                else
                {
                    frm2 = new LogOn(user, _userService);
                    frm2.ShowDialog();
                    user = frm2.getUser();
                    if (user != null)
                    {
                        toolStripStatusLabelLogin.Text = "Ulogovan: " + user.Name;
                        
                        if (user.IsAdministrator == true)
                        {
                            tsmiAdministrator.Visible = true;
                        }
                    }
                }
            }
            if (e.ClickedItem.Name == ToolStripMenuItem2.Name)
            {
                frm3 = new import();
                frm3.ShowDialog();
            }
            if (e.ClickedItem.Name == tsmiAdministrator.Name)
            {
                frmAdmin = new Administration();
                frmAdmin.ShowDialog();
            }
            if (e.ClickedItem.Name == tsmiGroupOfTags.Name)
            {
                frmGroup = new GroupOfTags();
                frmGroup.ShowDialog();
            }
        }
    }
}
