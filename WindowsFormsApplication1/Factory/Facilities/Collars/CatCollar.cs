using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory.Facilities.Collars
{
    class CatCollar : Collar
    {
        public override void create()
        {
            info = "Cat Collar \n";
        }
        public override string getInfo()
        {
            return info;
        }
    }
}
