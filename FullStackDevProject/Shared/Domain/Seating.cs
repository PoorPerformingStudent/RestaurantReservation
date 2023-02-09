using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackDevProject.Shared.Domain
{
    public class Seating : BaseDomainModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int TimeSlot { get; set; }
        [Required]
        public int TableNumber { get; set; }
    }
}
