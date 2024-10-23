using System.ComponentModel.DataAnnotations;

namespace ConcursoPogramacion2024pro.Models
{
	public class Materia
	{
		[Key]

		public int IdMateria { get; set; }
		[Required(ErrorMessage ="Campo requerido!")]

		public String NombreMateria { get; set; }
		[Required(ErrorMessage ="Campo requerido!")]

		public int Creditos {  get; set; }
		[Required (ErrorMessage ="Campo requerido!")]
	}
}
