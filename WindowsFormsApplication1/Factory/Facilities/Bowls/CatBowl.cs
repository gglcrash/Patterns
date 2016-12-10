using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory.Facilities.Bowls
{
    //миска для кота
    class CatBowl : Bowl
    {
        public override void create()
        {
            info = "Cat Bowl \n";
        }

        public override string getInfo()
        {
            return info;
        }
    }
}
