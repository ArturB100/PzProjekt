using System.Windows.Forms;
using WinForm.views;

namespace WinForm
{
    public partial class FirstPage : UserControlBase
    {
        public FirstPage(Form1 form) : base(form)
        {
            InitializeComponent();
            backgroundImg.SendToBack();
            backgroundImg.BackgroundImageLayout = ImageLayout.Stretch;
            backgroundImg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.ChangeView(new GameSelectView(MainForm));
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
