using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practice.Exercise_2
{
    internal class Tiger : Animal
    {
        public Tiger()
        {

        }

        public Tiger(string name, int weight) : base(name, weight)
        {
        }

        public override void SetMe(string name, int weight)
        {
            Name= name;
            Weight= weight;
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + Name + ", Weight: " + Weight);
        }
   
    }
}
