using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.L0093.T000;
using R5T.L0096.T000;
using R5T.T0221;
using R5T.T0241;


namespace R5T.L0097.O001
{
    [ContextOperationsMarker]
    public partial interface ICodeFileGenerationContextOperations : IContextOperationsMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Implementations.ICodeFileGenerationContextOperations _Implementations => Implementations.CodeFileGenerationContextOperations.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public Func<TContext, Task> Create_InstancesFile<TContext>(
            (IsSet<IHasProjectFilePath>, IsSet<IHasNamespaceName>) requiredProperties,
            out IChecked<IFileExists> checkedInstancesFileExists
            )
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            checkedInstancesFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                var codeFilePath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    context.ProjectFilePath,
                    Instances.ProjectDirectoryPathRelativePaths.Instances_cs);

                return Instances.CodeFileContextOperator.In_CodeFileContext(
                    codeFilePath,
                    context.NamespaceName,
                    out (IsSet<IHasFilePath> FilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) codeFilePropertiesSet,
                    Instances.CodeFileContextOperationSetOperator.Generate_InstancesFile<CodeFileContext>(
                        (codeFilePropertiesSet.FilePathSet, codeFilePropertiesSet.NamespaceNameSet),
                        out _
                    )
                );
            };
        }

        public Func<TContext, Task> Create_DocumentationFile<TContext>(
            (IsSet<IHasProjectFilePath>, IsSet<IHasNamespaceName>, IsSet<IHasProjectDescription>) requiredProperties,
            out IChecked<IFileExists> checkedDocumentationFileExists
            )
            where TContext : IHasProjectFilePath, IHasNamespaceName, IHasProjectDescription
        {
            checkedDocumentationFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                var codeFilePath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    context.ProjectFilePath,
                    Instances.ProjectDirectoryPathRelativePaths.Documentation_cs);

                return Instances.CodeFileContextOperator.In_CodeFileContext(
                    codeFilePath,
                    context.NamespaceName,
                    out (IsSet<IHasFilePath> FilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) codeFilePropertiesSet,
                    Instances.CodeFileContextOperationSetOperator.Generate_DocumentationFile<CodeFileContext>(
                        (codeFilePropertiesSet.FilePathSet, codeFilePropertiesSet.NamespaceNameSet),
                        out _,
                        context.ProjectDescription
                    )
                );
            };
        }

        /// <summary>
        /// <inheritdoc cref="F0083.ICodeFileGenerationOperations.Create_ProgramFile_ForConsole(string, string)"/>
        /// <para><inheritdoc cref="Z0067.IProjectDirectoryPathRelativePaths.Program_cs" path="/descendant::value"/></para>
        /// </summary>
        public Func<TContext, Task> Create_ProgramFile_ForConsole<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedProgramFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            checkedProgramFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                var codeFilePath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    context.ProjectFilePath,
                    Instances.ProjectDirectoryPathRelativePaths.Program_cs);

                return Instances.CodeFileContextOperator.In_CodeFileContext(
                    codeFilePath,
                    context.NamespaceName,
                    out (IsSet<IHasFilePath> FilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) codeFilePropertiesSet,
                    //_Implementations.Create_ProgramFile_ForConsole_UsingRazorComponents<CodeFileContext>(
                    //    out _
                    //)
                    _Implementations.Create_ProgramFile_ForConsole_UsingRazorComponents<CodeFileContext>(
                        (codeFilePropertiesSet.FilePathSet, codeFilePropertiesSet.NamespaceNameSet),
                        out _
                    )
                    //_Implementations.Create_ProgramFile_ForConsole_UsingRoslyn<CodeFileContext>(
                    //    out _
                    //)
                    //_Implementations.Create_ProgramFile_ForConsole_UsingRoslyn<CodeFileContext>(
                    //    (codeFilePropertiesSet.FilePathSet, codeFilePropertiesSet.NamespaceNameSet),
                    //    out _
                    //)
                    //_Implementations.Create_ProgramFile_ForConsole_UsingTextTemplating<CodeFileContext>(
                    //    out _
                    //)
                    //_Implementations.Create_ProgramFile_ForConsole_UsingTextTemplating<CodeFileContext>(
                    //    (codeFilePropertiesSet.FilePathSet, codeFilePropertiesSet.NamespaceNameSet),
                    //    out _
                    //)
                );

                //var childContext = new CodeFileContext
                //{
                //    FilePath = codeFilePath,
                //    NamespaceName = context.NamespaceName,
                //};

                //var filePathSet = Instances.IsSetOperator.IsSet<IHasFilePath>();

                //return Instances.ContextOperator.In_Context(
                //    childContext,
                //    //_Implementations.Create_ProgramFile_ForConsole_UsingRazorComponents<CodeFileContext>(
                //    //    out _
                //    //)
                //    _Implementations.Create_ProgramFile_ForConsole_UsingRazorComponents<CodeFileContext>(
                //        (filePathSet, propertiesRequired.NamespaceNameSet),
                //        out _
                //    )
                //    //_Implementations.Create_ProgramFile_ForConsole_UsingRoslyn<CodeFileContext>(
                //    //    out _
                //    //)
                //    //_Implementations.Create_ProgramFile_ForConsole_UsingRoslyn<CodeFileContext>(
                //    //    (filePathSet, propertiesRequired.NamespaceNameSet),
                //    //    out _
                //    //)
                //    //_Implementations.Create_ProgramFile_ForConsole_UsingTextTemplating<CodeFileContext>(
                //    //    out _
                //    //)
                //    //_Implementations.Create_ProgramFile_ForConsole_UsingTextTemplating<CodeFileContext>(
                //    //    (filePathSet, propertiesRequired.NamespaceNameSet),
                //    //    out _
                //    //)
                //);
            };
        }

        /// <summary>
        /// <inheritdoc cref="F0083.ICodeFileGenerationOperations.Create_ProgramFile_ForConsole(string, string)"/>
        /// <para><inheritdoc cref="Z0067.IProjectDirectoryPathRelativePaths.Program_cs" path="/descendant::value"/></para>
        /// </summary>
        public Func<TContext, Task> Create_ProgramFile_ForConsole<TContext>(
            out IChecked<IFileExists> checkedProgramFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            checkedProgramFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                var codeFilePath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    context.ProjectFilePath,
                    Instances.ProjectDirectoryPathRelativePaths.Program_cs);

                var childContext = new CodeFileContext
                {
                    FilePath = codeFilePath,
                    NamespaceName = context.NamespaceName,
                };

                return Instances.ContextOperator.In_Context(
                    childContext,
                    //_Implementations.Create_ProgramFile_ForConsole_UsingRazorComponents<CodeFileContext>(
                    //    out _
                    //)
                    //_Implementations.Create_ProgramFile_ForConsole_UsingRoslyn<CodeFileContext>(
                    //    out _
                    //)
                    _Implementations.Create_ProgramFile_ForConsole_UsingTextTemplating<CodeFileContext>(
                        out _
                    )
                );
            };
        }

        public Func<TContext, Task> Create_ProjectPlanFile<TContext>(
            (IsSet<IHasProjectFilePath>, IsSet<IHasProjectName>, IsSet<IHasProjectDescription>) requiredProperties,
            out IChecked<IFileExists> checkedProjectPlanFileExists
            )
            where TContext : IHasProjectFilePath, IHasProjectName, IHasProjectDescription
        {
            checkedProjectPlanFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                var codeFilePath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    context.ProjectFilePath,
                    Instances.ProjectDirectoryPathRelativePaths.Project_Plan_md);

                return Instances.ContextOperator.In_Context(
                    new ProjectContextFileContext
                    {
                        FilePath = codeFilePath,
                        ProjectName = context.ProjectName,
                        ProjectDescription = context.ProjectDescription
                    },
                    this._Implementations._UsingTextTemplating.Create_ProjectPlanFile<ProjectContextFileContext>(
                        Instances.IsSetOperator.IsSet<IHasFilePath, IHasProjectName, IHasProjectDescription>(),
                        out _
                    )
                );
            };
        }
    }
}
