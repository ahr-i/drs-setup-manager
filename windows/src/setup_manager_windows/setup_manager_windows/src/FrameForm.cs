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
            SwitchScreen(new MainScreen());
        }

        // Restrict T to types that inherit from UserControl
        private void SwitchScreen(UserControl screen)
        {
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(screen);

            if (screen is ITransitionable transitionableScreen)
            {
                transitionableScreen.NextButtonClicked += (s, e) => HandleNextButtonClick(transitionableScreen);
            }
        }

        // Handle transition to the next screen when the Next button is clicked
        // HELP ME
        private void HandleNextButtonClick(ITransitionable currentScreen)
        {
            var nextScreen = ScreenManager.GetNextScreen((UserControl)currentScreen);

            if (nextScreen != null)
            {
                SwitchScreen(nextScreen);
            }
            else
            {
                Application.Exit();
            }
        }
    }

    // Interface that swappable screens must implement
    public interface ITransitionable
    {
        event EventHandler NextButtonClicked;
    }
}
