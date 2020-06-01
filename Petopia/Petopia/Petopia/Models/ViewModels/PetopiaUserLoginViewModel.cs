﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Petopia.Models.ViewModels
{
    public class PetopiaUserLoginViewModel
    {
        //NEED TO MAKE THIS DUMB VIEWMODEL JUST SO WE CAN ADD PROFILE PICTURES ON REGISTER
        //everything is the same as our PetopiaUser model 
        //        just with the profile picture changed to the right type.
        public int UserID { get; set; }

        //===============================================================================
        [StringLength(120)]
        public string UserName { get; set; }

        //-------------------------------------------------------------------------------
        [StringLength(50)]
        public string Password { get; set; }

        //===============================================================================
        [Required(ErrorMessage = "please enter your first name")]
        [DisplayName("* First name:")]
        [StringLength(50)]
        public string FirstName { get; set; }

        //-------------------------------------------------------------------------------
        [Required(ErrorMessage = "please enter your last name")]
        [DisplayName("* Last name:")]
        [StringLength(50)]
        public string LastName { get; set; }

        //===============================================================================
        [StringLength(128)]
        public string ASPNetIdentityID { get; set; }

        //-------------------------------------------------------------------------------
        public bool IsOwner { get; set; }

        //-------------------------------------------------------------------------------
        public bool IsProvider { get; set; }

        //===============================================================================
        [Required]
        [DisplayName("* Main Phone #")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "please enter phone number in requested format")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                            ErrorMessage = "please enter your phone number as requested")]
        [StringLength(12)]
        public string MainPhone { get; set; }

        //-------------------------------------------------------------------------------
        [StringLength(12)]
        [DisplayName("Alternate Phone #")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "please enter phone number in requested format")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                            ErrorMessage = "please enter your phone number as requested")]
        public string AltPhone { get; set; }

        //===============================================================================
        [Required(ErrorMessage = "please enter your residential street address")]
        [DisplayName("* Residential Address:")]
        [StringLength(50)]
        public string ResAddress01 { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Address, 2nd Line (if you have one)")]
        [StringLength(50)]
        public string ResAddress02 { get; set; }

        //-------------------------------------------------------------------------------
        [Required(ErrorMessage = "please enter your residential city")]
        [DisplayName("* City:")]
        [StringLength(50)]
        public string ResCity { get; set; }

        //-------------------------------------------------------------------------------
        [Required(ErrorMessage = "please enter 2-character state")]
        [DisplayName("* State:")]
        [StringLength(50)]
        public string ResState { get; set; }

        //-------------------------------------------------------------------------------
        [Required(ErrorMessage = "please enter 5-digit zipcode")]
        [DisplayName("* ZipCode:")]
        [StringLength(5)]
        public string ResZipcode { get; set; }

        //===============================================================================
        [DisplayName("Upload your Profile Photo!")]
        public HttpPostedFileBase ProfilePhoto { get; set; }

        //------------------------------------------------------------------------------
        [StringLength(72)]
        [DisplayName("Caption for your profile pic:")]
        public string UserCaption { get; set; }

        //-------------------------------------------------------------------------------
        [StringLength(72)]
        [DisplayName("A tagline to go under your name:")]
        public string Tagline { get; set; }

        //-------------------------------------------------------------------------------
        [DisplayName("Your Bio - some fun stuff about you!")]
        public string UserBio { get; set; }

        //-------------------------------------------------------------------------------
        [StringLength(72)]
        [DisplayName("General Location: (i.e., neighborhood name)")]
        public string GeneralLocation { get; set; }
    }
}