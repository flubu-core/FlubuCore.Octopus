using System;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Octopus
{
    public class OctopusPackTask : ExternalProcessTaskBase<OctopusPackTask>
    {
        protected override string Description { get; set; }


        public OctopusPackTask(string packageId)
        {
            ExecutablePath = "Octo";
            WithArguments("pack");
            WithArguments($"--id={packageId}");
        }

        /// <summary>
        ///  Package format. Options are: NuPkg, Zip.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public OctopusPackTask Format(PackFormat format)
        {
            WithArguments($"--format={format.ToString()}");
            return this;
        }

        /// <summary>
        ///  The version of the package; must be a valid SemVer; defaults to a timestamp-based version
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public OctopusPackTask Version(string version)
        {
            WithArguments($"--version={version}");
            return this;
        }

        /// <summary>
        /// The folder into which the generated NUPKG file will be written; defaults to '.'
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public OctopusPackTask OutFolder(string folder)
        {
            WithArguments($"--outFolder={folder}");
            return this;
        }

        /// <summary>
        /// The root folder containing files and folders to pack; defaults to '.'
        /// </summary>
        /// <param name="basePath"></param>
        /// <returns></returns>
        public OctopusPackTask BasePath(string basePath)
        {
            WithArguments($"--basePath={basePath}");
            return this;
        }

        /// <summary>
        ///  [Optional, Multiple] Add an author to the package metadata; defaults to the current user
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public OctopusPackTask PackageAuthor(string author)
        {
            WithArguments($"--author={author}");
            return this;
        }

        /// <summary>
        /// The title of the package
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public OctopusPackTask PackageTitle(string title)
        {
            WithArguments($"--title={title}");
            return this;
        }

        /// <summary>
        /// A description of the package; defaults to a generic description
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public OctopusPackTask PackageDescription(string description)
        {
            WithArguments($"--description={description}");
            return this;
        }

        /// <summary>
        /// Release notes for this version of the package
        /// </summary>
        /// <param name="releaseNotes"></param>
        /// <returns></returns>
        public OctopusPackTask PackageReleaseNotes(string releaseNotes)
        {
            WithArguments($"--releaseNotes={releaseNotes}");
            return this;
        }

        /// <summary>
        /// A file containing release notes for this version of the package
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public OctopusPackTask PackageReleaseNotesFile(string file)
        {
            WithArguments($"--releaseNotesFile={file}");
            return this;
        }

        /// <summary>
        /// [Optional, Multiple] Add a file pattern to include, relative to the base path e.g. /bin/-
        ///  *.dll - if none are specified, defaults to **
        /// </summary>
        /// <param name="include"></param>
        /// <returns></returns>
        public OctopusPackTask Include(string include)
        {
            WithArguments($"--include={include}");
            return this;
        }

        /// <summary>
        /// Allow an existing package file of the same ID/version to be overwritten
        /// </summary>
        /// <returns></returns>
        public OctopusPackTask Overwrite()
        {
            WithArguments("--overwrite");
            return this;
        }

    }
}
