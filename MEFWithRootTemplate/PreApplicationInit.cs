using System;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Hosting;
using System.Web.Compilation;
using System.Reflection;

[assembly: PreApplicationStartMethod(typeof(MEFWithRootTemplate.PreApplicationInit),"initialize")]
namespace MEFWithRootTemplate
{
    public class PreApplicationInit
    {
        PreApplicationInit()
        {

        }
        public static void Initialize()
        {
            var aPath = "C:\\Users\\rveluth\\Documents\\Visual Studio 2015\\Projects\\MEFWithRootTemplate\\MEFWithRootTemplate\\Modules\\PluginA\\MEFWithRootTemplatePlugin1.dll";
            var aName = AssemblyName.GetAssemblyName(aPath);
            var assembly = Assembly.LoadFrom(aPath);
            BuildManager.AddReferencedAssembly(assembly);
        }
    }
}