
namespace ejemploCapas
{
    using System;
    using System.Windows.Forms;
    using Common.Cache;
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to close app?", "Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            lblUser.Text = UserCache.LoginName;
            lblPosition.Text = UserCache.Position;
            lblEmail.Text = UserCache.Email;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajustes.frmUsers Form = new Ajustes.frmUsers();
            Form.ShowDialog();

        }
    }
}
