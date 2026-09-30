using System;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // frmMaterias objMaterias = new frmMaterias();
            // objMaterias.MdiParent = this;
            // objMaterias.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // frmPeriodos objPeriodo = new frmPeriodos();
            // objPeriodo.MdiParent = this;
            // objPeriodo.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // frmNotas objNota = new frmNotas();
            // objNota.MdiParent = this;
            // objNota.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}