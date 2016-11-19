using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaGra
{
    class Player : Entity, IDamageReceiver
    {
        
        public int exp { get; set; }
        public String name { get; set; }

        void IDamageReceiver.takeDamage(int dmg)
        {
            this.healthPoints -= (dmg - this.defense) ;
        }
        public Player(Form form)
        {
            healthPoints = 100;
            attackDamage = 10;
            defense = 1;
            unitPresentation = new UnitPresentation(new System.Drawing.Point(20, 20), UnitType.PLAYER, form);
     
          
            

 

        }
        void imageClickHandler(object sender, EventArgs e)
        {
            IDamageDealer me = (IDamageDealer)this;
            me.dealDamage(this);
            
        }

    }
    
}
