using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism_2.Models
{
    class Bird:Animal 
    {
        public bool CanFly { get; set; }

        public Bird(bool canFly, string spacies, byte age, float weight):base (spacies ,age ,weight )
        {
            CanFly = canFly;
        }
        public override  void ShowInfo()
        {
            Console.WriteLine($"Qus uca bilir:{CanFly }");
        }
    }
}
