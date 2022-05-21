using System;
using System.Collections.Generic;
using System.Text;


namespace Tracker_Library.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the Matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// List of matchup entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The ID from the database that will be used to identify the winner
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Round of the Matchup
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup not yet determined.";
                        break;
                    }
                }
                return output;
            }
        }
    }
}
