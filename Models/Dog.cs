using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public class Dog(int id,
    string name,
    DateOnly birthdate,
    string breed,
    string color,
    double weightInKg,
    bool breedingStatus,
    string temperament,
    string microchipNumber,
    string barkVolume,
    string coatType) :
    Animal(id, 
    name,
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

        public override void ShowInformation()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate}");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {WeightInKg} kg");
            Console.WriteLine($"Estado de castración: {BreedingStatus}");
            Console.WriteLine($"Temperamento: {Temperament}");
            Console.WriteLine($"Número de microchip: {MicrochipNumber}");
            Console.WriteLine($"Volumen de la piel: {BarkVolume}");
            Console.WriteLine($"Tipo de capa: {CoatType}");
        }

        //Peliqueria del perro
        public void Hairdress()
        {

        }
    }
}