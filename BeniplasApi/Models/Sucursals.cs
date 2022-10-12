namespace BeniplasApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sucursals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sucursals()
        {
            Empleadoes = new HashSet<Empleadoes>();
        }

        public int ID { get; set; }

        public int NumSucursal { get; set; }

        public string Direccion { get; set; }

        public int? Gerente_ID { get; set; }

        public int? Empresa_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleadoes> Empleadoes { get; set; }

        public virtual Empresas Empresas { get; set; }

        public virtual Gerentes Gerentes { get; set; }
    }
}
