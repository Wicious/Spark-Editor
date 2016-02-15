using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib
{
    public class ShineFile : IFile
    {
        public string FilePath { get; private set; }

        string IFile.FilePath
        {
            get
            {
                return FilePath;
            }
        }

        public async Task Load(IProgress<int> progress)
        {

        }

        public async Task Save(string filePath, IProgress<int> progress)
        {

        }
    }
}
