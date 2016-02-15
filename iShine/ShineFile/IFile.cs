using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.ShineFile
{
    public interface IFile
    {
        Task Load(IProgress<int> progress);
        Task Save(IProgress<int> progress);
    }
}
