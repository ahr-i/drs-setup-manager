using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src
{
    internal class ButtonController
    {
        public static void GithubBtn()
        {
            // Currently, it will temporarily link to my Github address.
            // I can change it later.
            string url = "http://github.com/ahr-i";

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to Open Webpage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This is a button that allows for exit.
        public static void CancelBtn()
        {
            Application.Exit();
        }
    }
}
