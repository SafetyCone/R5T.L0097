using System;

using R5T.T0132;


namespace R5T.L0097.F002
{
    [FunctionalityMarker]
    public partial interface ICodeFileContentGenerator : IFunctionalityMarker
    {
        public Func<string> Generate_AppSettingsJsonFileContent()
        {
            return () =>
$@"
{{
  ""Logging"": {{
    ""LogLevel"": {{
      ""Default"": ""Information"",
      ""Microsoft.AspNetCore"": ""Warning""
    }}
  }},
  ""AllowedHosts"": ""*""
}}
".Trim();
        }

        public Func<string> Generate_Class1FileContent(
            string namespaceName)
        {
            return () =>
$@"
using System;


namespace {namespaceName}
{{
    public class Class1
    {{
        
    }}
}}
".Trim();
        }

        public Func<string> Generate_DevelopmentAppSettingsJsonFileContent()
        {
            return () =>
$@"
{{
  ""Logging"": {{
    ""LogLevel"": {{
      ""Default"": ""Information"",
      ""Microsoft.AspNetCore"": ""Warning""
    }}
  }}
}}
".Trim();
        }

        public Func<string> Generate_AppRazorComponentFileContent(
            string namespaceName)
        {
            return () =>
$@"
@using Microsoft.AspNetCore.Components.Routing
@using Microsoft.AspNetCore.Components.Web


@namespace {namespaceName}

@*Only make components in *this* application assembly publically available (i.e. do not include additional assemblies).*@
<Router AppAssembly=""@typeof(App).Assembly"">
    <Found Context=""routeData"">
        <RouteView RouteData=""@routeData"" />
    </Found>
    <NotFound>
        <PageTitle>Not found</PageTitle>
        <p role=""alert"">Sorry, there's nothing at this address.</p>
    </NotFound>
</Router>
".Trim();
        }

        public Func<string> Generate_Component1FileContent(
            string namespaceName)
        {
            return () =>
$@"

@namespace {namespaceName}


<div class=""my-component"">
    This component is defined in the <strong>{namespaceName}</strong> library.
</div>
".Trim();
        }

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

        public Func<string> Generate_HostRazorPageFileContent(
            string namespaceName)
        {
            return () =>
$@"
@page ""/_Host""
@namespace {namespaceName}
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

<component type=""typeof(App)"" render-mode=""Static"" />
".Trim();
        }

        public Func<string> Generate_IndexRazorComponentFileContent(
            string namespaceName)
        {
            return () =>
$@"
@page ""/""

@namespace {namespaceName}

<html>
    <head>
        <meta charset=""utf-8"" />

        <title>Index Page</title>
    </head>
    <body>
        <h3>Index</h3>
    </body>
</html>

@code {{

}}
".Trim();
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

        public Func<string> Generate_LaunchSettingsJsonFileContent()
        {
            return () =>
$@"
{{
  ""$schema"": ""http://json.schemastore.org/launchsettings.json"",
  ""profiles"": {{
    ""http"": {{
      ""commandName"": ""Project"",
      ""dotnetRunMessages"": true,
      ""launchBrowser"": true,
      ""applicationUrl"": ""http://localhost:5137"",
      ""environmentVariables"": {{
        ""ASPNETCORE_ENVIRONMENT"": ""Development""
      }}
    }},
    ""https"": {{
      ""commandName"": ""Project"",
      ""dotnetRunMessages"": true,
      ""launchBrowser"": true,
      ""applicationUrl"": ""https://localhost:7020;http://localhost:5137"",
      ""environmentVariables"": {{
        ""ASPNETCORE_ENVIRONMENT"": ""Development""
      }}
    }}
  }}
}}
".Trim();
        }

        public string Generate_ProgramFileContent_ForStaticHtmlWebApplication(
            string namespaceName)
        {
            var output =
$@"
using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;


namespace {namespaceName}
{{
    class Program
    {{
        static void Main()
        {{
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddRazorPages(razorPagesOptions =>
            {{
                razorPagesOptions.RootDirectory = ""/Routes/Pages"";
            }});

            var app = builder.Build();

            app.MapFallbackToPage(""/_Host"");

            app.Run();
        }}
    }}
}}
".Trim();

            return output;
        }

        public string Generate_ProjectPlanFileContent(
            string projectName,
            string projectDescription)
        {
            var output =
$@"
# {projectName}
{projectDescription}
".Trim();

            return output;
        }
    }
}
