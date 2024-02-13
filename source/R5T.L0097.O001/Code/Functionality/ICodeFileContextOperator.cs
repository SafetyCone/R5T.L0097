using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.L0093.T000;
using R5T.L0096.T000;
using R5T.T0132;
using R5T.T0221;


namespace R5T.L0097.O001
{
    [FunctionalityMarker]
    public partial interface ICodeFileContextOperator : IFunctionalityMarker
    {
        public Task In_CodeFileContext(
            string codeFilePath,
            string namespaceName,
            out (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesSet,
            IEnumerable<Func<CodeFileContext, Task>> operations)
        {
            var context = new CodeFileContext
            {
                FilePath = codeFilePath,
                NamespaceName = namespaceName,
            };

            return Instances.ContextOperator.In_Context(
                context,
                operations);
        }

        public Task In_CodeFileContext(
            string codeFilePath,
            string namespaceName,
            out (IsSet<IHasFilePath>, IsSet<IHasNamespaceName>) propertiesSet,
            params Func<CodeFileContext, Task>[] operations)
        {
            return this.In_CodeFileContext(
                codeFilePath,
                namespaceName,
                out propertiesSet,
                operations.AsEnumerable());
        }
    }
}
