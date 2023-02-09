using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Exercise_2
{
    internal class Lion : Animal
    {
        public Lion()
        {

        }

        public Lion(string name, int weight) : base(name, weight)
        {
        }

        public override void SetMe(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public override void Show()
        {
            Console.WriteLine(Name, Weight);
        }
    }
}
