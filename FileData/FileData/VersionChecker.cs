using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
   public class VersionChecker:TypeChecker
    {
       public override string getFileInfo(string filePath) 
       {
           MethodCalled = "Version"; 
           return "Version of " + filePath + " --> " + _fileDetails.Version(filePath);
       }
    }
}
