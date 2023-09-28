using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crudFineRazor.Models
{
    public class Subscription
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título da inscrição!")]
        [StringLength(80, ErrorMessage = "O título deve conter até 80 caracters!")]
        [MinLength(5, ErrorMessage = "O título deve conter no mínimo 5 caracteres!")]
        [DisplayName("Título :)")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Data início")]
        public DateTime StarDate { get; set; }

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Data término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno inválido!")]
        public int StudentId { get; set; }
        
        public Student? Student { get; set; }
    }
}
