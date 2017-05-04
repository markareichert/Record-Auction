using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecordAuction.ViewModels
{
    public class AddConditionViewModel
    {
        [Required]
        [Display(Name = "Record Condition")]
        public string Name { get; set; }
    }
}
