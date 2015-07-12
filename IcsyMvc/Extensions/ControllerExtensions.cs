using IcsyMvc.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IcsyMvc
{
    public static class ControllerExtensions
    {
        public static void AddRuleErrors(this ModelStateDictionary modelState, RulesException ex)
        {
            foreach (var x in ex.Errors)
            {
                modelState.AddModelError(x.PropertyName, x.ErrorMessage);
            }
        }
    }
}