namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanser av djur
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
            parrot.Sleep();

            Console.WriteLine();
            // Lion
            lion.MakeSound();
            lion.Hunt();
            lion.Eat();
            lion.Sleep();
            lion.Move();

            Console.WriteLine();
            // Elephant
            elephant.MakeSound();
            elephant.SprayWater();
            elephant.Eat();
            elephant.Sleep();
            elephant.Move();

            Console.WriteLine();
            // Tiger
            tiger.MakeSound();
            tiger.Climb();
            tiger.Eat();
            tiger.Sleep();

            Console.WriteLine();
            // Leopard
            leopard.MakeSound();
            leopard.Hide();
            leopard.Eat();
            leopard.Sleep();
        }
    }
}
