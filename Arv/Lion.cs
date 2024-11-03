namespace Arv
{
    internal class Lion : Animal
    {
        public int TeethLength { get; set; } = 7;

        public Lion(
            string species = "Lion",
            int age = 5,
            double weight = 190.5,
            string habitat = "Savannah",
            string diet = "Meat",
            int teethLength = 7) : base(species, age, weight, habitat, diet)
        {
            TeethLength = teethLength;
        }

        public void Hunt()
        {
            Console.WriteLine("lion hunts by stalking its prey quietly until it’s close enough to pounce." +
                " Using teamwork, lions often hunt in groups to surround and ambush animals," +
                " targeting the weaker or slower members for an efficient kill.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Roooaaar!");
        }
    }
}
