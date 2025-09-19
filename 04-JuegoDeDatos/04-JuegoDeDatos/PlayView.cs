using static System.Formats.Asn1.AsnWriter;

namespace _04_JuegoDeDatos
{
    public partial class PlayView : Form
    {
        Character player1 = new Character();
        Character player2 = new Character();
        Play play = new Play();

        int scorePlayer1 = 0;
        int scorePlayer2 = 0;
        int currentPlayer = 1;

        int throwsPlayer1 = 0;
        int throwsPlayer2 = 0;
        const int maxThrows = 3;

        public PlayView()
        {
            InitializeComponent();
        }

        private void PlayView_Load(object sender, EventArgs e)
        {
            Face1.Visible = false;
            Face2.Visible = false;
            Face3.Visible = false;
            Face4.Visible = false;
            Face5.Visible = false;
            Face6.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int diceRoll = play.ThrowDiceRandon(1, 7);
            ShowDiceFace(diceRoll);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            int currentRoll = GetVisibleDiceValue();

            if (currentPlayer == 1)
            {
                scorePlayer1 = player1.Score(scorePlayer1, currentRoll);
                throwsPlayer1++;
                UpdatePlayerUI(ScorePlayer1, currentRoll, "lblScorePlayer1", throwsPlayer1);

                if (throwsPlayer1 < maxThrows)
                {
                    currentPlayer = 2; // Pasa el turno al jugador 2
                }

            }
            else // currentPlayer == 2
            {
                scorePlayer2 = player2.Score(scorePlayer2, currentRoll);
                throwsPlayer2++;
                UpdatePlayerUI(ScorePlayer2, currentRoll, "lblScorePlayer2", throwsPlayer2);

                if (throwsPlayer2 < maxThrows)
                {
                    currentPlayer = 1;
                }
            }


            if (throwsPlayer1 == maxThrows && throwsPlayer2 == maxThrows)
            {
                EndGame(scorePlayer1, scorePlayer2);

            }
            else
            {
                if (currentPlayer == 1 && throwsPlayer1 == maxThrows)
                {
                    // Pasa el turno al jugador 2 si el jugador 1 ya terminó
                    currentPlayer = 2;
                }
                else if (currentPlayer == 2 && throwsPlayer2 == maxThrows)
                {
                    // Pasa el turno al jugador 1 si el jugador 2 ya terminó
                    currentPlayer = 1;
                }

                // Muestra de quién es el turno
                lblTurno.Text = $"Turno del jugador {currentPlayer}";
            }

        }

        // Helper method to update the UI
        private void UpdatePlayerUI(ListView scoreListView, int currentRoll, string totalScoreLabelName, int throwsCount)
        {
            // Add the current roll value to the ListView
            scoreListView.Items.Add(new ListViewItem($"Lanzamiento {throwsCount}: {currentRoll}"));
        }

        private void ShowDiceFace(int diceValue)
        {
            Face1.Visible = (diceValue == 1);
            Face2.Visible = (diceValue == 2);
            Face3.Visible = (diceValue == 3);
            Face4.Visible = (diceValue == 4);
            Face5.Visible = (diceValue == 5);
            Face6.Visible = (diceValue == 6);
        }

        private int GetVisibleDiceValue()
        {
            if (Face1.Visible) return 1;
            if (Face2.Visible) return 2;
            if (Face3.Visible) return 3;
            if (Face4.Visible) return 4;
            if (Face5.Visible) return 5;
            if (Face6.Visible) return 6;
            return 0;
        }

        private void EndGame(int scorePlayer1, int scorePlayer2)
        {
            string winnerMessage = "";

            if (scorePlayer1 > scorePlayer2)
            {
                winnerMessage = "¡El Jugador 1 es el ganador! con: " + scorePlayer1 + " puntos";
            }
            else if (scorePlayer2 > scorePlayer1)
            {
                winnerMessage = "¡El Jugador 2 es el ganador! con: " + scorePlayer2 + " puntos";
            }
            else
            {
                winnerMessage = "¡Es un empate!";
            }

            MessageBox.Show(winnerMessage, "Fin del Juego");

            // Limpiar la interfaz
            ScorePlayer2.Clear();
            ScorePlayer1.Clear();
            scorePlayer2 = 0;
            scorePlayer1 = 0;
            throwsPlayer1 = 0;
            throwsPlayer2 = 0;
        }
    }
}