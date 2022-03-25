using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance.Models
{
    public class Song : IMedia
    {
        public int Id { get; set; }
       
        public string Title { get; set; }

        public int ArtistId { get; set; }
        
        public virtual Artist Artist { get; set; }

        public virtual Customer Customer { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public ICollection<IMedia> MediaObjects { get; set; }

        public int RunTime { get; set; }

       

        public Song (int id, string title, int artistId, int runTime)
        {
            Id = id;

            Title = title;
            
            ArtistId = artistId;
            
            RunTime = runTime;
        }

        void IMedia.Play()
        {

            Console.WriteLine($"Playing the song {Title} on your favourite music platform for {RunTime}.");
        }
    }
}
