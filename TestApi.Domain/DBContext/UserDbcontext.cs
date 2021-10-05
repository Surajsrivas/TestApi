using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Domain.Models;

namespace TestApi.Domain.DBContext
{
   public class UserDbcontext : DbContext
    {
        public UserDbcontext(DbContextOptions<UserDbcontext> options):base(options)
        {

        }
        public DbSet<user> users { get; set; }



    }
}
