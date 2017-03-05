using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.Composition;

namespace MEFWithRootTemplatePlugin1.Controllers
{
    [Export("PluginA_1",typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PluginA_1Controller : Controller
    {
        // GET: PluginA_1
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayAction()
        {
            return View("Index");
        }
    }
}