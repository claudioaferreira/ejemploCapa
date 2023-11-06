using System;
using System.Windows.Forms;
using Common.Cache;
using DataAccess;


namespace ejemploCapas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                if (txtPassword.Text != String.Empty)
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        frmPrincipal form = new frmPrincipal();
                        MessageBox.Show("Bienvenido " + UserCache.FirstName + " " + UserCache.LastName);
                        form.ShowDialog();
                        //Codigo cuando cerramos el formulario principal
                        txtPassword.Text = String.Empty;
                        txtUser.Text = String.Empty;
                        txtUser.Focus();
                    } else
                    {
                        MessageBox.Show("Usuario no Existe");
                    }
                }
                else
                {
                    MessageBox.Show("Introduce la contraseña");
                }
            }
            else
            {
                MessageBox.Show("Introduce todo los datos");
                txtUser.Focus();
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            
            this.Show();
           
        }
    }
}
