using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyExplorer.Domain
{
    public static class Util
    {
        public static int Min(int a, int b) { return Math.Min(a, b); }
        public static int Max(int a, int b) { return Math.Max(a, b); }
        public static IEnumerable<string> GetDrives()
        {
            return System.IO.DriveInfo.GetDrives()
                .Select(d => d.Name)
                .ToList();
            //yield break;
        }
    }
}
