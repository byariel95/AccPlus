using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccPluss.Data.Entities
{
    public  class Client
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
