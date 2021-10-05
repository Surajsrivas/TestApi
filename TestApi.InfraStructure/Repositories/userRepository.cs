using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Domain.DBContext;
using TestApi.Domain.Models;

namespace TestApi.InfraStructure.Repositories
{
   public  class userRepository

    {
        public readonly UserDbcontext _context;
        public userRepository(UserDbcontext context)
        {
            _context = context;

        }
        public async Task<user> AddUserDetails(user data)
        {
            var result = await _context.users.AddAsync(data);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
