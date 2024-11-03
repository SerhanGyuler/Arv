namespace Arv
{
    internal class Parrot : Animal
    {
        // Property
        public double WingSpan { get; set; } = 0.5;

        // Constructor
        public Parrot(
            string species = "Parrot",
            int age = 2,
            double weight = 1.5,
            string habitat = "Tropical",
            string diet = "Fruits",
            double wingSpan = 0.5)
            : base(species, age, weight, habitat, diet)
        {
            WingSpan = wingSpan;
        }

        // Methods
        public void MimicSound()
        {
            Console.WriteLine("The parrot mimics sounds!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squawk!");
        }
    }
}

