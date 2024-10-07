using setup_manager_windows.src.tool_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.step_4_nvidia_driver
{
    public partial class NvidiaDriverInstallationScreen : UserControl, ITransitionable
    {
        private string nvidiaInstallerURL = "https://kr.download.nvidia.com/GFE/GFEClient/3.28.0.417/GeForce_Experience_v3.28.0.417.exe";
        private bool nextEnabled = false;
        private ProgressForm progressForm;

        public event EventHandler NextButtonClicked;

        public NvidiaDriverInstallationScreen()
        {
            InitializeComponent();

            nextBtn.Enabled = false;

            CheckNvidiaDriver();
        }

        private void CheckNvidiaDriver()
        {
            string information = Nvidia.GetNvidiaInformation();

            if(information != string.Empty)
            {
                midTextBox.Text = information;

                bottomText.Text = "Great! Nvidia Driver is already installed.";
                nextBtn.Text = "Next";

                nextBtn.Enabled = true;
                nextEnabled = true;
            }
            else
            {
                midTextBox.Text = "Nvidia Driver is either not installed or not supported.";

                bottomText.Text = "Oh no! Installing Nvidia Driver now.";
                nextBtn.Text = "Install";

                nextBtn.Enabled = true;
            }
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            ButtonController.GithubBtn();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ButtonController.CancelBtn();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (nextEnabled)
            {
                NextButtonClicked?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                InstallNvidiaDriver();

                nextBtn.Text = "Next";
                nextEnabled = true;
            }
        }

        private void InstallNvidiaDriver()
        {
            FileManager.CreateDirectory("install");
            string nvidiaInstallerPath = FileManager.CombinePath("install", "NvidiaDriverInstaller.exe");

            if (!File.Exists(nvidiaInstallerPath))
            {
                DownloadNvidiaInstaller(nvidiaInstallerPath);
            }

            ExecuteInstaller(nvidiaInstallerPath);
        }

        private void DownloadNvidiaInstaller(string nvidiaInstallerPath)
        {
            progressForm = new ProgressForm();
            progressForm.Show();

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadProgressChanged += DownloadProgressCallback;
                    webClient.DownloadFileCompleted += DownloadFileCompletedCallback;

                    webClient.DownloadFileAsync(new Uri(nvidiaInstallerURL), nvidiaInstallerPath);

                    while (webClient.IsBusy)
                    {
                        Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while downloading the driver: {ex.Message}");
                }
            }
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            if (progressForm != null)
            {
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

        private void ExecuteInstaller(string nvidiaInstallerPath)
        {
            try
            {
                Process.Start(nvidiaInstallerPath).WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during NVIDIA driver installation: {ex.Message}");
            }
        }
    }
}
