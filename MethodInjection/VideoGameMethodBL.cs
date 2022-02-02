using DependancyInjectionExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExamples.MethodInjection
{
    public class VideoGameMethodBL
    {
        public IVideoGameDAL VideoGameDAL { get; set; }

        public List<VideoGame> GetAllVideoGames(IVideoGameDAL _videoGameDAL)
        {
            VideoGameDAL = _videoGameDAL;
            return VideoGameDAL.SelectAllVideoGames();
        }
    }
}
