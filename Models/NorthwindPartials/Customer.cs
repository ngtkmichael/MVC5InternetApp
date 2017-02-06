using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5InternetApp.Models.Northwind
{
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {

        public class CustomerMetaData
        {
            [Required]
            [Display(Name = "Customer ID")]
            [StringLength(5, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 1)]
            public object CustomerID { get; set; }

            [Required]
            [Display(Name = "Company Name")]
            [StringLength(40, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
            public object CompanyName { get; set; }

            [Required]
            [Display(Name = "Contact Name")]
            [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
            public object ContactName { get; set; }

            [Required]
            [Display(Name = "Contact Title")]
            [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 1)]
            public object ContactTitle { get; set; }

            [Required]
            [Display(Name = "City")]
            [StringLength(15, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 1)]
            public object City { get; set; }

        }
    }
}
