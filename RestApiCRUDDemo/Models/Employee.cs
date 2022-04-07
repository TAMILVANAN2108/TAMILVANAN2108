using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUDDemo.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100,ErrorMessage ="Name Should be 100 characters onl1!!!")]
        public string Name { get; set; }
    }
}
