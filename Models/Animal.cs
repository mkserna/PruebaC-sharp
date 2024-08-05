using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public abstract class Animal
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Breed { get; set; } //Raza
        protected string Color { get; set; } 
        protected double WeightInKg { get; set; } //Peso

        public Animal(string name, DateOnly birthdate, string breed, string color, double weightInKg)
        {
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        //Metodo abtracto para mostrar información del animal
        public abstract void ShowInformation();

        //Metodo para realizar una revisión básica del animal
        protected void BasicReview()
        {
            Console.WriteLine($"El animal {Name} tiene {WeightInKg} kg de peso.");
            Console.WriteLine($"Es de {Breed} y es de color {Color}.");
            Console.WriteLine($"Nació el {Birthdate}.");
        }

        //Metodo para calcular la edad del animal en meses
        protected int CalculateAgeInMonths()
        {
            return DateTime.Now.Month - Birthdate.Month;
        }
    }
}