using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("Signups")]
    public class Signup
    {
        
        [Key]
        public int Id { get; set; }
        public string userEmail { get; set; }
        public string userAddress { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
              
    }
}
