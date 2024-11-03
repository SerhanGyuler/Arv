namespace Arv
{
    internal class Animal
    {
        // Properties
        public string Species { get; set; } = "Ants";
        public int Age { get; set; } = 10;
        public double Weight { get; set; } = 43.2;
        public string Habitat { get; set; } = "Warm";
        public string Diet { get; set; } = "Plants";

        // Constructor
        public Animal(string species, int age, double weight, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Weight = weight;
            Habitat = habitat;
            Diet = diet;
        }
        // Methods
        public void Eat()
        {
            Console.WriteLine($"{Species} is eating {Diet}");
        }

        public void Live()
        {
            Console.WriteLine($"{Species}'s is living in {Habitat}");
        }

        public void WeightAnimal()
        {
            Console.WriteLine($"{Species}'s weight is {Weight}kg");
        }
        // Virtual can be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Species} makes a sound");
        }

    }
}
