using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaGra
{
    public enum ActiveUIComponent
    {
        NONE,
        ADD_PLAYER,
        ADD_MONSTER
    }
    public static class GameController
    {
       public static ActiveUIComponent activeUIComponent=ActiveUIComponent.NONE;
    }
}
