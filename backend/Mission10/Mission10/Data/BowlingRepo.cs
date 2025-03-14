using Microsoft.AspNetCore.Mvc;
using Mission10.Models;

namespace Mission10.Data
{
    //Create bowling repo
    public class BowlingRepo : IBowlingRepo
    {
        private readonly BowlingLeagueContext _context;

        public BowlingRepo(BowlingLeagueContext temp)
        {
            _context = temp;
        }


        //Create the method for the required API return
        public List<APIReturn> AllData()
        {
            List<APIReturn> allInfo = _context.Bowlers.Where(b => new[] { "Marlins", "Sharks" }.Contains(b.Team.TeamName))
                .Select(b => new APIReturn
            {
                BowlerFirstName = b.BowlerFirstName,
                BowlerMiddleName = b.BowlerMiddleInit,
                BowlerLastName = b.BowlerLastName,
                TeamName = b.Team.TeamName,
                Address = b.BowlerAddress,
                City = b.BowlerCity,
                State = b.BowlerState,
                BowlerZip = b.BowlerZip,
                Phone = b.BowlerPhoneNumber
            }
            ).ToList();

            return(allInfo);
        }

    }
}
