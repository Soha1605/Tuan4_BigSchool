using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tuan4_BigSchool.Models;

namespace Tuan4_BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Attend(Course courseDTO)
        {
            var userID = User.Identity.GetUserId();
            if(userID == null)
                  return BadRequest("Please login first");
            BigSchoolContext context = new BigSchoolContext();
            var attendance = new Attendance()
            {
                CourseId = courseDTO.Id,
                Attendee = userID
            };
            context.Attendance.Add(attendance);
            context.SaveChanges();
            return Ok();
            
        }
    }
}
