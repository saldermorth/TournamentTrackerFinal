using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Reprecents one team in the matchup
        /// </summary>
        public int TeamCompetingId { get; set; }
        public TeamModel TeamCompeting { get; set; }//ToDo- id sets att 1000 sometimes.
        /// <summary>
        /// Reprecents score for this particual team
        /// </summary>
        public double Score { get; set; }
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Reprecents the matchup that this
        /// team comes from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    } 
}
