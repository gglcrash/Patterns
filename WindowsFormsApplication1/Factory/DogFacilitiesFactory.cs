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
    class DogFacilitiesFactory : AnimalFacilitiesFactory
    {
        public override Bowl createBowl()
        {
            return new DogBowl();
        }

        public override Cage createCage()
        {
            return new DogCage();
        }

        public override Collar createCollar()
        {
            return new DogCollar();
        }
    }
}
