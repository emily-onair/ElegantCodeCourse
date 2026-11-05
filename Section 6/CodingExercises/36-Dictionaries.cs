using System;

namespace Coding.Exercise
{
    public static class Exercise
    {
        public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
        {
            var maxWeights = new Dictionary<PetType, double>();
            foreach (var pet in pets) {
                if (!maxWeights.ContainsKey(pet.PetType)) {
                    maxWeights.Add(pet.PetType, pet.Weight);
                }
                if (maxWeights[pet.PetType] < pet.Weight)
                {
                    maxWeights[pet.PetType] = pet.Weight;
                }
            }
            return maxWeights;
        }
    }
    
    public class Pet
    {
        public PetType PetType { get; }
        public double Weight { get; }
    
        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;    
        }
        
        public override string ToString() => $"{PetType}, {Weight} kilos";
    }
    
    public enum PetType { Dog, Cat, Fish }
}