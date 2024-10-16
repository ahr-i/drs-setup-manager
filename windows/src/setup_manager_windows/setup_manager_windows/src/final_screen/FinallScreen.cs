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

namespace setup_manager_windows.src.final_screen
{
    public partial class FinallScreen : TemplateType1, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public FinallScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.LeftBtnText1 = "Github";
            this.RightBtnText2 = "Cancel";
            this.RightBtnText1 = "Next";
            this.HeaderText = "Thank You Very Much";
            this.MainText = "We appreciate you becoming part of our community.\r\n\r\nThe installation process is now complete.\r\n\r\nDRS relies on user feedback to improve.\r\nIf you encounter any issues, please let us know.";

            this.LeftBtnClick1 += (s, e) => githubBtn_Click();
            this.RightBtnClick1 += (s, e) => nextBtn_Click();

            RightBtnVisiable2 = false;
        }


        private void githubBtn_Click()
        {
            ButtonController.GithubBtn();
        }

        private void nextBtn_Click()
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
