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
        
<<<<<<<< Updated upstream:WinForm/views/Weaponsmith.cs
        public Weaponsmith(Form1 form) : base(form)
========
        public WeaponsmithView(ProgramCtx form) : base(form, true)
>>>>>>>> Stashed changes:WinForm/views/WeaponsmithView.cs
        {
            InitializeComponent();
            //weapons = ProgramCtx.GameSetup.
        }
        



    }
}
