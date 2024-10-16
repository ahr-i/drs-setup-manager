using setup_manager_windows.src.template_form.type1;
using setup_manager_windows.src.tool_form;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.step_3_docker
{
    public partial class DockerInstallationScreen : TemplateType1, ITransitionable
    {
        private string dockerInstallerURL = "https://desktop.docker.com/win/stable/Docker%20Desktop%20Installer.exe";
        private ProgressForm progressForm;

        public event EventHandler NextButtonClicked;

        public DockerInstallationScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.LeftBtnText1 = "Github";
            this.RightBtnText2 = "Cancel";
            this.RightBtnText1 = "Next";
            this.HeaderText = "3. Install Docker";
            this.MainText = "Docker will be installed.\r\nClick 'Install' to begin the installation.\r\n\r\nThe installation will proceed using the official Docker installer.\r\nYou can either install a new version or upgrade through the Docker installer.\r\n\r\nIf you already have the latest version, you may skip this step.";

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

            Install();

            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Install()
        {
            FileManager.CreateDirectory("install");
            string dockerInstallerPath = FileManager.CombinePath("install", "DockerInstaller.exe");

            if (!File.Exists(dockerInstallerPath))
            {
                DownloadDockerInstaller(dockerInstallerPath);
            }

            ExecuteInstaller(dockerInstallerPath);
        }

        private void DownloadDockerInstaller(string dockerInstallerPath)
        {
            progressForm = new ProgressForm();
            progressForm.Show();

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    // Register event handlers
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompletedCallback);

                    // Start asynchronous download
                    webClient.DownloadFileAsync(new Uri(dockerInstallerURL), dockerInstallerPath);

                    // Await download completion
                    while (webClient.IsBusy)
                    {
                        // Handle UI events
                        Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while downloading the file: {ex.Message}");
                    return;
                }
            }
        }

        private void ExecuteInstaller(string dockerInstallerPath)
        {
            // Execute installation file
            try
            {
                Process.Start(dockerInstallerPath).WaitForExit();
                CommandController.RunCommand("cmd.exe", "/C docker version", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during Docker installation: {ex.Message}");
            }
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            if (progressForm != null)
            {
                // Update progress on the UI thread
                // OMG OMG OMG OMG OMG OMG
                progressForm.Invoke((MethodInvoker)(() =>
                {
                    progressForm.progressBar.Value = e.ProgressPercentage;
                    progressForm.progress.Text = $"{e.ProgressPercentage}%";
                }));
            }
        }

        private void DownloadFileCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (progressForm != null)
            {
                // Close ProgressForm after download completion
                progressForm.Invoke((MethodInvoker)(() =>
                {
                    progressForm.Close();
                    progressForm = null;
                }));
            }

            if (e.Error != null)
            {
                MessageBox.Show($"An error occurred while downloading the file: {e.Error.Message}");
            }
        }
    }
}
