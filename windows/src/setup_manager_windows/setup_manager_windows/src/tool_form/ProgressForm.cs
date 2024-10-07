using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.tool_form
{
    public partial class ProgressForm : MetroFramework.Forms.MetroForm
    {
        public ProgressForm()
        {
            InitializeComponent();

            Controls.Add(progressBar);
            Controls.Add(progress);
        }
    }
}
