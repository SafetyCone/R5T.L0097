using System;


namespace R5T.L0097.F002
{
    public static class Instances
    {
        public static ICodeFileContentGenerator CodeFileContentGenerator => F002.CodeFileContentGenerator.Instance;
        public static L0066.IFileOperator FileOperator => L0066.FileOperator.Instance;
    }
}