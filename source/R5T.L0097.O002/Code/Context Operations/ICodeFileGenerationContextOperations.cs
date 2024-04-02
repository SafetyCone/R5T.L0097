using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.L0093.T000;
using R5T.L0096.T000;
using R5T.T0221;
using R5T.T0241;


namespace R5T.L0097.O002
{
    [ContextOperationsMarker]
    public partial interface ICodeFileGenerationContextOperations : IContextOperationsMarker
    {
        public Func<TContext, Task> Create_ProgramFile_ForBlazorServer<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_ProgramFile_ForBlazorServer(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_ErrorPageComponent_ForBlazorClient<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_ErrorPageComponent_ForBlazorServer());
            };
        }

        public Func<TContext, Task> Create_TailwindConfigJs<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_TailwindConfigJs());
            };
        }

        public Func<TContext, Task> Create_TailwindConfigJs_ForBlog<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_TailwindConfigJs_ForBlog());
            };
        }

        public Func<TContext, Task> Create_TailwindSourceCss<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_TailwindSourceCss());
            };
        }

        public Func<TContext, Task> Create_ProgramFile_ForBlazorClient<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_ProgramFile_ForBlazorClient(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_ImportsComponent_ForBlazorClient<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_ImportsComponent_ForBlazorClient(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_ImportsComponent_ForBlazorLibrary<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_ImportsComponent_ForBlazorLibrary());
            };
        }

        public Func<TContext, Task> Create_RoutesComponent_ForBlazorClient<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_RoutesComponent_ForBlazorClient());
            };
        }

        public Func<TContext, Task> Create_MainLayoutComponent_ForBlazorClient<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_MainLayoutComponent_ForBlazorClient());
            };
        }

        public Func<TContext, Task> Create_HomeRazorComponent_ForBlazorClient<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_HomeRazorComponent_ForBlazorClient());
            };
        }

        public Func<TContext, Task> Create_HomeRazorComponent_ForBlazorClient_WithComponentLibrary<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_HomeRazorComponent_ForBlazorClient_WithComponentLibrary());
            };
        }

        public Func<TContext, Task> Create_TailwindContentPathsJsonFile_Default<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_TailwindContentPathsJsonFile_Default());
            };
        }

        public Func<TContext, Task> Create_TailwindContentPathsJsonFile_ForBlog<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasFilePath
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_TailwindContentPathsJsonFile_ForBlog());
            };
        }

        public Func<TContext, Task> Create_AppRazorComponentFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_AppRazorComponentFileContent(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_AppSettingsJsonFile<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_AppSettingsJsonFileContent());
            };
        }

        public Func<TContext, Task> Create_Class1File<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_Class1FileContent(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_Class1File_ForWindowsFormsLibrary<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_Class1_ForWindowsFormsLibraryFileContent(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_Component1File<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_Component1FileContent(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_Form1_cs<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_Form1_cs(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_Form1_Designer_cs<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_Form1_Designer_cs(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_Form1_resx<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext :
            IHasFilePath,
            IHasNamespaceName
        {
            fileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_Form1_resx(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_DevelopmentAppSettingsJsonFile<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_DevelopmentAppSettingsJsonFileContent());
            };
        }

        public Func<TContext, Task> Create_DocumentationFile<TContext>(
            string projectDescription,
            out IChecked<IFileExists> documentationFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            documentationFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_DocumentationFile(
                    context.FilePath,
                    context.NamespaceName,
                    projectDescription);
            };
        }

        public Func<TContext, Task> Create_IndexRazorComponentFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_IndexRazorComponentFileContent(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_IndexRazorComponentFile_ForBlogStaticHtmlWebApplication<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_IndexRazorComponentFileContent_ForBlog(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_IndexRazorComponentFile_ForStaticHtmlWebApplication_WithLibrary<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_IndexRazorComponentFileContent_WithLibrary(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_InstancesFile<TContext>(
            out IChecked<IFileExists> instancesFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            instancesFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_InstancesFile(
                    context.FilePath,
                    context.NamespaceName);
            };
        }

        public Func<TContext, Task> Create_LaunchSettingsJsonFile<TContext>(
            IsSet<IHasFilePath> propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_LaunchSettingsJsonFileContent());
            };
        }

        public Func<TContext, Task> Create_ProgramFile_ForWindowsFormsApplication<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) contextPropertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext :
            IHasFilePath,
            IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_ProgramFile_ForWindowsFormsApplicationContent(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_ProgramFile_ForConsole<TContext>(
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_ProgramFile(
                    context.FilePath,
                    context.NamespaceName);
            };
        }

        public Func<TContext, Task> Create_HostRazorPageFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_File(
                    context.FilePath,
                    Instances.CodeFileContentGenerator.Generate_HostRazorPageFileContent(
                        context.NamespaceName));
            };
        }

        public Func<TContext, Task> Create_ProgramFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_ProgramFile_ForStaticHtmlWebApplication(
                    context.FilePath,
                    context.NamespaceName);
            };
        }

        public Func<TContext, Task> Create_ProjectPlanFile<TContext>(
            (IsSet<IHasFilePath>, IsSet<IHasProjectName>, IsSet<IHasProjectDescription>) requiredProperties,
            out IChecked<IFileExists> projectPlanFileExists)
            where TContext : IHasFilePath, IHasProjectName, IHasProjectDescription
        {
            projectPlanFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerator.Generate_ProjectPlanFile(
                    context.FilePath,
                    context.ProjectName,
                    context.ProjectDescription);
            };
        }
    }
}
