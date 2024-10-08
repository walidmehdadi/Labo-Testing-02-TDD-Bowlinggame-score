using BowlingGameScore;
using NUnit.Framework;

namespace BowlingGameScoreTests
{
    [TestFixture]
    public class BowlingGameScoreTests
    {
        private BowlingGame game;
        [SetUp]
        public void Setup()
        {
            game = new BowlingGame();
        }

        [Test]
        public void When_Roll_GlutterGame_Returns_0()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void When_Roll_AllOnes_Returns_20()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, game.Score);
        }

        [Test]
        public void When_Roll_SpareAndThree_Returns_16()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, game.Score);
        }

        [Test]
        public void When_Roll_StrikeAndThreeAndFour_Returns_24()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(17, 0);
            Assert.AreEqual(24, game.Score);
        }

        [Test]
        public void When_Roll_PerfectGame_Returns_300()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, game.Score);
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }
    }
}