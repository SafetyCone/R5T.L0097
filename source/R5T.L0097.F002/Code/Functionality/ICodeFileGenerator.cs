using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.L0097.F002
{
    [FunctionalityMarker]
    public partial interface ICodeFileGenerator : IFunctionalityMarker
    {
        public Task Generate_DocumentationFile(
            string codeFilePath,
            string namespaceName,
            string projectDescription)
        {
            var codeFileContent = Instances.CodeFileContentGenerator.Generate_DocumentationFileContent(
                namespaceName,
                projectDescription);

            return Instances.FileOperator.Write_Text(
                codeFilePath,
                codeFileContent);
        }

        public Task Generate_InstancesFile(
            string codeFilePath,
            string namespaceName)
        {
            var codeFileContent = Instances.CodeFileContentGenerator.Generate_InstancesFileContent(
                namespaceName);

            return Instances.FileOperator.Write_Text(
                codeFilePath,
                codeFileContent);
        }

        public Task Generate_ProgramFile(
            string codeFilePath,
            string namespaceName)
        {
            var codeFileContent = Instances.CodeFileContentGenerator.Generate_ProgramFileContent(
                namespaceName);

            return Instances.FileOperator.Write_Text(
                codeFilePath,
                codeFileContent);
        }
    }
}
