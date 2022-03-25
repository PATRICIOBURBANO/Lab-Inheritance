using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance.Models
{

    internal class Video : IMedia
    {
        public int Id { get; set; }
       
        public string Title { get; set; }

        public int ArtistId { get; set; }

        public int RunTime { get; set; }

        public ICollection<IMedia> MediaObjects { get; set; }

        public void Play()
        {
            Console.WriteLine($"You are watching {Title} on your inadequate viewing screen for {RunTime}.");
        }
    }
}
