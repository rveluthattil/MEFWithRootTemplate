using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.Composition;

namespace MEFWithRootTemplatePlugin1.Controllers
{
    [Export("PluginA",typeof(IController))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PluginAController : Controller
    {
        // GET: PluginA
        public ActionResult Index()
        {
            return View();
        }
    }
}