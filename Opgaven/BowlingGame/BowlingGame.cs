
namespace BowlingGameScore
{
    public class BowlingGame
    {
        public int Score;
        public BowlingGame()
        {
        }

        public void Roll(int pins)
        {
            Score += pins;
        }
    }
}