using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Exercise_2
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Animal()
        {

        }

        public Animal( string name , int weight )
        {
            Name = name;
            Weight = weight;
        }

        public abstract void Show();
        public abstract void SetMe(string nam, int weight);
        
    }

  

  
}
