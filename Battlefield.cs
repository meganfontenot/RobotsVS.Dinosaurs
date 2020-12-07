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
            //Need to loop through dinos and robots for battle.

            //When player dies (health reaches zero), player should then be removed from the list shifting herd/fleet up by one index.
            //When one of the robot/dino list is empty (all players have died) then we can declare a winner
            //Need to break loop if last of dino/robot dies

            while (herd.dinoHerd.Count > 0 && fleet.robotFleet.Count > 0) //their is atleast one dino/robot
            {
                //Need to access Robot inside of Fleet and Attack() Dino inside of Herd
                fleet.robotFleet[0].Attack(herd.dinoHerd[0]);
                if (herd.dinoHerd[0].health == 0) //health reached 0
                {
                    //remove from list
                    herd.dinoHerd.RemoveAt(0);
                }

                //Need to access Dino inside of Herd and Attack() Robot inside of Fleet
                herd.dinoHerd[0].Attack(fleet.robotFleet[0]);
                if (fleet.robotFleet[0].health == 0) //health reached 0
                {
                    //remove from list
                    fleet.robotFleet.RemoveAt(0);
                }
            }

            //Break loop game over check score
            




        }
    }
}
