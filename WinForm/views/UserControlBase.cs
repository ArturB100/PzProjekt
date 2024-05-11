using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class UserControlBase : UserControl
    {
        private Form1 mainForm;

        public Form1 MainForm
        {
            get { return mainForm; }
            set { mainForm = value; }
        }
        public UserControlBase() { }
        public UserControlBase(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;
            this.Size = new System.Drawing.Size(mainForm.Width, mainForm.Height);
        }
    }
}
