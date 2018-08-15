using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;

namespace CricApiConsoleDemo
{
    class ConsumeAPISync
    {
        private static string apiKey = ConfigurationManager.AppSettings["ApiKey"].ToString();
        public void getNewCricketMatchesData()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/matches/?rnd=" + DateTime.Now.Ticks); //URI  
                Console.WriteLine(Environment.NewLine + result);

            }
        }

        public void getOldCricketMatchesData()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/cricket/?rnd=" + DateTime.Now.Ticks); //URI  
                Console.WriteLine(Environment.NewLine + result);

            }
        }

        public void getCricketMatchScore(string matchId = "1142589")
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/cricketScore/?rnd=" + DateTime.Now.Ticks +"&unique_id=" + matchId); //URI  
                Console.WriteLine(Environment.NewLine + result);

            }
        }

        public void getCricketMatchCalendar()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/matchCalendar?rnd=" + DateTime.Now.Ticks); //URI  
                Console.WriteLine(Environment.NewLine + result);

            }
        }

        public void getPlayerStats(string playerId = "253802")
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/playerStats?rnd=" + DateTime.Now.Ticks + "&pid=" + playerId); //URI  pass unique player id - 253802
                Console.WriteLine(Environment.NewLine + result);

            }
        }


        public void getFantasySummary(string uniqueMatchId = "1142589")
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/fantasySummary?rnd=" + DateTime.Now.Ticks + "&unique_id=" + uniqueMatchId); //URI pass match id  1142589  
                Console.WriteLine(Environment.NewLine + result);

            }
        }


        public void getFantasySquad(string uniqueMatchId = "1142589")
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/fantasySquad?rnd=" + DateTime.Now.Ticks + "&unique_id=" + uniqueMatchId); //URI pass match id  1142589
                Console.WriteLine(Environment.NewLine + result);

            }
        }

        public void SearchPlayer(string searchText = "Virat")
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("apikey", apiKey);
                var result = client.DownloadString("http://cricapi.com/api/playerFinder?rnd=" + DateTime.Now.Ticks + "&name=" + searchText); //URI  
                Console.WriteLine(Environment.NewLine + result);

            }
        }
        

    }
}
