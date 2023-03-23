using CinemaTicketSalesAutomation.Enums;
using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies() 
        { 
            string basePath = "C:/Users/Aslı/source/repos/CinemaTicketSalesAutomation/CinemaTicketSalesAutomation/Pictures/";

            return new List<Movie>() 
            {
                new Movie()
                {
                    movieName="Arrival",
                    category=Category.bilim_kurgu,
                    minute="1 saat 56 dakika",
                    price=50,
                    picturePath=basePath + "arrival.jpg"
                },
                new Movie()
                {
                    movieName="3 Idiots",
                    category=Category.komedi,
                    minute="2 saat 51 dakika",
                    price=60,
                    picturePath=basePath + "3_idiots.jpg"
                },
                 new Movie()
                {
                    movieName="Don't Breathe",
                    category=Category.gerilim,
                    minute="1 saat 28 dakika",
                    price=40,
                    picturePath=basePath + "don't_breathe.jpg"
                },
                  new Movie()
                {
                    movieName="Back To The Future",
                    category=Category.macera,
                    minute="1 saat 56 dakika",
                    price=50,
                    picturePath=basePath + "back_to_the_future.jpg"
                },
                   new Movie()
                {
                    movieName="Jumanji",
                    category=Category.macera,
                    minute="1 saat 44 dakika",
                    price=50,
                    picturePath=basePath + "jumanji.jpg"
                },
                    new Movie()
                {
                    movieName="Warcraft",
                    category=Category.fantastik,
                    minute="2 saat 3 dakika",
                    price=40,
                    picturePath=basePath + "warcraft.jpg"
                }
            };
        }
    }
}
