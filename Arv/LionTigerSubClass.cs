namespace Arv
{
    internal class LionTigerSubClass : Lion
    {
        // Property
        public string StripePattern { get; set; } = "Black/White stripes";

        // Constructor
        public LionTigerSubClass(
            string species = "Tiger",
            int age = 3,
            double weight = 220.0,
            string habitat = "Rainforest",
            string diet = "Meat",
            int teethLength = 7,
            string stripePattern = "Black/White stripes") : base(species, age, weight, habitat, diet, teethLength)
        {
            this.StripePattern = stripePattern;
        }

        // Methods
        public void Climb()
        {
            Console.WriteLine("The tiger climbs trees skillfully");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rooaaaarrr! I'm a tiger this time");
        }
    }
}
