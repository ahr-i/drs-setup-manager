using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.step_2_wsl2
{

    public partial class WSL2InstallationScreen : UserControl, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public WSL2InstallationScreen()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            nextBtn.Enabled = false;

            InstallWSL2();

            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void InstallWSL2()
        {
            CommandController.RunCommand("cmd.exe", "/C dism /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart", true);
            CommandController.RunCommand("cmd.exe", "/C dism /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart", true);
            CommandController.RunCommand("cmd.exe", "/C wsl --set-default-version 2", true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ButtonController.CancelBtn();
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            ButtonController.GithubBtn();
        }
    }
}
