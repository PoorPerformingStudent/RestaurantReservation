using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackDevProject.Shared.Domain
{
    public class Table : BaseDomainModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        [Required]
        public virtual Restaurant Restaurant { get; set; }
    }
}
