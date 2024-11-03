namespace Arv
{
    internal class Elephant : Animal
    {
        // Property
        public int TrunkLength { get; set; } = 2;

        // Constructor
        public Elephant(
            string species = "Elephant",
            int age = 10,
            double weight = 6000.0,
            string habitat = "Savannah",
            string diet = "Plants",
            int trunkLength = 2) : base(species, age, weight, habitat, diet)
        {
            TrunkLength = trunkLength;
        }

        // Methods
        public void SprayWater()
        {
            Console.WriteLine("An elephant sprays water by using its trunk as a hose. " +
                "It sucks water into its trunk and then forcefully expels it, creating a spray." +
                " Elephants often do this to cool off, bathe," +
                " or play, and they can spray water over their bodies or onto other elephants.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Trumpet!");
        }
    }
}
