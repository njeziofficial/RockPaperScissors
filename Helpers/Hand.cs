namespace RockPaperScissors.Helpers
{
    public class Hand
    {
        public OptionRps UserSelection { get; set; }
        public OptionRps WinsAgainst { get; set; }
        public OptionRps LosesAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (UserSelection == opponentHand.UserSelection)
            {
                return GameStatus.Draw;
            }

            if (WinsAgainst == opponentHand.UserSelection)
            {
                return GameStatus.Victory;
            }

            return GameStatus.Loss;
        }
    }
}