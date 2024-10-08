


namespace BowlingGameScore
{
    public class BowlingGame
    {
        private int[] pins = new int[21];
        private int currentRoll = 0;
        public int Score 
        {
            get 
            { 
                int score =  0;
                int rollIndex = 0;
                for (int frame = 0; frame < 10; frame++)
                {
                    if (IsStrike(rollIndex))
                    {
                        score += GetStrikeScore(rollIndex);
                        rollIndex ++;
                    }
                    else if (IsSpare(rollIndex))
                    {
                        score += GetSpareScore(rollIndex);
                        rollIndex += 2;
                    }
                    else 
                    {
                        score += GetStandardScore(rollIndex);
                        rollIndex += 2;
                    }
                }
                return score;
            } 
        }
        public BowlingGame()
        {
        }

        public void Roll(int pinsThisRoll)
        {
            pins[currentRoll++] = pinsThisRoll;
        }
        private bool IsStrike(int rollIndex)
        {
            return pins[rollIndex] == 10;
        }
        private bool IsSpare(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1] == 10;
        }
        private int GetStrikeScore(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1] + pins[rollIndex + 2];
        }
        private int GetSpareScore(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1] + pins[rollIndex + 2];
        }
        private int GetStandardScore(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1];
        }
    }
}