using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaGra
{
    class Monster : IDamageReceiver, IDamageDealer
    {
        public int healthPoints { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int level { get; set; }
        public int exp { get; set; }
        public ProgressBar healthBar { get; set; }
        public PictureBox monsterimage { get; set; }

        void IDamageReceiver.takeDamage(int dmg)
        {
            this.healthPoints -= (dmg * defense / 2);
            this.healthBar.Value = this.healthPoints;
        }

        void IDamageDealer.dealDamage(IDamageReceiver enemy)
        {
            int totalDamage = attack * level;
            enemy.takeDamage(totalDamage); 

        }

        

        
        

        
        
    }
}
