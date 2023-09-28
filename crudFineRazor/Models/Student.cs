using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace crudFineRazor.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome!")]
        [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracters!")]
        [MinLength(5, ErrorMessage = "O nome deve conter no mínimo 5 caracteres!")]
        [DisplayName("Nome completo :)")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail!")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;

        public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    }
}
