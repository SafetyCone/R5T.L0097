using System;


namespace R5T.L0097.O002
{
    public class CodeFileGenerationContextOperations : ICodeFileGenerationContextOperations
    {
        #region Infrastructure

        public static ICodeFileGenerationContextOperations Instance { get; } = new CodeFileGenerationContextOperations();


        private CodeFileGenerationContextOperations()
        {
        }

        #endregion
    }
}
