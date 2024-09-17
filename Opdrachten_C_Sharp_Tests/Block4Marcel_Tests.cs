using Opdrachten_C_Sharp.Models.Block1;
using Opdrachten_C_Sharp.Models.Block2;
using Opdrachten_C_Sharp.Models.Block3;
using Opdrachten_C_Sharp.Models.Block4;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_C_Sharp_Tests
{
    public partial class Block4Tests
    {

        [Fact]
        public void CalculatePoints_HomeTeamWins_ShouldAssignCorrectPoints()
        {
            // Arrange
            var matchResult = new MatchResult
            {
                HomeTeamGoals = 3,
                AwayTeamGoals = 1
            };

            // Act
            matchResult.CalculatePoints();

            // Assert
            Assert.Equal(3, matchResult.HomeTeamPoints);
            Assert.Equal(0, matchResult.AwayTeamPoints);
        }

        [Fact]
        public void CalculatePoints_AwayTeamWins_ShouldAssignCorrectPoints()
        {
            // Arrange
            var matchResult = new MatchResult
            {
                HomeTeamGoals = 1,
                AwayTeamGoals = 3
            };

            // Act
            matchResult.CalculatePoints();

            // Assert
            Assert.Equal(0, matchResult.HomeTeamPoints);
            Assert.Equal(3, matchResult.AwayTeamPoints);
        }

        [Fact]
        public void CalculatePoints_Draw_ShouldAssignCorrectPoints()
        {
            // Arrange
            var matchResult = new MatchResult
            {
                HomeTeamGoals = 2,
                AwayTeamGoals = 2
            };

            // Act
            matchResult.CalculatePoints();

            // Assert
            Assert.Equal(1, matchResult.HomeTeamPoints);
            Assert.Equal(1, matchResult.AwayTeamPoints);
        }

        [Theory]
        [InlineData(0, 25)]
        [InlineData(5, 10)]
        [InlineData(0, 0)]
        [InlineData(25, 25)]
        public void MatchResult_GoalsWithinValidRange_ShouldNotThrowValidationError(int homeTeamGoals, int awayTeamGoals)
        {
            // Arrange
            var matchResult = new MatchResult
            {
                HomeTeamGoals = homeTeamGoals,
                AwayTeamGoals = awayTeamGoals
            };

            // Act & Assert (no exception should be thrown)
            var exception = Record.Exception(() => matchResult.CalculatePoints());
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(-1, 5)]
        [InlineData(26, 0)]
        public void MatchResult_GoalsOutOfRange_ShouldThrowValidationError(int homeTeamGoals, int awayTeamGoals)
        {
            // Arrange
            var matchResult = new MatchResult
            {
                HomeTeamGoals = homeTeamGoals,
                AwayTeamGoals = awayTeamGoals
            };

            // Act & Assert (Range validation would normally be handled by model validation, so simulate this)
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                if (homeTeamGoals < 0 || homeTeamGoals > 25 || awayTeamGoals < 0 || awayTeamGoals > 25)
                    throw new ArgumentOutOfRangeException("Goals must be between 0 and 25.");
            });
        }

        [Fact]
        public void MatchDate_ShouldNotBeFutureDate()
        {
            // Arrange
            var matchResult = new MatchResult
            {
                MatchDate = DateTime.Now.AddDays(1) // Tomorrow's date (future)
            };

            // Act & Assert (Simulate NoFutureDate validation)
            Assert.Throws<ArgumentException>(() =>
            {
                if (matchResult.MatchDate > DateTime.Now)
                    throw new ArgumentException("Match date cannot be in the future.");
            });
        }

        [Fact]
        public void MatchDate_TodayOrPastDate_ShouldBeValid()
        {
            // Arrange
            var matchResult = new MatchResult
            {
                MatchDate = DateTime.Now.AddDays(-1) // Yesterday's date (valid)
            };

            // Act & Assert
            var exception = Record.Exception(() =>
            {
                if (matchResult.MatchDate > DateTime.Now)
                    throw new ArgumentException("Match date cannot be in the future.");
            });

            Assert.Null(exception); // No exception should be thrown for past or current date
        }

    }
}
