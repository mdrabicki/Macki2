using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaGra
{
    class Skeleton : Monster
    {

        void monsterImageShow(Form form)
        {
            
            
      
        }


        public Skeleton (Form form, int level = 1)
        {
            healthPoints = 100;
            attackDamage=10;
            defense = 1;
            this.level = level;

            unitPresentation = new UnitPresentation(new System.Drawing.Point(500, 500),UnitType.SKELETON, form);  
            
        }
       void img_Click(object sender, EventArgs e)
        {
            
            
        }

    }
}
