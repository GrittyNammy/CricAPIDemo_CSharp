using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricApiConsoleDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsumeAPISync obj = new ConsumeAPISync();
            obj.getNewCricketMatchesData();
            obj.getOldCricketMatchesData();
            obj.getCricketMatchScore();
            obj.getCricketMatchCalendar();
            obj.getPlayerStats();
            obj.getFantasySquad();
            obj.getFantasySummary();
            obj.SearchPlayer();

            Console.ReadLine();
        }             
    }
}
