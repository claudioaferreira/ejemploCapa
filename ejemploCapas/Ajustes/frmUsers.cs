using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploCapas.Ajustes
{
    public partial class frmUsers : Form
    {

        string PageAction;
        public frmUsers()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCapas.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsCapas.Users);
            EstablecerEstado(false);
        }

        private void EstablecerEstado(bool v)
        {
            toolStripAgregar.Enabled = !v;
            toolStripModificar.Enabled = !v;
            toolStripBorrar.Enabled = !v;
            toolStripCancel.Enabled = v;
            toolStripGuardar.Enabled = v;
            toolStripSalir.Enabled = !v;
            dgUsers.Enabled = !v;
            gbUsuario.Enabled = v;
            gbBusqueda.Enabled = !v;
        }

        private void txtBusNombre_TextChanged(object sender, EventArgs e)
        {
            this.usersTableAdapter.FillByFirstName(this.dsCapas.Users, "%" + txtBusNombre.Text.ToString() + "%");
        }
    }
}
