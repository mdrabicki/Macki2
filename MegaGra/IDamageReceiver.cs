using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaGra
{
    public interface IDamageReceiver 
    {    
        void takeDamage(int dmg);
    }
}
