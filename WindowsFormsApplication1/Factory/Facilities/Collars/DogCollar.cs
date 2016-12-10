using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory.Facilities.Collars
{
    //ошейник для собаки
    class DogCollar : Collar
    {
        public override void create()
        {
            info = "Dog Collar \n";
        }
        public override string getInfo()
        {
            return info;
        }
    }
}
