using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto11.Models
{
    public class ValoracionModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Valoracion { get; set; }
        public List<string> Asignaturas { get; set; }
        public string Alineacion { get; set; }
        public string MejorasCurso { get; set; }
    }
}