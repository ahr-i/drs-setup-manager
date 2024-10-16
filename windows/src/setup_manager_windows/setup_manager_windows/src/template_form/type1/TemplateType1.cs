using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setup_manager_windows.src.template_form.type1
{
    public partial class TemplateType1 : UserControl
    {
        public event EventHandler LeftBtnClick1;
        public event EventHandler RightBtnClick1;
        public event EventHandler RightBtnClick2;

        public string HeaderText
        {
            get => headerText.Text;
            set => headerText.Text = value;
        }

        public string MainText
        {
            get => mainText.Text;
            set => mainText.Text = value;
        }

        public string LeftBtnText1
        {
            get => leftBtn1.Text;
            set => leftBtn1.Text = value;
        }

        public string RightBtnText1
        {
            get => rightBtn1.Text;
            set => rightBtn1.Text = value;
        }
        public bool RightBtnEnabled1
        {
            get => rightBtn2.Enabled;
            set => rightBtn2.Enabled = value;
        }

        public string RightBtnText2
        {
            get => rightBtn2.Text;
            set => rightBtn2.Text = value;
        }

        public bool RightBtnVisiable2
        {
            get => rightBtn2.Visible;
            set => rightBtn2.Visible = value;
        }

        public TemplateType1()
        {
            InitializeComponent();

            leftBtn1.Click += (s, e) => LeftBtnClick1?.Invoke(s, e);
            rightBtn1.Click += (s, e) => RightBtnClick1?.Invoke(s, e);
            rightBtn2.Click += (s, e) => RightBtnClick2?.Invoke(s, e);
        }
    }
}
