using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public class Cat(string name,
    DateOnly birthdate,
    string breed,
    string color,
    double weightInKg,
    bool breedingStatus,
    string furLength) :
    Animal(name,
    birthdate,
    breed,
    color,
    weightInKg)
    {
        public bool BreedingStatus { get; set; } = breedingStatus; //Estado de castración
        public string FurLength { get; set; } = furLength; //Longitud de pelo

        //Metodo para saber si el gato está castrado
        public void CastrateAnimal()
        {
            if (BreedingStatus == true)
            {
                Console.WriteLine($"El gato está castrado.");
            }
            else
            {
                Console.WriteLine($"El gato no está castrado.");
            }
        }

        //Peliqueria del gato
        public void Hairdress()
        {

        }
    }
}