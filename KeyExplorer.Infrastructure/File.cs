using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyExplorer.Infrastructure
{
    public class File : Domain.Repositories.IFile
    {
        public IEnumerable<string> GetDrives()
        {
            return System.IO.DriveInfo.GetDrives()
                .Select(d => d.Name)
                .ToList();
            //yield break;
        }
    }
}
