using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MarianaPerezSerna.Models
{
    public class ManagerApp
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Cat> Cats { get; set; }

        public List<Dog> Dogs { get; set; }

        public ManagerApp(string name, string address)
        {
            Name = name;
            Address = address;
            Cats = new List<Cat>();
            Dogs = new List<Dog>();
        }

        //----------------------CATS--------------------------------------
        //Metodo para agregar un gato
        public void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
        }

        //Metodo para actualizar un gato
        public void UpdateCat()
        {

        }

        //Metodo para eliminar un gato
        public void DeleteCat()
        {

        }

        //----------------------DOGS--------------------------------------
        //Metodo para guardar un perro
        public void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
        }

        //Metodo para actualizar un gato
        public void UpdateDog()
        {

        }

        //Metodo para eliminar un perro 
        public void DeleteDog()
        {
        }
        
        //---------------------------GENERAL------------------------------
        //Metodo para ver todos los pacientes
        public void ShowAllPatients()
        {
            foreach (var cat in Cats)
            {
                cat.ShowInformation();
            }
            foreach (var dog in Dogs)
            {
                dog.ShowInformation();
            }
        }

        //Metodo para ver los animales de un tipo
        public void ShowAnimal(string type)
        {

        }

        //Metodo para buscar un animal por su id
        public void ShowPatient()
        {

        }

    }
}