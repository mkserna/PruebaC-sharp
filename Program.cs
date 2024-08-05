using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            VeterinaryClinic veterinaryClinic = new VeterinaryClinic("Veterinario", "Calle de la Veterinaria");

            bool exit = false;
            while (!exit)
            {
                ManagerApp.Header("Veterinario RIWI");
                Console.WriteLine("¿Qué quieres hacer?");
                ManagerApp.Separator();
                Console.WriteLine("1. Seccion de perros");
                ManagerApp.Separator();
                Console.WriteLine("2. Seccion de gatos");
                ManagerApp.Separator();
                Console.WriteLine("3. Ver los animales");
                ManagerApp.Separator();
                Console.WriteLine("4. Salir");
                ManagerApp.Separator();
                Console.Write("Ingresa tu respuesta: ");
                byte option = Convert.ToByte(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        bool exitDog = false;
                        while (!exitDog)
                        {
                            ManagerApp.Header("Seccion de Perros");
                            Console.WriteLine("¿Qué quieres hacer?");
                            ManagerApp.Separator();
                            Console.WriteLine("1. Registrar perro");
                            ManagerApp.Separator();
                            Console.WriteLine("2. Actualizar perro");
                            ManagerApp.Separator();
                            Console.WriteLine("3. Eliminar perro");
                            ManagerApp.Separator();
                            Console.WriteLine("4. Ver perros");
                            ManagerApp.Separator();
                            Console.WriteLine("5. Esterilizacion");
                            ManagerApp.Separator();
                            Console.WriteLine("6. Peliqueria");
                            ManagerApp.Separator();
                            Console.WriteLine("7. Salir");
                            ManagerApp.Separator();
                            Console.Write("Ingresa tu respuesta: ");
                            
                            byte optionDogs = Convert.ToByte(Console.ReadLine());
                            switch (optionDogs)
                            {
                                case 1:
                                    veterinaryClinic.SaveDog();
                                    break;
                                case 2:
                                    veterinaryClinic.UpdateDog();
                                    break;
                                case 3:
                                    veterinaryClinic.DeleteDog();
                                    break;
                                case 4:
                                    veterinaryClinic.ShowAllDogs();
                                    break;
                                case 5:
                                    veterinaryClinic.CastrateDog();
                                    break;
                                case 6:
                                    veterinaryClinic.HairdressDog();
                                    break;
                                case 7:
                                    exitDog = true;
                                    break;
                                default:
                                    ManagerApp.Footer("Opción no válida");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        bool exitCat = false;
                        while (!exitCat)
                        {
                            ManagerApp.Header("Seccion de Gatos");
                            Console.WriteLine("¿Qué quieres hacer?");
                            ManagerApp.Separator();
                            Console.WriteLine("1. Registrar gato");
                            ManagerApp.Separator();
                            Console.WriteLine("2. Actualizar gato");
                            ManagerApp.Separator();
                            Console.WriteLine("3. Eliminar gato");
                            ManagerApp.Separator();
                            Console.WriteLine("4. Ver gatos");
                            ManagerApp.Separator();
                            Console.WriteLine("5. Esterilizacion");
                            ManagerApp.Separator();
                            Console.WriteLine("6. Peliqueria");
                            ManagerApp.Separator();
                            Console.WriteLine("7. Salir");
                            ManagerApp.Separator();
                            Console.Write("Ingresa tu respuesta: ");
                            byte optionCats = Convert.ToByte(Console.ReadLine());
                            switch (optionCats)
                            {
                                case 1:
                                    veterinaryClinic.SaveCat();
                                    break;
                                case 2:
                                    veterinaryClinic.UpdateCat();
                                    break;
                                case 3:
                                    veterinaryClinic.DeleteCat();
                                    break;
                                case 4:
                                    veterinaryClinic.ShowAllCats();
                                    break;
                                case 5:
                                    veterinaryClinic.CastrateCat();
                                    break;
                                case 6: 
                                    veterinaryClinic.HairdressCat();
                                    break;
                                case 7:
                                    exitCat = true;
                                    break;
                                default:
                                    ManagerApp.Footer("Opción no válida");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        bool exitAnimals = false;
                        while (!exitAnimals)
                        {
                            ManagerApp.Header("Veterinario RIWI");
                            Console.WriteLine("¿Qué quieres hacer?");
                            ManagerApp.Separator();
                            Console.WriteLine("1. Ver todos los pacientes");
                            ManagerApp.Separator();
                            Console.WriteLine("2. Ver todos los animales por tipo");
                            ManagerApp.Separator();
                            Console.WriteLine("3. Buscar un animal por Id");
                            ManagerApp.Separator();
                            Console.WriteLine("4. Salir");
                            ManagerApp.Separator();
                            Console.WriteLine("Ingresa tu respuesta: ");
                            byte optionAnimals = Convert.ToByte(Console.ReadLine());
                            switch (optionAnimals)
                            {
                                case 1:
                                    veterinaryClinic.ShowAllPatients();
                                    break;
                                case 2:
                                    veterinaryClinic.ShowAnimal();
                                    break;
                                case 3:
                                    veterinaryClinic.ShowPatient();
                                    break;
                                case 4:
                                    exitAnimals = true;
                                    break;
                                default:
                                    ManagerApp.Footer("Opción no válida");
                                    break;
                            }

                        }
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}