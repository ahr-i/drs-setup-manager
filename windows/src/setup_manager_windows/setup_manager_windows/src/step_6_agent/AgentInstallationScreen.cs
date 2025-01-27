﻿using setup_manager_windows.src.template_form.type1;
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
    public partial class AgentInstallationScreen : TemplateType1, ITransitionable
    {
        private string agentName = "docker pull ahri0/drs-test:test";
        private string networkCommand = "docker network create --subnet 102.0.1.0/24 drs-test-network";
        private string executeCommand = "docker run -d --rm --name drs-test --network drs-test-network --ip 102.0.1.2 -p 80:80 ahri0/drs-test:test";

        public event EventHandler NextButtonClicked;

        public AgentInstallationScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.LeftBtnText1 = "Github";
            this.RightBtnText2 = "Cancel";
            this.RightBtnText1 = "Next";
            this.HeaderText = "6. Install DRS Agent";
            this.MainText = "Final step!\r\nInstalling the DRS Agent.\r\n\r\nPlease ensure Docker is running.\r\nThe installation will be in the form of a Docker container.\r\n\r\nThank you for following all the steps.";

            this.LeftBtnClick1 += (s, e) => githubBtn_Click();
            this.RightBtnClick2 += (s, e) => cancelBtn_Click();
            this.RightBtnClick1 += (s, e) => nextBtn_Click();
        }


        private void githubBtn_Click()
        {
            ButtonController.GithubBtn();
        }

        private void cancelBtn_Click()
        {
            ButtonController.CancelBtn();
        }

        private void nextBtn_Click()
        {
            this.RightBtnEnabled1 = false;

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
