using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealApp
{
    class players
    {

        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Position { get; set; }
        public string Adress { get; set; }
        public players(int id, string firstname, string lastname, string position, string adress)
        {

            Adress = adress;
            Id = id;
            Position = position;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
