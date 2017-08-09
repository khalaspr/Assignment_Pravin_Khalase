using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;
namespace FileData
{
    class SizeChecker : TypeChecker
    {
        public override string getFileInfo(string filePath)
        {
            MethodCalled = "Size"; 
            return "Size of " + filePath + " --> " + _fileDetails.Size(filePath);
        }
    }
}
