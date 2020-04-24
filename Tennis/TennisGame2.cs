namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int player1Points;
        private int player2Points;

        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string ConvertPointsToScore(int points)
        {
            if (points == 0)
                return "Love";
            if (points == 1)
                return "Fifteen";
            if (points == 2)
                return "Thirty";
            return "Forty";
        }

        public string GetScore()
        {
            var gameScore = "";

            if (player1Points == player2Points)
            {
                gameScore = player1Points < 3 ?
                        ConvertPointsToScore(player1Points) + "-All" :
                        "Deuce";
            }

            if (player1Points > player2Points && player2Points >= 3)
            {
                gameScore = "Advantage player1";
            }

            if (player2Points > player1Points && player1Points >= 3)
            {
                gameScore = "Advantage player2";
            }

            if (player1Points > 0 && player2Points == 0)
            {
                gameScore = ConvertPointsToScore(player1Points) + "-Love";
            }

            if (player2Points > 0 && player1Points == 0)
            {
                gameScore = "Love-" + ConvertPointsToScore(player2Points);
            }

            if (player1Points > player2Points && player1Points < 4)
            {
                gameScore = ConvertPointsToScore(player1Points) + "-"+
                            ConvertPointsToScore(player2Points);
            }

            if (player2Points > player1Points && player2Points < 4)
            {
                gameScore = ConvertPointsToScore(player1Points) + "-"+
                            ConvertPointsToScore(player2Points);
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

        public void SetPlayer1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                IncrementPlayer1Points();
            }
        }

        public void SetPlayer2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                IncrementPlayer2Points();
            }
        }

        private void IncrementPlayer1Points()
        {
            player1Points++;
        }

        private void IncrementPlayer2Points()
        {
            player2Points++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                IncrementPlayer1Points();
            else
                IncrementPlayer2Points();
        }

    }
}

