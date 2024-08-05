using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public class Cat(int id,
    string name,
    DateOnly birthdate,
    string breed,
    string color,
    double weightInKg,
    bool breedingStatus,
    string furLength) :
    Animal(id,
    name,
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
                Console.WriteLine("El gato ya está castrado. No puedes castrarlo otra vez");

            }
            else if (BreedingStatus == false)
            {
                Console.WriteLine("Gato castrado. Ahora está castrado");
                BreedingStatus = true;
            }
        }

        public override void ShowInformation()
        {
            ManagerApp.Header($"Información de {Name} 😺");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate}");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {WeightInKg} kg");
            Console.WriteLine($"Estado de castración: {BreedingStatus}");
            Console.WriteLine($"Longitud de pelo: {FurLength}");
        }

        //Peliqueria del gato
        public void HairdressCat()
        {
            if (FurLength == "Sin pelo")
            {
                Console.WriteLine("El gato no tiene pelo, no lo puedes peliquerar");

            }
            else if (FurLength == "Pelo corto")
            {
                Console.WriteLine("Gato peluqueado. Ahora no tiene pelo");
                FurLength = "Sin pelo";
            }
            else if (FurLength == "Pelo largo")
            {
                Console.WriteLine("Gato peluqueado. Ahora tiene el pelo corto");
                FurLength = "Pelo corto";
            }
        }
    }
}