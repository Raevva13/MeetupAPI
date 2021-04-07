using MeetupAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetupAPI.Controllers
{
    [Route("api/meetup")]
    public class MeetupControler : ControllerBase
    {
        private readonly MeetupContext _meetupContext;

        public MeetupControler(MeetupContext meetupContext)
        {
            _meetupContext = meetupContext;
        }

        [HttpGet]
        public ActionResult<List<Meetup>> Get()
        {
            var meetup = _meetupContext.Meetups.ToList();

            return meetup;
        }
    }
}
