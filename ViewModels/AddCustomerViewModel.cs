using RecordAuction.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAuction.ViewModels
{
    public class AddCustomerViewModel
    {
        [Required(ErrorMessage = "You must give the Customer's First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must give the Customer's Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must give at least one address line for the Customer")]
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [Display(Name = "Address 3")]
        public string Address3 { get; set; }

        [Required(ErrorMessage = "You must give the Customer's City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "You must give the Customer's State")]
        [Display(Name = "State")]
        [RegularExpression(@"^([A-Z]{2})$", ErrorMessage = "Two letter State abbreviation only.")]
        public string State { get; set; }

        [Required(ErrorMessage = "You must give the Customer's Zip Code")]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Five digit zip code only.")]
        public string ZipCode { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }
    }
}
