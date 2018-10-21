using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneFinal
{
    interface IWalkAway //interface can be inherited in addition to a class
    {
         void WalkAway(Player player); //everything in interfaces are public by default
    }
}
 