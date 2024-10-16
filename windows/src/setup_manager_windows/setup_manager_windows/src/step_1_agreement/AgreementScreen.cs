using setup_manager_windows.src.template_form.type3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.step_1_agreement
{
    public partial class AgreementScreen : TemplateType3, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public AgreementScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.LeftBtnText1 = "Github";
            this.RightBtnText2 = "Cancel";
            this.RightBtnText1 = "Agree";
            this.HeaderText = "1. License Agreement";
            this.MainText = "Please review the license terms and installation details before installing the DRS Agent.";
            this.TextBox = "- License Agreement\r\nThe DRS Setup Manager will proceed with the following installation steps:\r\n\r\n1. Install WSL2\r\n2. Enable WSL2\r\n3. Install Docker\r\n4. Install Nvidia Driver\r\n5. Install CUDA (if required)\r\n6. Install DRS Agent\r\nItems that are already installed will not be reinstalled.\r\n\r\nCurrently, the DRS Agent only supports Nvidia graphics cards, but support for additional hardware is planned for the future.\r\n\r\nAn internet connection is required to ensure a smooth installation process.\r\nIf you encounter any issues, please report them using the link at the bottom left.\r\n\r\nPlease note that installation time may vary based on your internet speed.";
            this.AsideText = "If you agree with the terms above, please click 'Agree' to proceed.";

            this.LeftBtnClick1 += (s, e) => githubBtn_Click();
            this.RightBtnClick2 += (s, e) => cancelBtn_Click();
            this.RightBtnClick1 += (s, e) => nextBtn_Click();
        }


        private void nextBtn_Click()
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
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
