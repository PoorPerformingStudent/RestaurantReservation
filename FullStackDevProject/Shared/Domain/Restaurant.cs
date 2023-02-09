using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackDevProject.Shared.Domain
{
    public class Restaurant : BaseDomainModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string Name { get; set; }
        public string Type { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
        public int Contact { get; set; }
        [Required]
        public string Address { get; set; }
        public int TableNumber { get; set; }
        [Required]
        public int TimeSlot { get; set; }
    }
}
