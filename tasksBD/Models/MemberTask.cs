using System.ComponentModel.DataAnnotations;

namespace tasksBD.Models
{
	public class MemberTask
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "El título es obligatorio")]
		[StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
		public string? Title { get; set; }

		[Required(ErrorMessage = "La descripción es obligatoria")]
		[StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
		public string? Description { get; set; }
		[Required(ErrorMessage = "El estado de la tarea es obligatorio")]
		[StringLength(100, ErrorMessage = "Máximo 30 caracteres")]
		public string? TaskState { get; set; }
        //propiedad de navegación EF
        [Required(ErrorMessage = "Se debe asignar un responsable")]
        public int MemberId { get; set; }
		virtual public Member? Member { get; set; }
	}
}