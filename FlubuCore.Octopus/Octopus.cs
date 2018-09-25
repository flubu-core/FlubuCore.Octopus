using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Octopus
{
    public class Octopus
    {
        /// <summary>
        /// Generates a package
        /// </summary>
        /// <param name="packageId">The ID of the package; e.g. MyCompany.MyApp</param>
        /// <returns></returns>
        public OctopusPackTask Pack(string packageId)
        {
            return new OctopusPackTask(packageId);
        }

        /// <summary>
        /// The following command will push the package MyPackage to your Octopus Server and will replace the package if it already exists in the built-in repository.
        /// </summary>
        /// <param name="packageId">Package file to push. Specify multiple packages by specifying this argument multiple times: --package package1 --package package2</param>
        /// <returns></returns>
        public OctopusPushTask Push(string packageId)
        {
            return new OctopusPushTask(packageId);
        }

        /// <summary>
        /// The following command will push the package MyPackage to your Octopus Server and will replace the package if it already exists in the built-in repository.
        /// </summary>
        /// <param name="packageIds">Package file to push. Specify multiple packages by specifying this argument multiple times: --package package1 --package package2</param>
        /// <returns></returns>
        public OctopusPushTask Push(params string[] packageIds)
        {
            return new OctopusPushTask(packageIds);
        }


        /// <summary>
        /// This command allows you to create a release.
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public OctopusCreateReleaseTask CreateRelease(string project)
        {
            return new OctopusCreateReleaseTask(project);
        }
        
        /// <summary>
        /// can be used to deploy releases that have already been created.
        /// </summary>
        /// <returns></returns>
        public OctopusDeployReleaseTask DeployRelease()
        {
            return new OctopusDeployReleaseTask();
        }

        /// <summary>
        /// can be used to promote a release from one environment to another.
        /// </summary>
        /// <param name="project">Name of the project</param>
        /// <param name="deployFrom"> Name of the environment to get the current deployment from, e.g., Staging</param>
        /// <param name="deployTo"> Environment to deploy to, e.g., Production</param>
        /// <returns></returns>
        public OctopusPromoteReleaseTask PromoteRelease(string project, string deployFrom, string deployTo)
        {
            return new OctopusPromoteReleaseTask(project, deployFrom, deployTo);
        }
    }
}
