using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaGra
{
    abstract class Entity
    {
        public UnitPresentation unitPresentation { get; set; }
        public int level { get; set; }
        public int healthPoints { get; set; }
        public int attackDamage { get; set; }
        public int defense { get; set; }

    }
}
