using System.Collections.Generic;

namespace MethodConf.Classes
{
    public static class SessionRepository
    {
        public static List<Session> GetSessions()
        {
            var sessions = new List<Session>();

            var jordanMorgan = new Speaker
            {
                Image = "/images/speakers/jordan_morgan.jpg",
                Name = "Jordan Morgan",
                Title = "iOS engineer at Buffer",
                Url = "#"
            };
            
            var charlieRosenbury = new Speaker
            {
                Image = "/images/speakers/charlie_rosenbury.jpeg",
                Name = "Charlie Rosenbury",
                Title = "President of Self Interactive",
                Url = "#"
            };
            
            var amberGillenwaters = new Speaker
            {
                Image = "/images/speakers/amber_gillenwaters.jpeg",
                Name = "Amber Gillenwaters",
                Title = "Freelance Data Scientist",
                Url = "#"
            };
            
            var taylorOtwell = new Speaker
            {
                Image = "/images/speakers/taylor_otwell.jpg",
                Name = "Taylor Otwell",
                Title = "Creator of Laravel",
                Url = "#"
            };
            
            var katieWomersly = new Speaker
            {
                Image = "/images/speakers/katie_womersly.jpg",
                Name = "Katie Womersly",
                Title = "VP of Engineering at Buffer",
                Url = "#"
            };
            
            var rubyFleener = new Speaker
            {
                Image = "/images/speakers/ruby_fleener.jpeg",
                Name = "Ruby Fleener",
                Title = "UX Consultant at WWT",
                Url = "#"
            };
            
            var nilly = new Speaker
            {
                Image = "/images/speakers/nilly.png",
                Name = "Nilly",
                Title = "Mascot at Horsestrap",
                Url = "#"
            };
            
            var mainSession1 = new Session
            {
                Title = "SwiftUI",
                TimeLabel = "8:00AM-9:00AM",
                Description = "",
                SessionType = SessionType.Main,
                Speaker = jordanMorgan
            };
            
            var mainSession2 = new Session
            {
                Title = "Machine learning",
                TimeLabel = "9:15AM–10:15AM",
                Description = "",
                SessionType = SessionType.Main,
                Speaker = amberGillenwaters
            };
            
            var mainSession3 = new Session
            {
                Title = "Laravel Vapor",
                TimeLabel = "10:30AM–11:30AM",
                Description = "",
                SessionType = SessionType.Main,
                Speaker = taylorOtwell
            };
            
            var workshop1 = new Session
            {
                Title = "Buidling AR and VR apps",
                TimeLabel = "8:00AM-10:15AM",
                Description = "",
                SessionType = SessionType.Workshop,
                Speaker = charlieRosenbury
            };
            
            var workshop2 = new Session
            {
                Title = "Coming Soon Part 1",
                TimeLabel = "10:30AM-11:30AM",
                Description = "",
                SessionType = SessionType.Workshop,
                Speaker = nilly
            };
            
            var lunch = new Session
            {
                Title = "Lunch",
                TimeLabel = "11:30AM–1:00PM",
                Description = "",
                SessionType = SessionType.Lunch,
                Speaker = null
            };
            
            var mainSession4 = new Session
            {
                Title = "Coming Soon",
                TimeLabel = "1:00PM-2:00PM",
                Description = "",
                SessionType = SessionType.Main,
                Speaker = nilly
            };
            
            var mainSession5 = new Session
            {
                Title = "Coming Soon",
                TimeLabel = "2:15PM–3:15PM",
                Description = "",
                SessionType = SessionType.Main,
                Speaker = nilly
            };
            
            var mainSession6 = new Session
            {
                Title = "Coming Soon",
                TimeLabel = "3:30PM–4:30PM",
                Description = "",
                SessionType = SessionType.Main,
                Speaker = nilly
            };
            
            var workshop22 = new Session
            {
                Title = "Coming Soon Part 2",
                TimeLabel = "1:00PM-2:00PM",
                Description = "",
                SessionType = SessionType.Workshop,
                Speaker = nilly
            };
            
            var workshop3 = new Session
            {
                Title = "Modern CSS with Grid and Flexbox",
                TimeLabel = "2:15PM-4:30PM",
                Description = "",
                SessionType = SessionType.Workshop,
                Speaker = rubyFleener
            };
            
            var keynote = new Session
            {
                Title = "Keynote",
                TimeLabel = "4:30PM-5:30PM",
                Description = "",
                SessionType = SessionType.Keynote,
                Speaker = katieWomersly
            };
            
            sessions.Add(mainSession1);
            sessions.Add(mainSession2);
            sessions.Add(mainSession3);
            sessions.Add(workshop1);
            sessions.Add(workshop2);
            
            sessions.Add(lunch);
            
            sessions.Add(mainSession4);
            sessions.Add(mainSession5);
            sessions.Add(mainSession6);
            sessions.Add(workshop22);
            sessions.Add(workshop3);
            
            sessions.Add(keynote);

            return sessions;
        }
    }
}