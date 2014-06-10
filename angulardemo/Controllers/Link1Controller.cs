using angulardemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using angulardemo.Infrastructure;

namespace angulardemo.Controllers
{

    public class Link1Controller : Controller
    {
        //
        // GET: /Link1/

        //public async System.Threading.Tasks.Task<ViewResult> Index()
        //{
        //    var myService = new SlowService();
        //    var result = await myService.GetString("this is the input string");
        //    return View();
        //}

        
        public ActionResult Index()
        {
            
            ViewBag.lei = "feeling hot hot hot";
            var model = new IndexPageViewModel() {Title="this is a title", Text1="this is text1", Text2="this is text2" };
            return View(model);
        }

        

        //public class SlowService
        //{
        //    public System.Threading.Tasks.Task<string> GetString(string inString)
        //    {
        //        System.Threading.Thread.Sleep(5000);
        //        return inString;
        //    }
        //}

    }
}
