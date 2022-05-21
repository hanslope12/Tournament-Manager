using System;
using System.Collections.Generic;
using System.Text;
using Tracker_Library.Models;

namespace TrackerUI
{
    public interface ITeamRequester
    {
        void TeamComplete(TeamModel model);
    }
}
