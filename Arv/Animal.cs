namespace Arv
{
    internal class Animal
    {
        public string Species { get; set; } = "Ants";
        public int Age { get; set; } = 10;
        public double Weight { get; set; } = 43.2;
        public string Habitat { get; set; } = "Warm";
        public string Diet { get; set; } = "Plants";

        public Animal(string species, int age, double weight, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Weight = weight;
            Habitat = habitat;
            Diet = diet;
        }

        public void Eat()
        {
            Console.WriteLine($"{Species} is eating {Diet}");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Species} is sleeping");
        }

        public void Move()
        {
            Console.WriteLine($"{Species} is moving");
        }

    }
}
