using System;


namespace R5T.L0097.F002
{
    public class CodeFileGenerator : ICodeFileGenerator
    {
        #region Infrastructure

        public static ICodeFileGenerator Instance { get; } = new CodeFileGenerator();


        private CodeFileGenerator()
        {
        }

        #endregion
    }
}
