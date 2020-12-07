using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVS.Dinosaurs
{
    class Fleet
    {
        //MemberVariables "Has A"
        public List<Robot> robotFleet;

        //Constructor
        public Fleet()
        {
            robotFleet = new List<Robot>();
            Robot firstRobot = new Robot("K2SO", "Blaster");
            Robot secondRobot = new Robot("R2D2", "Spanner");
            Robot thridRobot = new Robot("K9", "Sonic Screwdriver");

            robotFleet.Add(firstRobot);
            robotFleet.Add(secondRobot);
            robotFleet.Add(thridRobot);
        }

        //MemberMethods "Can Do"
    }
}
