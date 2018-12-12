using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.CodeDom.Compiler;

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
        public static void Compiler(string file)
        {
            CodeDomProvider provedor = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters parames = new CompilerParameters();
            parames.GenerateExecutable = true;
            parames.OutputAssembly = "test.exe";
            parames.TreatWarningsAsErrors = false;
            parames.GenerateInMemory = false;

            CompilerResults comp = provedor.CompileAssemblyFromFile(parames,file);

        }

    }
}
