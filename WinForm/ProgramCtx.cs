
using PzProjekt;

namespace WinForm
{
    public partial class ProgramCtx : Form
    {

    

        public PlayableCharacters PlayableCharacters { get; set; } = new PlayableCharacters();

        public Character SelectedCharacter { get; set; } = null;

        public GameSetup GameSetup { get; set; }

       

        public ProgramCtx()
        {
            InitializeComponent();
            LoadSavedGame();
            GameSetup = new GameSetup();

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

        public void SelectCharacter (Character character)
        {            
            SelectedCharacter = character;
            SelectedCharacter.InitializeAllObjects();
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
