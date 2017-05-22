using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GMDemo.Logger;
using GMDemo.Models;
using GMDemo.Repository;

namespace GMDemo.Controllers
{
    /******************************************
     General Notes:
     MVC project
     Refers to the model and repo classes
     
         
         
         
    *******************************************/

    public class GmController : Controller
    {
        private readonly IGmData _gmRepository;
        private readonly ILogger _logger;
       

        //constructor passing interfaces needed in controller
        public GmController(IGmData machineRepository, ILogger logger)
        {
            _gmRepository = machineRepository;
            _logger = logger;
        }

        // GET: return initial view
        public ActionResult Index()
        {
            return View("Index");
        }

        //Metod to return our dataset
        [HttpGet]
        public JsonResult GetGmData()
        {
            var result = new List<GmModel>();
            try
            {
                result = _gmRepository.GetSampleData();
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}