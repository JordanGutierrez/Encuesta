using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Administracion
{
    public class Usuario
    {

        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [MinLength(8, ErrorMessage = "Las contraseñas deben tener un mínimo de 8 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "La nueva contraseña es requerida")]
        [MinLength(8, ErrorMessage = "Las contraseñas deben tener un mínimo de 8 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string NewClave { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Las contraseñas deben tener un mínimo de 8 caracteres")]
        [Display(Name = "Confirmar contraseña")]
        [Compare("NewClave", ErrorMessage = "Las contraseñas nuevas no coinciden.")]
        public string ConfirmClave { get; set; }

        [Required(ErrorMessage = "La cédula es requerida")]
        [Display(Name = "Cédula")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "La cédula solo acepta caracteres numéricos")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Los nombres son requeridos")]
        [Display(Name = "Nombres")]
        [RegularExpression(@"^[A-Za-zÑñáéíóúÁÉÍÓÚ ]*$", ErrorMessage = "Los nombres solo aceptan caracteres alfabéticos")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Los apellidos son requeridos")]
        [Display(Name = "Apellidos")]
        [RegularExpression(@"^[A-Za-zÑñáéíóúÁÉÍÓÚ ]*$", ErrorMessage = "Los apellidos solo aceptan caracteres alfabéticos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El rol es requerido")]
        [Display(Name = "Rol")]
        public int RolID { get; set; }

        public char Estado { get; set; }

        public string MaqSitio { get; set; }

        public string Maquina { get; set; }

        public static Usuario CreateUsuarioFromDataRecord(IDataRecord dr)
        {
            Usuario usuario = new Usuario();

            usuario.UsuarioID = int.Parse(dr["UsuarioID"].ToString());
            usuario.Clave = dr["Clave"].ToString();
            usuario.Cedula = dr["Cedula"].ToString();
            usuario.Nombres = dr["Nombres"].ToString();
            usuario.Apellidos = dr["Apellidos"].ToString();
            usuario.Correo = dr["Correo"].ToString();
            usuario.RolID = int.Parse(dr["RolID"].ToString());
            usuario.Estado = char.Parse(dr["Estado"].ToString());

            return usuario;
        }
    }
}
