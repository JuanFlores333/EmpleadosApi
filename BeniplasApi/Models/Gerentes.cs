namespace BeniplasApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gerentes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gerentes()
        {
            RegistroAperturaGerentes = new HashSet<RegistroAperturaGerentes>();
            Sucursals = new HashSet<Sucursals>();
        }

        public int ID { get; set; }

        public string NombreUsuario { get; set; }

        public string Nombre { get; set; }

        public string ApellidoP { get; set; }

        public string ApellidoM { get; set; }

        public string Region { get; set; }

        public long NumTel { get; set; }

        public string Contrasena { get; set; }

        public bool Status { get; set; }

        public int? Empresa_ID { get; set; }

        public virtual Empresas Empresas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroAperturaGerentes> RegistroAperturaGerentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursals> Sucursals { get; set; }
    }
}
