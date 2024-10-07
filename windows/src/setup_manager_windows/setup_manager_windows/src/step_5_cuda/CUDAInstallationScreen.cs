using setup_manager_windows.src.step_4_nvidia_driver;
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

namespace setup_manager_windows.src.step_5_cuda
{
    public partial class CUDAInstallationScreen : UserControl, ITransitionable
    {
        private bool isCheck = false;

        public event EventHandler NextButtonClicked;

        public CUDAInstallationScreen()
        {
            InitializeComponent();
        }

        private void CheckNvidiaDriver()
        {
            string information = Nvidia.GetNvidiaInformation();

            if (information != string.Empty)
            {
                midTextBox.Text = information;
                string cudaVersion = Nvidia.GetCUDAVersion();

                MessageBox.Show($"CUDA Version: {cudaVersion}");
                bottomText.Text = $"CUDA Version: {cudaVersion}";
            }
            else
            {
                midTextBox.Text = "Nvidia Driver is either not installed or not supported.";

                MessageBox.Show("No Driver!");
                Application.Exit();
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
            if (!isCheck)
            {
                CheckNvidiaDriver();

                isCheck = true;
                nextBtn.Text = "Next";
            }
            else
            {
                // Updating the Nvidia Driver also installs CUDA
                //InstallCUDA();

                NextButtonClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        public void InstallCUDA()
        {
            FileManager.CreateDirectory("install");
            string nvidiaInstallerPath = FileManager.CombinePath("install", "CUDAInstaller.exe");
            string cudaVersion = Nvidia.GetCUDAVersion();

            if (!File.Exists(nvidiaInstallerPath))
            {
                DownloadCUDAInstaller(nvidiaInstallerPath, cudaVersion);
            }

            ExecuteInstaller(nvidiaInstallerPath, cudaVersion);
        }

        private void DownloadCUDAInstaller(string cudaInstallerPath, string cudaVersion)
        {
            //string versionForUrl = cudaVersion.Replace('.', '-') + "-1";
            string version = ConvertToThreePartVersion(cudaVersion);

            string downloadUrl = $"https://developer.download.nvidia.com/compute/cuda/{version}/network_installers/cuda_{version}_windows_network.exe";
            MessageBox.Show("CUDA Download URL: " + downloadUrl);

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(downloadUrl, cudaInstallerPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while downloading the file: {ex.Message}");
                    return;
                }
            }
        }

        public void ExecuteInstaller(string cudaInstallerPath, string cudaVersion)
        {
            try
            {
                Process.Start(cudaInstallerPath).WaitForExit();
                CommandController.RunCommand("cmd.exe", "/C nvcc --version");
                MessageBox.Show("CUDA installation completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during CUDA installation: {ex.Message}");
            }
        }

        public string ConvertToThreePartVersion(string version)
        {
            // Split the version by "."
            string[] versionParts = version.Split('.');

            // If it consists of only two parts, add a third part (.0)
            if (versionParts.Length == 2)
            {
                return $"{versionParts[0]}.{versionParts[1]}.0";
            }

            // If it already has three parts, return it as is
            return version;
        }
    }
}
