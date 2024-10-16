using setup_manager_windows.src.template_form.type1;
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
    public partial class WSL2InstallationScreen : TemplateType1, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public WSL2InstallationScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.LeftBtnText1 = "Github";
            this.RightBtnText1 = "Install";
            this.RightBtnText2 = "Cancel";
            this.HeaderText = "2. Install WSL2";
            this.MainText = "WSL2 will be installed.\r\nClick 'Install' to begin the installation.\r\n\r\nWSL2 is required to run DRS using Docker.\r\n";


            this.LeftBtnClick1 += (s, e) => githubBtn_Click();
            this.RightBtnClick2 += (s, e) => cancelBtn_Click();
            this.RightBtnClick1 += (s, e) => nextBtn_Click();
        }

        private void nextBtn_Click()
        {
            this.RightBtnEnabled1 = false;

            InstallWSL2();

            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void InstallWSL2()
        {
            CommandController.RunCommand("cmd.exe", "/C dism /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart", true);
            CommandController.RunCommand("cmd.exe", "/C dism /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart", true);
            CommandController.RunCommand("cmd.exe", "/C wsl --set-default-version 2", true);
        }

        private void cancelBtn_Click()
        {
            ButtonController.CancelBtn();
        }

        private void githubBtn_Click()
        {
            ButtonController.GithubBtn();
        }
    }
}
