using ResturauntRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ResturauntRater.Controllers
{
    public class RestaurantController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();
        // POST (CREATE)
        public async Task<IHttpActionResult> PostRestaurant(Restaurant restaurant)
        {
            // checks if the state of the model is valid in relation to the annotations that we have given it and if it is not null
            // ModelState is going into the Request and checking the body (similar to req.body in js servers) 
            if (ModelState.IsValid && restaurant != null)
            {
                // go into our RestaurantDbContext file and grab the DbSet to add something into that array
                // DbSets act like our tables
                // db context makes a copy of our database information that we can change and mess with
                _context.Restaurants.Add(restaurant);
                // Save the changes we have made to our database
                // this changes our database once we have made all of our changes to help prevent the database from getting too many pings
                await _context.SaveChangesAsync();
                // System.Web.Http built in method to return a 200 OK response
                return Ok();
            }
            // System.Web.Http built in method to return a bad request response, giving it the ModelState will give the exact error
            return BadRequest(ModelState);
        }



    }
}
