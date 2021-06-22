using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HonduMedicalAPI.Models
{
    class ConsultaCita
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdIdentidad { get; set; }
        public string NombreUsu { get; set; }
        public string ApellidoUsu { get; set; }
        public string? Celular { get; set; }
        public string CiudadUsu { get; set; }
        public string EspecialidadC { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Horario_C { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaC { get; set; }
        public string TipoConsulta { get; set; }

        [ForeignKey("Login")]
        public int LoginId { get; set; }


        public void mostrarDatos()

        {
            Console.WriteLine("Identidad: " + IdIdentidad);
            Console.WriteLine("Nombre " + NombreUsu);
            Console.WriteLine("Ciudad" + CiudadUsu);
            Console.WriteLine("Especialidad: " + EspecialidadC);
            Console.WriteLine("Horario: " + Horario_C);
            Console.WriteLine("Fecha " + FechaC);
            Console.WriteLine("Tipo de Consulta " + TipoConsulta);

        }


    }
}
