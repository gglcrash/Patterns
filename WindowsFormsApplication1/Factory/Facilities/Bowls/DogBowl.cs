using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory.Facilities.Bowls
{
    class DogBowl : Bowl
    {
        public override void create()
        {
            info = "Dog Bowl \n";
        }
        public override string getInfo()
        {
            return info;
        }
    }
}
