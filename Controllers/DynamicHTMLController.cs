using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Dynamic_Input.Models;
using Dynamic_Input.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dynamic_Input.Controllers
{
    public class DynamicHTMLController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string DynamicTextBoxValues)
        {
            var VehicleViewModel = new VehicleViewModel();

            VehicleViewModel.Vehicles =
            JsonConvert.DeserializeObject<List<Vehicle>>(WebUtility.UrlDecode(DynamicTextBoxValues) ?? string.Empty);

            return View();
        }
    }
}
