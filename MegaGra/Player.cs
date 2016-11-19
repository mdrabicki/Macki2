using System;
using System.Windows.Forms;
using System.Drawing;

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
        public Player(Form form, Point point)
        {
            healthPoints = 100;
            attackDamage = 10;
            defense = 1;
            unitPresentation = new UnitPresentation(point, UnitType.PLAYER, form);
        }

        void imageClickHandler(object sender, EventArgs e)
        {
            IDamageDealer me = (IDamageDealer)this;
            me.dealDamage(this);
            
        }

    }
    
}
