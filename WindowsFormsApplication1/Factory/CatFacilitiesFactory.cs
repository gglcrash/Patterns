using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Factory.Facilities.Bowls;
using WindowsFormsApplication1.Factory.Facilities.Cages;
using WindowsFormsApplication1.Factory.Facilities.Collars;

namespace WindowsFormsApplication1.Factory
{
    class CatFacilitiesFactory : AnimalFacilitiesFactory
    {
        public override Bowl createBowl()
        {
            return new CatBowl();
        }

        public override Cage createCage()
        {
            return new CatCage();
        }

        public override Collar createCollar()
        {
            return new CatCollar();
        }
    }
}
