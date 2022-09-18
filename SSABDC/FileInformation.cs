using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSABDC
{
    public class FileInformation
    {
        private string _fileName;
        private bool _isSynchronyzed;
        private int _type;

        public FileInformation(string filename, bool isSynchronized, int type) 
        {
            _fileName = filename;
            _isSynchronyzed = isSynchronized;
            _type = type;
        }
        public string FileName { get { return _fileName; } }
        public bool IsSynchronyzed { get { return _isSynchronyzed; } }
        public int Type { get { return _type; } }
    }
}
