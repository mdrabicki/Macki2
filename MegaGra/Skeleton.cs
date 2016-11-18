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
       
       

        public Skeleton (Form form, int healthPoints = 100, int attack = 10, int defense = 1, int level = 1, int exp = 50)
        {
            this.healthPoints = healthPoints;
            this.attack = attack;
            this.defense= defense;
            this.level = level;
            this.exp = exp;     
            
            this.healthBar = new ProgressBar();
            this.healthBar.Parent = form;          
            this.healthBar.Location = new System.Drawing.Point(10, 40);
            this.healthBar.Show();
            this.healthBar.Maximum = healthPoints;
            this.healthBar.Value = healthPoints;

            PictureBox img = new PictureBox();
            img.Parent = form;            
            img.Location = new System.Drawing.Point(10, 50);
            img.Width = 100;
            img.Height = 100;
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.ImageLocation = @"C:\Projekty\c#\Macki2\MegaGra\resources\skeleton.jpg";
            img.Show();






        }

    }
}
