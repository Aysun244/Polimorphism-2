using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism_2.Models
{
   class Mammal : Animal
    {
        public bool HasFur { get; set; }

        public Mammal(bool hasFur,string spacies,byte age, float weight):base(spacies ,age,weight )
        {
            HasFur = hasFur;
        }
        public override void  ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Tukludur:{HasFur}");
        }

    }
}
