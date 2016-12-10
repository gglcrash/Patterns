using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory.Facilities.Cages
{
    //клетка для кого-либо
    abstract class Cage
    {
        public Cage()
        {
            create();
        }
        protected String info;
        public abstract String getInfo();
        public abstract void create();
    }
}
