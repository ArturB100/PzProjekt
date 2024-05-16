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
        private ProgramCtx programCtx;

        public ProgramCtx ProgramCtx
        {
            get { return programCtx; }
            set { programCtx = value; }
        }

        public UserControlBase() { }
        public UserControlBase(ProgramCtx form)
        {
            InitializeComponent();
            this.programCtx = form;
            this.Size = new System.Drawing.Size(programCtx.Width, programCtx.Height);
        }
    }
}
