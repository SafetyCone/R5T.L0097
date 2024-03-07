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
