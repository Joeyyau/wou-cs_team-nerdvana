namespace Petopia.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PetopiaUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetopiaUser()
        {
            CareProviders = new HashSet<CareProvider>();
            PetOwners = new HashSet<PetOwner>();
        }

        [Key]
        public int UserID { get; set; }

        [StringLength(120)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string ASPNetIdentityID { get; set; }

        public bool IsOwner { get; set; }

        public bool IsProvider { get; set; }

        [Required]
        [StringLength(50)]
        public string MainPhone { get; set; }

        [StringLength(50)]
        public string AltPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string ResAddress01 { get; set; }

        [StringLength(50)]
        public string ResAddress02 { get; set; }

        [Required]
        [StringLength(50)]
        public string ResCity { get; set; }

        [Required]
        [StringLength(50)]
        public string ResState { get; set; }

        [Required]
        [StringLength(24)]
        public string ResZipcode { get; set; }

        public byte[] ProfilePhoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CareProvider> CareProviders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PetOwner> PetOwners { get; set; }
    }
}
