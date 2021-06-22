using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HonduMedicalAPI.Models
{
    class TablaDrs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdDrs { get; set; }
        public string NombreDrs { get; set; }
        public string AEspecialidadDrs { get; set; }
        public string EspecialidadOtra { get; set; }
        public string Especi_Consultorio { get; set; }
        public string HorarioC { get; set; }

        [ForeignKey("CCita")]
        public int IdentidadID { get; set; }
    }
}
