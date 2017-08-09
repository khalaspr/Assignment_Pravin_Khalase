using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
   public class Program
    {
       public static string source { get; set; } 
       public static void Main(string[] args)
        {
            ProcessFileData(args);
        }

       public static void ProcessFileData(string[] options) 
        {
            try
            {
                string type = options[0];
                string filePath = options[1];
                
                TypeFactory _factory = new TypeFactory();
                TypeChecker tc = _factory.getTypeChecker(type);//get the type from factory like Version/Size and So on...
                string message = tc.getFileInfo(filePath);
                Console.WriteLine(message);
                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: "+ex.Message);
                Console.ReadLine();
            }
           
        }
    }
}
