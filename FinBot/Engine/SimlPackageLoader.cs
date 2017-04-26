using System.IO;
using System.Reflection;

namespace FinBot.Engine
{
    public interface ISimlPackageLoader
    {
        string LoadSimlPackage();
    }

    public class SimlPackageLoader : ISimlPackageLoader
    {
        public string LoadSimlPackage()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FinBot.Content.SimlPackage.simlpk";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}