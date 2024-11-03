namespace Arv
{
    internal class LionLeopardSubClass : Lion
    {
        // Property
        public string SpotPattern { get; set; } = "Black rosettes";

        // Constructor
        public LionLeopardSubClass(
            string species = "Leopard",
            int age = 4,
            double weight = 90.0,
            string habitat = "Savannah",
            string diet = "Meat",
            int teethLength = 7,
            string SpotPattern = "Black rosettes") : base(species, age, weight, habitat, diet, teethLength)
        {
            this.SpotPattern = SpotPattern;
        }
        // Methods
        public void Hide()
        {
            Console.WriteLine("The leopard hides skillfully in the grass.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Groowwlll!!!");
        }
    }
}
