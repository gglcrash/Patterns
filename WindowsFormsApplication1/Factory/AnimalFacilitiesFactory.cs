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
    
    abstract class AnimalFacilitiesFactory
    {
        public abstract Bowl createBowl();
        public abstract Cage createCage();
        public abstract Collar createCollar();
    }
}
