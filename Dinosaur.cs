using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVS.Dinosaurs
{
    class Dinosaur
    {
        //MemberVariables "Has A"
        public string type;
        public int health;
        public int energy;
        

        //Constructor
        public Dinosaur(string type)
        {
            this.type = type;
            health = 100;
            energy = 50;

        }

        //MemberMethods "Can Do"
    }
}
