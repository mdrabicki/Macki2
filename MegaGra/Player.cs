using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaGra
{
    class Player : IDamageReceiver
    {
        public String name  { get; set; }
        public int healthPoints { get; set; }
        public int attackDamage { get; set; }
        public int defense { get; set; }

        void IDamageReceiver.takeDamage(int dmg)
        {
            this.healthPoints -= (dmg - this.defense) ;
        }
        public ProgressBar healthBar { get; set; }
        public PictureBox monsterimage { get; set; }
        public Player(Form form, int healthPoints = 100, int attack = 10, int def = 1, int level = 1, int exp = 50)
        {
            this.healthPoints = healthPoints;
            this.attackDamage = attack;


            this.healthBar = new ProgressBar();
            this.healthBar.Parent = form;
            this.healthBar.Location = new System.Drawing.Point(10, 40);
            this.healthBar.Show();
            this.healthBar.Maximum = healthPoints;
            this.healthBar.Value = 70;

        }

    }
}
