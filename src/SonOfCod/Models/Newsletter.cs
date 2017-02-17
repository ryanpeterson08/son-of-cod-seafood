using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("Newsletters")]
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        public string Body { get; set; }
        public string FishOfTheMonth { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
