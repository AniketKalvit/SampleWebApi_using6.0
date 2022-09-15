using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApi.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Dob { get; set; }
        public string? City { get; set; }
    }
}
