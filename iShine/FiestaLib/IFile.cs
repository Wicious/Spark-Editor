using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib
{
    public interface IFile
    {
        string FilePath { get; }
        bool IsSaved { get; set; }
        Task Load(IProgress<int> progress);
        Task Save(string filePath, IProgress<int> progress);
    }
}
