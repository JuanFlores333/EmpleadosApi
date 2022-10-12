namespace BeniplasApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administradors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Administradors()
        {
            RegistroAperturaAdministradors = new HashSet<RegistroAperturaAdministradors>();
        }

        public int ID { get; set; }

        public string NombreUsuario { get; set; }

        public string Nombre { get; set; }

        public string ApellidoP { get; set; }

        public string ApellidoM { get; set; }

        public long NumTel { get; set; }

        public string Contrasena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroAperturaAdministradors> RegistroAperturaAdministradors { get; set; }
    }
}
