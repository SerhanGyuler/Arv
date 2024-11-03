namespace Arv
{
    internal class LionTigerSubClass : Lion
    {
        public string StripePattern { get; set; } = "Black/White stripes";

        public LionTigerSubClass(
            string species = "Tiger",
            int age = 3,
            double weight = 220.0,
            string habitat = "Rainforest",
            string diet = "Meat",
            int teethLength = 7,
            string stripePattern = "Black/White stripes") : base(species, age, weight, habitat, diet, teethLength)
        {
            StripePattern = stripePattern;
        }

        public void Climb()
        {
            Console.WriteLine("The tiger climbs trees skillfully");
        }

        public void MakeSounds()
        {
            Console.WriteLine("Rooaaaarrr! I'm a tiger this time");
        }
    }
}
