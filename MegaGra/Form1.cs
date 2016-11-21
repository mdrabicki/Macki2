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
            MouseClick += Form1_MouseClick;

        }

        private void addMonsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.activeUIComponent = ActiveUIComponent.ADD_MONSTER;
            
           
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (GameController.activeUIComponent) { 
            case ActiveUIComponent.ADD_MONSTER:
                Skeleton skeleton = new Skeleton(this, MousePosition);
                break;
            case ActiveUIComponent.ADD_PLAYER:
                Player player = new Player(this, MousePosition);
                break;
                    
        }
            GameController.activeUIComponent = ActiveUIComponent.NONE;
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.activeUIComponent = ActiveUIComponent.ADD_PLAYER;
        }

       
    }
}
