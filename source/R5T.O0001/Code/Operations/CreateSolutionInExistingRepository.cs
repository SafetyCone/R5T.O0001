using System;
using System.Threading.Tasks;

using R5T.D0078;
using R5T.T0020;


namespace R5T.O0001
{
    /// <summary>
    /// Creates a solution in an existing repository context.
    /// </summary>
    [OperationMarker]
    public class CreateSolutionInExistingRepository : IOperation
    {
        private IVisualStudioSolutionFileOperator VisualStudioSolutionFileOperator { get; }


        public CreateSolutionInExistingRepository(
            IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator)
        {
            this.VisualStudioSolutionFileOperator = visualStudioSolutionFileOperator;
        }

        public async Task Run(
            string repositoryDirectoryPath,
            string solutionName)
        {
            await Instances.SolutionOperator.CreateSolutionInExistingRepository(
                repositoryDirectoryPath,
                solutionName,
                this.VisualStudioSolutionFileOperator);
        }
    }
}
