using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickPuli
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnQuitAboutDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAboutVersion_Click(object sender, EventArgs e)
        {

        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            //string version = System.Windows.Forms.Application.ProductVersion;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
            lblAboutVersion.Text = String.Format("Version: {0}", version);
        }

        private void llAboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start("https://battlepuli.com/clickpuli/#desc");
        }

        private void btnShowLicense_Click(object sender, EventArgs e)
        {
            Process.Start("https://battlepuli.com/clickpuli/#lic");
        }

        private void btnShowHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://battlepuli.com/clickpuli/#howto");
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.woof);
            player.Play();
        }
    }
}
