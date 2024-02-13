using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.L0093.T000;
using R5T.L0096.T000;
using R5T.T0241;


namespace R5T.L0097.O001.Implementations
{
    [ContextOperationsMarker]
    public partial interface ICodeFileGenerationContextOperations : IContextOperationsMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private O002.ICodeFileGenerationContextOperations _UsingTextTemplating => O002.CodeFileGenerationContextOperations.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <inheritdoc cref="F0083.ICodeFileGenerationOperations.Create_ProgramFile_ForConsole(string, string)"/>
        /// <para><inheritdoc cref="Z0067.IProjectDirectoryPathRelativePaths.Program_cs" path="/descendant::value"/></para>
        /// </summary>
        public Func<TContext, Task> Create_ProgramFile_ForConsole_UsingRazorComponents<TContext>(
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                return Instances.CodeFileGenerationOperations.Create_ProgramFile_ForConsole(
                    context.FilePath,
                    context.NamespaceName);
            };
        }

        public Func<TContext, Task> Create_ProgramFile_ForConsole_UsingRoslyn<TContext>(
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                var operations = Instances.CodeFileContextOperationSetOperator.Generate_ProgramFile<L0073.T003.CodeFileContext>(
                    context.NamespaceName);

                return Instances.CodeFileContextOperator.In_CodeFileContext(
                    context.FilePath,
                    out _,
                    operations
                );
            };
        }

        public Func<TContext, Task> Create_ProgramFile_ForConsole_UsingTextTemplating<TContext>(
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasFilePath, IHasNamespaceName
        {
            return _UsingTextTemplating.Create_ProgramFile_ForConsole<TContext>(
                out programFileExists);
        }
    }
}
