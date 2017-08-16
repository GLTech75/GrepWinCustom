using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class TestHelper
    {
        public static string GetLocalPath()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            if (path != null) return new Uri(path).LocalPath;

            throw new Exception("No local path found.");
        }

        public static string GetTemplateDataPath(string localFilePath)
        {
            return Path.Combine(GetLocalPath(), localFilePath);
        }

        public static string ReadTemplateData(string localFilePath)
        {
            return File.ReadAllText(GetTemplateDataPath(localFilePath));
        }
    }
}
