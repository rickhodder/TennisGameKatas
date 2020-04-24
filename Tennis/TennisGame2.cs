namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int player1Points;
        private int player2Points;

        private string player1Score = "";
        private string player2Score = "";
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            var gameScore = "";
            if (player1Points == player2Points && player1Points < 3)
            {
                if (player1Points == 0)
                    gameScore = "Love";
                if (player1Points == 1)
                    gameScore = "Fifteen";
                if (player1Points == 2)
                    gameScore = "Thirty";
                gameScore += "-All";
            }
            if (player1Points == player2Points && player1Points > 2)
                gameScore = "Deuce";

            if (player1Points > 0 && player2Points == 0)
            {
                if (player1Points == 1)
                    player1Score = "Fifteen";
                if (player1Points == 2)
                    player1Score = "Thirty";
                if (player1Points == 3)
                    player1Score = "Forty";

                player2Score = "Love";
                gameScore = player1Score + "-" + player2Score;
            }
            if (player2Points > 0 && player1Points == 0)
            {
                if (player2Points == 1)
                    player2Score = "Fifteen";
                if (player2Points == 2)
                    player2Score = "Thirty";
                if (player2Points == 3)
                    player2Score = "Forty";

                player1Score = "Love";
                gameScore = player1Score + "-" + player2Score;
            }

            if (player1Points > player2Points && player1Points < 4)
            {
                if (player1Points == 2)
                    player1Score = "Thirty";
                if (player1Points == 3)
                    player1Score = "Forty";
                if (player2Points == 1)
                    player2Score = "Fifteen";
                if (player2Points == 2)
                    player2Score = "Thirty";
                gameScore = player1Score + "-" + player2Score;
            }
            if (player2Points > player1Points && player2Points < 4)
            {
                if (player2Points == 2)
                    player2Score = "Thirty";
                if (player2Points == 3)
                    player2Score = "Forty";
                if (player1Points == 1)
                    player1Score = "Fifteen";
                if (player1Points == 2)
                    player1Score = "Thirty";
                gameScore = player1Score + "-" + player2Score;
            }

            if (player1Points > player2Points && player2Points >= 3)
            {
                gameScore = "Advantage player1";
            }

            if (player2Points > player1Points && player1Points >= 3)
            {
                gameScore = "Advantage player2";
            }

            if (player1Points >= 4 && player2Points >= 0 && (player1Points - player2Points) >= 2)
            {
                gameScore = "Win for player1";
            }
            if (player2Points >= 4 && player1Points >= 0 && (player2Points - player1Points) >= 2)
            {
                gameScore = "Win for player2";
            }
            return gameScore;
        }

        public void SetP1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                P2Score();
            }
        }

        private void P1Score()
        {
            player1Points++;
        }

        private void P2Score()
        {
            player2Points++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

    }
}

