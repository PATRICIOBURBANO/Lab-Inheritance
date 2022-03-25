using Lab_Inheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Abstract.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist artist1 = new Artist(1, "Jon Bon Jovi");
            Artist artist2= new Artist(2, "Jon Bon Jovi");
            Artist artist3 = new Artist(3, "Jon Bon Jovi");
            Artist artist4 = new Artist(4, "Jon Bon Jovi");
            Artist artist5 = new Artist(5, "Jon Bon Jovi");

            IMedia song1 = new Song(1, "Always", 1, 150);
            IMedia song2 = new Song(2, "Always", 1, 150);
            IMedia song3 = new Song(3, "Always", 1, 150);
            IMedia song4 = new Song(4, "Always", 1, 150);
            IMedia song5 = new Song(5, "Always", 1, 150);
            
            Customer customer1 = new Customer(1, "TheDarkUser");
            Customer customer2 = new Customer(2, "PatricioBurbano");
            Customer customer3 = new Customer(3, "TheDevil");
            Customer customer4 = new Customer(4, "HenryFayol");
            Customer customer5 = new Customer(5, "TomCruise");


            customer1.GenerateEmail();
            customer2.GenerateEmail();
            customer3.GenerateEmail();
            customer4.GenerateEmail();
            customer5.GenerateEmail();

            customer1.MediaObjects.Add(song1);
            customer2.MediaObjects.Add(song2);
            customer3.MediaObjects.Add(song3);
            customer4.MediaObjects.Add(song4);
            customer5.MediaObjects.Add(song5);


            customer1.Binge();
            customer2.Binge();
            customer3.Binge();
            customer4.Binge();
            customer5.Binge();

            artist1.GenerateEmail();
            artist2.GenerateEmail();
            artist3.GenerateEmail();
            artist4.GenerateEmail();
            artist5.GenerateEmail();

        }
    }

}