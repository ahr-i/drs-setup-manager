using setup_manager_windows.src.final_screen;
using setup_manager_windows.src.step_0_main;
using setup_manager_windows.src.step_1_agreement;
using setup_manager_windows.src.step_2_wsl2;
using setup_manager_windows.src.step_3_docker;
using setup_manager_windows.src.step_4_nvidia_driver;
using setup_manager_windows.src.step_5_cuda;
using setup_manager_windows.src.step_6_agent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src
{
    public partial class FrameForm : MetroFramework.Forms.MetroForm
    {
        public FrameForm()
        {
            InitializeComponent();

            // Set the initial screen to MainScreen
            SwitchScreen<MainScreen>();
        }

        // Restrict T to types that inherit from UserControl
        private void SwitchScreen<T>() where T : UserControl, new()
        {
            // Create and configure a new screen instance
            var screen = new T
            {
                Dock = DockStyle.Fill
            };

            // Add the new screen to mainPanel
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(screen);

            // Attach the NextButtonClicked event handler to each screen
            if (screen is ITransitionable transitionableScreen)
            {
                transitionableScreen.NextButtonClicked += (s, e) => HandleNextButtonClick(transitionableScreen);
            }
        }

        // Handle transition to the next screen when the Next button is clicked
        // HELP ME
        private void HandleNextButtonClick(ITransitionable currentScreen)
        {
            if (currentScreen is MainScreen)
            {
                SwitchScreen<AgreementScreen>();
            }
            else if (currentScreen is AgreementScreen)
            {
                SwitchScreen<WSL2InstallationScreen>();
            }
            else if (currentScreen is WSL2InstallationScreen)
            {
                SwitchScreen<DockerInstallationScreen>();
            }
            else if (currentScreen is DockerInstallationScreen)
            {
                SwitchScreen<NvidiaDriverInstallationScreen>();
            }
            else if (currentScreen is NvidiaDriverInstallationScreen)
            {
                SwitchScreen<CUDAInstallationScreen>();
            }
            else if(currentScreen is CUDAInstallationScreen)
            {
                SwitchScreen<AgentInstallationScreen>();
            }
            else if(currentScreen is AgentInstallationScreen)
            {
                SwitchScreen<FinallScreen>();
            }
            else if(currentScreen is FinallScreen)
            {
                Application.Exit();
                return;
            }
        }
    }

    // Interface that swappable screens must implement
    public interface ITransitionable
    {
        event EventHandler NextButtonClicked;
    }
}
