using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.components
{
    class WoodButton : Button
    {
        public WoodButton()
        {
            // Set default properties
            this.BackColor = Color.SaddleBrown;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Arial", 10f, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Cursor = Cursors.Hand; // Change cursor to hand when hovering over the button
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            // You can further customize the appearance here if needed
        }
    }
}
