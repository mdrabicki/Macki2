using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaGra
{
    class Monster : Entity, IDamageReceiver, IDamageDealer
    {
        
        void IDamageReceiver.takeDamage(int dmg)
        {
            healthPoints -= (dmg * defense / 2);
        }

        void IDamageDealer.dealDamage(IDamageReceiver enemy)
        {
            int totalDamage = attackDamage * level;
            enemy.takeDamage(totalDamage); 

        }
   
    }
}
