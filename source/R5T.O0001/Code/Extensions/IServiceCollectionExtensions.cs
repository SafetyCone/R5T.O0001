using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0078;
using R5T.D0079;
using R5T.T0063;


namespace R5T.O0001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CreateProjectForExistingSolution"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCreateProjectForExistingSolution(this IServiceCollection services,
            IServiceAction<IVisualStudioProjectFileOperator> visualStudioProjectFileOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            services
                .Run(visualStudioProjectFileOperatorAction)
                .Run(visualStudioSolutionFileOperatorAction)
                .AddSingleton<CreateProjectForExistingSolution>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CreateSolutionInExistingRepository"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCreateSolutionInExistingRepository(this IServiceCollection services,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            services
                .Run(visualStudioSolutionFileOperatorAction)
                .AddSingleton<CreateSolutionInExistingRepository>();

            return services;
        }
    }
}
