using System;

namespace Euclidian3DSpace
{
    [AttributeUsage(AttributeTargets.All)]
    class Version : Attribute
    {
        private string currentVersion;
        private int major=0;
        private int minor=0;
        
        public string CurrentVersion
        {
            get
            {
                return this.currentVersion;
            }            
        }
        public Version(int major, int minor)
        {
            this.major = major;
            this.minor = minor;

            currentVersion = (major + "." + minor);
        }
    }
}
