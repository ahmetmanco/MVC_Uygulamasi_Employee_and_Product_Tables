
using System.ComponentModel.DataAnnotations;

namespace MVC_Uygulama_Guncel.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required,Display(Name ="Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        public string? Aciklama { get; set; }

    }
}
