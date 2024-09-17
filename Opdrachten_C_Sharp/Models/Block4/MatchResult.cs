using System;
using System.ComponentModel.DataAnnotations;

namespace Opdrachten_C_Sharp.Models.Block4
{
    public class MatchResult
    {
        #region Properties
        /// <summary>
        /// Gets or sets the match date.
        /// </summary>
        /// <value>
        /// The match date.
        /// </value>
        [DataType(DataType.Date)]
        [NoFutureDate()]
        public DateTime MatchDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Gets or sets the home team.
        /// </summary>
        /// <value>
        /// The home team.
        /// </value>
        public Team HomeTeam { get; set; }
        /// <summary>
        /// Gets or sets the away team.
        /// </summary>
        /// <value>
        /// The away team.
        /// </value>
        public Team AwayTeam { get; set; }
        /// <summary>
        /// Gets or sets the home team goals.
        /// </summary>
        /// <value>
        /// The home team goals.
        /// </value>
        [Range(0,25,ErrorMessage="Aantal doelpunten moet tussen 0 en 25 liggen")]
        public int HomeTeamGoals { get; set; }
        /// <summary>
        /// Gets or sets the away team goals.
        /// </summary>
        /// <value>
        /// The away team goals.
        /// </value>
        [Range(0, 25, ErrorMessage = "Aantal doelpunten moet tussen 0 en 25 liggen")]
        public int AwayTeamGoals { get; set; }
        /// <summary>
        /// Gets or sets the home team points.
        /// </summary>
        /// <value>
        /// The home team points.
        /// </value>
        public int HomeTeamPoints { get; set; }
        /// <summary>
        /// Gets or sets the away team points.
        /// </summary>
        /// <value>
        /// The away team points.
        /// </value>
        public int AwayTeamPoints { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates the points.
        /// </summary>
        public void CalculatePoints()
        {
            if (HomeTeamGoals > AwayTeamGoals)
            {
                HomeTeamPoints = 3;
                AwayTeamPoints = 0;
            }
            else if (HomeTeamGoals < AwayTeamGoals)
            {
                HomeTeamPoints = 0;
                AwayTeamPoints = 3;
            }
            else
            {
                HomeTeamPoints = 1;
                AwayTeamPoints = 1;
            }
        } 
        #endregion
    }
}
