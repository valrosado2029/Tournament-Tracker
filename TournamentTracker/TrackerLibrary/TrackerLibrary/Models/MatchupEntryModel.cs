using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
     public class MatchupEntryModel
    {

        /// <summary>
        /// represents one team in thre matchup
        /// </summary>

        public TeamModel TeamCompeting { get; set; }

        //represents the score for this team
        public double Score { get; set; }


        //represents the matchup that this team came from as the winner
        public MatchupModel ParentMatchup { get; set; }

       

    }
}
