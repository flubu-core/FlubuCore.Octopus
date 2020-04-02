using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Octopus
{
    public abstract class OctopusBaseTask<TTask> : ExternalProcessTaskBase<int, TTask> where TTask : class, ITask
    {
        /// <summary>
        /// The base URL for your Octopus Server - e.g., http://your-octopus/
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
        public TTask Server(string server)
        {
            WithArgumentsValueRequired("--server", server);
            return this as TTask;
        }

        /// <summary>
        /// Your API key. Get this from the user profile page. Your must provide an apiKey or username and password.
        /// If the guest account is enabled, a key of API-GUEST can be used.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public TTask ApiKey(string apiKey)
        {
            WithArgumentsValueRequired("--apiKey", apiKey);
            return this as TTask;
        }

        /// <summary>
        ///  Username to use when authenticating with the server. Your must provide an apiKey or username and password.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public TTask User(string user)
        {
            WithArgumentsValueRequired("--user", user);
            return this as TTask;
        }

        /// <summary>
        /// Password to use when authenticating with the server.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public TTask Pass(string password)
        {
            WithArgumentsValueRequired("--pass", password);
            return this as TTask;
        }

        /// <summary>
        /// Text file of default values, with one 'key = value' per line.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public TTask ConfigFile(string file)
        {
            WithArgumentsValueRequired("--configFile", file);
            return this as TTask;
        }

        /// <summary>
        /// Enable debug logging
        /// </summary>
        /// <returns></returns>
        public TTask Debug()
        {
            WithArguments("--debug");
            return this as TTask;
        }

        /// <summary>
        /// Set this flag if your Octopus Server uses HTTPS but the certificate is not trusted onthis machine.
        /// Any certificate errors will be ignored. WARNING: this option may create a security vulnerability.
        /// </summary>
        /// <returns></returns>
        public TTask IgnoreSslErrors()
        {
            WithArguments("--ignoreSslErrors");
            return this as TTask;
        }

        /// <summary>
        /// Enable TeamCity or Team Foundation Build service messages when logging.
        /// </summary>
        /// <returns></returns>
        public TTask EnableServiceMessages()
        {
            WithArguments("--enableServiceMessages");
            return this as TTask;
        }

        /// <summary>
        /// Timeout in seconds for network operations. Default is 600.
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public TTask Timeout(int timeout)
        {
            WithArguments("--timeout", timeout.ToString());
            return this as TTask;
        }

        /// <summary>
        /// The URI of the proxy to use, eg http://example.com:8080.
        /// </summary>
        /// <param name="proxy"></param>
        /// <returns></returns>
        public TTask Proxy(string proxy)
        {
            WithArguments("--proxy", proxy);
            return this as TTask;
        }

        /// <summary>
        /// The username for the proxy.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public TTask ProxyUser(string user)
        {
            WithArgumentsValueRequired("--proxyUser", user);
            return this as TTask;
        }

        /// <summary>
        /// The password for the proxy.
        /// If both the username and password are omitted and proxyAddress is specified, the default credentials are used.
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public TTask ProxyPass(string pass)
        {
            WithArgumentsValueRequired("--proxyPass", pass);
            return this as TTask;
        }

        /// <summary>
        /// The log level.
        /// </summary>
        /// <param name="logLevel"></param>
        /// <returns></returns>
        public TTask LogLevel(LogLevel logLevel)
        {
            WithArguments("--logLevel", logLevel.ToString().ToLowerInvariant());
            return this as TTask;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            if (string.IsNullOrEmpty(ExecutablePath))
            {
                ExecutablePath = "Octo";
            }

            return base.DoExecute(context);
        }
    }
}
