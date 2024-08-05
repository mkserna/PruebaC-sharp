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

        public override void ShowInformation()
        {
            ManagerApp.Header($"Información de {Name} 🐶");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate}");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {WeightInKg} kg");
            Console.WriteLine($"Estado de castración: {BreedingStatus}");
            Console.WriteLine($"Temperamento: {Temperament}");
            Console.WriteLine($"Número de microchip: {MicrochipNumber}");
            Console.WriteLine($"Volumen del ladrido: {BarkVolume}");
            Console.WriteLine($"Tipo de capa: {CoatType}");
        }
        //Metodo para saber si el perro está castrado
        public void CastrateAnimal()
        {
            if (BreedingStatus == true)
            {
                Console.WriteLine("El perro ya está castrado. No puedes castrarlo otra vez");

            }
            else if (BreedingStatus == false)
            {
                Console.WriteLine("Perro castrado. Ahora está castrado");
                BreedingStatus = true;
            }
        }

        //Longitud de pelo del perro
        public void HairdressDog()
        {
            if (CoatType == "Sin pelo"){
                Console.WriteLine("El perro no tiene pelo, no lo puedes peliquerar");
                
            }else if (CoatType == "Pelo corto"){
                Console.WriteLine("El perro tiene pelo corto, no lo puedes peliquerar");

            }else if (CoatType == "Pelo largo"){
                Console.WriteLine("Perro peluqueado. Ahora tiene el pelo corto");
                CoatType = "Pelo corto";
            }
        }

        //Volumen del ladrido del perro
        public string? DogBarkVolume(byte dogBarkVolume)
        {
            if (dogBarkVolume == 1)
            {
                BarkVolume = "Bajo";
            }
            else if (dogBarkVolume == 2)
            {
                BarkVolume = "Medio";
            }
            else if (dogBarkVolume == 3)
            {
                BarkVolume = "Alto";
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }
            return BarkVolume;
        }

        //Temperamento del perro
        public void DogTemperament(byte dogTemperament)
        {
            if (dogTemperament == 1)
            {
                Temperament = "Timido";
            }
            else if (dogTemperament == 2)
            {
                Temperament = "Tranquilo";
            }
            else if (dogTemperament == 3)
            {
                Temperament = "Agresivo";
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }

        }
    }
}