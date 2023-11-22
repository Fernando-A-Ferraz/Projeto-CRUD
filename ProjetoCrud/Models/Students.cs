using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCrud.Models;

public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "informe o nome")]
    [StringLength(80, ErrorMessage = " O nome deve conter 80 caracteres")]
    [MinLength(5, ErrorMessage = " O nome deve conter pelo menos 5 caracteres")]
    [DisplayName("Nome completo")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o e-mail")]
    [EmailAddress(ErrorMessage ="E-mail invalido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiuns { get; set; } = new();
    
}