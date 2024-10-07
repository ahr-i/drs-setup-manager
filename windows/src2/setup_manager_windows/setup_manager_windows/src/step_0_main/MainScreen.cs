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
    public partial class MainScreen : UserControl, ITransitionable
    {
        public event EventHandler NextButtonClicked;

        public MainScreen()
        {
            InitializeComponent();
        }

        // When the Github button is clicked.
        // Redirects to the Github page.
        private void githubBtn_Click(object sender, EventArgs e)
        {
            ButtonController.GithubBtn();
        }

        // When the Cancel button is clicked
        // Exit the program.
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ButtonController.CancelBtn();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
