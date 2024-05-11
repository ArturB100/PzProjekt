
using PzProjekt;

namespace WinForm
{
    public partial class Form1 : Form
    {

        private List<string> savedGames = new List<string>() { };

        public PlayableCharacters PlayableCharacters { get; set; }

        public Character SelectedCharacter { get; set; }



        public List<string> SavedGames
        {
            get { return savedGames; }
        }

        public Form1()
        {
            InitializeComponent();
            this.ChangeView(new FirstPage(this));
        }

       

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        public void ChangeView (UserControl userControlToDisplay)
        {
            this.Controls.Clear();
            this.Controls.Add(userControlToDisplay);
        }

        public void WarningMessage (string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void SuccessMessage(string msg)
        {
            MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
