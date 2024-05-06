using System.Windows.Forms;

namespace WinForm
{
    public partial class FirstPage : UserControlBase
    {
        public FirstPage(Form form) : base(form)
        {
            InitializeComponent();
            backgroundImg.SendToBack();
            backgroundImg.BackgroundImageLayout = ImageLayout.Stretch;
            backgroundImg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
