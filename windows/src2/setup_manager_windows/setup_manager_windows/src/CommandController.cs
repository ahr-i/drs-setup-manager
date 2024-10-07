using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src
{
    internal class CommandController
    {
        public static string RunCommand(string command, string args, bool isAdmin = false, bool redirect = false, bool exitOption = true)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        // If some annoying error occurs, this is likely the issue.
                        // What the hell is the problem?
                        // Finally resolved it. The issue was with redirection.
                        FileName = command,
                        Arguments = args,
                        CreateNoWindow = true,
                        UseShellExecute = !redirect,        // Even with admin rights, set UseShellExecute to false for standard output redirection to work
                        RedirectStandardOutput = redirect,  // Redirect standard output
                        RedirectStandardError = redirect,   // Also redirect standard error (to log any issues)
                        Verb = isAdmin ? "runas" : null     // Configure if admin rights are needed for execution
                    }
                };

                process.Start();

                if (!redirect)
                {
                    process.WaitForExit();
                    return string.Empty;
                }

                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();   // Check error output as well
                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Error Occurred During Command Execution: {error}");
                    if (exitOption)
                    {
                        Application.Exit();
                    }

                    return string.Empty;
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing the command: {ex.Message}");
                Application.Exit();
                return string.Empty;
            }
        }
    }
}
