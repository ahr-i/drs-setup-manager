using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.step_6_agent
{
    public partial class AgentInstallationScreen : UserControl, ITransitionable
    {
        private string agentName = "docker pull ahri0/drs-test:test";
        private string networkCommand = "docker network create --subnet 102.0.1.0/24 drs-test-network";
        private string executeCommand = "docker run -d --rm --name drs-test --network drs-test-network --ip 102.0.1.2 -p 80:80 ahri0/drs-test:test";

        public event EventHandler NextButtonClicked;

        public AgentInstallationScreen()
        {
            InitializeComponent();
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            ButtonController.GithubBtn();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ButtonController.CancelBtn();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            nextBtn.Enabled = false;

            InstallAgent();

            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void InstallAgent()
        {
            CommandController.RunCommand("powershell.exe", $"-Command \"{agentName}\"", true);
            CommandController.RunCommand("powershell.exe", $"-Command \"{networkCommand}\"", true, false, true);
            CommandController.RunCommand("powershell.exe", $"-Command \"{executeCommand}\"", true);
        }
    }
}
