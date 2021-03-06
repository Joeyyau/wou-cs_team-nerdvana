namespace Petopia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Provider")]
    public partial class Provider
    {
        [StringLength(120)]
        public string ProviderID { get; set; }

        [StringLength(120)]
        public string Username { get; set; }

        [Required]
        [DisplayName("First Name:")]
        [StringLength(120)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name:")]
        [StringLength(120)]
        public string LastName { get; set; }
    }
}
