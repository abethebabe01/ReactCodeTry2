using System.Collections.Generic;
using System.Linq;

namespace BowlingAPI.Models
{
    public class EFBowlerRepository : IBowlingRepository
    {
        private BowlingLeagueContext context;

        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            context = temp;
        }

        public IEnumerable<Bowler> Bowlers => context.Bowlers;

        public IEnumerable<Team> Teams => context.Teams; // Provide access to Teams
    }
}


//namespace BowlingAPI.Models
//{
//    public class EFBowlerRepository : IBowlingRepository
//    {

//        private BowlingLeagueContext context;
//        public EFBowlerRepository(BowlingLeagueContext temp)
//        {
//            context = temp;
//        }

//        public IEnumerable<Bowler> Bowlers => context.Bowlers;
//    }
//}