using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public static class ManagerApp
    {
        private static int CurrenlyId = 1;
        public static Dog CreateDog()
        {
            int newId = CurrenlyId++;

            Console.Write("Nombre del perro: ");
            string? newDogName = Console.ReadLine();
            Separator();

            Console.Write("Fecha de nacimiento (aaaa/mm/dd) del perro: ");
            DateOnly newDogBirthDate = DateOnly.Parse(Console.ReadLine());
            //Validar que la fecha no sea mayor a la actual y volver a pedirle la fecha de nacimiento si es así 
            while (newDogBirthDate > DateOnly.FromDateTime(DateTime.Now))
            {
                Console.WriteLine("La fecha de nacimiento no puede ser mayor a la actual");
                Console.Write("Fecha de nacimiento (aaaa/mm/dd) del perro: ");
                newDogBirthDate = DateOnly.Parse(Console.ReadLine());
            }

            Separator();

            Console.Write("Raza del perro: ");
            string? newDogRace = Console.ReadLine();
            Separator();

            Console.Write("Color del perro: ");
            string? newDogColor = Console.ReadLine();
            Separator();

            Console.Write("Peso del perro (kg):");
            double newDogWeight = Convert.ToDouble(Console.ReadLine());
            Separator();

            Console.Write("Número de microchip del perro: ");
            string? newDogMicrochip = Console.ReadLine();
            Separator();

            Console.WriteLine("¿El perro está castrado?: ");
            Console.WriteLine("   1. Si");
            Console.WriteLine("   2. No");
            Console.Write("Ingresa tu respuesta: ");
            byte dogIsBarking = Convert.ToByte(Console.ReadLine());
            bool newDogIsBarking;
            if (dogIsBarking == 1)
            {
                newDogIsBarking = true;
            }
            else
            {
                newDogIsBarking = false;
            }
            Separator();

            Console.WriteLine("¿Que temperamento tiene el perro?:");
            Console.WriteLine("   1. Timido");
            Console.WriteLine("   2. Tranquilo");
            Console.WriteLine("   3. Agresivo");
            Console.Write("Ingresa tu respuesta: ");
            byte dogTemperament = Convert.ToByte(Console.ReadLine());
            string? newDogTemperament;
            if (dogTemperament == 1)
            {
                newDogTemperament = "Timido";
            }
            else if (dogTemperament == 2)
            {
                newDogTemperament = "Tranquilo";
            }
            else
            {
                newDogTemperament = "Agresivo";
            }
            Separator();

            Console.WriteLine("Volumen del ladrido del perro:");
            Console.WriteLine("   1. Bajo");
            Console.WriteLine("   2. Medio");
            Console.WriteLine("   3. Alto");
            Console.Write("Ingresa tu respuesta: ");
            byte dogBarkVolume = Convert.ToByte(Console.ReadLine());
            string? newDogBarkVolume;
            if (dogBarkVolume == 1)
            {
                newDogBarkVolume = "Bajo";
            }
            else if (dogBarkVolume == 2)
            {
                newDogBarkVolume = "Medio";
            }
            else
            {
                newDogBarkVolume = "Alto";
            }
            Separator();

            Console.WriteLine("Longitud de pelo del perro:");
            Console.WriteLine("   1. Sin pelo");
            Console.WriteLine("   2. Pelo corto");
            Console.WriteLine("   3. Pelo largo");
            Console.Write("Ingresa tu respuesta: ");
            byte dogCoatType = Convert.ToByte(Console.ReadLine());
            string? newDogCoatType;
            if (dogCoatType == 1)
            {
                newDogCoatType = "Sin pelo";
            }
            else if (dogCoatType == 2)
            {
                newDogCoatType = "Pelo corto";
            }
            else
            {
                newDogCoatType = "Pelo largo";
            }

            Dog newDog = new Dog(newId, newDogName, newDogBirthDate, newDogRace, newDogColor, newDogWeight, newDogIsBarking, newDogTemperament, newDogMicrochip, newDogBarkVolume, newDogCoatType);

            return newDog;
        }

        public static Cat CreateCat()
        {
            int newId = CurrenlyId++;

            Console.Write("Nombre del gato: ");
            string? newCatName = Console.ReadLine();
            Separator();

            Console.Write("Fecha de nacimiento (aaaa/mm/dd) del gato: ");
            DateOnly newCatBirthDate = DateOnly.Parse(Console.ReadLine());
            while (newCatBirthDate > DateOnly.FromDateTime(DateTime.Now))
            {
                Console.WriteLine("La fecha de nacimiento no puede ser mayor a la actual");
                Console.Write("Fecha de nacimiento (aaaa/mm/dd) del perro: ");
                newCatBirthDate = DateOnly.Parse(Console.ReadLine());
            }
            Separator();

            Console.Write("Raza del gato: ");
            string? newCatRace = Console.ReadLine();
            Separator();

            Console.Write("Color del gato: ");
            string? newCatColor = Console.ReadLine();
            Separator();

            Console.Write("Peso del gato (kg):");
            double newCatWeight = Convert.ToDouble(Console.ReadLine());
            Separator();

            Console.WriteLine("¿El gato está castrado?: ");
            Console.WriteLine("   1. Si");  
            Console.WriteLine("   2. No");
            Console.Write("Ingresa tu respuesta: ");
            byte catIsBarking = Convert.ToByte(Console.ReadLine());
            bool newCatIsBarking;
            if (catIsBarking == 1)
            {
                newCatIsBarking = true;
            }
            else
            {
                newCatIsBarking = false;
            }
            Separator();

            Console.WriteLine("Longitud de pelo del gato:");
            Console.WriteLine("   1. Sin pelo");
            Console.WriteLine("   2. Pelo corto");
            Console.WriteLine("   3. Pelo largo");
            Console.Write("Ingresa tu respuesta: ");
            byte catCoatType = Convert.ToByte(Console.ReadLine());
            string? newCatCoatType;
            if (catCoatType == 1)
            {
                newCatCoatType = "Sin pelo";
            }
            else if (catCoatType == 2)
            {
                newCatCoatType = "Pelo corto";
            }
            else 
            {
                newCatCoatType = "Pelo largo";
            }
            Separator();

            Cat newCat = new Cat(newId, newCatName, newCatBirthDate, newCatRace, newCatColor, newCatWeight, newCatIsBarking, newCatCoatType);

            return newCat;
        }
        public static void Header(string tittle)
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(TextCenter(tittle, 50));
            Console.WriteLine(new string('=', 50));
        }

        public static void Footer(string footer)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(TextCenter(footer, 50));
            Console.WriteLine(new string('-', 50));
        }

        public static void Separator()
        {
            Console.WriteLine(new string('-', 50));
        }

        private static string TextCenter(string text, int longitudTotal)
        {
            if (text.Length >= longitudTotal)
                return text;

            int spaceLeft = (longitudTotal - text.Length) / 2;
            int spaceRight = longitudTotal - text.Length - spaceLeft;

            return new string(' ', spaceLeft) + text + new string(' ', spaceRight);
        }

    }
}