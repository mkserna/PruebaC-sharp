using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public class Dog(string name,
    DateOnly birthdate,
    string breed,
    string color,
    double weightInKg,
    bool breedingStatus,
    string temperament,
    string microchipNumber,
    string barkVolume,
    string coatType) :
    Animal(name,
    birthdate,
    breed,
    color,
    weightInKg)
    {
        public bool BreedingStatus { get; set; } = breedingStatus; //Estado de castración
        public string Temperament { get; set; } = temperament;
        public string MicrochipNumber { get; set; } = microchipNumber;
        public string BarkVolume { get; set; } = barkVolume; //Ladrido
        public string CoatType { get; set; } = coatType; //Tipo de capa

        //Metodo para saber si el perro está castrado
        public void CastrateAnimal()
        {
            if (BreedingStatus == true)
            {
                Console.WriteLine($"El perro está castrado.");
            }
            else
            {
                Console.WriteLine($"El perro no está castrado.");
            }
        }

        //Peliqueria del perro
        public void Hairdress()
        {

        }
    }
}