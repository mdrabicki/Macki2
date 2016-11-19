using System;
using System.Windows.Forms;

namespace MegaGra
{
    class Skeleton : Monster
    {

        public Skeleton (Form form,System.Drawing.Point possition,  int level = 1)
        {
            healthPoints = 100;
            attackDamage=10;
            defense = 1;
            this.level = level;

            unitPresentation = new UnitPresentation(possition,UnitType.SKELETON, form);  
            
        }
       void img_Click(object sender, EventArgs e)
        {
            
            
        }

    }
}
