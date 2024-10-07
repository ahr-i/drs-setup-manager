using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.step_4_nvidia_driver
{
    internal class Nvidia
    {
        public static string GetNvidiaInformation()
        {
            // This command doesn't run on a 32-bit platform.
            // This damn thing cost me an entire day.
            string result = CommandController.RunCommand("powershell.exe", "-Command \"nvidia-smi\"", true, true, false);

            return result;
        }

        public static string GetCUDAVersion()
        {
            string result = CommandController.RunCommand("powershell.exe", "-Command \"nvidia-smi\"", true, true);

            // Regular expression for extracting CUDA version
            var match = Regex.Match(result, @"CUDA Version:\s*(\d+\.\d+)");
            if (!match.Success)
            {
                MessageBox.Show("CUDA version not found.");
                Application.Exit();
            }

            // Extracts only the version
            return match.Groups[1].Value;
        }
    }
}
