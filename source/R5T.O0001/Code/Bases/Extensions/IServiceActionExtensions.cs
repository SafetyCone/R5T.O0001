using System;

using R5T.D0078;
using R5T.D0079;
using R5T.T0062;
using R5T.T0063;


namespace R5T.O0001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CreateProjectForExistingSolution"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<CreateProjectForExistingSolution> AddCreateProjectForExistingSolutionAction(this IServiceAction _,
            IServiceAction<IVisualStudioProjectFileOperator> visualStudioProjectFileOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            var serviceAction = _.New<CreateProjectForExistingSolution>(services => services.AddCreateProjectForExistingSolution(
                visualStudioProjectFileOperatorAction,
                visualStudioSolutionFileOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="CreateSolutionInExistingRepository"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<CreateSolutionInExistingRepository> AddCreateSolutionInExistingRepositoryAction(this IServiceAction _,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            var serviceAction = _.New<CreateSolutionInExistingRepository>(services => services.AddCreateSolutionInExistingRepository(
                visualStudioSolutionFileOperatorAction));

            return serviceAction;
        }
    }
}
