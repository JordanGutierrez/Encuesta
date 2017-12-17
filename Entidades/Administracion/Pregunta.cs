using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Administracion
{
    public class Pregunta
    {
        public int PreguntaID { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public char Estado { get; set; }

        public static Pregunta CreateUsuarioFromDataRecord(IDataRecord dr)
        {
            Pregunta pregunta = new Pregunta();

            pregunta.PreguntaID = int.Parse(dr["PreguntaID"].ToString());
            pregunta.Descripcion = dr["Descripcion"].ToString();
            pregunta.Estado = char.Parse(dr["Estado"].ToString());

            return pregunta;
        }
    }
}
