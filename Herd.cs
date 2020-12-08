using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVS.Dinosaurs
{
    class Herd
    {
        //MemberVariables "Has A"
        public List<Dinosaur> dinoHerd;

        //Constructor
        public Herd()
        {
            dinoHerd = new List<Dinosaur>();
            Dinosaur firstDino = new Dinosaur("T-rex");
            Dinosaur secondDino = new Dinosaur("Brachiosaurus");
            Dinosaur thridDino = new Dinosaur("Indominus-Rex");

            dinoHerd.Add(firstDino);
            dinoHerd.Add(secondDino);
            dinoHerd.Add(thridDino);

            CreateHerd(300);
        }
        //MemberMethods "Can Do"
        public string GenerateRandomName()
        {
            List<string> names = new List<string>();
            return names[Helper.GenerateRandomNumber(0, 50)];
        }
        public void CreateHerd(int numberOfDinos)
        {
            for (int i = 0; i < numberOfDinos; i++)
            {
                
                string name = GenerateRandomName();

                Dinosaur dinosaur = new Dinosaur(name);
                dinoHerd.Add(dinosaur);
            }
        }

    }
}
