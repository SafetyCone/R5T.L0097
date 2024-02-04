using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.L0096.T000;
using R5T.T0241;


namespace R5T.L0097.O001
{
    [ContextOperationsMarker]
    public partial interface ICodeFileGenerationContextOperations : IContextOperationsMarker
    {
        /// <summary>
        /// <inheritdoc cref="F0083.ICodeFileGenerationOperations.Create_ProgramFile_ForConsole(string, string)"/>
        /// <para><inheritdoc cref="Z0067.IProjectDirectoryPathRelativePaths.Program_cs" path="/descendant::value"/></para>
        /// </summary>
        public Func<TContext, Task> Create_ProgramFile_ForConsole<TContext>(
            out IChecked<IFileExists> programFileExists)
            where TContext : IHasProjectFilePath, IHasNamespaceName
        {
            programFileExists = Checked.Check<IFileExists>();

            return context =>
            {
                var codeFilePath = Instances.ProjectPathsOperator.Get_Path_ForProjectDirectoryRelativePath(
                    context.ProjectFilePath,
                    Instances.ProjectDirectoryPathRelativePaths.Program_cs);

                return Instances.CodeFileGenerationOperations.Create_ProgramFile_ForConsole(
                    codeFilePath,
                    context.NamespaceName);
            };
        }
    }
}
