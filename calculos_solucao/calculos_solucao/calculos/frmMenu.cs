using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        static void frmmenu()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
            
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objCalc = new Form1();
            objCalc.MdiParent = this;
            objCalc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 objCalc = new Form1();
            objCalc.MdiParent = this;
            objCalc.Show();
        }

        private void calculadoraBotoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objCalc = new Form1();
            objCalc.MdiParent = this;
            objCalc.Show();
        }
    }
}
