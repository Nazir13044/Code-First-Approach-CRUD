using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreFirstPrimary.Models.NHL;

namespace CoreFirstPrimary.Data
{
    public class DummyData
    {
        public static List<Team> GeTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                    TeamName = "Real Madrid",
                    City = "Hala Madrid",
                    Province = "Madrid",
                    Country = "Sapin"
                },
                new Team()
                {
                    TeamName = "Juventas",
                    City = "Hala Juventas",
                    Province = "Juventas",
                    Country = "England"
                },
                new Team()
                {
                    TeamName = "Barcelona",
                    City = "Hala Barcelona",
                    Province = "Barcelona",
                    Country="France"
                },
                new Team()
                {
                    TeamName = "PSG",
                    City = "Hala PSG",
                    Province = "PSG",
                    Country = "Itali"
                },

            };
            return teams;
        }

        public static List<Player> GetPlayers(NHLContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player()
                {

                    LastName = "Robnaldo",
                    FirstName = "Cristian",
                    Position = "Attacking",
                    TeamName = context.Teams.Find("Real Madrid").TeamName
                },
                new Player()
                {

                    LastName = "Messi",
                    FirstName = "Leonel",
                    Position = "Midfield",
                    TeamName = context.Teams.Find("Juventas").TeamName
                },
                new Player()
                {

                    LastName = "Shuareg",
                    FirstName = "Kaua",
                    Position = "Attacking",
                    TeamName = context.Teams.Find("Barcelona").TeamName
                },
                new Player()
                {

                    LastName = "Neymar",
                    FirstName = "Bolda",
                    Position = "Midfield",
                    TeamName = context.Teams.Find("PSG").TeamName
                }
            };
            return players;
        }
    }
}