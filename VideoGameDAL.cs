using DependancyInjectionExamples.Models;
using System.Collections.Generic;

namespace DependancyInjectionExamples
{
    public interface IVideoGameDAL
    {
        List<VideoGame> SelectAllVideoGames();
    }

    public class VideoGameDAL : IVideoGameDAL
    {
        public List<VideoGame> SelectAllVideoGames()
        {
            List<VideoGame> listVideoGames = new()
            {
                new VideoGame() { ID = 1, Title = "Skyrim", Genre = "RPG" },
                new VideoGame() { ID = 2, Title = "Lost Ark", Genre = "ARPG MMO" },
                new VideoGame() { ID = 3, Title = "God Of War", Genre = "Action" }
            };

            return listVideoGames;
        }
    }
}
