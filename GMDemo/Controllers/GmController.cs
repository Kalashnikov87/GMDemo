using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GMDemo.Models;
using GMDemo.Repository;

namespace GMDemo.Controllers
{
    public class GmController : Controller
    {
        // GET: Gm
        public ActionResult Index()
        {
            return View("Index");
        }
        [HttpGet]
        public JsonResult GetSomeData()
        {
            var result = new List<GmModel>();
            try
            {
                result = MockData.GetSampleData();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    
}
}