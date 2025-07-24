using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTraKy072025.Models
{
     [Table("Person")]
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
    }
}