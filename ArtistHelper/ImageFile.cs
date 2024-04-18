using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistHelper
{
    internal struct ImageFile
    {
        private bool isShown;
        private string filePath;

        public bool IsShown {  get { return isShown; } }
        public string FilePath { get { return filePath; } }


        public ImageFile(bool isShown, string filePath)
        {
            this.isShown = isShown;
            this.filePath = filePath;
        }
    }
}
