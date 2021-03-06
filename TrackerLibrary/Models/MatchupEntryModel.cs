using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Reprecents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Reprecents score for this particual team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Reprecents the matchup that this
        /// team comes from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    } 
}
