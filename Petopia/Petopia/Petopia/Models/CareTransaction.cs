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
        [Required(ErrorMessage = "please enter a start date")]
        [Column(TypeName = "date")]     // gets rid of '12:00:00 AM' appendage
        [DisplayName("Start Date:")]
        //
        // adding this to the data definition gives me a date-picker in the view
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        // it also formats things correctly for going into our db..... yay!
        //
        public DateTime StartDate { get; set; }

        //-------------------------------------------------------------
        [Required(ErrorMessage = "please enter an end date")]
        [Column(TypeName = "date")]
        [DisplayName("End Date:")]
        //
        // to get our date-picker:
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        //
        public DateTime EndDate { get; set; }

        //-------------------------------------------------------------------------------
        // TIME CRAP!!!!!
        // when it's [DataType(DataType.DateTime)] 
        //   ^-- in 'EditAppt': the time *DOES* populate to the form\input boxes
        //       BUT -- when you 'submit' you get "field End Time: must be a date"
        // 
        // when it's [DataType(DataType.Time)]
        //   ^-- in 'EditAppt': the time does *NOT* populate to the form\input boxes
        //       BUT -- it all works just fine and everything
        //              displays just fine w/'Html.DisplayFor', interacts w/db just fine
        //              it just won't display w/'Html.EditorFor'
        //
        [Required(ErrorMessage = "please enter a start time")]
        [DisplayName("Start Time:")]
        [DisplayFormat(DataFormatString = "{0:h:mm tt}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        //-------------------------------------------------------------
        [Required(ErrorMessage = "please enter an end time")]
        [DisplayName("End Time:")]
        [DisplayFormat(DataFormatString = "{0:h:mm tt}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        //===============================================================================
        [Required(ErrorMessage = "please give instructions for your pet carer")]
        [DisplayName("Pet Care instructions for this visit:")]
        public string NeededThisVisit { get; set; }

        //-------------------------------------------------------------
        [DisplayName("Pet Care recap:")]
        public string CareProvided { get; set; }

        //-------------------------------------------------------------
        [DisplayName("Full Pet Care Report -- Details:")]
        public string CareReport { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Pet Carer's fee for this visit:")]
        public decimal? Charge { get; set; }

        [DisplayName("Tip? (optional)")]
        public decimal? Tip { get; set; }

        //===============================================================================
        [DisplayName("Pet Carer Rating:")]
        public int? PC_Rating { get; set; }

        [DisplayName("Comments on Pet Carer:")]
        public string PC_Comments { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Pet Owner Rating:")]
        public int? PO_Rating { get; set; }

        [DisplayName("Comments on Pet Owner:")]
        public string PO_Comments { get; set; }

        //===============================================================================
        // booleans for status of appointments
        [DisplayName("Pending")]
        public bool Pending { get; set; }

        [DisplayName("Confirmed")]
        public bool Confirmed { get; set; }

        [DisplayName("Completed - Pet Owner")]
        public bool Completed_PO { get; set; }

        [DisplayName("Completed - Pet Carer")]
        public bool Completed_CP { get; set; }

        [DisplayName("IsPaid?")]
        public bool IsPaid { get; set; }

        //===============================================================================
        // FOREIGN KEYS
        //
        [DisplayName("Pet's Owner:")]
        public int PetOwnerID { get; set; }

        [DisplayName("Which Pet Carer?")]
        public int CareProviderID { get; set; }

        [DisplayName("Which Pet?")]
        public int PetID { get; set; }

        //===============================================================================
    }
}
