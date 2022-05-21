using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker_Library.Models
{
    public class TournamentModel
    {

        public int Id { get; set; }
        /// <summary>
        /// Name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Fee in order to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of Teams who joined
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes for the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of matchups for the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
