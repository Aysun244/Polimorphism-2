using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism_2.Models
{
   abstract  class Animal
    {
        public string Spacies { get; set; }
        public byte  Age { get; set; }
        public float Weight { get; set; }

        public Animal(string spacies, byte age,float weight)
        {
            Spacies = spacies;
            Age = age;
            Weight = weight;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Nov:{Spacies },Yas:{Age},Ceki:{Weight}");
        }
    }
}
