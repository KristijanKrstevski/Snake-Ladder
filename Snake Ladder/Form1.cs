namespace Snake_Ladder
{
    public partial class FormWelocome : Form
    {
        FormGame game;
        public FormWelocome()
        {
            InitializeComponent();
            game = new FormGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game.lblPlayer1.Text = tbPlayer1.Text;
            game.lblPlayer2.Text = tbPlayer2.Text;
            game.Show();
            // this.Hide();
        }

        private void FormWelocome_Load(object sender, EventArgs e)
        {

        }
    }
}
