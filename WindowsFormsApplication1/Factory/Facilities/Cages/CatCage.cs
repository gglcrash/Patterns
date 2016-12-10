using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory.Facilities.Cages
{
    class CatCage : Cage
    {
        public override void create()
        {
            info = "Cat Cage \n";
        }
        public override string getInfo()
        {
            return info;
        }
    }
}
