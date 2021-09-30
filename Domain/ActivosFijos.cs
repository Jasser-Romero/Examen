using Domain.Enums;
using System;

namespace Domain
{
    public class ActivosFijos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivo TipoActivo { get; set; }

        
    }
}
