using System;
using System.Threading.Tasks;

using R5T.D0078;
using R5T.D0079;
using R5T.T0020;
using R5T.T0114;


namespace R5T.O0001
{
    /// <summary>
    /// Creates a new project in an existing solution.
    /// </summary>
    [OperationMarker]
    public class CreateProjectForExistingSolution : IOperation
    {
        private IVisualStudioProjectFileOperator VisualStudioProjectFileOperator { get; }
        private IVisualStudioSolutionFileOperator VisualStudioSolutionFileOperator { get; }


        public CreateProjectForExistingSolution(
            IVisualStudioProjectFileOperator visualStudioProjectFileOperator,
            IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator)
        {
            this.VisualStudioProjectFileOperator = visualStudioProjectFileOperator;
            this.VisualStudioSolutionFileOperator = visualStudioSolutionFileOperator;
        }

        public async Task Run(
            string solutionFilePath,
            IProjectSpecification projectSpecification)
        {
            await Instances.ProjectOperator.CreateProjectForExistingSolution(
                solutionFilePath,
                projectSpecification,
                this.VisualStudioProjectFileOperator,
                this.VisualStudioSolutionFileOperator);
        }
    }
}
