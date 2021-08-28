//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCustomerManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class CustomersTBL
    {
        public CustomersTBL()
        {

            this.Cities = new List<SelectListItem>();
            this.Banks = new List<SelectListItem>();
            this.Branches = new List<SelectListItem>();

        }

        public List<SelectListItem> Cities { get; set; }
        public List<SelectListItem> Banks { get; set; }
        public List<SelectListItem> Branches { get; set; }

        [Display(Name = "Customer ID")]
       // [RegularExpression("@^[0-9]$", ErrorMessage = "Digits Only")]
     
        public int IDCusomer { get; set; }

        [Display(Name = "Hebrew Name")]
        [RegularExpression(@"^[�-�\'\-\ ]+$", ErrorMessage = "Hebrew only, till 20 characters, characters only, no special characters and numbers." +
            " Divide, dash and space allowed.")]
        [StringLength(20,MinimumLength=0,ErrorMessage = "Maximum 20 characters")]
        public string HebrewName { get; set; }

        [Display(Name = "English Name")]
        [RegularExpression(@"^[a-zA-z\'\-\ ]+$", ErrorMessage = "English only, till 15 characters, characters only, no special characters and numbers." +
            " Divide, dash and space allowed.")]
        [StringLength(15, MinimumLength = 0, ErrorMessage = "Maximum 15 characters")]
        public string EnglishName { get; set; }

        [Display(Name = "BirthDate")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> BirthDate { get; set; }

        [Display(Name = "City")]
        public int IDCity { get; set; }

        [Display(Name = "Bank")]
        public string Bank { get; set; }

        [Display(Name = "Branch")]
        public string Branch { get; set; }

        [Display(Name = "Account Number")]
       // [RegularExpression("@^[0-9]$", ErrorMessage = "Up to 10 digits only, no special characters")]
       
        public Nullable<int> AccountNumber { get; set; }

        public virtual CitiesTBL CitiesTBL { get; set; }
    }
}
