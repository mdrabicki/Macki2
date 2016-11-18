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

        public Skeleton (Form form, int healthPoints = 100, int attack = 10, int def = 1, int level = 1, int exp = 50)
        {
            this.healthPoints = healthPoints;
            this.attack = attack;
            this.def = def;
            this.level = level;
            this.exp = exp;

            this.healthBar = new ProgressBar();
            this.healthBar.Parent = form;          
            this.healthBar.Location = new System.Drawing.Point(10, 40);
            this.healthBar.Show();
            this.healthBar.Maximum = healthPoints;
            this.healthBar.Value = 70;

        }

    }
}
