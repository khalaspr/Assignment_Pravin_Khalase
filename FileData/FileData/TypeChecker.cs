using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public abstract class TypeChecker
    {
        public readonly FileDetails _fileDetails;
        public string MethodCalled { get; set; }
        public TypeChecker()
        {
            _fileDetails = new FileDetails();
        }
        public abstract string getFileInfo(string filePath);

    }
}
