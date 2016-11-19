using System.Windows.Forms;
using System.Drawing;

namespace MegaGra
{
    public enum UnitType
    {
        SKELETON,
        PLAYER,
        UNKNOWN
    };
    class UnitPresentation
    {


        public Point possition { get; set; }
        public ProgressBar healthBar { get; set; }
        public PictureBox unitImage { get; set; }

        public UnitPresentation(Point possition,UnitType unitType, Form form)
        {
            this.possition = possition;
            createHealthBar(form);
            createUnitImage(form, unitType);     
        }

        private void createHealthBar(Form form)
        {
            healthBar = new ProgressBar();
            healthBar.Parent = form;
            healthBar.Location = new Point(possition.X, possition.Y + 100);
            healthBar.Height = 30;
            healthBar.Width = 100;
            healthBar.Show();

        }
        private void createUnitImage(Form form, UnitType unitType)
        {
            
            unitImage = new PictureBox();
            switch (unitType)
            {
                case UnitType.PLAYER:

                    unitImage.Image = Image.FromFile("resources/player.jpg");
                    break;
                case UnitType.SKELETON:
                    unitImage.Image = Image.FromFile("resources/skeleton.jpg");
                    break;
                default:
                    break;

            }
            unitImage.Location = possition;
            unitImage.Width = 100;
            unitImage.Height = 100;
            unitImage.SizeMode = PictureBoxSizeMode.StretchImage;
            unitImage.Parent = form;
            unitImage.Show();

        }

        
    }
}
