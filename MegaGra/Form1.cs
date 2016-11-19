using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaGra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void addMonsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Skeleton skeleton = new Skeleton(this);
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player player = new Player(this);
        }
    }
}
