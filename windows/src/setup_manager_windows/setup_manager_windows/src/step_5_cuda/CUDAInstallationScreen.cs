using setup_manager_windows.src.step_4_nvidia_driver;
using setup_manager_windows.src.template_form.type3;
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

namespace setup_manager_windows.src.step_5_cuda
{
    public partial class CUDAInstallationScreen : TemplateType3, ITransitionable
    {
        private bool isCheck = false;

        public event EventHandler NextButtonClicked;

        public CUDAInstallationScreen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.LeftBtnText1 = "Github";
            this.RightBtnText2 = "Cancel";
            this.RightBtnText1 = "Next";
            this.HeaderText = "5. Install CUDA";
            this.MainText = "Checking for Driver information...";
            this.TextBox = "";
            this.AsideText = "";

            this.LeftBtnClick1 += (s, e) => githubBtn_Click();
            this.RightBtnClick2 += (s, e) => cancelBtn_Click();
            this.RightBtnClick1 += (s, e) => nextBtn_Click();
        }


        private void CheckNvidiaDriver()
        {
            string information = Nvidia.GetNvidiaInformation();

            if (information != string.Empty)
            {
                this.TextBox = information;
                string cudaVersion = Nvidia.GetCUDAVersion();

                MessageBox.Show($"CUDA Version: {cudaVersion}");
                this.AsideText = $"CUDA Version: {cudaVersion}";
            }
            else
            {
                this.HeaderText = "Nvidia Driver is either not installed or not supported.";

                MessageBox.Show("No Driver!");
                Application.Exit();
            }
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
            if (!isCheck)
            {
                CheckNvidiaDriver();

                isCheck = true;
                this.RightBtnText1 = "Next";
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
