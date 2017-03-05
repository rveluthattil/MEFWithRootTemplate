using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.Composition;

namespace MEFWithRootTemplatePlugin1.Models
{
    [Export("VModel", typeof(IBaseModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class VModel : IBaseModel
    {
        public int VINNumber { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleYear { get; set; }

        public string getProperty()
        {
            return "property";
        }
    }
}