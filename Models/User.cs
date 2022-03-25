using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance.Models
{

    public abstract class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<IMedia> MediaObjects { get; set; }

        public User(int id, string name)
        {
            Id = id;

            Name = name;

            MediaObjects = new List<IMedia>();
        }

        public virtual string GenerateEmail()
        {
            
            Email = Name + Id.ToString() + "@yahoo.com";

            return Email;
        }

        public void Binge()
        {
            foreach (IMedia media in MediaObjects)
            {

                media.Play();
            }
        }

        public User()
        {

            MediaObjects = new HashSet<IMedia>();

        }
    }

}
