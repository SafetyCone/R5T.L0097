using System;

using R5T.L0093.T000;
using R5T.L0096.T000;
using R5T.T0137;


namespace R5T.L0097.O001
{
    [ContextImplementationMarker]
    public class CodeFileContext : IContextImplementationMarker,
        IWithFilePath,
        IWithNamespaceName
    {
        public string FilePath { get; set; }
        public string NamespaceName { get; set; }
    }
}
