using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// List of two MatchupEntry objects
        /// that are competing.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Team object that represents the winning contestant.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round in which
        /// the matchup occurs.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
