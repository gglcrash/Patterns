using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory.Facilities.Collars
{
    //ошейник для кого-либо
    abstract class Collar
    {
        public Collar()
        {
            create();
        }
        protected String info;
        public abstract String getInfo();
        public abstract void create();
    }
}
