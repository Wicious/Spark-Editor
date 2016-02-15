using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib
{
    public class QuestFile : IFile
    {
        public string FilePath { get; private set; }
        public bool IsSaved { get; set; }

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
