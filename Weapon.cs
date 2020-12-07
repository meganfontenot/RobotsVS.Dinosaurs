using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVS.Dinosaurs
{
    class Weapon
    {
        //MemberVariables "Has A"
        public string type;
        public int attackPower;

        //Constructor
        public Weapon (string type)
        {
            this.type = type;
            Random random = new Random();
            attackPower = random.Next(1, 10);

        }

        //MemberMethods "Can Do"
    }
}
