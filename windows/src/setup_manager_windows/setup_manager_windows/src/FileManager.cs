using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setup_manager_windows.src
{
    
    internal class FileManager
    {
        // Check if the directory exists, and create it if it doesn't.
        public static void CreateDirectory(string directoryName)
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryName);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        // Easily combine paths with Path.Combine.
        // Very useful and highly convenient.
        public static string CombinePath(string directoryName, string fileName)
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryName);
            string path = Path.Combine(directory, fileName);

            return path;
        }
    }
}
