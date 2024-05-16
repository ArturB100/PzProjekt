using PzProjekt;
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
    public partial class WeaponsmithView : UserControlBase
    {



        private List<Weapon> weapons;
        


        public WeaponsmithView(ProgramCtx form) : base(form, true)

        {
            InitializeComponent();
            //weapons = ProgramCtx.GameSetup.
        }
        



    }
}
