# FlubuCore.Octopus

[![NuGet](https://img.shields.io/nuget/v/FlubuCore.CakePlugin.svg)](https://www.nuget.org/packages/FlubuCore.Octopus/)
[![Gitter](https://img.shields.io/gitter/room/FlubuCore/Lobby.svg)](https://gitter.im/FlubuCore/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![License](https://img.shields.io/github/license/flubu-core/flubuCore.CakePlugin.svg)](https://github.com/flubu-core/FlubuCore.Octopus/blob/master/LICENSE)

FlubuCore.Octopus is a [FlubuCore](https://github.com/flubu-core/flubu.core) plugin adds octopus specific tasks.

Plugin adds npm tasks to FlubuCore ``` ITaskContext ``` interface:  ``` context.Tasks().Npm() ```

Plugin adds Following tasks:
* OctopusPackTask.cs
* OctopusCreateReleaseTask
* OctopusDeployReleaseTask
* OctopusPushTask
* OctopusPromoteReleaseTask.cs
