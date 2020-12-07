using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVS.Dinosaurs
{
    class Battlefield
    {
        //MemberVariables "Has A"
        public Fleet fleet;
        public Herd herd;

        //Constructor
        public Battlefield ()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //MemberMethods "Can Do"
        public void Battle ()
        {
            //Need to access Dino inside of Herd and Attack() Robot inside of Fleet
            herd.dinoHerd[0].Attack(fleet.robotFleet[0]);
            //Need to access Robot inside of Fleet and Attack() Dino inside of Herd
            fleet.robotFleet[0].Attack(herd.dinoHerd[0]);


        }
    }
}
