using BowlingAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BowlingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlerController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }


        [HttpGet]
        public IEnumerable<BowlerWithTeamName> Get()
        {
            //var Bowlers = _bowlingRepository.Bowlers.ToArray();

            var Bowlers = (from Bowler in _bowlingRepository.Bowlers
                          join Team in _bowlingRepository.Teams
                          on Bowler.TeamId equals Team.TeamId
                           where Bowler.TeamId == 1 || Bowler.TeamId == 2
                           select new BowlerWithTeamName
                          {

                              BowlerId = Bowler.BowlerId,
                              BowlerFirstName = Bowler.BowlerFirstName,
                              BowlerMiddleInit = Bowler.BowlerMiddleInit,
                              BowlerLastName = Bowler.BowlerLastName,
                              TeamId = Bowler.TeamId,
                              BowlerAddress = Bowler.BowlerAddress,
                              BowlerCity = Bowler.BowlerCity,
                              BowlerState = Bowler.BowlerState,
                              BowlerZip = Bowler.BowlerZip,
                              BowlerPhoneNumber = Bowler.BowlerPhoneNumber,
                              TeamName = Team.TeamName

                          }).ToList();


            return Bowlers;
        }


    }

    //[HttpGet]
    //public IEnumerable<Bowler> Get()
    //{
    //    var Bowlers = _bowlingRepository.Bowlers
    //                    .Join(_bowlingRepository.Teams, // Join with Teams table
    //                          bowler => bowler.TeamId, // Select the foreign key in Bowlers table
    //                          team => team.TeamId, // Select the primary key in Teams table
    //                          (bowler, team) => new Bowler // Project to a new Bowler object
    //                          {
    //                              BowlerId = bowler.BowlerId,
    //                              BowlerFirstName = bowler.BowlerFirstName,
    //                              BowlerMiddleInit = bowler.BowlerMiddleInit,
    //                              BowlerLastName = bowler.BowlerLastName,
    //                              TeamId = bowler.TeamId,
    //                              BowlerAddress = bowler.BowlerAddress,
    //                              BowlerCity = bowler.BowlerCity,
    //                              BowlerState = bowler.BowlerState,
    //                              BowlerZip = bowler.BowlerZip,
    //                              BowlerPhoneNumber = bowler.BowlerPhoneNumber,
    //                              // Add other properties you want to include from the Bowlers table
    //                              // Add properties you want to include from the Teams table
    //                              Team = bowler.Team // Assign the joined Team object
    //                          })
    //                    .ToArray();

    //    return Bowlers;
    //}

}
