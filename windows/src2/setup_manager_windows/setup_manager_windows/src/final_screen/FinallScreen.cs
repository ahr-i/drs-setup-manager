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
    public partial class FinallScreen : UserControl, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public FinallScreen()
        {
            InitializeComponent();
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            ButtonController.GithubBtn();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
