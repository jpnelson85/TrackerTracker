using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Descriptive name of
        /// the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Decimal fee needed to
        /// enter tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of competing
        /// teams.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of Prizes
        /// available to win.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of the Matchups within
        /// a list of the round that
        /// it occurs in.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
