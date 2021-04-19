using Xunit;
namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests

    {
        private Game game;

        public BowlingGameTests()
        {
            this.game = new Game() ;
        }


        [Fact]
        public void ScoreReturnsZero()
        {
            //Arrange
            
            var rolls = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //Act
            var score = game.Score(rolls);

            //Assert
            Assert.Equal(0, score);

        }

          
        [Fact]
        public void WhenRollsArePlayedThenReturnsScore()
        {
            //Arrange
            
            var rolls = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            //Act
            var score = game.Score(rolls);

            //Assert
            Assert.Equal(20, score);

        }

        [Fact]
        public void ShouldCalculateScoreWhenSpareIsIncluded()
        {
            //Arrange
            
            var rolls = new int[] { 5, 5, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //Act
            var score = game.Score(rolls);

            //Assert
            Assert.Equal(12, score);

        }

        [Fact]
        public void ShouldCalculateScoreWhenStrikeIsIncluded()
        {
            //Arrange

            var rolls = new int[] { 10, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //Act
            var score = game.Score(rolls);

            //Assert
            Assert.Equal(14, score);

        }

    }

       
}
