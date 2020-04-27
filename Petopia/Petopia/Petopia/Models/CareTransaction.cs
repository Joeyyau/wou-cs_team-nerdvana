namespace Petopia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CareTransaction")]
    public partial class CareTransaction
    {
        //===============================================================================
        [Key]
        public int TransactionID { get; set; }

        //===============================================================================
        [Column(TypeName = "date")]     // gets rid of '12:00:00 AM' appendage
        [DisplayName("Start Date:")]
        //
        // adding this to the data definition gives me a date-picker in the view
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        // it also formats things correctly for going into our db..... yay!
        //
        public DateTime StartDate { get; set; }

        //-------------------------------------------------------------------------------
        [Column(TypeName = "date")]
        [DisplayName("End Date:")]
        //
        // to get our date-picker:
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        //
        public DateTime EndDate { get; set; }

        //-------------------------------------------------------------------------------
        [Column(TypeName = "time")]
        [DisplayName("Start Time:")]
        [DataType(DataType.Time)]
        //[DisplayFormat(DataFormatString = "{0:hh\\:mm tt}", ApplyFormatInEditMode = true)]
        public TimeSpan StartTime { get; set; }

        //-------------------------------------------------------------------------------
        //SERIOUSLY! DISPLAYING TIME IN 12-HOUR FORMAT SHOULsDN'T BE THIS F'ING DIFFICULT!
        // YES I TRIED CHANGING FROM 'TimeSpan' to 'DateTime'
        // I remember this shit being unconscionably difficult in 460 as well.
        //-------------------------------------------------------------------------------
        [Column(TypeName = "time")]
        [DisplayName("End Time:")]
        [DataType(DataType.Time)]
        //[DisplayFormat(DataFormatString = "{0:hh\\:mm tt}", ApplyFormatInEditMode = true)]
        public TimeSpan EndTime { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Care needed this visit:")]
        public string NeededThisVisit { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("What I did for your Pet this appointment:")]
        public string CareProvided { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Full Pet Care Report -- Details:")]
        public string CareReport { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Pet Carer's fee for this visit:")]
        public float? Charge { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Tip? (optional)")]
        public float? Tip { get; set; }

        //-------------------------------------------------------------------------------
        //[Range(0,5)] <= handle in .cshtml or else it can't be nullable!
        [DisplayName("Pet Carer Rating:")]
        public int? PC_Rating { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Comments on Pet Carer:  (from Pet Owner!)")]
        public string PC_Comments { get; set; }

        //-------------------------------------------------------------------------------
        //[Range(0,5)] <= handle in .cshtml or else it can't be nullable!
        [DisplayName("Pet Owner Rating:")]
        public int? PO_Rating { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Comments on Pet Owner:  (from Pet Carer!)")]
        public string PO_Comments { get; set; }

        //===============================================================================
        // FOREIGN KEYS
        [DisplayName("Pet's Owner:")]
        public int PetOwnerID { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Which Pet Carer?")]
        public int CareProviderID { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Which Pet?")]
        public int PetID { get; set; }

        //===============================================================================
        
    }
}
