namespace Petopia.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CareProvider")]
    public partial class CareProvider
    {
        public int CareProviderID { get; set; }

        [StringLength(120)]
        public string AverageRating { get; set; }

        [Required]
        public string ExperienceDetails { get; set; }

        public int? UserID { get; set; }

        public virtual PetopiaUser PetopiaUser { get; set; }
    }
}
