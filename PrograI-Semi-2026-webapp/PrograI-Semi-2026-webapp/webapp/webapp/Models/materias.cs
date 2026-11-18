using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Materias
    {
        [key]

        public int idMateria { get; set; }
        public int codiigo { get; set; }
        public int materia { get; set; }
        public int uv { get; set; }
    }
}
