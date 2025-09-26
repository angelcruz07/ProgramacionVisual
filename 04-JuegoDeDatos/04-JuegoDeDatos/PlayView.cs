using static System.Formats.Asn1.AsnWriter;

namespace _04_JuegoDeDatos
{
    public partial class PlayView : Form
    {
        Player player1 = new Player();
        Player player2 = new Player();
        Game game = new Game();

        // Estado inicial de juego
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
            Face1.Visible = true;
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
            int diceRoll = game.ThrowDiceRandon(1, 7);
            ShowDiceFace(diceRoll);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            int currentRoll = GetVisibleDiceValue();

            if (currentPlayer == 1)
            {
                player1.AddPoints(currentRoll);
                throwsPlayer1++;

                UpdatePlayerUI(Score1, currentRoll, labelScore1, throwsPlayer1, player1.Score.ToString());

                if (throwsPlayer1 < maxThrows)
                {
                    currentPlayer = 2; // Pasa el turno al jugador 2
                    lblTurno.Text = $"Turno del jugador {currentPlayer}";
                }
            }
            else // currentPlayer == 2
            {
                player2.AddPoints(currentRoll);
                throwsPlayer2++;

                UpdatePlayerUI(Score2, currentRoll, labelScore2, throwsPlayer2, player2.Score.ToString());

                if (throwsPlayer2 < maxThrows)
                {
                    currentPlayer = 1;
                    lblTurno.Text = $"Turno del jugador {currentPlayer}";
                }
            }


            if (throwsPlayer1 == maxThrows && throwsPlayer2 == maxThrows)
            {
                EndGame(player1.Score, player2.Score);
                
            }

            currentPlayer = (currentPlayer == 1 && throwsPlayer1 == maxThrows) ? 2 : 1;

        }

        // Helper method to update the UI




        private static void UpdatePlayerUI(ListBox scoreListView, int currentRoll, Label totalScoreLabelName, int throwsCount, string score)
        {
            scoreListView.Items.Add($"Lanzamiento {throwsCount}: {currentRoll}");
            totalScoreLabelName.Text = $"Puntuación total: {score}";     
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

            // Limpiar la puntuacion
            Score1.Items.Clear();
            Score2.Items.Clear();

            player1.ResetScore();
            player2.ResetScore();

            labelScore1.Text = "Puntuacion: 0";
            labelScore2.Text = "Puntuacion: 0";

            // Resetear los lanzamientos
            throwsPlayer1 = 0;
            throwsPlayer2 = 0;
            currentPlayer = 1;

            lblTurno.Text = $"Turno del jugador {currentPlayer}";
        }
    }
}