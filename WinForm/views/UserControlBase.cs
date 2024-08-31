using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.views;

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
        
        public UserControlBase(ProgramCtx form, bool showMenu = false)
        {
            InitializeComponent();
            this.programCtx = form;
            this.Size = new System.Drawing.Size(programCtx.Width, programCtx.Height);
            menu.Visible = showMenu;
            messageLabel.Font = new Font(messageLabel.Font.FontFamily, 16);
            this.Resize += new EventHandler(Form1_Resize);
            CenterLabel();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void CenterLabel()
        {
            messageLabel.AutoSize = true;
            messageLabel.PerformLayout();
            Size labelSize = messageLabel.PreferredSize;
            messageLabel.Location = new Point(
                (this.ClientSize.Width - labelSize.Width) / 2,
                (this.ClientSize.Height - labelSize.Height) / 2
            );
        }

        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new HomeView(ProgramCtx));
        }

        public void ShowMessage (string msg)
        {
            messageLabel.Visible = true;
            messageLabel.Text = msg;
            CenterLabel();
            HideMessageLabel();
        }

        public async Task HideMessageLabel ()
        {
            await Task.Delay(3000);
            messageLabel.Visible = false;
        }

        public void WarningMessage(string msg)
        {
            messageLabel.ForeColor = Color.Blue;
            ShowMessage(msg);
        }

        public void SuccessMessage(string msg)
        {
            messageLabel.ForeColor = Color.Green;
            ShowMessage(msg);
        }

        public void ErrorMessage(string msg)
        {
            messageLabel.ForeColor = Color.Red;
            ShowMessage(msg);
        }
    }
}
