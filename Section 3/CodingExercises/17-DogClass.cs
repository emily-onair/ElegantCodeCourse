using System;

namespace Coding.Exercise
{
    public class Dog
    {
        public Dog (string name, int weight) : this(name, "mixed-breed", weight) {}
        
        public Dog (string name, string breed, int weight) {
            Name = name;
            Breed = breed;
            Weight = weight;
        }
        
        private string Name;
        private string Breed;
        private int Weight;
        
        private string ClassifyWeight(int weight) {
            if (weight < 5) return "tiny";
            if (weight < 30) return "medium";
            return "large";
        }
        
        public string Describe() {
            return $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {ClassifyWeight(Weight)} dog.";
        }
    }
}
