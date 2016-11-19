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
    enum ActiveUIComponent
    {
        NONE,
        ADD_PLAYER,
        ADD_MONSTER
    }
    public partial class Form1 : Form
    {
        ActiveUIComponent activeUIComponent=ActiveUIComponent.NONE;
        public Form1()
        {
             
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MouseClick += Form1_MouseClick;

        }

        private void addMonsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeUIComponent = ActiveUIComponent.ADD_MONSTER;
            
           
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (activeUIComponent) { 
            case ActiveUIComponent.ADD_MONSTER:
                Skeleton skeleton = new Skeleton(this, MousePosition);
                break;
            case ActiveUIComponent.ADD_PLAYER:
                Player player = new Player(this, MousePosition);
                break;
                    
        }
            activeUIComponent = ActiveUIComponent.NONE;
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeUIComponent = ActiveUIComponent.ADD_PLAYER;
        }

       
    }
}
