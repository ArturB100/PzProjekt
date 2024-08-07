
using PzProjekt;
using System.Diagnostics;
using System.Media;

namespace WinForm
{
    public partial class ProgramCtx : Form
    {

        public SoundPlayer Music { get; set; }

        public PlayableCharacters PlayableCharacters { get; set; } = new PlayableCharacters();

        public Character SelectedCharacter { get; set; } = null;

        public GameSetup GameSetup { get; set; }

        public Tournament ActiveTournament { get; set; }

        public ProgramCtx()
        {
            InitializeComponent();
            LoadSavedGame();
            GameSetup = new GameSetup();
            Music = new SoundPlayer("sound/The-Elder-Scrolls-IV-Oblivion-Soundtrack-04-Harvest-Dawn.wav");
            Music.Play();
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
                ErrorMessage(ex.Message);
            }

            PlayableCharacters ??= new PlayableCharacters();

        }

        public void SelectCharacter (Character character)
        {            
            SelectedCharacter = character;
        }
       

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //SaveGame();
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

        public void ErrorMessage(Error error)
        {           
            MessageBox.Show(TranslateToString(error), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErrorMessage(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private static string TranslateToString(Error error)
        {
            switch (error)
            {
                case Error.NOT_ENOUGHT_MONEY:
                    return "Za malo pieniedzy";
                case Error.TOO_WEAK_STATISTICS:
                    return "Zbyt slabe statystyki";
                case Error.TOO_WEAK_LEVEL:
                    return "Zbyt niski level";
                default:
                    return "Cos poszlo nie tak";
                    
            }
        }
    }


   

    public enum Error
    {
        NOT_ENOUGHT_MONEY,
        TOO_WEAK_STATISTICS,
        TOO_WEAK_LEVEL,
        OTHER

        
    }
}
