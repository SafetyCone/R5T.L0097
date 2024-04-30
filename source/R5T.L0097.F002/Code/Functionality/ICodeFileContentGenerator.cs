using System;

using R5T.T0132;


namespace R5T.L0097.F002
{
    [FunctionalityMarker]
    public partial interface ICodeFileContentGenerator : IFunctionalityMarker
    {
        public Func<string> Generate_ProgramFile_ForBlazorServer(
            string namespaceName)
        {
            return () =>
$@"
using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.AspNetCore.Builder;

using {namespaceName}.Components;


namespace {namespaceName}
{{
    public class Program
    {{
        public static void Main(string[] args)
        {{
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveWebAssemblyComponents();

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {{
                app.UseWebAssemblyDebugging();
            }}
            else
            {{
                app.UseExceptionHandler(""/Error"");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }}

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client.Components._Imports).Assembly);

            app.MapControllers();

            app.Run();
        }}
    }}
}}
".Trim();
        }

        public Func<string> Generate_ImportsComponent_ForBlazorServer(
            string clientProjectName,
            string serverProjectName)
        {
            return () =>
$@"
@using System.Net.Http
@using System.Net.Http.Json

@using Microsoft.AspNetCore.Components.Forms
@using Microsoft.AspNetCore.Components.Routing
@using Microsoft.AspNetCore.Components.Web
@using static Microsoft.AspNetCore.Components.Web.RenderMode
@using Microsoft.AspNetCore.Components.Web.Virtualization
@using Microsoft.AspNetCore.Http;
@using Microsoft.JSInterop

@using {clientProjectName}.Components
@using {serverProjectName}.Components
".Trim();
        }

        public Func<string> Generate_ImportsComponent_ForBlazorLibrary()
        {
            return () =>
$@"
@using Microsoft.AspNetCore.Components.Web
".Trim();
        }

        public Func<string> Generate_AppComponent_ForBlazorServer(
            string projectName)
        {
            return () =>
$@"
<!DOCTYPE html>
<html lang=""en"">

<head>
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <base href=""/"" />
    <link rel=""stylesheet"" href=""/css-out/tailwind.css"" />
    <link rel=""stylesheet"" href=""{projectName}.styles.css"" />
    <HeadOutlet @rendermode=""new InteractiveWebAssemblyRenderMode(prerender: false)"" />
</head>

<body>
    <Routes @rendermode=""new InteractiveWebAssemblyRenderMode(prerender: false)"" />
    <script src=""_framework/blazor.web.js""></script>
</body>

</html>
".Trim();
        }

        public Func<string> Generate_ErrorPageComponent_ForBlazorServer()
        {
            return () =>
$@"
@page ""/Error""

@using System.Diagnostics


<PageTitle>Error</PageTitle>

<h1 class=""text-red-500"">Error.</h1>
<h2 class=""text-red-500"">An error occurred while processing your request.</h2>

@if (ShowRequestId)
{{
    <p>
        <strong>Request ID:</strong> <code>@RequestId</code>
    </p>
}}

<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>

@code{{
    [CascadingParameter]
    private HttpContext HttpContext {{ get; set; }}

    private string RequestId {{ get; set; }}
    private bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    protected override void OnInitialized() =>
        RequestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
}}
".Trim();
        }

        public Func<string> Generate_PackageJson(
            string projectName,
            string projectDescription,
            string authorName,
            string licenseName)
        {
            return () =>
$@"
{{
  ""name"": ""{projectName}"",
  ""version"": ""0.0.1"",
  ""description"": ""{projectDescription}"",
  ""main"": ""index.js"",
  ""scripts"": {{
    ""tailwindcss"": ""npx tailwindcss -i ./source/css/tailwind.css -o ./wwwroot/css-out/tailwind.css --watch"",
    ""test"": ""echo \""Error: no test specified\"" && exit 1""
  }},
  ""author"": ""{authorName}"",
  ""license"": ""{licenseName}"",
  ""devDependencies"": {{
    ""tailwindcss"": ""3.4.1""
  }}
}}
".Trim();
        }

        /// <summary>
        /// Includes @tailwindcss/typography.
        /// </summary>
        public Func<string> Generate_PackageJson_ForBlog(
            string projectName,
            string projectDescription,
            string authorName,
            string licenseName)
        {
            return () =>
$@"
{{
  ""name"": ""{projectName}"",
  ""version"": ""0.0.1"",
  ""description"": ""{projectDescription}"",
  ""main"": ""index.js"",
  ""scripts"": {{
    ""tailwindcss"": ""npx tailwindcss -i ./source/css/tailwind.css -o ./wwwroot/css-out/tailwind.css --watch"",
    ""test"": ""echo \""Error: no test specified\"" && exit 1""
  }},
  ""author"": ""{authorName}"",
  ""license"": ""{licenseName}"",
  ""devDependencies"": {{
    ""tailwindcss"": ""3.4.1"",
    ""@tailwindcss/typography"": ""0.5.11""
  }}
}}
".Trim();
        }

        public Func<string> Generate_TailwindConfigJs()
        {
            return () =>
$@"
/** @type {{import('tailwindcss').Config}} */

const content = require('./tailwind.contentpaths.all.json');

module.exports = {{
  content: content,
  theme: {{
    extend: {{}},
  }},
  plugins: [],
}}
".Trim();
        }

        public Func<string> Generate_TailwindSourceCss()
        {
            return () =>
$@"
@tailwind base;
@tailwind components;
@tailwind utilities;
".Trim();
        }

        public Func<string> Generate_StringsControllerFileContent(
            string namespaceName)
        {
            return () =>
$@"
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace {namespaceName}.Controllers
{{
    [ApiController]
    [Route(""/api/[controller]"")]
    public class StringsController : ControllerBase
    {{
        [HttpGet(""values"")]
        public async Task<string[]> Get()
        {{
            // Simulate a long operation.
            await Task.Delay(3000);

            var output = new string[]
            {{
            ""A"",
            ""B"",
            ""C""
            }};

            return output;
        }}
    }}
}}
".Trim();
        }

        public Func<string> Generate_TailwindConfigJs_ForBlog()
        {
            return () =>
$@"
/** @type {{import('tailwindcss').Config}} */

const content = require('./tailwind.contentpaths.all.json');

const defaultTheme = require('tailwindcss/defaultTheme')

module.exports = {{
    content: content,
    theme: {{
        fontFamily: {{
            'sans': ['""Inter var""', ...defaultTheme.fontFamily.sans]
        }},
        extend: {{
            typography: {{
                DEFAULT: {{
                    css: {{
                        'code::before': {{
                            content: '""""'
                        }},
                        'code::after': {{
                            content: '""""'
                        }},
                        'code.ticked::before': {{
                            content: '""`""'
                        }},
                        'code.ticked::after': {{
                            content: '""`""'
                        }}
                    }}
                }}
            }}
        }},
    }},
    plugins: [
        require('@tailwindcss/typography')
    ],
}}
".Trim();
        }

        public Func<string> Generate_ProgramFile_ForBlazorClient(
            string namespaceName)
        {
            return () =>
$@"
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


namespace {namespaceName}
{{
    internal class Program
    {{
        static async Task Main(string[] args)
        {{
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }}
    }}
}}
".Trim();
        }

        public Func<string> Generate_ImportsComponent_ForBlazorClient(
            string namespaceName)
        {
            return () =>
$@"
@using System.Net.Http
@using System.Net.Http.Json

@using Microsoft.AspNetCore.Components.Forms
@using Microsoft.AspNetCore.Components.Routing
@using Microsoft.AspNetCore.Components.Web
@using static Microsoft.AspNetCore.Components.Web.RenderMode
@using Microsoft.AspNetCore.Components.Web.Virtualization
@using Microsoft.JSInterop

@using {namespaceName}
@using {namespaceName}.Components

".Trim();
        }

        public Func<string> Generate_RoutesComponent_ForBlazorClient()
        {
            return () =>
$@"

<Router AppAssembly=""typeof(Program).Assembly"">
    <Found Context=""routeData"">
        <RouteView RouteData=""routeData"" DefaultLayout=""typeof(Layout.MainLayout)"" />
        <FocusOnNavigate RouteData=""routeData"" Selector=""h1"" />
    </Found>
</Router>
".Trim();
        }

        public Func<string> Generate_MainLayoutComponent_ForBlazorClient()
        {
            return () =>
$@"
@inherits LayoutComponentBase

@Body

<div class=""font-bold text-red-500"">
    An unhandled error has occurred.
    <a href="""" class=""reload"">Reload</a>
    <a class=""dismiss"">🗙</a>
</div>
".Trim();
        }

        public Func<string> Generate_HomeRazorComponent_ForBlazorClient()
        {
            return () =>
$@"
@page ""/""

<PageTitle>Home</PageTitle>

<h1 class=""text-blue-600"">Hello, world!</h1>

Welcome to your new app.

".Trim();
        }

        public Func<string> Generate_HomeRazorComponent_ForBlazorClient_WithComponentLibrary()
        {
            return () =>
$@"
@page ""/""

<PageTitle>Home</PageTitle>

<h1 class=""text-blue-600"">Hello, world!</h1>

Welcome to your new app.

<Component1/>

".Trim();
        }

        /// <summary>
        /// For the Rivet-convention of using a per-project TailwindCSS content paths file (that are all then aggregated into a single -all TailwincCSS content paths file by R5T.S0062 for a entry-point application project).
        /// </summary>
        public Func<string> Generate_TailwindContentPathsJsonFile_Default()
        {
            return () =>
$@"
[
  ""./Components/**/*.razor""
]
".Trim();
        }

        /// <summary>
        /// For the Rivet-convention of using a per-project TailwindCSS content paths file (that are all then aggregated into a single -all TailwincCSS content paths file by R5T.S0062 for a entry-point application project).
        /// This includes the page (route endpoint) components in /Routes/Components/ for static HTML web applications (which do not have client-side WebAssembly functionality).
        /// This is different from WebAssembly projects where 
        /// </summary>
        public Func<string> Generate_TailwindContentPathsJsonFile_ForBlog()
        {
            return () =>
$@"
[
  ""./Components/**/*.razor"",
  ""./Routes/**/*.razor""
]
".Trim();
        }

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

        public Func<string> Generate_Class1_ForWindowsFormsLibraryFileContent(
            string namespaceName)
        {
            return () =>
$@"
using System;
using System.Windows.Forms;


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

        public Func<string> Generate_Form1_cs(
            string namespaceName)
        {
            return () =>
$@"
using System;
using System.Windows.Forms;


namespace {namespaceName}
{{
    public partial class Form1 : Form
    {{
        public Form1()
        {{
            InitializeComponent();
        }}
    }}
}}
".Trim();
        }

        public Func<string> Generate_Form1_Designer_cs(
            string namespaceName)
        {
            return () =>
$@"
using System;
using System.Windows.Forms;


namespace {namespaceName}
{{
    partial class Form1
    {{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name=""disposing"">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {{
            if (disposing && (components != null))
            {{
                components.Dispose();
            }}
            base.Dispose(disposing);
        }}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {{
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = ""Form1"";
        }}

        #endregion
    }}
}}
".Trim();
        }

        public Func<string> Generate_Form1_resx(
            string namespaceName)
        {
            return () =>
$@"
<?xml version=""1.0"" encoding=""utf-8""?>
<root>
  <!-- 
    Microsoft ResX Schema 
    
    Version 2.0
    
    The primary goals of this format is to allow a simple XML format 
    that is mostly human readable. The generation and parsing of the 
    various data types are done through the TypeConverter classes 
    associated with the data types.
    
    Example:
    
    ... ado.net/XML headers & schema ...
    <resheader name=""resmimetype"">text/microsoft-resx</resheader>
    <resheader name=""version"">2.0</resheader>
    <resheader name=""reader"">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>
    <resheader name=""writer"">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>
    <data name=""Name1""><value>this is my long string</value><comment>this is a comment</comment></data>
    <data name=""Color1"" type=""System.Drawing.Color, System.Drawing"">Blue</data>
    <data name=""Bitmap1"" mimetype=""application/x-microsoft.net.object.binary.base64"">
        <value>[base64 mime encoded serialized .NET Framework object]</value>
    </data>
    <data name=""Icon1"" type=""System.Drawing.Icon, System.Drawing"" mimetype=""application/x-microsoft.net.object.bytearray.base64"">
        <value>[base64 mime encoded string representing a byte array form of the .NET Framework object]</value>
        <comment>This is a comment</comment>
    </data>
                
    There are any number of ""resheader"" rows that contain simple 
    name/value pairs.
    
    Each data row contains a name, and value. The row also contains a 
    type or mimetype. Type corresponds to a .NET class that support 
    text/value conversion through the TypeConverter architecture. 
    Classes that don't support this are serialized and stored with the 
    mimetype set.
    
    The mimetype is used for serialized objects, and tells the 
    ResXResourceReader how to depersist the object. This is currently not 
    extensible. For a given mimetype the value must be set accordingly:
    
    Note - application/x-microsoft.net.object.binary.base64 is the format 
    that the ResXResourceWriter will generate, however the reader can 
    read any of the formats listed below.
    
    mimetype: application/x-microsoft.net.object.binary.base64
    value   : The object must be serialized with 
            : System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
            : and then encoded with base64 encoding.
    
    mimetype: application/x-microsoft.net.object.soap.base64
    value   : The object must be serialized with 
            : System.Runtime.Serialization.Formatters.Soap.SoapFormatter
            : and then encoded with base64 encoding.

    mimetype: application/x-microsoft.net.object.bytearray.base64
    value   : The object must be serialized into a byte array 
            : using a System.ComponentModel.TypeConverter
            : and then encoded with base64 encoding.
    -->
  <xsd:schema id=""root"" xmlns="""" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xsd:import namespace=""http://www.w3.org/XML/1998/namespace"" />
    <xsd:element name=""root"" msdata:IsDataSet=""true"">
      <xsd:complexType>
        <xsd:choice maxOccurs=""unbounded"">
          <xsd:element name=""metadata"">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name=""value"" type=""xsd:string"" minOccurs=""0"" />
              </xsd:sequence>
              <xsd:attribute name=""name"" use=""required"" type=""xsd:string"" />
              <xsd:attribute name=""type"" type=""xsd:string"" />
              <xsd:attribute name=""mimetype"" type=""xsd:string"" />
              <xsd:attribute ref=""xml:space"" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name=""assembly"">
            <xsd:complexType>
              <xsd:attribute name=""alias"" type=""xsd:string"" />
              <xsd:attribute name=""name"" type=""xsd:string"" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name=""data"">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name=""value"" type=""xsd:string"" minOccurs=""0"" msdata:Ordinal=""1"" />
                <xsd:element name=""comment"" type=""xsd:string"" minOccurs=""0"" msdata:Ordinal=""2"" />
              </xsd:sequence>
              <xsd:attribute name=""name"" type=""xsd:string"" use=""required"" msdata:Ordinal=""1"" />
              <xsd:attribute name=""type"" type=""xsd:string"" msdata:Ordinal=""3"" />
              <xsd:attribute name=""mimetype"" type=""xsd:string"" msdata:Ordinal=""4"" />
              <xsd:attribute ref=""xml:space"" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name=""resheader"">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name=""value"" type=""xsd:string"" minOccurs=""0"" msdata:Ordinal=""1"" />
              </xsd:sequence>
              <xsd:attribute name=""name"" type=""xsd:string"" use=""required"" />
            </xsd:complexType>
          </xsd:element>
        </xsd:choice>
      </xsd:complexType>
    </xsd:element>
  </xsd:schema>
  <resheader name=""resmimetype"">
    <value>text/microsoft-resx</value>
  </resheader>
  <resheader name=""version"">
    <value>2.0</value>
  </resheader>
  <resheader name=""reader"">
    <value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
  <resheader name=""writer"">
    <value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
</root>
".Trim();
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

        public Func<string> Generate_IndexRazorComponentFileContent_ForBlog(
            string namespaceName)
        {
            return () =>
$@"
@page ""/""

@namespace {namespaceName}

<html>
    <head>
        <meta charset=""utf-8"" />

        @*Use Tailwind CSS*@
        <link rel=""stylesheet"" type=""text/css"" href=""/css-out/tailwind.css"" />

        @*Use Inter font.*@
        <link href='https://rsms.me/inter/inter.css' rel='stylesheet' type='text/css'>

        <title>Index Page</title>
    </head>
    <body>
        <div class=""prose"">
            <h3>Index</h3>
        </div>
    </body>
</html>

@code {{

}}
".Trim();
        }

        public Func<string> Generate_IndexRazorComponentFileContent_WithLibrary(
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

        <Component1 />
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

        public Func<string> Generate_ProgramFile_ForWindowsFormsApplicationContent(
            string namespaceName)
        {
            return () =>
$@"
using System;
using System.Windows.Forms;


namespace {namespaceName}
{{
    internal static class Program
    {{
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {{
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }}
    }}
}}
".Trim();
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
      ""inspectUri"": ""{{wsProtocol}}://{{url.hostname}}:{{url.port}}/_framework/debug/ws-proxy?browser={{browserInspectUri}}"",
      ""environmentVariables"": {{
        ""ASPNETCORE_ENVIRONMENT"": ""Development""
      }}
    }},
    ""https"": {{
      ""launchUrl"": """",
      ""environmentVariables"": {{
        ""ASPNETCORE_ENVIRONMENT"": ""Development""
      }},
      ""commandName"": ""Project"",
      ""dotnetRunMessages"": true,
      ""launchBrowser"": true,
      ""applicationUrl"": ""https://localhost:7020;http://localhost:5137"",
      ""inspectUri"": ""{{wsProtocol}}://{{url.hostname}}:{{url.port}}/_framework/debug/ws-proxy?browser={{browserInspectUri}}""
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

            app.UseStaticFiles();

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
