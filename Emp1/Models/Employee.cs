using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Emp1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string Address { get; set; }
        [Required] public string Qualification { get; set; }
        public int ContectNumber { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
