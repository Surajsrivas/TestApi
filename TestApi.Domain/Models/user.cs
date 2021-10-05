using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Domain.Models
{
   public  class user
    {
        [Key]
        public int userId { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string LastName { get; set; }
    }
}
