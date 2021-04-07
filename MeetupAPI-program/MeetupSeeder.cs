using MeetupAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetupAPI
{
    public class MeetupSeeder
    {
        private readonly MeetupContext _meetupContext;
        public MeetupSeeder(MeetupContext meetupContext)
        {
            _meetupContext = meetupContext;
        }

        public void Seed()
        {
            if(_meetupContext.Database.CanConnect())
            {
                if(!_meetupContext.Meetups.Any())
                {
                    InsertSampleData();
                }
            }
        }

        private void InsertSampleData()
        {
            var meetups = new List<Meetup>
            {
                new Meetup
                {
                    Name = "Web submit",
                    Date = DateTime.Now.AddDays(7),
                    IsPrivate = false,
                    Organizer = "Microsoft",
                    Location = new Location
                    {
                        City = "Prague",
                        Street = "Laubova 33",
                        PostCode = "00100"

                    },
                    Lectures = new List<Lecture>
                    {
                        new Lecture
                        {
                            Author = "Bob Clark",
                            Topic = "Modern Browsers",
                            Description = "Deep dove into V8"

                        }

                    }


                },
                new Meetup
                {
                    Name = "4Devs",
                    Date = DateTime.Now.AddDays(7),
                    IsPrivate = false,
                    Organizer = "KGD",
                    Location = new Location
                    {
                        City = "Warszaw",
                        Street = "Chmielna 33/5",
                        PostCode = "00-007"

                    },
                    Lectures = new List<Lecture>
                    {
                        new Lecture
                        {
                            Author = "Will Smith",
                            Topic = "1000 words",
                            Description = "Budhism"
                        }
                    }
                },





            };



            _meetupContext.AddRange(meetups);
            _meetupContext.SaveChanges();
        }
    }
}
