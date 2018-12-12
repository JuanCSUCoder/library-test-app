using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CodeGen
    {
        public static string prefile = "using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Reflection;namespace ConsoleApp1{class ExampleCodeToCompile{static void main(string[] args){";
        public static string midfile = "AppDomain.CurrentDomain.Load(assemble(path).GetName());";
        public static string posfile = "}static Assembly assemble(string path){Assembly a = Assembly.LoadFrom(path);return a;}}}";
        public static string GenerateFile(string path, string code) {
            path = "string path = \""+path+"\";";
            string file = prefile + path + midfile + code + posfile;
            return file;
        }
    }
}
