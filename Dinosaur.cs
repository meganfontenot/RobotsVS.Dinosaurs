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
        public int attackPower;
        

        //Constructor
        public Dinosaur(string type)
        {
            this.type = type;
            health = 100;
            energy = 50;
            //Helper.GenerateRandomNumber();
            Random random = new Random();
            attackPower = random.Next(1, 10);
            
        }

        //MemberMethods "Can Do"
        public void Attack (Robot robotBattle)
        {
            robotBattle.health -= attackPower;
        }
    }
}
