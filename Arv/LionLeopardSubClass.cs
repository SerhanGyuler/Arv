namespace Arv
{
    internal class LionLeopardSubClass : Lion
    {
        public string SpotPattern { get; set; } = "Black rosettes";

        public LionLeopardSubClass(
            string species = "Leopard",
            int age = 4,
            double weight = 90.0,
            string habitat = "Savannah",
            string diet = "Meat",
            int teethLength = 7,
            string SpotPattern = "Black rosettes") : base(species, age, weight, habitat, diet, teethLength)
        {
            SpotPattern = SpotPattern;
        }

        public void Hide()
        {
            Console.WriteLine("The leopard hides skillfully in the grass.");
        }

        public void MakeSounds()
        {
            Console.WriteLine("Groowwlll!");
        }
    }
}
