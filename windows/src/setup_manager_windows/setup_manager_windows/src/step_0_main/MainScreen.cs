using setup_manager_windows.src.template_form.type2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.step_0_main
{
    public partial class MainScreen : TemplateType2, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public MainScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.LeftBtnText1 = "Github";
            this.RightBtnText1 = "Next";
            this.RightBtnText2 = "Cancel";
            this.HeaderText = "Distributed Resource Sharing System";
            this.TextBox = "Everything is set up and ready to go!\r\nYou can easily provide resources to DRS with just a few simple steps.\r\nTo continue, click the 'Next' button at the bottom right.\r\n\r\nFor more details, check out our 'GitHub' link at the bottom left.\r\n\r\n* Note: This program is currently in the testing phase.\r\n";

            this.LeftBtnClick1 += (s, e) => githubBtn_Click();
            this.RightBtnClick1 += (s, e) => nextBtn_Click();
            this.RightBtnClick2 += (s, e) => cancelBtn_Click();
        }

        // When the Github button is clicked.
        // Redirects to the Github page.
        private void githubBtn_Click()
        {
            ButtonController.GithubBtn();
        }

        // When the Cancel button is clicked
        // Exit the program.
        private void cancelBtn_Click()
        {
            ButtonController.CancelBtn();
        }

        private void nextBtn_Click()
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
