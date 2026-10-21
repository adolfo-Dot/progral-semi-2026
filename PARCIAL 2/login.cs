using PARCIAL_2;
using System;
using System.Data;
using System.Windows.Forms;

namespace PARCIAL_2
{
    public partial class login : Form
    {
        private Conexion_base_datos bd;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            bd = new Conexion_base_datos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (bd == null) bd = new Conexion_base_datos();

            string usr = txtUsuario.Text.Trim();
            string pass = txtClave.Text;

            if (string.IsNullOrWhiteSpace(usr) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"SELECT * FROM usuarios_USSS080626 WHERE usuario = '{usr}' AND clave = '{pass}'";
            DataTable dt = bd.consultar(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("¡Bienvenido al sistema!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_usuario frmUser = new frm_usuario();
                this.Hide();
                frmUser.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Acceso denegado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}