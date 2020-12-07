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
        }
        //MemberMethods "Can Do"
    }
}
