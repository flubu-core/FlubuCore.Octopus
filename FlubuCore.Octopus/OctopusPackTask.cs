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

        public OctopusPackTask Format(PackFormat format)
        {
            WithArguments($"--format={format.ToString()}");
            return this;
        }

        public OctopusPackTask Version(string version)
        {
            WithArguments($"--version={version}");
            return this;
        }

        public OctopusPackTask OutFolder(string folder)
        {
            WithArguments($"--outFolder={folder}");
            return this;
        }

        public OctopusPackTask BasePath(string basePath)
        {
            WithArguments($"--basePath={basePath}");
            return this;
        }

        public OctopusPackTask PackageAuthor(string author)
        {
            WithArguments($"--author={author}");
            return this;
        }

        public OctopusPackTask PackageTitle(string title)
        {
            WithArguments($"--title={title}");
            return this;
        }

        public OctopusPackTask PackageDescription(string description)
        {
            WithArguments($"--description={description}");
            return this;
        }

        public OctopusPackTask PackageReleaseNotes(string releaseNotes)
        {
            WithArguments($"--releaseNotes={releaseNotes}");
            return this;
        }

        public OctopusPackTask PackageReleaseNotesFile(string file)
        {
            WithArguments($"--releaseNotesFile={file}");
            return this;
        }

        public OctopusPackTask Include(string include)
        {
            WithArguments($"--include={include}");
            return this;
        }

        public OctopusPackTask Overwrite()
        {
            WithArguments("--overwrite");
            return this;
        }

    }
}
