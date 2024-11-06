using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaJKA.DAL
{

    [Table("AspNetUsers")]
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del Usuario")]
        public string name { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Apellidos")]
        public string surnames { get; set; }

        [Required]
        [DisplayName("Tipo de Cedula")]
        public string idType { get; set; }

        [Required]
        [MaxLength(12)]
        [DisplayName("Numero de Cedula")]
        public string idNumber { get; set; }

        [Required]
        [MaxLength(12)]
        [DisplayName("Telefono")]
        public string phone { get; set; }

        [DisplayName("Última Fecha de Conexion")]
        public DateTime lastConnection { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool status { get; set; }

    }
}