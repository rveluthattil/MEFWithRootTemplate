using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.Composition;
using MEFWithRootTemplatePlugin1.Models;

namespace MEFWithRootTemplatePlugin1.Controllers
{
    [Export("PluginA_2", typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PluginA_2Controller : Controller
    {
        public ActionResult Index()
        {
            return View(new VModel { VINNumber = 11, VehicleMake = "Nissan", VehicleModel = "Altima", VehicleYear = 2016 });
        }
    }
}