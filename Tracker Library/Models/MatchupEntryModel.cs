using System;
using System.Collections.Generic;
using System.Text;


namespace Tracker_Library.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique identifier for the MatchupEntry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// The unique Identifier for the team
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The unique Identifier for the Parent matchup
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represents the matchup this team won from.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        
    }
}
