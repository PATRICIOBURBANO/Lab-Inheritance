using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance.Models
{
    public class Customer : User
    {

        public ICollection<IMedia> MediaObjects { get; set; }
        public Customer(int id, string name) : base(id, name)
        {

            MediaObjects = new HashSet<IMedia>();

        }
        

       
    }
}
