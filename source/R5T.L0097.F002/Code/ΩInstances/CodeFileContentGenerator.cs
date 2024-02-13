using System;


namespace R5T.L0097.F002
{
    public class CodeFileContentGenerator : ICodeFileContentGenerator
    {
        #region Infrastructure

        public static ICodeFileContentGenerator Instance { get; } = new CodeFileContentGenerator();


        private CodeFileContentGenerator()
        {
        }

        #endregion
    }
}
