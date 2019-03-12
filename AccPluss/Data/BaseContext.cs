using AccPluss.Data.Entities;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccPluss.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class BaseContext: DbContext
    {
        public BaseContext() : base("AccConection")
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
