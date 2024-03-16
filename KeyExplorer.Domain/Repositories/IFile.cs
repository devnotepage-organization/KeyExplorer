using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyExplorer.Domain.Repositories
{
    public interface IFile
    {
        IEnumerable<string> GetDrives();
    }
}
