using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBacklogger
{
    public static class Queries
    {
        public static string selectGames = @"SELECT

Games.Game_ID as 'ID'
,Games.Game_Name as 'Game Name'
,Genres.Genre_Type as 'Genre'
,Progress.Progress as 'Progress %'

from Games
LEFT JOIN Genres ON
Games.Genre_ID = Genres.Genre_ID
LEFT JOIN Progress ON
Games.Game_ID=Progress.Game_ID";


        public static string selectGenres = @"SELECT
Genres.Genre_ID
,Genres.Genre_Type as 'Genre'
from Genres
";


    }
}
