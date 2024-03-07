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

        public async Task Generate_File(
            string filePath,
            Func<Task<string>> fileContentProvider)
        {
            var fileContent = await fileContentProvider();

            await Instances.FileOperator.Write_Text(
                filePath,
                fileContent);
        }

        public Task Generate_File(
            string filePath,
            Func<string> fileContentProvider)
        {
            var fileContent = fileContentProvider();

            return Instances.FileOperator.Write_Text(
                filePath,
                fileContent);
        }

        public Task Generate_ProgramFile_ForStaticHtmlWebApplication(
            string codeFilePath,
            string namespaceName)
        {
            var codeFileContent = Instances.CodeFileContentGenerator.Generate_ProgramFileContent_ForStaticHtmlWebApplication(
                namespaceName);

            return Instances.FileOperator.Write_Text(
                codeFilePath,
                codeFileContent);
        }

        public Task Generate_ProjectPlanFile(
            string codeFilePath,
            string projectName,
            string projectDescription)
        {
            var codeFileContent = Instances.CodeFileContentGenerator.Generate_ProjectPlanFileContent(
                projectName,
                projectDescription);

            return Instances.FileOperator.Write_Text(
                codeFilePath,
                codeFileContent);
        }
    }
}
