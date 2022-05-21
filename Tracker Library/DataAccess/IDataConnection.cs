﻿using System;
using System.Collections.Generic;
using System.Text;
using Tracker_Library.Models;

namespace Tracker_Library.DataAccess
{
   
        public interface IDataConnection
        {
            void CreatePrize(PrizeModel model);
            void CreatePerson(PersonModel model);
            void CreateTeam(TeamModel model);
            void CreateTournament(TournamentModel model);
            void UpdateMatchup(MatchupModel model);
            List<PersonModel> GetPerson_All();
            List<TeamModel> GetTeam_All();
            List<TournamentModel> GetTournament_All();

        }
    
}
