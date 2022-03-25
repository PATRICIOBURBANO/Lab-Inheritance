using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance.Models
{
    public interface IMedia
    {
        int Id { get; set; }

        string Title { get; set; }

        int RunTime { get; set; }

        int ArtistId { get; set; }

        public ICollection<IMedia> MediaObjects { get; set; }

        void Play();
    }
}
