using System.ComponentModel.DataAnnotations;

namespace MVC_Uygulama_Guncel.Models
{
    public class Product
    {
        [Required,Display(Name ="Ürün kodu")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,Display(Name ="Geçerlilik Tarihi")]
        public DateTime GecerlilikTarihi { get; set; }
        public string? Renk { get; set; }
        [Required]
        public decimal Fiyat { get; set; }
        [MinLength(3,ErrorMessage ="En az 3 karakter girmelisiniz")]
        public string? Tanım { get; set; }
    }
}
