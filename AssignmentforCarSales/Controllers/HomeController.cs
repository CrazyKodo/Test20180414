using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Model.DTO;

namespace AssignmentforCarSales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string sort = "Make", int page = 1, int size = 10)
        {
            var model = CarService.GetCarsList(sort, page, size);
            if (Request.IsAjaxRequest())
            {
                model.sort = sort;
                model.pageNumber = page;
                model.pageSize = size;
                return PartialView("CarsListPartial", model);
            }
            return View(model);




        }


    }
}