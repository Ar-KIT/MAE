namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private TicTacToe game;

        public Form1()
        {
            InitializeComponent();
            game = new TicTacToe(this);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());
            game.MakeMove(index, button);
        }

        public void UpdateScore(string winner)
        {
            if (winner == "X")
                px_score.Text = (int.Parse(px_score.Text) + 1).ToString();
            else
                po_score.Text = (int.Parse(po_score.Text) + 1).ToString();
        }

        public void UpdateStatus(string status)
        {
            lbl3.Text = status;
        }

        public void ResetBoard()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Tag != null)
                {
                    control.Text = "";
                    control.Enabled = true;
                }
            }

            lbl3.Text = "";
        }
        public void DisableAllButtons()
        {
            foreach (Control control in Controls)
            {
                if (control.Enabled && control.Tag != null){
                    control.Enabled = false;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            game.Reset();
        }

        private void NG_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public abstract class Game
        {
            protected string[] Board;
            protected bool isPlayerX;

            public Game()
            {
                Board = new string[9];
                isPlayerX = true;
            }

            protected abstract string CheckWinner();

            public abstract void Reset();
        }

        public class TicTacToe : Game
        {
            private Form1 form;

            public TicTacToe(Form1 form)
            {
                this.form = form;
            }

            protected override string CheckWinner()
            {
                string winner = null;

                if (Board[0] == Board[1] && Board[1] == Board[2] && Board[0] != null)
                    winner = Board[0];
                else if (Board[0] == Board[3] && Board[3] == Board[6] && Board[0] != null)
                    winner = Board[0];
                else if (Board[0] == Board[4] && Board[4] == Board[8] && Board[0] != null)
                    winner = Board[0];
                else if (Board[3] == Board[4] && Board[4] == Board[5] && Board[3] != null)
                    winner = Board[3];
                else if (Board[6] == Board[7] && Board[7] == Board[8] && Board[6] != null)
                    winner = Board[6];
                else if (Board[1] == Board[4] && Board[4] == Board[7] && Board[1] != null)
                    winner = Board[1];
                else if (Board[2] == Board[5] && Board[5] == Board[8] && Board[2] != null)
                    winner = Board[2];
                else if (Board[2] == Board[4] && Board[4] == Board[6] && Board[2] != null)
                    winner = Board[2];

                if (winner != null)
                {
                    form.UpdateScore(winner);
                    form.DisableAllButtons();
                    return $"Player {winner} Wins!";
                }

                return "";
            }

            public override void Reset()
            {
                for (int i = 0; i < Board.Length; i++)
                    Board[i] = null;

                isPlayerX = true;
                form.ResetBoard();
            }

            public void MakeMove(int index, Button button)
            {
                if (isPlayerX)
                {
                    button.Text = "X";
                    Board[index] = "X";
                }
                else
                {
                    button.Text = "O";
                    Board[index] = "O";
                }

                button.Enabled = false;
                isPlayerX = !isPlayerX;

                string result = CheckWinner();
                if (result != "")
                    form.UpdateStatus(result);
            }
        }
    }
}