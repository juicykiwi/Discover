using System;

namespace Windlight.Data
{
    public class FileInfo
    {
        public string path { get; set; }
        public string name { get; set; }
        public string extension { get; set; }

        public string GetAllPath()
        {
            return string.Format("{0}/{1}", path, name);
        }

        public string GetAllPathIncludeExtension()
        {
            return string.Format("{0}/{1}.{2}", path, name, extension);
        }

        public string GetNameIncludeExtension()
        {
            return string.Format("{0}.{1}", name, extension);
        }
    }
}

