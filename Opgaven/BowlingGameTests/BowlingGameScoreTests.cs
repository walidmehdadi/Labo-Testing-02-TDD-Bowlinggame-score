using BowlingGameScore;
using NUnit.Framework;

namespace BowlingGameScoreTests
{
    [TestFixture]
    public class BowlingGameScoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_Roll_GlutterGame_Returns_0()
        {
            var game = new BowlingGame();
            for (var i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score);
        }
    }
}