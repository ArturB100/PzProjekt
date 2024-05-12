
using PzProjekt;

namespace WinForm
{
    public partial class Form1 : Form
    {

        //private List<string> savedGames = new List<string>() { };

        public PlayableCharacters PlayableCharacters { get; set; } = new PlayableCharacters();

        public Character SelectedCharacter { get; set; } = null;



        /*public List<string> SavedGames
        {
            get { return savedGames; }
        }
        */

        public Form1()
        {
            InitializeComponent();
            LoadSavedGame();
            this.ChangeView(new FirstPage(this));
        }

        public void SaveGame ()
        {
            GameSaverService.WriteToFile(this.PlayableCharacters);
        }

        public void LoadSavedGame ()
        {
            try
            {
                PlayableCharacters = GameSaverService.ReadFromFile<PlayableCharacters>();
            } 
            catch (Exception ex) 
            {
                WarningMessage(ex.Message);
            }
            if (PlayableCharacters == null)
            {
                PlayableCharacters = new PlayableCharacters();

            }
        }
       

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveGame();
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
