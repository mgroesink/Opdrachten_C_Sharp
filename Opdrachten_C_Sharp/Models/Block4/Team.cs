using System.ComponentModel.DataAnnotations;

namespace Opdrachten_C_Sharp.Models.Block4
{
    public class Team
    {
        /// <summary>
        /// Gets or sets the name of the team.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required(ErrorMessage="{0} is een verplicht veld")]
        public string Name { get; set; }
    }
}
