namespace Snake_Ladder
{
    public partial class FormWelocome : Form {
        public FormWelocome() {
            InitializeComponent();
        }
        private void FormWelocome_Load(object sender, EventArgs e) {

        }

        private void tbPlayer1_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (tbPlayer1.Text.Trim().Length == 0) {
                errorProvider1.SetError(tbPlayer1, "Внеси име!");
                e.Cancel = true;
            } else {
                errorProvider1.SetError(tbPlayer1, null);
                e.Cancel = false;
            }
        }

        private void tbPlayer2_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (tbPlayer2.Text.Trim().Length == 0) {
                errorProvider1.SetError(tbPlayer2, "Внеси име!");
                e.Cancel = true;
            } else {
                errorProvider1.SetError(tbPlayer2, null);
                e.Cancel = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            FormGame game = new FormGame();
            if (tbPlayer1.Text.Trim().Length != 0 && tbPlayer2.Text.Trim().Length != 0) {
                game.lblPlayer1.Text = tbPlayer1.Text;
                game.lblPlayer2.Text = tbPlayer2.Text;
                game.ShowDialog();
            }
            // this.Hide();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e) {
            Form3 howToPlay = new Form3();
            howToPlay.ShowDialog();
        }
    }
}
