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
    public partial class AgreementScreen : UserControl, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public AgreementScreen()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
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
