using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Factory.Facilities;

namespace WindowsFormsApplication1.Factory
{
    class Helper
    {
        private static Helper instance;
        public static Helper getInstance()
        {
            if (instance == null)
            {
                instance = new Helper();
            }
            return instance;
        }

        public Facility createFacilities(AnimalFacilitiesFactory factory)
        {
            Facility facility = new Facility();

            facility.setBowl(factory.createBowl());
            facility.setCage(factory.createCage());
            facility.setCollar(factory.createCollar());

            return facility;
        }
    }
}
