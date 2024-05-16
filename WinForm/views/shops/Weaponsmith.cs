using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.views
{
    public partial class Weaponsmith : UserControlBase
    {


        public Weaponsmith()
        {
            InitializeComponent();
        }

        
        public Weaponsmith(ProgramCtx form) : base(form)
        {
            InitializeComponent();
        }
        


    }
}
