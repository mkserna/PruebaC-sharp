using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public class VeterinaryClinic
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Cat> Cats { get; set; } = new List<Cat>();

        public List<Dog> Dogs { get; set; } = new List<Dog>();

        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
        }

        //----------------------CATS--------------------------------------
        //Metodo para agregar un gato
        public void SaveCat()
        {
            ManagerApp.Header("Registro de gato 😺");
            var saveNewCat = ManagerApp.CreateCat();
            Cats.Add(saveNewCat);
            ManagerApp.Footer("Gato registrado con éxito");
        }

        //Metodo para actualizar un gato
        public void UpdateCat()
        {
            ManagerApp.Header("Actualización de gato 😺");
            ShowAllCats();
            ManagerApp.Separator();
            Console.WriteLine("Ingresa el id del gato: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Cat cat = Cats.Find(x => x.GetId() == id);

            if (cat != null)
            {

                Console.Write($"Ingresa el nuevo nombre del gato (o dejar en blanco para no cambiar ({cat.GetName()})): ");
                string newName = Console.ReadLine();
                ManagerApp.Separator();

                Console.Write($"Ingresa la nueva raza (o dejar en blanco para no cambiar ({cat.GetBreed()})): ");
                string newBreed = Console.ReadLine();
                ManagerApp.Separator();

                Console.Write($"Ingresa la nueva color (o dejar en blanco para no cambiar ({cat.GetColor()})): ");
                string newColor = Console.ReadLine();
                ManagerApp.Separator();

                Console.Write($"Ingresa el nuevo peso (o ingresar 0 para no cambiar ({cat.GetWeightInKg()})): ");
                double newWeight = Convert.ToDouble(Console.ReadLine());
                ManagerApp.Separator();

                Console.WriteLine($"Ingresa el nuevo largo de pelo");
                Console.WriteLine("1. Sin pelo");
                Console.WriteLine("2. Pelo corto");
                Console.WriteLine("3. Pelo largo");
                Console.Write($"O deja en blanco para no cambiar ({cat.FurLength}):");
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
                ManagerApp.Separator();

                cat.SetName(string.IsNullOrEmpty(newName) ? cat.GetName() : newName);
                cat.SetBreed(string.IsNullOrEmpty(newBreed) ? cat.GetBreed() : newBreed);
                cat.SetColor(string.IsNullOrEmpty(newColor) ? cat.GetColor() : newColor);
                cat.SetWeightInKg((newWeight == 0) ? cat.GetWeightInKg() : newWeight);
                cat.FurLength = string.IsNullOrEmpty(newCatCoatType) ? cat.FurLength : newCatCoatType;

                ManagerApp.Footer("Gato actualizado con éxito");
            }
        }

        //Metodo para eliminar un gato
        public void DeleteCat()
        {
            ManagerApp.Header("Eliminación de gato 😺");
            ShowAllCats();
            ManagerApp.Separator();
            Console.WriteLine("Ingresa el id del gato: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Cat cat = Cats.Find(x => x.GetId() == id);

            if (cat != null)
            {
                Cats.Remove(cat);
                ManagerApp.Footer("Gato eliminado con éxito");
            }
            else
            {
                ManagerApp.Footer("No existe ese gato");
            }
        }

        public void ShowAllCats()
        {
            if (Cats.Count == 0)
            {
                ManagerApp.Footer("No hay gatos 😺");
            }
            else
            {
                foreach (Cat cat in Cats)
                {
                    cat.ShowInformation();
                }
            }
        }
        //----------------------DOGS--------------------------------------
        //Metodo para guardar un perro
        public void SaveDog()
        {
            ManagerApp.Header("Registro de perro 🐶");
            var newDog = ManagerApp.CreateDog();
            Dogs.Add(newDog);
            ManagerApp.Footer("Perro registrado con éxito");
        }

        //Metodo para actualizar un gato
        public void UpdateDog()
        {
            ManagerApp.Header("Actualización de perro 🐶");
            ShowAllDogs();
            ManagerApp.Separator();
            Console.WriteLine("Ingresa el id del perro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Dog dog = Dogs.Find(x => x.GetId() == id);

            if (dog != null)
            {
                Console.Write($"Ingresa el nuevo nombre del perro (o dejar en blanco para no cambiar ({dog.GetName()})): ");
                string newName = Console.ReadLine();
                ManagerApp.Separator();

                Console.Write($"Ingresa la nueva raza (o dejar en blanco para no cambiar ({dog.GetBreed()})): ");
                string newBreed = Console.ReadLine();
                ManagerApp.Separator();

                Console.Write($"Ingresa la nueva color (o dejar en blanco para no cambiar ({dog.GetColor()})): ");
                string newColor = Console.ReadLine();
                ManagerApp.Separator();

                Console.Write($"Ingresa el nuevo peso (o ingresar 0 para no cambiar ({dog.GetWeightInKg()})): ");
                double newWeight = Convert.ToDouble(Console.ReadLine());
                ManagerApp.Separator();

                Console.WriteLine($"¿Que temperamento tiene el perro?:");
                Console.WriteLine("   1. Timido");
                Console.WriteLine("   2. Tranquilo");
                Console.WriteLine("   3. Agresivo");
                Console.Write($"Ingresa tu respuesta o ingresar 0 para no cambiar ({dog.Temperament}): ");
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
                ManagerApp.Separator();

                Console.Write($"Número de microchip del perro o dejar en blanco para no cambiar ({dog.MicrochipNumber}): ");
                string? newDogMicrochip = Console.ReadLine();
                ManagerApp.Separator();

                Console.WriteLine($"Volumen del ladrido del perro:");
                Console.WriteLine("   1. Bajo");
                Console.WriteLine("   2. Medio");
                Console.WriteLine("   3. Alto");
                Console.Write($"Ingresa tu respuesta o ingresar 0 para no cambiar ({dog.BarkVolume}): ");
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
                ManagerApp.Separator();

                Console.WriteLine($"Longitud de pelo del perro:");
                Console.WriteLine("   1. Sin pelo");
                Console.WriteLine("   2. Pelo corto");
                Console.WriteLine("   3. Pelo largo");
                Console.Write($"O ingresar 0 para no cambiar ({dog.CoatType}): ");
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
                ManagerApp.Separator();

                dog.SetName(string.IsNullOrEmpty(newName) ? dog.GetName() : newName);
                dog.SetBreed(string.IsNullOrEmpty(newBreed) ? dog.GetBreed() : newBreed);
                dog.SetColor(string.IsNullOrEmpty(newColor) ? dog.GetColor() : newColor);
                dog.SetWeightInKg((newWeight == 0) ? dog.GetWeightInKg() : newWeight);
                dog.Temperament = string.IsNullOrEmpty(newDogTemperament) ? dog.Temperament : newDogTemperament;
                dog.MicrochipNumber = string.IsNullOrEmpty(newDogMicrochip) ? dog.MicrochipNumber : newDogMicrochip;
                dog.BarkVolume = string.IsNullOrEmpty(newDogBarkVolume) ? dog.BarkVolume : newDogBarkVolume;
                dog.CoatType = string.IsNullOrEmpty(newDogCoatType) ? dog.CoatType : newDogCoatType;

                ManagerApp.Footer("Perro actualizado con éxito");

            }
        }

        //Metodo para eliminar un perro 
        public void DeleteDog()
        {
            ManagerApp.Header("Eliminación de perro 🐶");
            ShowAllDogs();
            ManagerApp.Separator();
            Console.WriteLine("Ingresa el id del perro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Dog dog = Dogs.Find(x => x.GetId() == id);

            if (dog != null)
            {
                Dogs.Remove(dog);
                ManagerApp.Footer("Perro eliminado con éxito");
            }
            else
            {
                ManagerApp.Footer("No existe ese perro");
            }
        }
        //ver todos los perros
        public void ShowAllDogs()
        {
            if (Dogs.Count == 0)
            {
                ManagerApp.Footer("No hay perros 🐶");
            }
            else
            {
                foreach (Dog dog in Dogs)
                {
                    dog.ShowInformation();
                }
            }
        }

        //---------------------------GENERAL------------------------------
        //Metodo para ver todos los pacientes
        public void ShowAllPatients()
        {
            foreach (Cat cat in Cats)
            {
                cat.ShowInformation();
            }
            foreach (Dog dog in Dogs)
            {
                dog.ShowInformation();
            }
        }

        //Metodo para ver los animales de un tipo
        public void ShowAnimal()
        {
            Console.WriteLine("Elige el tipo de animal que deseas ver");
            Console.WriteLine("1. Gatos");
            Console.WriteLine("2. Perros");
            Console.Write("Ingresa tu respuesta: ");
            string type = Console.ReadLine();
            ManagerApp.Separator();

            if (type == "1")
            {
                foreach (Cat cat in Cats)
                {
                    cat.ShowInformation();
                }
            }
            else if (type == "2")
            {
                foreach (Dog dog in Dogs)
                {
                    dog.ShowInformation();
                }
            }
            else
            {
                ManagerApp.Footer("No existe ese tipo de animal");
            }
        }

        //Metodo para buscar un animal por su id
        public void ShowPatient()
        {
            ShowAllPatients();
            ManagerApp.Separator();
            Console.WriteLine("Ingresa el id del animal: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            if (id == 0)
            {
                ManagerApp.Footer("No existe ese animal");
            }
            else
            {
                Cat cat = Cats.Find(x => x.GetId() == id);
                if (cat != null)
                {
                    cat.ShowInformation();
                }
                else
                {
                    Dog dog = Dogs.Find(x => x.GetId() == id);
                    if (dog != null)
                    {
                        dog.ShowInformation();
                    }
                    else
                    {
                        ManagerApp.Footer("No existe ese animal");
                    }
                }
            }
        }

        //Peluqueria

        public void HairdressCat()
        {
            Console.WriteLine("Ingresa el id del gato: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Cat cat = Cats.Find(x => x.GetId() == id);

            if (cat != null)
            {
                cat.HairdressCat();
            }
            else
            {
                ManagerApp.Footer("No existe ese gato");
            }

        }

        public void HairdressDog()
        {
            Console.WriteLine("Ingresa el id del perro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Dog dog = Dogs.Find(x => x.GetId() == id);

            if (dog != null)
            {
                dog.HairdressDog();
            }
            else
            {
                ManagerApp.Footer("No existe ese perro");
            }

        }

        public void CastrateCat()
        {
            Console.WriteLine("Ingresa el id del gato: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Cat cat = Cats.Find(x => x.GetId() == id);

            if (cat != null)
            {
                cat.CastrateAnimal();
            }
            else
            {
                ManagerApp.Footer("No existe ese gato");
            }
        }

        public void CastrateDog()
        {
            Console.WriteLine("Ingresa el id del perro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ManagerApp.Separator();

            Dog dog = Dogs.Find(x => x.GetId() == id);

            if (dog != null)
            {
                dog.CastrateAnimal();
            }
            else
            {
                ManagerApp.Footer("No existe ese perro");
            }
        }

    }
}