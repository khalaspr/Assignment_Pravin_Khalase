using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
  public  class TypeFactory
    {
        public TypeChecker getTypeChecker(string type)  
        {
            TypeChecker tc=null;
            string[] versions = { "-v", "--v", " /v", "--" };
            string[] sizes = { "---s", "--s", " /s", "--size" };
            var IsVersion = (from m in versions
                             where m.Contains(type)
                             select m).Any();

            var IsSize = (from m in sizes
                          where m.Contains(type)
                          select m).Any();

            if (IsVersion)
            {
                tc = new VersionChecker();
            }
            if (IsSize)
            {
                tc = new SizeChecker();
            }
            return tc;
        }

    }
}
