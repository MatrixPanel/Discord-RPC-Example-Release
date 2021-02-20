using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
//Coded and supplied by Matrix
namespace Discord_RPC_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void err()
        {
            MessageBox.Show("Error has occured", "Error");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DiscordRpcClient Matrix = new DiscordRpcClient("Input your Client ID for application here");//Go to https://discord.com/developers/applications and create a application and copy the client id and paste it in here
                Matrix.Initialize();
                Matrix.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

                if (Matrix.IsInitialized == false)
                {
                    err();
                }
                else
                {
                    Matrix.SetPresence(new DiscordRPC.RichPresence()//Setting the Presence
                    {
                        Details = $"Developing",//This displays under your application name 
                        State = $"Matrix Geo Bot",//this goes under Details
                        Timestamps = Timestamps.Now,//Starts counting how long you have been playing the application
                        Assets = new Assets()
                        {
                            LargeImageKey = $"anime",//Picture that shows when playing Set this in the application panel
                            LargeImageText = $"Come Cop Matrix Panel",//Text that shows when you hover over the picture
                        }
                    });
                }
            }
            catch
            {

            }
        }
    }
}
