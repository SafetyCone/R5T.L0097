using System;
using System.Threading.Tasks;

using R5T.L0066.Contexts;
using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.L0093.T000;
using R5T.L0096.T000;
using R5T.T0180;
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


        public Func<TContext, Task> Create_ProgramFile_ForBlazorServer<TContext>(
            (IsSet<IHasProjectFilePath>, IsSet<IHasNamespaceName>) propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Program_cs,
                _Implementations._UsingTextTemplating.Create_ProgramFile_ForBlazorServer<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_ErrorPageRazorComponent_ForBlazorClient<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Error_razor_Page,
                _Implementations._UsingTextTemplating.Create_ErrorPageComponent_ForBlazorClient<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_TailwindConfigJs<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.tailwind_config_js,
                _Implementations._UsingTextTemplating.Create_TailwindConfigJs<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_TailwindConfigJs_ForBlog<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.tailwind_config_js,
                _Implementations._UsingTextTemplating.Create_TailwindConfigJs_ForBlog<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_TailwindSourceCss<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.tailwind_css,
                _Implementations._UsingTextTemplating.Create_TailwindSourceCss<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_ProgramFile_ForBlazorClient<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Program_cs,
                _Implementations._UsingTextTemplating.Create_ProgramFile_ForBlazorClient<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_ImportsComponent_ForBlazorClient<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths._Imports_razor_ForComponents,
                _Implementations._UsingTextTemplating.Create_ImportsComponent_ForBlazorClient<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_ImportsComponent_ForBlazorLibrary<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths._Imports_razor_ForComponents,
                _Implementations._UsingTextTemplating.Create_ImportsComponent_ForBlazorLibrary<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_RoutesComponent_ForBlazorClient<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Routes_razor,
                _Implementations._UsingTextTemplating.Create_RoutesComponent_ForBlazorClient<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_MainLayoutComponent_ForBlazorClient<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.MainLayout_razor,
                _Implementations._UsingTextTemplating.Create_MainLayoutComponent_ForBlazorClient<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_HomeRazorComponent_ForBlazorClient<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Home_razor,
                _Implementations._UsingTextTemplating.Create_HomeRazorComponent_ForBlazorClient<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_HomeRazorComponent_ForBlazorClient_WithComponentLibrary<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Home_razor,
                _Implementations._UsingTextTemplating.Create_HomeRazorComponent_ForBlazorClient_WithComponentLibrary<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_TailwindContentPathsJsonFile_Default<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.tailwind_contentpaths_json,
                _Implementations._UsingTextTemplating.Create_TailwindContentPathsJsonFile_Default<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_TailwindContentPathsJsonFile_ForBlog<TContext>(
            IsSet<IHasProjectFilePath> propertiesRequired,
            out IChecked<IFileExists> fileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.tailwind_contentpaths_json,
                _Implementations._UsingTextTemplating.Create_TailwindContentPathsJsonFile_ForBlog<CodeFileContext>,
                propertiesRequired,
                out fileExists);
        }

        public Func<TContext, Task> Create_AppRazorComponentFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedProgramFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.App_razor,
                _Implementations._UsingTextTemplating.Create_AppRazorComponentFile_ForStaticHtmlWebApplication<CodeFileContext>,
                propertiesRequired,
                out checkedProgramFileExists);
        }

        public Func<TContext, Task> Create_AppSettingsJsonFile<TContext>(
            IsSet<IHasProjectFilePath> projectFilePathSet,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.AppSettings_json,
                _Implementations._UsingTextTemplating.Create_AppSettingsJsonFile<CodeFileContext>,
                projectFilePathSet,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_Component1File<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedProgramFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Component1_razor,
                _Implementations._UsingTextTemplating.Create_Component1File<CodeFileContext>,
                propertiesRequired,
                out checkedProgramFileExists);
        }

        public Func<TContext, Task> Create_DevelopmentAppSettingsJsonFile<TContext>(
            IsSet<IHasProjectFilePath> projectFilePathSet,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.AppSettings_Development_json,
                _Implementations._UsingTextTemplating.Create_DevelopmentAppSettingsJsonFile<CodeFileContext>,
                projectFilePathSet,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_Form1_cs<TContext>(
            (IsSet<IHasProjectFilePath> projectFilePathSet, IsSet<IHasNamespaceName> namespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext :
            IHasProjectFilePath,
            IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Form1_cs,
                _Implementations._UsingTextTemplating.Create_Form1_cs<CodeFileContext>,
                propertiesRequired,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_Form1_Designer_cs<TContext>(
            (IsSet<IHasProjectFilePath> projectFilePathSet, IsSet<IHasNamespaceName> namespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext :
            IHasProjectFilePath,
            IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Form1_Designer_cs,
                _Implementations._UsingTextTemplating.Create_Form1_Designer_cs<CodeFileContext>,
                propertiesRequired,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_Form1_resx<TContext>(
            IsSet<IHasProjectFilePath> projectFilePathSet,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext :
            IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Form1_resx,
                _Implementations._UsingTextTemplating.Create_Form1_resx<CodeFileContext>,
                projectFilePathSet,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_HostRazorPageFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedProgramFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths._Host_cshtml,
                _Implementations._UsingTextTemplating.Create_HostRazorPageFile_ForStaticHtmlWebApplication<CodeFileContext>,
                propertiesRequired,
                out checkedProgramFileExists);
        }

        public Func<TContext, Task> Create_IndexRazorComponentFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Index_razor,
                _Implementations._UsingTextTemplating.Create_IndexRazorComponentFile_ForStaticHtmlWebApplication<CodeFileContext>,
                propertiesRequired,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_IndexRazorComponentFile_ForBlogStaticHtmlWebApplication<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Index_razor,
                _Implementations._UsingTextTemplating.Create_IndexRazorComponentFile_ForBlogStaticHtmlWebApplication<CodeFileContext>,
                propertiesRequired,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_IndexRazorComponentFile_ForStaticHtmlWebApplication_WithLibrary<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Index_razor,
                _Implementations._UsingTextTemplating.Create_IndexRazorComponentFile_ForStaticHtmlWebApplication_WithLibrary<CodeFileContext>,
                propertiesRequired,
                out checkeIndexFileExists);
        }

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

        public Func<TContext, Task> Create_Class1File<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedClass1FileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Class1_cs,
                _Implementations._UsingTextTemplating.Create_Class1File<CodeFileContext>,
                propertiesRequired,
                out checkedClass1FileExists);
        }

        public Func<TContext, Task> Create_Class1File_ForWindowsFormsLibrary<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedClass1FileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Class1_cs,
                _Implementations._UsingTextTemplating.Create_Class1File_ForWindowsFormsLibrary<CodeFileContext>,
                propertiesRequired,
                out checkedClass1FileExists);
        }

        public delegate Func<CodeFileContext, Task> CodeFileGenerator_CodeFileOnly(
            IsSet<IHasFilePath> codeFilePathSet,
            out IChecked<IFileExists> checkedCodeFileExists);

        public Func<TContext, Task> Create_CodeFile<TContext>(
            string projectDirectoryRelativeFilePath,
            CodeFileGenerator_CodeFileOnly codeFileGenerator,
            IsSet<IHasProjectFilePath> projectFilePathSet,
            out IChecked<IFileExists> checkedCodeFileExists)
            where TContext : IHasProjectFilePath
        {
            var contextSet = Instances.ContextOperator.Get_ContextSetSpecifier<CodeFileContext, TContext>();

            return Instances.ContextOperations.In_ContextSet_A_BA<CodeFileContext, TContext>(
                Instances.ContextOperations.Construct_Context_B_BA<CodeFileContext, TContext>(
                    // Do nothing.
                ),
                this.Set_CodeFilePath<CodeFileContext, TContext>(
                    projectDirectoryRelativeFilePath,
                    projectFilePathSet,
                    out var codeFilePathSet),
                codeFileGenerator(codeFilePathSet,
                    out checkedCodeFileExists).In(contextSet)
            );
        }

        public delegate Func<CodeFileContext, Task> CodeFileGenerator(
            (IsSet<IHasFilePath> CodeFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedCodeFileExists);

        public Func<TContext, Task> Create_CodeFile<TContext>(
            string projectDirectoryRelativeFilePath,
            CodeFileGenerator codeFileGenerator,
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedCodeFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            var contextSet = Instances.ContextOperator.Get_ContextSetSpecifier<CodeFileContext, TContext>();

            return Instances.ContextOperations.In_ContextSet_A_BA<CodeFileContext, TContext>(
                Instances.ContextOperations.Construct_Context_B_BA<CodeFileContext, TContext>(
                    Instances.ProjectContextOperations.Set_NamespaceName<CodeFileContext, TContext>(propertiesRequired.NamespaceNameSet,
                        out var namespaceNameSet)
                ),
                this.Set_CodeFilePath<CodeFileContext, TContext>(
                    projectDirectoryRelativeFilePath,
                    propertiesRequired.ProjectFilePathSet,
                    out var codeFilePathSet),
                codeFileGenerator((codeFilePathSet, propertiesRequired.NamespaceNameSet),
                    out checkedCodeFileExists).In(contextSet)
            );
        }

        public Func<TContext, Task> Create_ProgramFile_ForStaticHtmlWebApplication<TContext>(
            (IsSet<IHasProjectFilePath> ProjectFilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) propertiesRequired,
            out IChecked<IFileExists> checkedProgramFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Program_cs,
                _Implementations._UsingTextTemplating.Create_ProgramFile_ForStaticHtmlWebApplication<CodeFileContext>,
                propertiesRequired,
                out checkedProgramFileExists);
        }

        public Func<TContext, Task> Create_LaunchSettingsJsonFile<TContext>(
            IsSet<IHasProjectFilePath> projectFilePathSet,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext : IHasProjectFilePath
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.LaunchSettings_json,
                _Implementations._UsingTextTemplating.Create_LaunchSettingsJsonFile<CodeFileContext>,
                projectFilePathSet,
                out checkeIndexFileExists);
        }

        public Func<TContext, Task> Create_ProgramFile_ForWindowsFormsApplication<TContext>(
            (IsSet<IHasProjectFilePath> projectFilePathSet, IsSet<IHasNamespaceName>) contextPropertiesRequired,
            out IChecked<IFileExists> checkeIndexFileExists)
            where TContext :
            IHasProjectFilePath,
            IHasNamespaceName
        {
            return this.Create_CodeFile<TContext>(
                Instances.ProjectDirectoryPathRelativePaths.Program_cs,
                _Implementations._UsingTextTemplating.Create_ProgramFile_ForWindowsFormsApplication<CodeFileContext>,
                contextPropertiesRequired,
                out checkeIndexFileExists);
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

        public Func<TContext, Task> Create_WwwrootDirectory<TContext>(
            IsSet<IHasProjectFilePath> projectFilePathSet,
            out IChecked<IDirectoryExists> checkedWwwrootDirectoryExists)
            where TContext : IHasProjectFilePath
        {
            checkedWwwrootDirectoryExists = Checked.Check<IDirectoryExists>();

            return context =>
            {
                var wwwrootDirectoryPath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    context.ProjectFilePath,
                    @"wwwroot\");

                Instances.FileSystemOperator.Create_Directory_OkIfAlreadyExists(wwwrootDirectoryPath);

                return Task.CompletedTask;
            };
        }

        public Func<TContext, TProjectContext, Task> Set_CodeFilePath<TContext, TProjectContext>(
            string projectDirectoryRelativePath,
            IsSet<IHasProjectFilePath> projectFilePath_ProjectContextPropertiesSet,
            out IsSet<IHasFilePath> codeFilePathSet)
            where TContext : IWithFilePath
            where TProjectContext : IHasProjectFilePath
        {
            return (context, projectContext) =>
            {
                context.FilePath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    projectContext.ProjectFilePath,
                    projectDirectoryRelativePath);

                return Task.CompletedTask;
            };
        }
    }
}
