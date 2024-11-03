namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instances of animals
            Parrot parrot = new Parrot();
            Lion lion = new Lion();
            Elephant elephant = new Elephant();
            LionTigerSubClass tiger = new LionTigerSubClass();
            LionLeopardSubClass leopard = new LionLeopardSubClass();

            Console.WriteLine("Animals sounds and properties\n");

            // Parrot
            parrot.MakeSound();
            parrot.MimicSound();
            parrot.Eat();
            parrot.Live();
            parrot.WeightAnimal();

            Console.WriteLine();

            // Lion
            lion.MakeSound();
            lion.Hunt();
            lion.Eat();
            lion.Live();
            lion.WeightAnimal();

            Console.WriteLine();

            // Elephant
            elephant.MakeSound();
            elephant.SprayWater();
            elephant.Eat();
            elephant.Live();
            elephant.WeightAnimal();

            Console.WriteLine();

            // Tiger
            tiger.MakeSound();
            tiger.Climb();
            tiger.Eat();
            tiger.Live();
            tiger.WeightAnimal();

            Console.WriteLine();

            // Leopard
            leopard.MakeSound();
            leopard.Hide();
            leopard.Eat();
            leopard.Live();
            leopard.WeightAnimal();
        }
    }
}
