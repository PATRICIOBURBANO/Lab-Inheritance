using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Inheritance.Models
{
    public class Artist : User
    {
        public Artist(int id, string name) : base(id, name)
        {

        }

        public override String GenerateEmail()
        {
            Email = "A" + base.GenerateEmail();
            
            return Email;
        }
    }
}
