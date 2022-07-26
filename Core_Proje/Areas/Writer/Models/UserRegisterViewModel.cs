using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanici adini girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen sifreyi adini girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen sifreyi tekrar adini girin")]
        [Compare("Password", ErrorMessage = "Sifreler uyumlu degil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mail girin")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen mail adresinizi dogru formatta girin")]
        public string Mail { get; set; }
    }
}
