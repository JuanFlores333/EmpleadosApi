namespace BeniplasApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empleadoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleadoes()
        {
            RegistroAperturaEmpleadoes = new HashSet<RegistroAperturaEmpleadoes>();
        }

        public int ID { get; set; }

        public string NombreUsuario { get; set; }

        public string Nombre { get; set; }

        public string ApellidoP { get; set; }

        public string ApellidoM { get; set; }

        public long NumTel { get; set; }

        public string Contrasena { get; set; }

        public bool Status { get; set; }

        public long Codigo { get; set; }

        public int? Sucursal_ID { get; set; }

        public virtual Sucursals Sucursals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroAperturaEmpleadoes> RegistroAperturaEmpleadoes { get; set; }
    }

    public class EmpleadoDTO
    {

        public int ID { get; set; }

        public string NombreUsuario { get; set; }

        public string Nombre { get; set; }

        public string ApellidoP { get; set; }

        public string ApellidoM { get; set; }

        public long NumTel { get; set; }

        public string Contrasena { get; set; }

        public bool Status { get; set; }

        public long Codigo { get; set; }

        public int? Sucursal_ID { get; set; }

    }
}
