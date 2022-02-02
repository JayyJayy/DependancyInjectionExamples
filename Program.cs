using DependancyInjectionExamples.ConstructorInjection;
using DependancyInjectionExamples.MethodInjection;
using DependancyInjectionExamples.Models;
using DependancyInjectionExamples.PropertyInjection;
using System;
using System.Collections.Generic;

namespace DependancyInjectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Constructor Injection");

            //Constructor Injection
            VideoGameBL videoGameBL = new VideoGameBL(new VideoGameDAL());
            List<VideoGame> videoGameList = videoGameBL.GetAllVideoGames();
            foreach(var game in videoGameList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", game.ID, game.Title, game.Genre);
            }

            Console.WriteLine("*****************************");
            Console.WriteLine("Property Injection");

            //PropertyInjection
            VideoGamePropBL videoGamePropBL = new VideoGamePropBL();
            videoGamePropBL.VideoGameDataObject = new VideoGameDAL();
            List<VideoGame> videoGamePropList = videoGamePropBL.GetAllVideoGames();
            foreach (var game in videoGamePropList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", game.ID, game.Title, game.Genre);
            }

            Console.WriteLine("*****************************");
            Console.WriteLine("Method Injection");

            //MethodInjection
            VideoGameMethodBL videoGameMethodBL = new VideoGameMethodBL();
            List<VideoGame> videoGameMethodList = videoGameMethodBL.GetAllVideoGames(new VideoGameDAL());
            foreach (var game in videoGameMethodList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", game.ID, game.Title, game.Genre);
            }
            Console.ReadKey();
        }
    }
}
