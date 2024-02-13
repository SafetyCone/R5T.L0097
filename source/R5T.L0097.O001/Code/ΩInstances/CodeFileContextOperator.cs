using System;


namespace R5T.L0097.O001
{
    public class CodeFileContextOperator : ICodeFileContextOperator
    {
        #region Infrastructure

        public static ICodeFileContextOperator Instance { get; } = new CodeFileContextOperator();


        private CodeFileContextOperator()
        {
        }

        #endregion
    }
}
