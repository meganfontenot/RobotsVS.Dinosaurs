using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVS.Dinosaurs
{
    class Robot
    {
        //MemberVariables "Has A"
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        

        //Constructor
        public Robot(string name, string battleWeapon)
        {
            this.name = name;
            health = 100;
            powerLevel = 10;
            weapon = new Weapon(battleWeapon);
        }

        //MemberMethods "Can Do"
        public void Attack(Dinosaur dinoBattle)
        {
            dinoBattle.health -= weapon.attackPower;
        }
    }
}
