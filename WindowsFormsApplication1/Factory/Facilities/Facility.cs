using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Factory.Facilities.Bowls;
using WindowsFormsApplication1.Factory.Facilities.Cages;
using WindowsFormsApplication1.Factory.Facilities.Collars;

namespace WindowsFormsApplication1.Factory.Facilities
{
    class Facility
    {
        //созданные "приспособления" для кого-либо, не важно кошка или собака
        private Bowl bowl;
        private Cage cage;
        private Collar collar;
        public void setBowl(Bowl bowl)
        {
            this.bowl = bowl;
        }

        public void setCage(Cage cage)
        {
            this.cage = cage;
        }
        public void setCollar(Collar collar)
        {
            this.collar = collar;
        }

        public override string ToString()
        {
            return "Created Facilities: \n" + bowl.getInfo()+cage.getInfo()+collar.getInfo();
        }
    }
}
