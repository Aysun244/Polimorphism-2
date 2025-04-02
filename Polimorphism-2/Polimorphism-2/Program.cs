using Polimorphism_2.Models;

namespace Polimorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal delphin = new Mammal(false, "fish", 2, 45);
            Bird owl = new Bird(true, "bird", 3, 12);

            Console.WriteLine($"Memelidir:{delphin .HasFur },Nov:{delphin .Spacies },Yas:{delphin .Age },Ceki:{delphin .Weight }");
            Console.WriteLine($"Uca bilir:{owl.CanFly },Nov:{owl .Spacies },Yas:{owl .Age},Ceki:{owl.Weight }");
        }
    }
}

