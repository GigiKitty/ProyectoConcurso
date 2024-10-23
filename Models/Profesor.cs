using System.ComponentModel.DataAnnotations;

namespace ConcursoPogramacion2024pro.Models
{
	public class Profesor
	{
		[Key]

		public int IdProfesor { get; set; }
		[Required (ErrorMessage ="Campo requerido!")]

		public String NombreProfesor { get; set; }
		[Required (ErrorMessage = "Campo requerido!")]

		public String ApellidoProfesor { get; set; }
		[Required(ErrorMessage = "Campo requerido!")]

		public String EmailProfesor { get; set; }
		[Required(ErrorMessage ="Campo requerido!")]
		[EmailAddress]

	}
}
