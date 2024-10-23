using System.ComponentModel.DataAnnotations;

namespace ConcursoPogramacion2024pro.Models
{
	public class Estudiante
	{
		[Key]

		public int IdEstudiante { get; set; }
		[Required(ErrorMessage = "Campo requerido!")]

		public String NombreEstudiante { get; set; }
		[Required(ErrorMessage = "Campo requerido!")]

		public String ApellidoEstudiante { get; set; }
		[Required(ErrorMessage = "Campo requerido!")]

		public DateTime FechaNacimiento { get; set; }
		[Required(ErrorMessage = "Campo requerido!")]

	}
}
