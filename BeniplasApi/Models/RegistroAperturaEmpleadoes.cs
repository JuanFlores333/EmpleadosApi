namespace BeniplasApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistroAperturaEmpleadoes
    {
        public int ID { get; set; }

        public string Comentario { get; set; }

        public DateTime FechaHora { get; set; }

        public int? Empleado_ID { get; set; }

        public virtual Empleadoes Empleadoes { get; set; }
    }
}
