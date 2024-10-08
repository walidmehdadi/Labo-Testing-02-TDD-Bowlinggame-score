
namespace BowlingGameScore
{
    public class BowlingGame
    {
        public int Score { get; private set; }
        public BowlingGame()
        {
        }

        public void Roll(int pins)
        {
            Score += pins;
        }
    }
}