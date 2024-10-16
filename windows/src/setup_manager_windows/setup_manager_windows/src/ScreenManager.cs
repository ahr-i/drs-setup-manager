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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src
{
    internal class ScreenManager
    {
        // The C# version is too low to use a Switch statement.
        // WTF
        public static UserControl GetNextScreen(UserControl currentScreen)
        {
            if (currentScreen is MainScreen)
            {
                return new AgreementScreen();
            }
            else if (currentScreen is AgreementScreen)
            {
                return new WSL2InstallationScreen();
            }
            else if (currentScreen is WSL2InstallationScreen)
            {
                return new DockerInstallationScreen();
            }
            else if (currentScreen is DockerInstallationScreen)
            {
                return new NvidiaDriverInstallationScreen();
            }
            else if (currentScreen is NvidiaDriverInstallationScreen)
            {
                return new CUDAInstallationScreen();
            }
            else if(currentScreen is CUDAInstallationScreen)
            {
                return new AgentInstallationScreen();
            }
            else if(currentScreen is AgentInstallationScreen)
            {
                return new FinallScreen();
            }
            else
            {
                return null;
            }
        }
    }
}
