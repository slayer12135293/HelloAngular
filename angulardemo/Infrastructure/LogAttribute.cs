﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace angulardemo.Infrastructure
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext){
            
            base.OnActionExecuted(filterContext);
        }       
    }  
}      
       