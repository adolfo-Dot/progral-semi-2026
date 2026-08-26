using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btndeducciones_Click(object sender, EventArgs e)
        {
            frmDeducciones ventana = new frmDeducciones();
            ventana.Show();

        }

        private void btnaguapotable_Click(object sender, EventArgs e)
        {
            frmaguapotable ventana = new frmaguapotable();
            ventana.Show();
        }
    }
}
