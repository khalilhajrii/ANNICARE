//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace application_adoption
{
    using System;
    using System.Collections.Generic;
    
    public partial class animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public animal()
        {
            this.detail_adopt = new HashSet<detail_adopt>();
        }
    
        public int id_animal { get; set; }
        public string nom_animal { get; set; }
        public int quantite_animal { get; set; }
        public string type_animal { get; set; }
        public string sexe_animal { get; set; }
        public byte[] image_animal { get; set; }
        public int id_category { get; set; }
    
        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail_adopt> detail_adopt { get; set; }
    }
}