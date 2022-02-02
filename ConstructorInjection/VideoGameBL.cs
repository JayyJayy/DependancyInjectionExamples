using DependancyInjectionExamples.Models;
using System.Collections.Generic;

namespace DependancyInjectionExamples.ConstructorInjection
{
    public class VideoGameBL
    {
        private IVideoGameDAL VideoGameDAL { get; set; }
        public VideoGameBL(IVideoGameDAL videoGameDAL)
        {
            VideoGameDAL = videoGameDAL;
        }

        public List<VideoGame> GetAllVideoGames()
        {
            return VideoGameDAL.SelectAllVideoGames();
        }
    }
}
