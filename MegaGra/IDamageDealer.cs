﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaGra
{
    interface IDamageDealer
    {
        void dealDamage(IDamageReceiver enemy);
       
    }
}
