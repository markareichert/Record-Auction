using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecordAuction.Models;
using RecordAuction.ViewModels;
using RecordAuction.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordAuction.Controllers
{
    public class ConditionController : Controller
    {
        private RecordDbContext context;

        public ConditionController(RecordDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<RecordCondition> conditionList = context.RecordConditions.ToList();
            return View(conditionList);
        }

        public IActionResult Add()
        {
            AddConditionViewModel addConditionViewModel = new AddConditionViewModel();
            return View(addConditionViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddConditionViewModel addConditionViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new record condition to my existing conditions

                RecordCondition newCondition = new RecordCondition
                {
                    Name = addConditionViewModel.Name
                };

                context.RecordConditions.Add(newCondition);
                context.SaveChanges();

                return Redirect("/Condition");
            }

            return View(addConditionViewModel);
        }
    }
}
