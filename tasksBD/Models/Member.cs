 using System.ComponentModel.DataAnnotations;

namespace tasksBD.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Email { get; set; }
        //propiedad de navegación EF
        virtual public ICollection<MemberTask>? Tasks { get; set; }
    }
}