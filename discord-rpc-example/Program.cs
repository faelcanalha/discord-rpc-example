using DiscordRPC;
using System;
using System.Windows.Forms;

namespace discord_rpc_example
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #region Discord RPC
        public static DiscordRpcClient client;
        static void Initialize()
        {
            // Create Application in https://discord.com/developers/applications and copy Application ID
            client = new DiscordRpcClient("936284924179251220");
            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Starting...",
                Assets = new Assets()
                {
                    LargeImageKey = "asdas",
                    LargeImageText = "Example Discord RPC",
                    SmallImageKey = "asdas",
                    SmallImageText = "N/A",
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = "Join the Discord Server", Url = "https://www.google.com/" }
                },
                Timestamps = Timestamps.Now
            });
        }
        #endregion
    }
}
