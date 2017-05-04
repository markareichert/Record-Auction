using RecordAuction.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAuction.ViewModels
{
    public class AddRecordViewModel
    {
        [Required(ErrorMessage = "You must give the record's artist")]
        [Display(Name = "Record Artist")]
        public string Artist { get; set; }

        [Required]
        [Display(Name = "Side A")]
        public string SideA { get; set; }

        [Required]
        [Display(Name = "Side B")]
        public string SideB { get; set; }

        [Display(Name = "Miscellaneous Notes")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "You must give the record's label")]
        [Display(Name = "Record Label")]
        public string Label { get; set; }

        [Required(ErrorMessage = "You must give the record's number at the label")]
        [Display(Name = "Record Number at Label")]
        public int RecordNumber { get; set; }

        [Required]
        [Display(Name = "Record Condition")]
        public int ConditionID { get; set; }

        public List<SelectListItem> Conditions { get; set; }

        public AddRecordViewModel()
        {

        }

        public AddRecordViewModel(IEnumerable<RecordCondition> conditions)
        {
            Conditions = new List<SelectListItem>();

            foreach (RecordCondition condition in conditions)
            {
                Conditions.Add(new SelectListItem
                {
                    Value = ((int)condition.ID).ToString(),
                    Text = condition.Name
                });
            }
        }
    }
}
