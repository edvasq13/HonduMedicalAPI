using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HonduMedicalAPI.Models
{
    class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdLogin { get; set; }
        public string CorreoUsu { get; set; }
        public string ContraseñaUsu { get; set; }
    }
}
