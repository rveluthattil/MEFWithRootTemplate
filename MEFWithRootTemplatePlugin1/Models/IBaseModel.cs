using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.Composition;

namespace MEFWithRootTemplatePlugin1.Models
{
    public interface IBaseModel
    {
        string getProperty();
    }
}