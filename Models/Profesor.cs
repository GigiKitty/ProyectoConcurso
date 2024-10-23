using System.ComponentModel.DataAnnotations;

namespace ConcursoPogramacion2024pro.Models
{
	public class Profesor
	{
		[Key]

		int IdProfesor { get; set; }
		[Required (ErrorMessage ="Campo requerido!")]

		String NombreProfesor { get; set; }
		[Required (ErrorMessage = "Campo requerido!")]

		String ApellidoProfesor { get; set; }
		[Required(ErrorMessage = "Campo requerido!")]

		String EmailProfesor { get; set; }
		[Required(ErrorMessage ="Campo requerido!")]
		[EmailAddress]

	}
}
