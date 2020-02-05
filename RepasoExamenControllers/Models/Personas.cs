using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoExamenControllers.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "El campo nombre no puede esta vacio")]
        [StringLength(maximumLength:99,ErrorMessage ="El nombre es muy largo")]
        public string Nombres { get; set; }
        [Required(ErrorMessage ="Es necesario seleccionar una fecha")]
        public DateTime FechaNacimiento { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Nombres = string.Empty;
            FechaNacimiento = DateTime.Now;
        }
    }
}
