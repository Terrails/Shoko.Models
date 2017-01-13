﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoko.Models.Server;

namespace Shoko.Models.Client
{
    public class CL_AnimeEpisode_User : AnimeEpisode_User
    {
        public DateTime DateTimeUpdated { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public int AniDB_EpisodeID { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeNameRomaji { get; set; }
        public string EpisodeNameEnglish { get; set; }
        public int EpisodeType { get; set; }
        public int LocalFileCount { get; set; }
        public int UnwatchedEpCountSeries { get; set; }

        // from AniDB_Episode
        public int AniDB_LengthSeconds { get; set; }
        public string AniDB_Rating { get; set; }
        public string AniDB_Votes { get; set; }
        public string AniDB_RomajiName { get; set; }
        public string AniDB_EnglishName { get; set; }
        public DateTime? AniDB_AirDate { get; set; }

        public List<CL_AniDB_GroupStatus> ReleaseGroups { get; set; }

    }
}