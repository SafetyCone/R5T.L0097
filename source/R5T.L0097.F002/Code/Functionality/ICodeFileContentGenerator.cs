using System;

using R5T.T0132;


namespace R5T.L0097.F002
{
    [FunctionalityMarker]
    public partial interface ICodeFileContentGenerator : IFunctionalityMarker
    {
        public string Generate_DocumentationFileContent(
            string namespaceName,
            string projectDescription)
        {
            var output =
$@"
using System;


namespace {namespaceName}
{{
	/// <summary>
	/// {projectDescription}
	/// </summary>
	public static class Documentation
	{{
	}}
}}
".Trim();

            return output;
        }

        public string Generate_InstancesFileContent(
            string namespaceName)
        {
            var output =
$@"
using System;


namespace {namespaceName}
{{
    public static class Instances
    {{
		
    }}
}}
".Trim();

            return output;
        }

        public string Generate_ProgramFileContent(
            string namespaceName)
        {
            var output =
$@"
using System;


namespace {namespaceName}
{{
    class Program
    {{
        static void Main()
        {{
            Console.WriteLine(""Hello World!"");
        }}
    }}
}}
".Trim();

            return output;
        }
    }
}
