using DependancyInjectionExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExamples.PropertyInjection
{
    public class VideoGamePropBL
    {
        private IVideoGameDAL VideoGameDAL;

        public IVideoGameDAL VideoGameDataObject
        {
            set
            {
                VideoGameDAL = value;
            }
            get
            {
                if (VideoGameDataObject == null)
                {
                    throw new Exception("Video Game is not initialised");
                }
                else
                {
                    return VideoGameDAL;
                }
            }
        }

        public List<VideoGame> GetAllVideoGames()
        {
            return VideoGameDAL.SelectAllVideoGames();
        }
    }
}
